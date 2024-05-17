using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;


namespace pryEstructuraDatos
{
    internal class clsBaseDatos
    {
        //Instanciamos 3 objetos conexion, comando y adaptador
        private OleDbConnection conexion = new OleDbConnection();//Hace de puente con el sistema gestor de base de datos 
        private OleDbCommand comando = new OleDbCommand();//Ejecuta las acciones que le pidamos a la base de datos 
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();//Adapta el tipo de datos a nuestro 

        private string varCadenaConexion1 = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=Libreria.mdb";
        //private string varCadenaConexion2 = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Libreria.mdb";

        public void Listar(DataGridView Grilla)
        {
            try
            {
                conexion.ConnectionString = varCadenaConexion1;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = "LIBRO";

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, "Libro");

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables["Libro"];

                conexion.Close();
            }
            catch(Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        public void Listar(DataGridView Grilla, String ConsultaSQL)
        {
            try
            {
                conexion.ConnectionString = varCadenaConexion1;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = ConsultaSQL;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, "Tabla");

                Grilla.DataSource = null;
                Grilla.DataSource = DS.Tables["Tabla"];

                conexion.Close();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }
    }
}
