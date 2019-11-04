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
using Recuerdos.Properties;
using System.Drawing.Text;

namespace Recuerdos
{
    public partial class pnPrincipal : Form
    {
        //Instancias
        //sirve para saber el ID del usuario logueado actualmente
        int usuario;
        //sirve para saber cual es el texto que tiene un archivo cuando se abre
        String textoCuandoAbre = "", antes;
        //Arraylist para manejar los directorios existentes en la BD
        public static ArrayList lista_directorios = new ArrayList();

        //Arraylist para manejar los archivos existentes en la BD
        public static ArrayList lista_archivos = new ArrayList();

        //objeto de la conexion, consulta y operaciones a la BD
        public static Conexion objCon = new Conexion();

        //Variable para guardar la conexion a la BD
        private static SqlConnection con = null;

        //Almacena el nombre del nodo que este actualmente abierto 
        static TreeNode nodoAbierto = null;

        //booleano para manejar el movimiento del sliptterPanel
        Boolean esconder = true;

        private InstalledFontCollection installedFonts = new InstalledFontCollection();
        
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
            //Carga lo que tiene que ver con los colores de fuente (carga el nombre en el textbox)
            string[] colores = Enum.GetNames(typeof(System.Drawing.KnownColor));
            foreach (String item in colores)
            {
                cmbColor.Items.Add(Color.FromName(item));
            }
        }

        void cargarListas()
        {
            con = objCon.conectar();
            lista_directorios = objCon.consultaDir("select * from  recuerdo where id_usuario=" + usuario + "", con);
            objCon.cerrar(con);
            con = objCon.conectar();
            lista_archivos = objCon.consultaArch("select * from  sueno where id_usuario=" + usuario + "", con);
            objCon.cerrar(con);
        }
        //llena el tree view        
        public Boolean InicializarTree()
        {
            //Instancias del metodo
            TreeNode nodo = null;
            Color c = Color.Transparent;
            try
            {
                cargarListas();
                if (lista_directorios != null)
                {
                    if (lista_directorios.Count > 0)
                    {
                        foreach (Recuerdo d in lista_directorios)
                        {
                            if (d.Padre == 0)
                            {
                                nodo = new TreeNode
                                {
                                    Text = d.Nombre,
                                    Tag = d.Padre,
                                    ImageIndex = d.Tipo,
                                    SelectedImageIndex = d.Tipo,
                                };
                                tvSuenos.Nodes.Add(nodo);
                                if (lista_archivos.Count > 0)
                                {
                                    foreach (Sueno a in lista_archivos)
                                    {
                                        //if (a.Id_recuerdo == 0)
                                        //{
                                        //    if (a.Pendiente == true)
                                        //    {
                                        //        c = Color.Red;
                                        //    }
                                        //    else
                                        //    {
                                        //        c = Color.White;
                                        //    }
                                        //    tvSuenos.Nodes.Add(new TreeNode
                                        //    {
                                        //        Text = a.Nombre,
                                        //        Tag = "arch",
                                        //        ImageIndex = 1,
                                        //        SelectedImageIndex = 1,
                                        //        BackColor = c
                                        //    });
                                        //}
                                        if (a.Id_recuerdo == d.Id)
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
                                                Tag = d.Id,
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
            foreach (Recuerdo d in alDir)
            {
                if (id == d.Padre)
                {
                    node2 = new TreeNode
                    {
                        Text = d.Nombre,
                        Tag = id,
                        ImageIndex = d.Tipo,
                        SelectedImageIndex = d.Tipo,
                    };
                    node.Nodes.Add(node2);
                    if (alArch.Count > 0)
                    {
                        foreach (Sueno a in alArch)
                        {
                            if (a.Id_recuerdo == d.Id)
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
                                    Tag = d.Id,
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
            guardarToolStripMenuItem.Enabled = true;
            editarToolStripMenuItem.Enabled = true;
            herramientasToolStripMenuItem.Enabled = true;
            txtSueño.Visible = true;
            btnSinAcabar.Visible = true;
            pbWrapper.BackColor = Color.LightSteelBlue;
            cmbFuentes.Enabled = true;
            cmbColor.Enabled = true;
            cmbTamano.Enabled = true;
            btnDerecha.Enabled = true;
            btnIzquierda.Enabled = true;
            btnCentrar.Enabled = true;
        }

        //metodo que desabilita componentes en caso de que no halla un sueño abierto
        void desHabilitarComponenes()
        {
            guardarToolStripMenuItem.Enabled = false;
            editarToolStripMenuItem.Enabled = false;
            herramientasToolStripMenuItem.Enabled = false;
            txtSueño.Visible = false;
            btnSinAcabar.Visible = false;
            cmbFuentes.Enabled = false;
            cmbColor.Enabled = false;
            cmbTamano.Enabled = false;
            btnDerecha.Enabled = false;
            btnIzquierda.Enabled = false;
            btnCentrar.Enabled = false;
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

        //instancia de treenode para saber que nodo fue seleccionado al crear otro
        TreeNode seleccion = null;
        private void nuevaCarpetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seleccion = tvSuenos.SelectedNode;
            if (seleccion.SelectedImageIndex != 1)
            {
                crearSueñosRecuerdos csr = new crearSueñosRecuerdos("arch", seleccion, usuario);
                csr.Show();
            }
            else
            {
                MessageBox.Show("Lo sentimos un sueño no puede tener sueños dentro :c.");
            }
        }

        //Opcion que elimina sueño o recuedo del tree view por medio de menu de click derecho
        private void eliminarcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cargarListas();
            if (seleccion.SelectedImageIndex != 1)
            {
                foreach (Recuerdo d in lista_directorios)
                {
                    if (d.Nombre == seleccion.Text)
                    {
                        eliminarHijos(d.Nombre, d.Id);
                        con = objCon.conectar();
                        objCon.operar("delete from recuerdo where nombre='" + d.Nombre + "' and id_usuario=" + d.Id_usuario + " and id_padre=" + d.Padre + "", con);
                        objCon.cerrar(con);
                        foreach (Sueno s in lista_archivos)
                        {
                            if (s.Id_recuerdo == d.Id)
                            {
                                con = objCon.conectar();
                                objCon.operar("delete from sueno where nombre='" + s.Nombre + "' and id_recuerdo=" + s.Id_recuerdo + " and id_usuario=" + s.Id_usuario + "", con);
                                objCon.cerrar(con);
                            }
                        }
                        tvSuenos.Nodes.Remove(seleccion);
                        return;
                    }
                }
            }
            else
            {
                con = objCon.conectar();
                objCon.operar("delete from sueno where nombre='" + seleccion.Text + "' and id_usuario=" + usuario + " and id_padre=" + seleccion.Tag + "", con);
                objCon.cerrar(con);
                tvSuenos.Nodes.Remove(seleccion);
            }
        }

        //Elimina los hijos de la carpeta padre que sea mandada
        void eliminarHijos(String nombre, double id)
        {
            int num = 0;

            foreach (Recuerdo d in lista_directorios)
            {
                if (d.Padre == id)
                {
                    eliminarHijos(d.Nombre, d.Id);
                    con = objCon.conectar();
                    num = objCon.operar("delete from recuerdo where nombre='" + d.Nombre + "' and id_usuario=" + d.Id_usuario + " and id_padre=" + d.Padre + "", con);
                    objCon.cerrar(con);
                    foreach (Sueno s in lista_archivos)
                    {
                        if (s.Id_recuerdo == d.Id)
                        {
                            con = objCon.conectar();
                            objCon.operar("delete from sueno where nombre='" + s.Nombre + "' and id_recuerdo=" + s.Id_recuerdo + " and id_usuario=" + s.Id_usuario + "", con);
                            objCon.cerrar(con);
                        }
                    }
                }
            }
        }

        //Opcion que permite el cambio de nombre por medio de click derecho en el treenode 
        private void cambiarNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tvSuenos.LabelEdit = true;
            seleccion.BeginEdit();
            antes = seleccion.Text;
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
                        if (tvSuenos.SelectedNode != null && seleccion.SelectedImageIndex == 1)
                        {
                            abrirNota();
                        }
                    }
                }
                else
                {
                    if (tvSuenos.SelectedNode != null && seleccion.SelectedImageIndex == 1)
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

        //metodo generico para abrir un sueño
        void abrirNota()
        {
            SqlDataReader consulta;
            con = objCon.conectar();
            nodoAbierto = tvSuenos.SelectedNode;
            consulta = objCon.consulta("select contenido from sueno where nombre ='" + nodoAbierto.Text + "' and id_usuario=" + usuario + "", con);
            while (consulta.Read())
            {
                txtSueño.Text = consulta["contenido"].ToString();
                textoCuandoAbre = txtSueño.Text;
            }
            objCon.cerrar(con);
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
                objCon.operar("update sueno set contenido='" + nota + "' where nombre='" + nodoAbierto.Text + "' and id_usuario=" + usuario + " and id_recuerdo=" + nodoAbierto.Tag + "", con);
                objCon.cerrar(con);
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
            cambio = objCon.operar("update sueno set pendiente=" + estado + "where nombre='" + nodoAbierto.Text + "' and id_usuario=" + usuario + " and id_recuerdo=" + nodoAbierto.Tag + "", con);
            objCon.cerrar(con);
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

        //Crea un nuevo recuerdo como nodo raiz.
        private void tsmNuevoRecuerdo_Click(object sender, EventArgs e)
        {
            seleccion = tvSuenos.SelectedNode;
            if (seleccion.SelectedImageIndex != 1)
            {
                crearSueñosRecuerdos csr = new crearSueñosRecuerdos("dir", seleccion, usuario);
                csr.Show();
            }
            else
            {
                MessageBox.Show("Lo sentimos un sueño no puede tener recuerdos :c.");
            }
        }

        //SIN TERMINAR (oculta u muestra la ventana de recuerdos con un shortcut (stackoverflow))
        private void ocultarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Minimized)
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
            if (txtSueño.Visible==true)
            {
                salirDeSueno();
            }
            Ingreso objIng = new Ingreso(this);
            desHabilitarComponenes();
            objIng.Show();
            this.Hide();
        }

        //Programacion del boton de salida panel principal
        private void pnPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (textoCuandoAbre != txtSueño.Text)
            {
                var respuesta = MessageBox.Show("¿Desea guardar los cambios hechos antes de cerrar el sueño?", "", MessageBoxButtons.YesNo);
                if (respuesta == DialogResult.Yes)
                {
                    if (ActualizarSueño())
                    {
                        Application.Exit();
                    }
                }
                else if (respuesta == DialogResult.No)
                {
                    Application.Exit();
                }
            }
            else
            {
                Application.Exit();
            }

        }

        //Programacion del boton de saida menu principal
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //seleccion con click izquierdo y derecho el nodo sobre el que este parado el mouse
        private void tvSuenos_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (MouseButtons.Right == e.Button)
            {
                seleccion = tvSuenos.SelectedNode;
                tvSuenos.SelectedNode = e.Node;
            }
            else
            {
                seleccion = tvSuenos.SelectedNode;
                tvSuenos.SelectedNode = e.Node;
            }

        }

        //Despues de que el label del tree node es editado estas son las medidas que se toman
        private void tvSuenos_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            int num = 0;
            double padre = 0;
            if (e.Label != null)
            {
                if (e.Label.Length > 0)
                {
                    if (seleccion.SelectedImageIndex != 1)
                    {
                        padre = Convert.ToDouble(seleccion.Tag.ToString());
                        con = objCon.conectar();
                        if (padre != 0)
                        {
                            num = objCon.operar("update recuerdo set nombre='" + e.Label + "' where nombre='" + seleccion.Text + "' and id_usuario=" + usuario + " and id_padre=" + padre + "", con);
                        }
                        else
                        {
                            num = objCon.operar("update recuerdo set nombre='" + e.Label + "' where nombre='" + seleccion.Text + "' and id_usuario=" + usuario + " and id_padre=0", con);
                        }
                        objCon.cerrar(con);
                        if (num > 0)
                        {
                            seleccion.EndEdit(false);
                            tvSuenos.LabelEdit = false;
                        }
                        else
                        {
                            seleccion.EndEdit(true);
                            tvSuenos.LabelEdit = false;
                        }
                    }
                    else
                    {
                        padre = Convert.ToDouble(seleccion.Tag.ToString());
                        con = objCon.conectar();
                        num = objCon.operar("update sueno set nombre='" + e.Label + "' where nombre='" + seleccion.Text + "' and id_usuario=" + usuario + " and id_recuerdo=" + padre + "", con);
                        objCon.cerrar(con);
                        if (num > 0)
                        {
                            seleccion.EndEdit(false);
                            tvSuenos.LabelEdit = false;
                        }
                        else
                        {
                            seleccion.EndEdit(true);
                            tvSuenos.LabelEdit = false;
                        }
                    }
                    e.Node.EndEdit(false);
                }
            }
        }

        //deshace lo hecho a el ultimo estado del texto
        private void deshacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //txtNota.Text=(String)Clipboard.GetData(DataFormats.Text);
            txtSueño.Undo();
        }

        //va un paso adelante del estado del texto
        private void rehacerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSueño.Redo();
        }

        //Cambio de icono de carpeta  en caso de que sea de trabajo 
        private void trabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarIcono(4);
        }

        //Cambio de icono de carpeta  en caso de que sea de estudio
        private void estudioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cambiarIcono(2);
        }

        //Cambio de icono de carpeta  en caso de que sea de algo personal
        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarIcono(3);
        }

        //Cambio de icono de carpeta  en caso de que quiera un folder o carpeta
        private void capetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cambiarIcono(0);
        }

        //cambia el icono de las carpetas al que seleccione el usuario
        void cambiarIcono(int index)
        {
            if (seleccion.SelectedImageIndex != 1)
            {
                con = objCon.conectar();
                int num = objCon.operar("update recuerdo set tipo=" + index + " where nombre='" + seleccion.Text + "' and id_usuario=" + usuario + " and id_padre=" + seleccion.Tag.ToString() + "", con);
                objCon.cerrar(con);
                if (num > 0)
                {
                    seleccion.ImageIndex = index;
                    seleccion.SelectedImageIndex = index;
                }
                else
                {
                    MessageBox.Show("Lo sentimos hubo un error al cambiar el tipo, lo arreglaremos lo mas pronto posible (;´༎ຶД༎ຶ`)");
                }
            }
        }

        //Selecciona todo los que este en el sueño que esta abierto
        private void seleccionartodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSueño.SelectAll();
        }

        //Herramienta de menu para el cambio de fuente
        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() != DialogResult.Cancel)
            {
                txtSueño.Font = fd.Font;
                Settings.Default["Fuente"] = txtSueño.Font;
                Settings.Default.Save();
            }
        }

        //Load de la interfaz
        private void pnPrincipal_Load(object sender, EventArgs e)
        {
            //Carga lo que tiene que ver con la fuente
            txtSueño.Font = (Font)Settings.Default["Fuente"];
            txtSueño.ForeColor = (Color)Settings.Default["Color"];
            cmbFuentes.DataSource = installedFonts.Families;
            cmbFuentes.DisplayMember = "Name";
            //selecciona la fuente que fue seleccinada
            int indexFuente= cmbFuentes.FindString(txtSueño.Font.Name);
            cmbFuentes.SelectedIndex = indexFuente;
            //Selecciona el color que estaba seleccionado
            int IndexColor = cmbColor.FindString(txtSueño.ForeColor.Name);
            cmbColor.SelectedIndex = IndexColor;
            //seleccionamos el tamaño de la fuente
            txtSueño.Font = new Font(txtSueño.Font.Name,(Int32)Settings.Default["Tamano"]);
            int indexTamano=cmbTamano.FindString(Settings.Default["Tamano"].ToString());
            cmbTamano.SelectedIndex = indexTamano;
            //Carga la ultima alineacion
            txtSueño.SelectionAlignment = (HorizontalAlignment)Settings.Default["Alineacion"];
        }

        //Funcion draw para las fuentas
        private void cmbFuentes_DrawItem(object sender, DrawItemEventArgs e)
        {
            FontFamily family = installedFonts.Families[e.Index];
            FontStyle style = FontStyle.Regular;
            if (!family.IsStyleAvailable(style))
                style = FontStyle.Bold;
            if (!family.IsStyleAvailable(style))
                style = FontStyle.Italic;
            Font fnt = new Font(family,10, style);            
            Brush brush;
            if (e.State == DrawItemState.Selected)
            {
                brush = new SolidBrush(Color.White);
            }
            else
            {
                brush = new SolidBrush(cmbFuentes.ForeColor);
            }
            e.DrawBackground();
            e.Graphics.DrawString(family.GetName(0),fnt, brush, e.Bounds.Location);
            fnt = new Font(family, txtSueño.Font.Size, style);
            txtSueño.Font = fnt;
            Settings.Default["Fuente"] = fnt;
            Settings.Default.Save();
        }

        //Funcion draw para los colores de fuente
        private void cmbColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                if (cmbColor == null) return;
                if (e.Index < 0) return;
                if (!(cmbColor.Items[e.Index] is Color)) return;
                Color color = (Color)cmbColor.Items[e.Index];
                // Dibujamos el fondo
                e.DrawBackground();
                // Creamos los objetos GDI+
                Brush brush = new SolidBrush(color);
                Pen forePen = new Pen(e.ForeColor);
                Brush foreBrush = new SolidBrush(e.ForeColor);
                // Dibujamos el borde del rectángulo
                e.Graphics.DrawRectangle(forePen,new Rectangle(e.Bounds.Left + 2, e.Bounds.Top + 2, 19,e.Bounds.Size.Height - 4));
                // Rellenamos el rectángulo con el Color seleccionado
                // en la combo
                e.Graphics.FillRectangle(brush,new Rectangle(e.Bounds.Left + 3, e.Bounds.Top + 3, 18,e.Bounds.Size.Height - 5));
                // Dibujamos el nombre del color
                e.Graphics.DrawString(color.Name, cmbColor.Font,foreBrush, e.Bounds.Left + 25, e.Bounds.Top + 2);
                e.DrawFocusRectangle();
                txtSueño.ForeColor = color;
                Settings.Default["Color"] = color;
                Settings.Default.Save();
                // Eliminamos objetos GDI+
                brush.Dispose();
                forePen.Dispose();
                foreBrush.Dispose();
            }
            catch (Exception)
            {
                //MessageBox.Show("catch de drawcolor "+e.ToString());
                throw;
            }
        }

        //Funcion para cambiar el tamaño de la fuente con evento de combobox
        private void cmbTamano_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default["Tamano"] = Convert.ToInt32(cmbTamano.SelectedItem.ToString());
            txtSueño.Font = new Font(txtSueño.Font.Name, (Int32)Settings.Default["Tamano"]);
            int indexTamano = cmbTamano.FindString(Settings.Default["Tamano"].ToString());
            cmbTamano.SelectedIndex = indexTamano;
        }

        //Evento click boton alineacion centrada
        private void cmbCentrar_Click(object sender, EventArgs e)
        {
            alinearTexto(HorizontalAlignment.Center);
        }

        //Evento clck de boton alineacion a la izquierda
        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            alinearTexto(HorizontalAlignment.Left);
        }
        //Evento clck de boton alineacion a la derecha
        private void btnDerecha_Click(object sender, EventArgs e)
        {
            alinearTexto(HorizontalAlignment.Right);
        }

        //Evento clck de boton alineacion justificada (SIN DESARROLLAR)
        private void btnJustificar_Click(object sender, EventArgs e)
        {

        }

        //Funcion que elinea el texto segun su parametro de alineacion horizontal
        void alinearTexto(HorizontalAlignment h)
        {
            txtSueño.SelectionAlignment = h;
            Settings.Default["Alineacion"] = h;
        }

        //crea un nuevo recuerdo raiz<
        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                con = objCon.conectar();
                objCon.operar("insert into recuerdo values(" + usuario + ",0,'Nuevo recuerdo',0);", con);
                objCon.cerrar(con);
                tvSuenos.LabelEdit = true;
                seleccion = tvSuenos.Nodes.Add("Nuevo recuerdo", "Nuevo recuerdo", 0, 0);
                seleccion.Tag = 0;
                tvSuenos.Focus();
                seleccion.BeginEdit();
                antes = seleccion.Text;
            }
            catch (Exception ex)
            {
                con = objCon.conectar();
                objCon.operar("delete from recuerdo where nombre ='Nuevo recuerdo' and id_usuario=" + usuario + "", con);
                objCon.cerrar(con);
                tvSuenos.Nodes.Remove(seleccion);
                MessageBox.Show("Lo sentimos ah ocurrido un error al crear el recuerdo intentelo mas tarde.");
                //MessageBox.Show(ex.ToString());
            }
        }

        //public void crearSuenoRaiz(String nombre)
        //{
        //    tvSuenos.Nodes.Add(new TreeNode
        //    {
        //        Text = nombre,
        //        Tag = "arch",
        //        ImageIndex = 1,
        //        SelectedImageIndex = 1,
        //        BackColor = Color.White
        //    });

        //}
        //public pnPrincipal()
        //{
        //    InitializeComponent();
        //    txtSueño.Hide();
        //    this.Focus();
        //    InicializarTree();
        //}
    }
}