using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Acceso
{
    public class Conexion
    {
        private SqlConnection Conection;
        private const string CONNECTION_STRING = @"Data Source=DESKTOP-4EMC1D1;Initial Catalog=PrimerParcialLug;Integrated Security=True";

        #region Abrir y Cerrar Conexion
        public bool OpenConexion()
        {
            if (Conection != null && Conection.State == System.Data.ConnectionState.Open)
            {
                return true;
            }

            try
            {
                Conection = new SqlConnection();
                Conection.ConnectionString = CONNECTION_STRING;
                Conection.Open();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
            
        }
        public void ClosedConexion()
        {
            Conection.Close();      
            Conection.Dispose();
            GC.Collect();
        }
        #endregion


        public bool CrearComando(string ProcedAlmacenado, List<IDbDataParameter> parametros = null)
        {
            using (var Comando = new SqlCommand(ProcedAlmacenado, Conection)) 
            {           
                Comando.CommandType = System.Data.CommandType.StoredProcedure;
                Comando.Parameters.AddRange(parametros.ToArray());//añado todos los parametros
                Comando.ExecuteNonQuery();
            }
            return true;
        }

        public DataTable LeerBaseDeDatos(string procAlmacenado)
        {
            DataTable tabla = new DataTable();

            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = new SqlCommand(procAlmacenado, Conection); //Le paso el procAlmacenado y la conexion al comando
            DA.Fill(tabla); //Ejecuto comando y le paso la tabla para rellenar

            return tabla;
        }//Leo todos los elementos

        public DataTable LeerBaseDeDatos(string procAlmacenado, int id)
        {
            DataTable tabla = new DataTable();
            SqlCommand comando = new SqlCommand(procAlmacenado, Conection);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            SqlDataAdapter DA = new SqlDataAdapter();
            DA.SelectCommand = comando; //Le paso el procAlmacenado y la conexion al comando
            DA.Fill(tabla); //Ejecuto comando y le paso la tabla para rellenar

            return tabla;
        }//Leo los elementos con cierto ID

        #region Creo Parametros
        public IDbDataParameter CrearParametro(string nom, string valor)
        {
            SqlParameter parametro = new SqlParameter(nom, valor);
            parametro.DbType = DbType.String;
            return parametro;
        }
        public IDbDataParameter CrearParametro(string nom, int valor)
        {
            SqlParameter parametro = new SqlParameter(nom, valor);
            parametro.DbType = DbType.Int32;
            return parametro;
        }
        #endregion

    }
}
