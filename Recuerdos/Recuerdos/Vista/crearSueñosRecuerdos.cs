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
        int usuario, padre = 0;
        public static Conexion objCon = new Conexion();
        private static SqlConnection con = null;
        SqlDataReader consulta;
        String tipo;
        //CONSTRUCTOR
        public crearSueñosRecuerdos()
        {
            InitializeComponent();
        }

        //Sobrecarga del constructor que permite el traspaso de informacion desde recuerdos a esta ventana para la creacion de un nodo
        public crearSueñosRecuerdos(String tipo, TreeNode seleccion, int usuario)
        {
            InitializeComponent();
            lblTexto.Text = lblTexto.Text + " " + tipo;
            this.tipo = tipo;
            this.seleccion = seleccion;
            this.usuario = usuario;
        }

        //Cancela la accion de crear un nuevo nodo
        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Crea el nuevo nodo y retorna al principal
        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (tipo == "dir")
            {
                crearRecuerdo();
            }
            else
            {
                crearSueno();
            }
        }

        //Crea el treenode e inserta en la BD el nuevo sueño
        void crearSueno()
        {
            if (txtNuevoNombre.Text != "")
            {
                con = objCon.conectar();
                if (seleccion != null)
                {
                    consulta = objCon.consulta("select * from recuerdo where nombre='" + seleccion.Text + "' and id_usuario=" + usuario + "", con);
                    if (consulta.Read())
                    {
                        padre = Convert.ToInt32(consulta["id"].ToString());
                    }
                }
                objCon.cerrar(con);
                con = objCon.conectar();
                consulta = objCon.consulta("select * from sueno where nombre='" + txtNuevoNombre.Text + "' and id_usuario=" + usuario + " and id_recuerdo=" + padre + "", con);
                if (consulta.Read())
                {
                    MessageBox.Show("Lo sentimos ya existe un sueño con este nombre. （⊙ｏ⊙）");
                    objCon.cerrar(con);
                }
                else
                {
                    con = objCon.conectar();
                    objCon.operar("insert into sueno values(" + usuario + "," + padre + ",'" + txtNuevoNombre.Text + "',NULL,0)", con);
                    pnPrincipal objr = new pnPrincipal(usuario);
                    seleccion.Nodes.Add(new TreeNode
                    {
                        Text = txtNuevoNombre.Text,
                        Tag = padre,
                        ImageIndex = 1,
                        SelectedImageIndex = 1,
                        BackColor = Color.White
                    });
                    seleccion = null;
                    objCon.cerrar(con);
                    objr.Focus();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Porfavor ingresa un nombre, no se admite vacio como nombre  ⊙﹏⊙∥");
            }
        }

        //Crea el treenode e inserta en la BD el nuevo recuerdo
        void crearRecuerdo()
        {
            if (txtNuevoNombre.Text != "")
            {
                con = objCon.conectar();
                consulta = objCon.consulta("select * from recuerdo where nombre='" + seleccion.Text + "' and id_usuario=" + usuario + "", con);
                if (consulta.Read())
                {
                    padre = Convert.ToInt32(consulta["id"].ToString());
                    objCon.cerrar(con);
                }
                con = objCon.conectar();
                consulta = objCon.consulta("select * from recuerdo where id_padre=" + padre + " and nombre='" + txtNuevoNombre.Text + "' and id_usuario=" + usuario + "", con);
                if (consulta.Read())
                {
                    MessageBox.Show("Lo sentimos ya existe una recuerdo con este nombre. （⊙ｏ⊙）");
                    objCon.cerrar(con);
                }
                else
                {
                    con = objCon.conectar();
                    objCon.operar("insert into recuerdo values(" + usuario + "," + padre + ",'" + txtNuevoNombre.Text + "',0)", con);
                    pnPrincipal objr = new pnPrincipal(usuario);
                    seleccion.Nodes.Add(new TreeNode
                    {
                        Text = txtNuevoNombre.Text,
                        Tag = padre,
                        ImageIndex = 0,
                        SelectedImageIndex = 0
                    });
                    seleccion = null;
                    objCon.cerrar(con);
                    objr.Focus();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Porfavor ingresa un nombre, no se admite vacio como nombre  ⊙﹏⊙∥");
            }
        }
    }
}
