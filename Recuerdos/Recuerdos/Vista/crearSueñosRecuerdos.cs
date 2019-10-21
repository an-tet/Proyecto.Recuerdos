using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Recuerdos.Modelo;
using Recuerdos.Utilidades;

namespace Recuerdos
{
    public partial class crearSueñosRecuerdos : Form
    {
        //Instacias propias

        public TreeNode seleccion = null;
         pnPrincipal objr =new pnPrincipal(1);
        public static Conexion objCon = new Conexion();
        private static SqlConnection con = null;
        //CONSTRUCTOR
        public crearSueñosRecuerdos()
        {
            InitializeComponent();
        }

        //Sobrecarga del constructor que permite el traspaso de informacion desde recuerdos a esta ventana para la creacion de un nodo
        public crearSueñosRecuerdos(String tipo,TreeNode seleccion)
        {
            InitializeComponent();
            lblTexto.Text = lblTexto.Text + " " + tipo;
            this.seleccion = seleccion;
        }

        //Cancela la accion de crear un nuevo nodo
        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Crea el nuevo nodo y retorna al principal
        private void btnCrear_Click(object sender, EventArgs e)
        {
            SqlDataReader consulta;
            con = objCon.conectar();
            consulta = objCon.consulta("select * from directorio where nombre='" + seleccion.Text + "'", con);
            if(consulta.Read())
            {
                objCon.cerrar(con);
                int pardre = Convert.ToInt32(consulta["id_padre"].ToString());
                objCon.conectar();
                consulta = objCon.consulta("select * from directorio where id_padre=1 and nombre='"+txtNuevoNombre+"'", con);
                if (consulta.Read())
                {
                    MessageBox.Show("Lo sentimos ya existe una carpeta con este nombre.");
                }
                else
                {
                    pnPrincipal objr = new pnPrincipal(1);                    
                    seleccion.Nodes.Add(new TreeNode
                    {
                        Text = txtNuevoNombre.Text,
                        Tag = "dir",
                    });
                    seleccion = null;
                    objr.Focus();
                    this.Close();
                }
            }
            //con.Close();
            //con = objCon.conectar();
            //consulta.Read();
            //objCon.operar("insert into directorio values()", con);            
        }
    }
}
