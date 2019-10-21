using Recuerdos.Modelo;
using Recuerdos.Utilidades;
using Recuerdos.Vista;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recuerdos
{
    public partial class pnPrincipal : Form
    {
        //Instancias
        //sirve para saber el ID del usuario logueado actualmente
        int usuario;
        //sirve para saber cual es el texto que tiene un archivo cuando se abre
        String textoCuandoAbre = "";
        //Arraylist para manejar los directorios existentes en la BD
        public static ArrayList lista_directorios = new ArrayList();

        //Arraylist para manejar los archivos existentes en la BD
        public static ArrayList lista_archivos = new ArrayList();

        //objeto de la conexion, consulta y operaciones a la BD
        public static Conexion objCon = new Conexion();

        //Variable para guardar la conexion a la BD
        private static SqlConnection con = null;

        //Almacena el nombre del nodo que este actualmente abierto (por uncionalidad puede ser un nodo en un futuro)
        static TreeNode nodoAbierto = null;

        //booleano para manejar el movimiento del sliptterPanel
        Boolean esconder = true;

        //CONSTRUCTOR
        public pnPrincipal(int usuario)
        {
            
            InitializeComponent();
            tvSuenos.Nodes.Clear();
            lista_archivos.Clear();
            lista_directorios.Clear();        
            desHabilitarComponenes();
            this.Focus();
            this.usuario = usuario;
            InicializarTree();
        }

        //llena el tree view        
        Boolean InicializarTree()
        {
            //Instancias del metodo
            TreeNode nodo = null;
            Color c = Color.Transparent;
            try
            {
                con = objCon.conectar();
                lista_directorios = objCon.consultaDir("select * from  directorio where id_usuarios="+usuario+"", con);
                objCon.cerrar(con);
                con = objCon.conectar();
                lista_archivos = objCon.consultaArch("select * from  archivo where id_usuarios="+usuario+"", con);
                if (lista_directorios != null)
                {
                    if (lista_directorios.Count > 0)
                    {
                        foreach (Directorio d in lista_directorios)
                        {
                            if (d.Padre == 0)
                            {
                                nodo = new TreeNode
                                {
                                    Text = d.Nombre,
                                    Tag = "dir",
                                    ImageIndex = 0,
                                    SelectedImageIndex = 0,
                                };
                                tvSuenos.Nodes.Add(nodo);
                                if (lista_archivos.Count > 0)
                                {
                                    foreach (Archivo a in lista_archivos)
                                    {
                                        if (a.Id_directorio == d.Id)
                                        {
                                            if (a.Pendiente == true)
                                            {
                                                c = Color.Red;
                                            }
                                            else
                                            {
                                                c = Color.White;
                                            }
                                            nodo.Nodes.Add(new TreeNode
                                            {
                                                Text = a.Nombre,
                                                Tag = "arch",
                                                ImageIndex = 1,
                                                SelectedImageIndex = 1,
                                                BackColor = c
                                            });
                                        }
                                    }
                                }
                                cargarHijos(nodo, d.Id, lista_directorios, lista_archivos);
                            }
                            tvSuenos.ExpandAll();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ah ocurrido algun problema, notifiquelo al desarrollador");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Entro al catch \n " + e.ToString());
            }
            return true;
        }

        //nodo necesario para cargar tree view
        TreeNode node2 = null;

        //carga hijos del treeview
        public void cargarHijos(TreeNode node, double id, ArrayList alDir, ArrayList alArch)
        {
            Color c = Color.Transparent;
            foreach (Directorio d in alDir)
            {
                if (id == d.Padre)
                {
                    node2 = new TreeNode
                    {
                        Text = d.Nombre,
                        Tag = "dir",
                        ImageIndex = 0,
                        SelectedImageIndex = 0,
                    };
                    node.Nodes.Add(node2);
                    if (alArch.Count > 0)
                    {
                        foreach (Archivo a in alArch)
                        {
                            if (a.Id_directorio == d.Id)
                            {
                                if (a.Pendiente == true)
                                {
                                    c = Color.Red;
                                }
                                else
                                {
                                    c = Color.White;
                                }
                                node2.Nodes.Add(new TreeNode
                                {
                                    Text = a.Nombre,
                                    Tag = "arch",
                                    ImageIndex = 1,
                                    SelectedImageIndex = 1,
                                    BackColor = c
                                });
                            }
                        }
                    }
                    cargarHijos(node2, d.Id, alDir, alArch);
                }
            }
        }

        //Habilita todos los componentes cuando una hoja de texto es abierta y asi porder usarlos
        void habilitarComponentes()
        {
            guardarcomoToolStripMenuItem.Enabled = true;
            guardarToolStripMenuItem.Enabled = true;
            imprimirToolStripMenuItem.Enabled = true;
            vistapreviadeimpresiónToolStripMenuItem.Enabled = true;
            editarToolStripMenuItem.Enabled = true;
            herramientasToolStripMenuItem.Enabled = true;
            txtSueño.Visible = true;
            btnSinAcabar.Visible = true;
        }

        //metodo que desabilita componentes en caso de que no halla un sueño abierto
        void desHabilitarComponenes()
        {
            guardarcomoToolStripMenuItem.Enabled = false;
            guardarToolStripMenuItem.Enabled = false;
            imprimirToolStripMenuItem.Enabled = false;
            vistapreviadeimpresiónToolStripMenuItem.Enabled = false;
            editarToolStripMenuItem.Enabled = false;
            herramientasToolStripMenuItem.Enabled = false;
            txtSueño.Visible = false;
            btnSinAcabar.Visible = false;
        }

        //evento click de icono para esconder y abrir el sliptterPanel
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (esconder)
            {
                mainSlipContainer.Panel1.Hide();
                mainSlipContainer.SplitterDistance = 0;
                pbWrapper.Hide();
                esconder = false;
            }
            else
            {
                mainSlipContainer.Panel1.Show();
                mainSlipContainer.SplitterDistance = 200;
                pbWrapper.Hide();
                esconder = true;
            }
        }

        //Evento hover que muestra la imagen que esconde y muestra el sliptterPanel
        private void mainSlipContainer_MouseHover(object sender, EventArgs e)
        {
            if (txtSueño.Visible == true)
            {
                pbWrapper.BackColor = Color.LightSteelBlue;
            }
            pbWrapper.Show();
        }

        //Opcion alternativa para esconder el sliptterPanel por medio de click derecho en treeview
        private void ocultarSueñosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainSlipContainer.Panel1.Hide();
            mainSlipContainer.SplitterDistance = 0;
            pbWrapper.Hide();
            esconder = false;
        }

        //instancia de treenode para saber que nodo fue seleccionado al crear otro (SIN ACOPLAR A BD)
        TreeNode seleccion = null;
        private void nuevaCarpetaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Opcion que elimina tree node del tree view por medio de click derecho (SIN ACOPLAR A BD)
        private void eliminarcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tvSuenos.Nodes.Remove(tvSuenos.SelectedNode);
            //Eliminar de la base de datos y actualizar el treeview
        }

        //Opcion que permite el cambio de nombre por medio de click derecho en el treenode 
        private void cambiarNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tvSuenos.SelectedNode.BeginEdit();
        }

        //Funcionalidad de doble click que permite abrir el contenido de un nodo en el txtNota con la BD
        private void tvSuenos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (txtSueño.Visible == true)
                {
                    if (salirDeSueno() != "cancel")
                    {
                        if (tvSuenos.SelectedNode != null && tvSuenos.SelectedNode.Tag.ToString() == "arch")
                        {
                            abrirNota();
                        }
                    }
                }
                else
                {
                    if (tvSuenos.SelectedNode != null && tvSuenos.SelectedNode.Tag.ToString() == "arch")
                    {
                        abrirNota();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos, algo salio mal al abrir este archivo...\n" + ex.ToString());
            }
        }

        //metodo generico para abrir un sueño m
        void abrirNota()
        {
            SqlDataReader consulta;
            con = objCon.conectar();
            nodoAbierto = tvSuenos.SelectedNode;
            consulta = objCon.consulta("select contenido from archivo where nombre ='" + nodoAbierto.Text + "' and id_usuarios="+usuario+"", con);
            while (consulta.Read())
            {
                txtSueño.Text = consulta["contenido"].ToString();
                textoCuandoAbre = txtSueño.Text;
            }
            habilitarComponentes();
            nodoAbierto = tvSuenos.SelectedNode;
        }

        //Guarda lo que hay en el archivo actualmente abierto y lo actualiza en la BD
        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActualizarSueño())
            {
                ActualizarSueño();
                MessageBox.Show("Se guardo exitosamente");
            }
            else
            {
                MessageBox.Show("Ah ocurrido un error, lo atenderemos lo mas pronto posible.");
            }
        }

        //metodo generico para actualizar el valor del sueño
        public Boolean ActualizarSueño()
        {
            if (nodoAbierto != null)
            {
                String nota = txtSueño.Text;
                con = objCon.conectar();
                objCon.operar("update archivo set contenido='" + nota + "' where nombre='" + nodoAbierto.Text + "' and id_usuarios="+usuario+"", con);
                textoCuandoAbre = nota;
                return true;
            }
            else
            {
                return false;
            }
        }

        //Selecciona el nodo sobre el que esta el mouse
        private void tvSuenos_NodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
        {
            tvSuenos.SelectedNode = e.Node;
        }

        //Funcionalidad del click delerecho sobre el textBox de copiar el texto seleccionado
        private void copiarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (txtSueño.SelectedText != "")
            {
                //Clipboard.SetText(txtNota.SelectedText);
                txtSueño.Copy();
            }
        }

        //Funcionalidad del click delerecho sobre el textBox de cortar el texto seleccionado
        private void cortarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (txtSueño.SelectedText != "")
            {
                //Clipboard.SetText(txtNota.SelectedText);
                txtSueño.Cut();
            }
        }

        //Obtiene lo que hay en el porta papeles y lo pega donde esta el cursor
        private void pegarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IDataObject iData = Clipboard.GetDataObject();
            if (iData.GetDataPresent(DataFormats.Text))
            {
                //txtNota.Text=txtNota.Text.Insert(txtNota.SelectionStart, (String)iData.GetData(DataFormats.Text));
                txtSueño.Paste();
            }
        }

        //Opcion de cerrar sueño en el menu de contexto del textBox
        private void cerrarSueñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String salir = salirDeSueno();
            switch (salir)
            {
                case "si":
                    MessageBox.Show("Guardado..");
                    break;
                case "no":
                    break;
                case "error":
                    MessageBox.Show("ah ocurrido un problema, lo solucionaremos lo mas rapido posible.");
                    break;
                case "cancel":
                    break;
                default:
                    desHabilitarComponenes();
                    break;
            }
        }

        //Metodo generico para salir de un sueño
        public String salirDeSueno()
        {
            if (textoCuandoAbre != txtSueño.Text)
            {
                var respuesta = MessageBox.Show("¿Desea guardar los cambios hechos antes de cerrar el sueño?", "", MessageBoxButtons.YesNoCancel);
                if (respuesta == DialogResult.Yes)
                {
                    if (ActualizarSueño())
                    {
                        txtSueño.Visible = false;
                        tvSuenos.Focus();
                        nodoAbierto = null;
                        desHabilitarComponenes();
                        return "si";
                    }
                    else
                    {
                        return "error";
                    }
                }
                else if (respuesta == DialogResult.No)
                {
                    nodoAbierto = null;
                    tvSuenos.Focus();
                    desHabilitarComponenes();
                    return "no";
                }
                else if (respuesta == DialogResult.Cancel)
                {
                    return "cancel";
                }
            }
            return "";
        }

        //Opcion de menu de contexto del textBox para guardar sueño
        private void guardarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ActualizarSueño())
            {
                MessageBox.Show("Se guardo exitosamente");
            }
            else
            {
                MessageBox.Show("Ah ocurrido un error, lo atenderemos lo mas pronto posible.");
            }
        }

        //Limpia todo lo que hay en el sueño
        private void limpiarSueñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Esta seguro que desea limpar el sueño?", "", MessageBoxButtons.OKCancel);
            if (DialogResult.OK == respuesta)
            {
                Clipboard.SetText(txtSueño.Text);
                txtSueño.Text = "";
            }
        }

        //Funcion generica del ctr+z
        private void deshacerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //txtNota.Text=(String)Clipboard.GetData(DataFormats.Text);
            txtSueño.Undo();
        }

        //evento click valida el cambio de color para saber si el sueño esta con tarea o no
        private void btnSinAcabar_Click(object sender, EventArgs e)
        {

            if (nodoAbierto.BackColor != Color.Red)
            {
                actualizarPendiente(1);
            }
            else
            {
                actualizarPendiente(0);
            }
        }

        //Actualiza en la BD el texto que esta abierto en el momento
        public void actualizarPendiente(int estado)
        {
            int cambio;
            con = objCon.conectar();
            cambio = objCon.operar("update archivo set pendiente=" + estado + "where nombre='" + nodoAbierto.Text + "' and id_usuarios="+usuario+"", con);
            if (cambio > 0)
            {
                if (estado == 1)
                {
                    nodoAbierto.BackColor = Color.Red;
                    btnSinAcabar.Text = "Terminado";
                }
                else
                {
                    nodoAbierto.BackColor = Color.White;
                    btnSinAcabar.Text = "Sin terminar";
                }
            }
        }

        //SIN TERMINAR (crea un nuevo recuerdo)
        private void tsmNuevoRecuerdo_Click(object sender, EventArgs e)
        {            
            seleccion = tvSuenos.SelectedNode;
            if (seleccion.Tag.ToString() != "arch")
            {
                crearSueñosRecuerdos csr = new crearSueñosRecuerdos("recuerdo", seleccion);
                csr.Show();
            }
        }

        //SIN TERMINAR (oculta u muestra la ventana de recuerdos con un shortcut (stackoverflow))
        private void ocultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (this.WindowState==FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Minimized;  
                
            }
        }

        //Boton para cerrar la sesion del gestor de recuerdos
        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            Ingreso objIng = new Ingreso(this);
            desHabilitarComponenes();
            objIng.Show();
            this.Hide();
        }

        //Programacion del boton de salida panel principal
        private void pnPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //Programacion del boton de saida menu principal
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //public pnPrincipal()
        //{
        //    InitializeComponent();
        //    txtSueño.Hide();
        //    this.Focus();
        //    InicializarTree();
        //}
    }
}