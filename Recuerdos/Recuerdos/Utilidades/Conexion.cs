using Recuerdos.Modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recuerdos.Utilidades
{
    public class Conexion
    {
        //instancias
        public static ArrayList arrayDir = new ArrayList();
        public static ArrayList arrayArch = new ArrayList();
        public Conexion()
        {
        }


        //Metodo conecta abre la conexion con la base de datos
        public SqlConnection conectar()
        {
            //SqlConnection conectar = new SqlConnection("Data Source=localhost;Initial Catalog = " + nomBD + "; Integrated Security = SSPI; ");
            SqlConnection conectar = new SqlConnection("Data Source=localhost;Initial Catalog = recuerdos; Integrated Security = SSPI; ");
            try
            {
                conectar.Open();
                //MessageBox.Show("Se realizo la conexion...");
                return conectar;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la conexión " + ex.ToString());
                return null;
            }
        }

        //Consulta a la BD que retorna un SqlDataReader
        public SqlDataReader consulta(string conSQL, SqlConnection conector)
        {
            try
            {
                SqlCommand comando = new SqlCommand(conSQL, conector);
                SqlDataReader tabla = comando.ExecuteReader();
                return tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la consulta " + ex.ToString());
                return null;
            }
        }

        //Consulta todos los directorios existentes en la BD
        public ArrayList consultaDir(string conSQL, SqlConnection conector)
        {            
            try
            {
                SqlCommand comando = new SqlCommand(conSQL, conector);
                SqlDataReader tabla = comando.ExecuteReader();
                while (tabla.Read())
                {
                    Recuerdo objDir = new Recuerdo();
                    objDir.Id = Convert.ToDouble(tabla["id"].ToString());
                    objDir.Padre = Convert.ToDouble(tabla["id_padre"].ToString());            
                    objDir.Nombre = tabla["nombre"].ToString();
                    objDir.Id_usuario = Convert.ToDouble(tabla["id_usuario"].ToString());
                    objDir.Tipo = Convert.ToInt32(tabla["tipo"].ToString());
                    arrayDir.Add(objDir);                    
                }
                return arrayDir;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la consulta " + ex.ToString());
                return null;
            }
        }

        //Consulta todos los archivos existentes en la BD
        public ArrayList consultaArch(string conSQL, SqlConnection conector)
        {
            try
            {
                SqlCommand comando = new SqlCommand(conSQL, conector);
                SqlDataReader tabla = comando.ExecuteReader();
                while (tabla.Read())
                {
                    Sueno objArch = new Sueno();
                    objArch.Id = Convert.ToInt32(tabla["id"].ToString());
                    objArch.Id_usuario = Convert.ToDouble(tabla["id_usuario"].ToString());
                    objArch.Id_recuerdo = Convert.ToInt32(tabla["id_recuerdo"].ToString());
                    objArch.Nombre = tabla["nombre"].ToString();
                    objArch.Contenido = tabla["contenido"].ToString();
                    objArch.Pendiente = Convert.ToBoolean(tabla["pendiente"].ToString());
                    arrayArch.Add(objArch);
                }
                return arrayArch;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fallo la consulta " + ex.ToString());
                return null;
            }
        }

        //Actualiza, elimina y inserta en la BD
        public int operar(string conSQL, SqlConnection conector)
        {
            int num = 0;
            try
            {
                SqlCommand comando = new SqlCommand(conSQL, conector);
                num = comando.ExecuteNonQuery();
                return num;
            }
            catch (SqlException e)
            {
                //MessageBox.Show("Fallo la operacion" + e.ToString());
                return num;
            }
        }

        //Cierra conexion con la BD
        public void cerrar(SqlConnection conector)
        {
            try
            {
                conector.Close();
            }
            catch (SqlException eq)
            {
                MessageBox.Show("Fallo el cierre de base de datos" + eq.ToString());
            }
        }
    }
}