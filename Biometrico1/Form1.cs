using GriauleFingerprintLibrary;
using GriauleFingerprintLibrary.Exceptions;
using System;
using System.Data;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using AForge.Video.DirectShow;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.InteropServices;
using AForge.Video;

namespace Biometrico1
{
    public partial class Form1 : Form
    {

        private Persona persona;
        private int num = 0;
        private PersonaConsultas personaConsultas;
        private string path = @"C:\\fotos2\\";
        private bool HayDispositivos;
        private FilterInfoCollection MisDispositivos;
        private VideoCaptureDevice MiWebCam;
        public Form1()
        {
            InitializeComponent();

            fingerPrint = new FingerprintCore();
            fingerPrint.onStatus += new StatusEventHandler(fingerPrint_onStatus);
          //  fingerPrint.onFinger += new FingerEventHandler(fingerPrint_onFinger);
            fingerPrint.onImage += new ImageEventHandler(fingerPrint_onImage);

            persona = new Persona();
            personaConsultas = new PersonaConsultas();
        }

        private FingerprintCore fingerPrint;
        private GriauleFingerprintLibrary.DataTypes.FingerprintRawImage rawImage;
        GriauleFingerprintLibrary.DataTypes.FingerprintTemplate _template;
        GriauleFingerprintLibrary.DataTypes.FingerprintTemplate _templateD;

        private void Form1_Load(object sender, EventArgs e)
        {
            fingerPrint.Initialize();
            fingerPrint.CaptureInitialize();
            cargarDispositivos();
        }

        private void fingerPrint_onImage(object source, GriauleFingerprintLibrary.Events.ImageEventArgs ie)
        {
            rawImage = ie.RawImage;
            setImage(ie.RawImage.Image);
            ExtractTemplate();
            //MessageBox.Show("nro" + num);
            num++;

        }

        private void ExtractTemplate()
        {

            if (rawImage != null)
            {
                try
                {
                    if (num % 2 == 0)
                    {
                        //_template = null;
                        fingerPrint.Extract(rawImage, ref _template);
                        //SetQualityBar(_template.Quality);
                        DisplayImage(_template, false);
                        
                    }
                    else
                    {
                        
                        fingerPrint.Extract(rawImage, ref _templateD);
                        //SetQualityBar(_template.Quality);
                        DisplayImage(_templateD, false);
                        
                    }


                }
                catch (Exception e)
                {
                    if (e.Source != null)
                        Console.WriteLine("IOException source: {0}", e.Source);
                    
                }

            }
        }

        private void DisplayImage(GriauleFingerprintLibrary.DataTypes.FingerprintTemplate template, bool identify)
        {
            IntPtr hdc = FingerprintCore.GetDC();

            IntPtr image = new IntPtr();

            if (identify)
            {
                fingerPrint.GetBiometricDisplay(template, rawImage, hdc, ref image, FingerprintConstants.GR_DEFAULT_CONTEXT);

            }
            else
            {
                fingerPrint.GetBiometricDisplay(template, rawImage, hdc, ref image, FingerprintConstants.GR_DEFAULT_CONTEXT);
            }

            setImage(Bitmap.FromHbitmap(image));

            FingerprintCore.ReleaseDC(hdc);

        }



        private delegate void delSetImage(Image img);
        void setImage(Image img)
        {

            if (this.InvokeRequired)
            {
                this.Invoke(new delSetImage(setImage), new object[] { img });

            }
            else
            {
                if (num % 2 == 0)
                {
                    Bitmap bmp = new Bitmap(img, pictureBox1.Width, pictureBox1.Height);
                    pictureBox1.Image = bmp;
                    pictureBox1.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                    bmp.Save("C:\\huellasingreso\\" + tdni.Text + ".jpg", ImageFormat.Png);
                }
                else
                {
                    Bitmap bmp = new Bitmap(img, pictureBox3.Width, pictureBox3.Height);
                    pictureBox3.Image = bmp;
                    bmp.Save("C:\\huellasingreso\\" + tdni.Text + "x.jpg", ImageFormat.Png);

                }


            }

        }

        void fingerPrint_onStatus(object source, GriauleFingerprintLibrary.Events.StatusEventArgs se)
        {
            if (se.StatusEventType == GriauleFingerprintLibrary.Events.StatusEventType.SENSOR_PLUG)
            {
                fingerPrint.StartCapture(source.ToString());
            }
            else
            {
                fingerPrint.StopCapture(source);
            }

        }

        private bool validaciones()
        {
            if (tdni.Text.Trim().Equals(""))
            {
                MessageBox.Show("Ingrese Dni");
                return false;
            }
            else { return true; }
        }

        private void bguardar_Click(object sender, EventArgs e)
        {
            if (!validaciones())
            {
                return;
            }

            cargarDatosPersona();

            if (personaConsultas.agregarPersona(persona))
            {
                guardarfoto();
                MessageBox.Show("persona agregada");
                limpiarCampos();
                iniciarCamara();
            }
        }

        private void limpiarCampos()
        {
            tdni.Text = "";
            tpaterno.Text = "";
            tmaterno.Text = "";
            tnombres.Text = "";
            tprograma.Text = "";
            pictureBox1.Image = null;
            pictureBox3.Image = null;
            pictureBox2.Image = null;

        }

        private void cargarDatosPersona()
        {
            persona.dni = tdni.Text.Trim();
            persona.nombre = tnombres.Text.Trim();
            persona.paterno = tpaterno.Text.Trim();
            persona.materno = tmaterno.Text.Trim();
            persona.programa = tprograma.Text.Trim();
            persona.indiceIzquierdo = _template;
            persona.indiceDerecho = _templateD;
        }

        private void bnuevo_Click(object sender, EventArgs e)
        {

        }

        private void bidentificar_Click(object sender, EventArgs e)
        {
            IdentifyDNI();
        }

        private void Identify()
        {
            GriauleFingerprintLibrary.DataTypes.FingerprintTemplate testTemplate = null;
            try
            {
                if (_template != null && _template.Size > 0)
                {
                    fingerPrint.IdentifyPrepare(_template);

                    PersonaConsultas dll = new PersonaConsultas();
                    IDataReader dataReader = dll.getPersona();

                    using (dataReader)
                    {
                        while (dataReader.Read())
                        {
                            int tempId = Convert.ToInt32(dataReader["ID"]);
                            byte[] buff = (byte[])dataReader["template"];
                            string dni = Convert.ToString(dataReader["dni"]);
                            string nombre = Convert.ToString(dataReader["nombres"]);
                            string paterno = Convert.ToString(dataReader["paterno"]);
                            string materno = Convert.ToString(dataReader["materno"]);
                            string programa = Convert.ToString(dataReader["programa"]);

                            testTemplate = new GriauleFingerprintLibrary.DataTypes.FingerprintTemplate();

                            testTemplate.Size = buff.Length;
                            testTemplate.Buffer = buff;

                            int score;

                            if (Identify(testTemplate, out score))
                            {
                                USERID(nombre, dni, paterno, materno, programa);
                                DisplayImage(_template, true);
                            }
                        }

                    }

                }
            }
            catch (FingerprintException fe)
            {
                System.IO.FileStream dumpTemplate = System.IO.File.Create(@".\DumpTemplate.gt");
                System.IO.StreamWriter stWriter = new System.IO.StreamWriter(dumpTemplate);

                stWriter.WriteLine(BitConverter.ToString(testTemplate.Buffer, 0));
                stWriter.Close();
            }
        }

        private bool Identify(GriauleFingerprintLibrary.DataTypes.FingerprintTemplate testTemplate, out int score)
        {
            return fingerPrint.Identify(testTemplate, out score) == 1 ? true : false;
        }

        private void USERID(string nombre, string dni, string paterno, string materno, string programa)
        {
            tdni.Text = dni;
            tnombres.Text = nombre;
            tpaterno.Text = paterno;
            tmaterno.Text = materno;
            tprograma.Text = programa;


        }


        private void IdentifyDNI()
        {
            PersonaConsultas dll = new PersonaConsultas();
            IDataReader dataReader = dll.getPersonaDNI(tdni.Text);


            using (dataReader)
            {
                while (dataReader.Read())
                {
                    int tempId = Convert.ToInt32(dataReader["ID"]);
                    string dni = Convert.ToString(dataReader["dni"]);
                    string nombre = Convert.ToString(dataReader["nombres"]);
                    string paterno = Convert.ToString(dataReader["paterno"]);
                    string materno = Convert.ToString(dataReader["materno"]);
                    string programa = Convert.ToString(dataReader["programa"]);
                    USERID(nombre, dni, paterno, materno, programa);
                }

            }
    
        }


        private void Contar()
        {
            PersonaConsultas dll = new PersonaConsultas();
            IDataReader dataReader = dll.getPersonaCount();

            int contador = 0;

            using (dataReader)
            {
                while (dataReader.Read())
                {
                   contador = Convert.ToInt32(dataReader["cont"]);
                }

                tcontador.Text = contador.ToString();

            }

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lnombres_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void tdni_TextChanged(object sender, EventArgs e)
        {

            if (tdni.TextLength == 8)
            {
                IdentifyDNI();
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IdentifyDNI();
        }

        private void tdni_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!validaciones())
                {
                    return;
                }

                cargarDatosPersona();

                if (personaConsultas.agregarPersona(persona))
                {
                    guardarfoto();
                    MessageBox.Show("persona agregada");
                    limpiarCampos();
                    iniciarCamara();
                }


            }

            Contar();


        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tprograma_TextChanged(object sender, EventArgs e)
        {

        }


        public void cargarDispositivos()
        {
            MisDispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (MisDispositivos.Count > 0)
            {
                HayDispositivos = true;
                for (int i = 0; i < MisDispositivos.Count; i++)
                    comboBox1.Items.Add(MisDispositivos[i].Name.ToString());
                comboBox1.Text = MisDispositivos[0].ToString();
            }
            else
            {
                HayDispositivos = false;
            }

        }


        private void CerrarWebCam()
        {
            if (MiWebCam != null && MiWebCam.IsRunning)
            {
                MiWebCam.SignalToStop();
                MiWebCam = null;
            }
        }
        private void iniciarCamara() {
            CerrarWebCam();
            int i = comboBox1.SelectedIndex;
            string NombreVideo = MisDispositivos[i].MonikerString;
            MiWebCam = new VideoCaptureDevice(NombreVideo);
            MiWebCam.NewFrame += new NewFrameEventHandler(Capturando);
            MiWebCam.Start();
        }

        private void Capturando(Object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pictureBox2.Image = Imagen;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CerrarWebCam();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            iniciarCamara();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MiWebCam != null && MiWebCam.IsRunning)
            {
                pictureBox2.Image = pictureBox2.Image;
                pictureBox2.Image.Save(path + tdni.Text + ".jpg", ImageFormat.Jpeg);
                CerrarWebCam();
            }
        }

        private void guardarfoto() {
            if (MiWebCam != null && MiWebCam.IsRunning)
            {
                pictureBox2.Image = pictureBox2.Image;
                pictureBox2.Image.Save(path + tdni.Text + ".jpg", ImageFormat.Jpeg);
                CerrarWebCam();
            }
        }
    }
}
