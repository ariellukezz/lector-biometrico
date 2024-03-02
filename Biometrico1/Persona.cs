using GriauleFingerprintLibrary.DataTypes;

namespace Biometrico1
{
    internal class Persona
    {
        public int id { get; set; }
        public string dni { get; set; }
        public string nombre { get; set; }
        public string paterno { get; set; }
        public string materno { get; set; }
        public string programa { get; set; }

        public FingerprintTemplate indiceIzquierdo { get; set; }
        public FingerprintTemplate indiceDerecho { get; set; }
        public string huellaIzquierdaUrl { get; set; }
        public string huellaDerechaUrl { get; set; }


    }
}
