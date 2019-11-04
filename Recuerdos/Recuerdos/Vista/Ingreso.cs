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

namespace Recuerdos.Vista
{
    public partial class Ingreso : Form
    {
        Validaciones objV = new Validaciones();
        Conexion objCon = new Conexion();
        SqlConnection con;
        SqlDataReader consulta;

        //constructor sobrecargado
        public Ingreso(Recuerdos.pnPrincipal objR)
        {
            InitializeComponent();
        }

        //constructor vacio
        public Ingreso()
        {
            InitializeComponent();
        }
        
        //Valida si las credenciales son correctas y de serlo envia al pnprincipal de Recuerdos (ORGANIZAR CON OBJETO DE USUARIO DE SER NECESARIO)
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtClave.Text!="" && txtUsuario.Text!="")
            {
                con = objCon.conectar();
                consulta = objCon.consulta("select * from usuario where usuario='"+txtUsuario.Text+"'", con);
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

        //borra los datos que hay en las credenciales
        void limpiarCampos()
        {
            txtClave.Text = "";
            txtUsuario.Text = "";
        }

        //Sale de la aplicacion
        private void btbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
  
        //acciones cuando le dan al boton de salir
        private void Ingreso_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Boton que abre ventana de registro de usuario
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Registro objR = new Registro();
            objR.Show();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            objV.validarLetrasNumeros(sender, e);
        }

        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            objV.validarLetrasNumeros(sender, e);
        }
    }
}
