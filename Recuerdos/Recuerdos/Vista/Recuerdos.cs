using Recuerdos.Modelo;
using Recuerdos.Utilidades;
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
        public static ArrayList lista_directorios = new ArrayList();
        public static ArrayList lista_archivos = new ArrayList();
        public static Conexion objCon = new Conexion();
        private static SqlConnection con = null;
        
        //CONSTRUCTOR
        public pnPrincipal()
        {            
            InitializeComponent();
            txtNota.Hide();
            this.Focus();
            InicializarTree();
        }

        //llena el tree view
        Boolean InicializarTree()
        {
            //Instancias del metodo
            TreeNode nodo=null;
            try
            {
                con = objCon.conectar();
                lista_directorios = objCon.consultaDir("select * from  directorio", con);
                objCon.cerrar(con);
                con = objCon.conectar();
                lista_archivos = objCon.consultaArch("select * from  archivo", con);
                if (lista_directorios!=null)
                {
                    if (lista_directorios.Count > 0)
                    {
                        foreach (Directorio d in lista_directorios)
                        {                                            
                            if (d.Padre==0)
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
                                            nodo.Nodes.Add(new TreeNode
                                            {
                                                Text = a.Nombre,
                                                Tag = "arch",
                                                ImageIndex = 1,
                                                SelectedImageIndex = 1,
                                            });
                                        }
                                    }
                                }
                                cargarHijos(nodo, d.Id, lista_directorios, lista_archivos);
                            }                            
                            tvSuenos.ExpandAll();
                            objCon.cerrar(con);
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
                MessageBox.Show("Entro al catch \n "+e.ToString());               
            }
            return true;
        }

        //nodo necesario para cargar tree view
        TreeNode node2 = null;

        //carga hijos del treeview
        public void cargarHijos(TreeNode node,double id, ArrayList alDir,ArrayList alArch)
        {
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
                                node2.Nodes.Add(new TreeNode
                                {
                                    Text = a.Nombre,
                                    Tag = "arch",
                                    ImageIndex = 1,
                                    SelectedImageIndex = 1,
                                });
                            }
                        }
                    }
                    cargarHijos(node2, d.Id,alDir,alArch);                    
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
            txtNota.Visible = true;
        }

        //booleano para manejar el movimiento del sliptterPanel
        Boolean esconder = true;

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
            seleccion=tvSuenos.SelectedNode;
            crearSueñosRecuerdos csr = new crearSueñosRecuerdos("sueño",seleccion);
            csr.Show();
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
                SqlDataReader consulta;
                if (tvSuenos.SelectedNode != null && tvSuenos.SelectedNode.Tag.ToString() == "arch")
                {
                    con = objCon.conectar();
                    consulta = objCon.consulta("select contenido from archivo where nombre ='" + tvSuenos.SelectedNode.Text + "'", con);
                    while (consulta.Read())
                    {
                        txtNota.Text = consulta["contenido"].ToString();
                        habilitarComponentes();
                        objCon.cerrar(con);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lo sentimos, algo salio mal al abrir este archivo...\n"+ex.ToString());
            }
        }
    }
}