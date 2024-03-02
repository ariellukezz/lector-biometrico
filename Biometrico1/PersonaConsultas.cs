using GriauleFingerprintLibrary.DataTypes;
using MySqlConnector;
using System.Data.OleDb;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Collections.Generic;

namespace Biometrico1
{
    internal class PersonaConsultas
    {
        private ConexionMysql conexionMysql;

        public PersonaConsultas()
        {
            conexionMysql = new ConexionMysql();
        }

        internal bool agregarPersona(Persona mpersona)
        {
            string INSERT = "insert into ingresos(dni,nombres, paterno, materno, programa, template, template2) values(@dni,@nombre, @paterno, @materno, @programa, @template, @template2)";

            MySqlCommand mySqlCommand = new MySqlCommand(INSERT, conexionMysql.GetConnection());

            mySqlCommand.Parameters.Add(new MySqlParameter("@nombre", mpersona.nombre));
            mySqlCommand.Parameters.Add(new MySqlParameter("@dni", mpersona.dni));
            mySqlCommand.Parameters.Add(new MySqlParameter("@paterno", mpersona.paterno));
            mySqlCommand.Parameters.Add(new MySqlParameter("@materno", mpersona.materno));
            mySqlCommand.Parameters.Add(new MySqlParameter("@programa", mpersona.programa));
            mySqlCommand.Parameters.Add(new MySqlParameter("@template", mpersona.indiceIzquierdo.Buffer));
            mySqlCommand.Parameters.Add(new MySqlParameter("@template2", mpersona.indiceDerecho.Buffer));
            return mySqlCommand.ExecuteNonQuery() > 0;
        }

        public IDataReader getPersona() 
        {
            string strCommand = "select * from persona";
            MySqlCommand mySqlCommand = new MySqlCommand(strCommand, conexionMysql.GetConnection());

            return mySqlCommand.ExecuteReader();

        }


        public IDataReader getPersonaDNI(string _dni)
        {
            string strCommand = "SELECT * from persona  WHERE dni = " + _dni;
            MySqlCommand mySqlCommand = new MySqlCommand(strCommand, conexionMysql.GetConnection());

            return mySqlCommand.ExecuteReader();
        }

        public IDataReader getPersonaCount()
        {
            string strCommand = "SELECT count(*) as cont from ingresos";
            MySqlCommand mySqlCommand = new MySqlCommand(strCommand, conexionMysql.GetConnection());
            return mySqlCommand.ExecuteReader();
        }

    }
}
