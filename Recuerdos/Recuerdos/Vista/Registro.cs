using Recuerdos.Utilidades;
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

namespace Recuerdos.Vista
{
    public partial class Registro : Form
    {
        //Instancias
        static Validaciones objV = new Validaciones();
        Conexion objCon = new Conexion();
        SqlConnection con;
        SqlDataReader consulta;
        public Registro()
        {
            InitializeComponent();
        }

        //Limitacion de escritura para el usuario en el campo de nombres
        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            objV.validarLetraEspacio(sender, e);
        }

        //Limitacion de escritura para el usuario en el campo de apellidos
        private void txtApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            objV.validarLetraEspacio(sender, e);
        }

        //Limitacion de escritura para el usuario en el campo de usuario
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            objV.validarLetrasNumeros(sender, e);
        }

        //Limitacion de escritura para el usuario en el campo de contracena
        private void txtContracena_KeyPress(object sender, KeyPressEventArgs e)
        {
            objV.validarLetrasNumeros(sender, e);
        }

        //Funcionalidad de cancelar por medio un boton
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //funcionalidad de todo el proceso de registro por medio de boton
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombres.Text != "" && txtApellidos.Text != "" && txtUsuario.Text != "" && txtContracena.Text != "" && txtCorreo.Text != "")
            {
                if (objV.formato_Alfabetico_Espacios(txtNombres.Text) && objV.formato_Alfabetico_Espacios(txtApellidos.Text) && objV.formato_usuario(txtUsuario.Text) && objV.formato_Contracena(txtContracena.Text) && objV.formato_Contracena(txtConfirmarContracena.Text) && objV.validaCorreoElectronico(txtCorreo.Text))
                {
                    if (txtContracena == txtConfirmarContracena)
                    {
                        con = objCon.conectar();
                        consulta = objCon.consulta("select * from usuario where usuario='" + txtUsuario.Text + "' or correo_electronico='" + txtCorreo.Text + "'", con);
                        if (consulta.Read())
                        {
                            if (consulta["usuario"].ToString() == txtUsuario.Text)
                            {
                                MessageBox.Show("Lo sentimos ya existe un usuario con este nombre. (⊙_⊙)？");
                            }
                            else
                            {
                                MessageBox.Show("Lo sentimos ya existe un usuario con este correo electrónico. ¯\'(°_o)/¯");
                            }
                            objCon.cerrar(con);
                        }
                        else
                        {
                            objCon.cerrar(con);
                            con = objCon.conectar();
                            int num = objCon.operar("Insert into usuario values('" + txtUsuario.Text + "','" + txtContracena.Text + "','" + txtNombres.Text + "','" + txtApellidos.Text + "','" + txtCorreo.Text + "');", con);
                            objCon.cerrar(con);
                            if (num > 0)
                            {
                                MessageBox.Show("Registro exitoso, ¡FELICIDADES! ☜(ﾟヮﾟ☜)");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Lo sentimos, algo a salido mal inténtalo mas tarde (┬┬﹏┬┬)");
                            }
                        }
                    }
                    else
                    {
                        txtConfirmarContracena.Text = "";
                        txtContracena.Text = "";
                        MessageBox.Show("La cotraseña no coincide.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Verifica que hayas llenado todos los campos.");
            }
        }

        //Limitacion de escritura para el usuario en el campo de correo electronico
        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            objV.validarLetrasNumerosGuiones(sender, e);
        }

        private void limpiarCampos()
        {
            txtNombres.Text = "";
            txtApellidos.Text = "";
            txtUsuario.Text = "";
            txtContracena.Text = "";
            txtCorreo.Text = "";
            
        }

        private void txtConfirmarContracena_KeyPress(object sender, KeyPressEventArgs e)
        {
            objV.validarLetrasNumeros(sender, e);
        }
    }
}
