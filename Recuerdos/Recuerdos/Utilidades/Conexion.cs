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
                MessageBox.Show("Se realizo la conexion...");
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
                    Directorio objDir = new Directorio();
                    objDir.Id = Convert.ToDouble(tabla["id"].ToString());
                    if (tabla[1].ToString()=="")
                    {
                        objDir.Padre = 0;
                    }
                    else
                    {
                        objDir.Padre = Convert.ToDouble(tabla[1].ToString());
                    }                    
                    objDir.Nombre = tabla["nombre"].ToString();
                    arrayDir.Add(objDir);                    
                }
                conector.Close();
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
                    Archivo objArch = new Archivo();
                    objArch.Id = Convert.ToInt32(tabla["id"].ToString());
                    objArch.Nombre = tabla["nombre"].ToString();
                    objArch.Id_directorio = Convert.ToInt32(tabla["id_directorio"].ToString());
                    objArch.Contenido = tabla["contenido"].ToString();
                    //MessageBox.Show(tabla["pendiente"].ToString());
                    //objArch.Pendiente = Convert.ToBoolean(tabla["pendiente"].ToString());
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
                MessageBox.Show("Fallo la consulta" + e.ToString());
                return num;
            }
        }

        //Cierra conexion con la BD
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
