using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Recuerdos.Utilidades;
using Recuerdos.Vista;

namespace Recuerdos.Vista
{
    public partial class Ingreso : Form
    {
        Conexion objCon = new Conexion();
        SqlConnection con;
        SqlDataReader consulta;
        public Ingreso(Recuerdos.pnPrincipal objR)
        {
            InitializeComponent();
        }
        public Ingreso()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtClave.Text!="" && txtUsuario.Text!="")
            {
                con = objCon.conectar();
                consulta = objCon.consulta("select * from usuarios where usuario='"+txtUsuario.Text+"'", con);
                if (consulta.Read())
                {
                    String clave = consulta["contracena"].ToString();
                    String usuario = consulta["usuario"].ToString();
                    if (clave == txtClave.Text && txtUsuario.Text==usuario)
                    {
                        Recuerdos.pnPrincipal obj = new Recuerdos.pnPrincipal(Convert.ToInt32(consulta["id"].ToString()));
                        limpiarCampos();
                        this.Hide();
                        obj.Show();
                    }
                    else
                    {
                        MessageBox.Show("El usuario o contraceña ingresados son incorrectos, verifique los datos ingresados");
                    }
                }
                else
                {
                    MessageBox.Show("El usuario ingresado no existe");
                }
                objCon.cerrar(con);
            }
            else
            {
                MessageBox.Show("Verifique que todo los campos si hallan sido llenados");
            }
        }

        void limpiarCampos()
        {
            txtClave.Text = "";
            txtUsuario.Text = "";
        }
        private void btbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ingreso_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
