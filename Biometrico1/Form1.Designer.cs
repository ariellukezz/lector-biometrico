namespace Biometrico1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lnombre = new System.Windows.Forms.Label();
            this.lnombres = new System.Windows.Forms.Label();
            this.tdni = new System.Windows.Forms.TextBox();
            this.tpaterno = new System.Windows.Forms.TextBox();
            this.bguardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tmaterno = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tnombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tprograma = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tcontador = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnombre
            // 
            this.lnombre.AutoSize = true;
            this.lnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnombre.Location = new System.Drawing.Point(675, 36);
            this.lnombre.Name = "lnombre";
            this.lnombre.Size = new System.Drawing.Size(30, 18);
            this.lnombre.TabIndex = 0;
            this.lnombre.Text = "Dni";
            // 
            // lnombres
            // 
            this.lnombres.AutoSize = true;
            this.lnombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnombres.Location = new System.Drawing.Point(675, 97);
            this.lnombres.Name = "lnombres";
            this.lnombres.Size = new System.Drawing.Size(107, 18);
            this.lnombres.TabIndex = 1;
            this.lnombres.Text = "Primer Apellido";
            this.lnombres.Click += new System.EventHandler(this.lnombres_Click);
            // 
            // tdni
            // 
            this.tdni.BackColor = System.Drawing.SystemColors.Window;
            this.tdni.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdni.Location = new System.Drawing.Point(678, 59);
            this.tdni.Name = "tdni";
            this.tdni.Size = new System.Drawing.Size(196, 29);
            this.tdni.TabIndex = 2;
            this.tdni.TextChanged += new System.EventHandler(this.tdni_TextChanged);
            this.tdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tdni_KeyPress);
            // 
            // tpaterno
            // 
            this.tpaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpaterno.Location = new System.Drawing.Point(678, 123);
            this.tpaterno.Name = "tpaterno";
            this.tpaterno.Size = new System.Drawing.Size(196, 29);
            this.tpaterno.TabIndex = 3;
            // 
            // bguardar
            // 
            this.bguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bguardar.Location = new System.Drawing.Point(694, 380);
            this.bguardar.Name = "bguardar";
            this.bguardar.Size = new System.Drawing.Size(196, 44);
            this.bguardar.TabIndex = 8;
            this.bguardar.Text = "Guardar";
            this.bguardar.UseVisualStyleBackColor = true;
            this.bguardar.Click += new System.EventHandler(this.bguardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(424, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(218, 260);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(218, 41);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 261);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // tmaterno
            // 
            this.tmaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmaterno.Location = new System.Drawing.Point(678, 191);
            this.tmaterno.Name = "tmaterno";
            this.tmaterno.Size = new System.Drawing.Size(196, 29);
            this.tmaterno.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(675, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Segundo Apellido";
            // 
            // tnombres
            // 
            this.tnombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnombres.Location = new System.Drawing.Point(678, 256);
            this.tnombres.Name = "tnombres";
            this.tnombres.Size = new System.Drawing.Size(196, 29);
            this.tnombres.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(675, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Pre nombres";
            // 
            // tprograma
            // 
            this.tprograma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tprograma.Location = new System.Drawing.Point(424, 316);
            this.tprograma.Name = "tprograma";
            this.tprograma.Size = new System.Drawing.Size(450, 31);
            this.tprograma.TabIndex = 23;
            this.tprograma.TextChanged += new System.EventHandler(this.tprograma_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tprograma);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tcontador);
            this.groupBox1.Controls.Add(this.tnombres);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tmaterno);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.tpaterno);
            this.groupBox1.Controls.Add(this.tdni);
            this.groupBox1.Controls.Add(this.lnombres);
            this.groupBox1.Controls.Add(this.lnombre);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(884, 358);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control Biométrico";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SandyBrown;
            this.label7.Location = new System.Drawing.Point(287, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Izquierdo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Salmon;
            this.label6.Location = new System.Drawing.Point(74, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Derecho";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tcontador
            // 
            this.tcontador.Enabled = false;
            this.tcontador.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcontador.Location = new System.Drawing.Point(747, -1);
            this.tcontador.Name = "tcontador";
            this.tcontador.Size = new System.Drawing.Size(127, 43);
            this.tcontador.TabIndex = 27;
            this.tcontador.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 315);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(406, 32);
            this.comboBox1.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(492, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Iniciar Cam";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Yu Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(480, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Iniciar Cam";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 436);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bguardar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.Label lnombre;
        private System.Windows.Forms.Label lnombres;
        private System.Windows.Forms.TextBox tdni;
        private System.Windows.Forms.TextBox tpaterno;
        private System.Windows.Forms.Button bguardar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox tmaterno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tnombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tprograma;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tcontador;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

