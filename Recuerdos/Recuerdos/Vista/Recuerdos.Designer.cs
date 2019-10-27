namespace Recuerdos
{
    partial class pnPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pnPrincipal));
            this.tvSuenos = new System.Windows.Forms.TreeView();
            this.cmsTreeView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmNuevoRecuerdo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNuevoSueño = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOcultarRecuerdos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCambiarNombre = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoヾーノToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trabajoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgArchivos = new System.Windows.Forms.ImageList(this.components);
            this.mainSlipContainer = new System.Windows.Forms.SplitContainer();
            this.txtSueño = new System.Windows.Forms.RichTextBox();
            this.csmTextBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCortar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPegar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmLimpiarSueño = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCerrarSueño = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDeshacer = new System.Windows.Forms.ToolStripMenuItem();
            this.pbWrapper = new System.Windows.Forms.PictureBox();
            this.ofdNota = new System.Windows.Forms.OpenFileDialog();
            this.sfdNota = new System.Windows.Forms.SaveFileDialog();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnSinAcabar = new System.Windows.Forms.Button();
            this.mnPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarcomoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vistapreviadeimpresiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deshacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rehacerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cortarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.seleccionartodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contenidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.índiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.acercadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTreeView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSlipContainer)).BeginInit();
            this.mainSlipContainer.Panel1.SuspendLayout();
            this.mainSlipContainer.Panel2.SuspendLayout();
            this.mainSlipContainer.SuspendLayout();
            this.csmTextBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWrapper)).BeginInit();
            this.pnMenu.SuspendLayout();
            this.mnPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvSuenos
            // 
            this.tvSuenos.BackColor = System.Drawing.Color.White;
            this.tvSuenos.ContextMenuStrip = this.cmsTreeView;
            this.tvSuenos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvSuenos.ImageIndex = 0;
            this.tvSuenos.ImageList = this.imgArchivos;
            this.tvSuenos.Indent = 10;
            this.tvSuenos.ItemHeight = 20;
            this.tvSuenos.LineColor = System.Drawing.Color.White;
            this.tvSuenos.Location = new System.Drawing.Point(0, 0);
            this.tvSuenos.Name = "tvSuenos";
            this.tvSuenos.SelectedImageIndex = 0;
            this.tvSuenos.Size = new System.Drawing.Size(261, 578);
            this.tvSuenos.TabIndex = 0;
            this.tvSuenos.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.tvSuenos_AfterLabelEdit);
            this.tvSuenos.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.tvSuenos_NodeMouseHover);
            this.tvSuenos.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvSuenos_NodeMouseClick);
            this.tvSuenos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tvSuenos_MouseDoubleClick);
            // 
            // cmsTreeView
            // 
            this.cmsTreeView.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNuevoRecuerdo,
            this.tsmNuevoSueño,
            this.tsmOcultarRecuerdos,
            this.tsmCambiarNombre,
            this.tsmEliminar,
            this.tipoヾーノToolStripMenuItem});
            this.cmsTreeView.Name = "cmsTreeView";
            this.cmsTreeView.Size = new System.Drawing.Size(261, 148);
            // 
            // tsmNuevoRecuerdo
            // 
            this.tsmNuevoRecuerdo.Name = "tsmNuevoRecuerdo";
            this.tsmNuevoRecuerdo.Size = new System.Drawing.Size(260, 24);
            this.tsmNuevoRecuerdo.Text = "Nuevo recuerdo (❤ ω ❤)";
            this.tsmNuevoRecuerdo.Click += new System.EventHandler(this.tsmNuevoRecuerdo_Click);
            // 
            // tsmNuevoSueño
            // 
            this.tsmNuevoSueño.Name = "tsmNuevoSueño";
            this.tsmNuevoSueño.Size = new System.Drawing.Size(260, 24);
            this.tsmNuevoSueño.Text = "Nueva sueño   ✪ ω ✪";
            this.tsmNuevoSueño.Click += new System.EventHandler(this.nuevaCarpetaToolStripMenuItem_Click);
            // 
            // tsmOcultarRecuerdos
            // 
            this.tsmOcultarRecuerdos.Name = "tsmOcultarRecuerdos";
            this.tsmOcultarRecuerdos.Size = new System.Drawing.Size(260, 24);
            this.tsmOcultarRecuerdos.Text = "Ocultar sueños   (っ °Д °;)っ";
            this.tsmOcultarRecuerdos.Click += new System.EventHandler(this.ocultarSueñosToolStripMenuItem_Click);
            // 
            // tsmCambiarNombre
            // 
            this.tsmCambiarNombre.Name = "tsmCambiarNombre";
            this.tsmCambiarNombre.Size = new System.Drawing.Size(260, 24);
            this.tsmCambiarNombre.Text = "Cambiar nombre  (⊙_⊙;)";
            this.tsmCambiarNombre.Click += new System.EventHandler(this.cambiarNombreToolStripMenuItem_Click);
            // 
            // tsmEliminar
            // 
            this.tsmEliminar.Name = "tsmEliminar";
            this.tsmEliminar.Size = new System.Drawing.Size(260, 24);
            this.tsmEliminar.Text = "Eliminar   X﹏X";
            this.tsmEliminar.Click += new System.EventHandler(this.eliminarcToolStripMenuItem_Click);
            // 
            // tipoヾーノToolStripMenuItem
            // 
            this.tipoヾーノToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trabajoToolStripMenuItem,
            this.estudioToolStripMenuItem1,
            this.personalToolStripMenuItem});
            this.tipoヾーノToolStripMenuItem.Name = "tipoヾーノToolStripMenuItem";
            this.tipoヾーノToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.tipoヾーノToolStripMenuItem.Text = "Tipo ヾ(＠⌒ー⌒＠)ノ";
            // 
            // trabajoToolStripMenuItem
            // 
            this.trabajoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("trabajoToolStripMenuItem.Image")));
            this.trabajoToolStripMenuItem.Name = "trabajoToolStripMenuItem";
            this.trabajoToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.trabajoToolStripMenuItem.Text = "Trabajo";
            // 
            // estudioToolStripMenuItem1
            // 
            this.estudioToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("estudioToolStripMenuItem1.Image")));
            this.estudioToolStripMenuItem1.Name = "estudioToolStripMenuItem1";
            this.estudioToolStripMenuItem1.Size = new System.Drawing.Size(139, 26);
            this.estudioToolStripMenuItem1.Text = "Estudio";
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("personalToolStripMenuItem.Image")));
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.personalToolStripMenuItem.Text = "Personal";
            // 
            // imgArchivos
            // 
            this.imgArchivos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgArchivos.ImageStream")));
            this.imgArchivos.TransparentColor = System.Drawing.Color.Transparent;
            this.imgArchivos.Images.SetKeyName(0, "carpeta.png");
            this.imgArchivos.Images.SetKeyName(1, "documento.png");
            this.imgArchivos.Images.SetKeyName(2, "biblioteca.png");
            this.imgArchivos.Images.SetKeyName(3, "pensar.png");
            this.imgArchivos.Images.SetKeyName(4, "empleado.png");
            // 
            // mainSlipContainer
            // 
            this.mainSlipContainer.BackColor = System.Drawing.Color.SteelBlue;
            this.mainSlipContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mainSlipContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSlipContainer.ForeColor = System.Drawing.Color.SteelBlue;
            this.mainSlipContainer.Location = new System.Drawing.Point(0, 48);
            this.mainSlipContainer.Name = "mainSlipContainer";
            // 
            // mainSlipContainer.Panel1
            // 
            this.mainSlipContainer.Panel1.Controls.Add(this.tvSuenos);
            this.mainSlipContainer.Panel1MinSize = 5;
            // 
            // mainSlipContainer.Panel2
            // 
            this.mainSlipContainer.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mainSlipContainer.Panel2.Controls.Add(this.txtSueño);
            this.mainSlipContainer.Panel2.Controls.Add(this.pbWrapper);
            this.mainSlipContainer.Panel2MinSize = 100;
            this.mainSlipContainer.Size = new System.Drawing.Size(1171, 582);
            this.mainSlipContainer.SplitterDistance = 265;
            this.mainSlipContainer.SplitterWidth = 5;
            this.mainSlipContainer.TabIndex = 1;
            this.mainSlipContainer.MouseHover += new System.EventHandler(this.mainSlipContainer_MouseHover);
            // 
            // txtSueño
            // 
            this.txtSueño.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtSueño.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSueño.ContextMenuStrip = this.csmTextBox;
            this.txtSueño.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSueño.Location = new System.Drawing.Point(0, 0);
            this.txtSueño.Name = "txtSueño";
            this.txtSueño.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtSueño.Size = new System.Drawing.Size(897, 578);
            this.txtSueño.TabIndex = 6;
            this.txtSueño.Text = "";
            // 
            // csmTextBox
            // 
            this.csmTextBox.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.csmTextBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCopiar,
            this.tsmCortar,
            this.tsmPegar,
            this.tsmGuardar,
            this.tsmLimpiarSueño,
            this.tsmCerrarSueño,
            this.tsmDeshacer});
            this.csmTextBox.Name = "csmTextBox";
            this.csmTextBox.Size = new System.Drawing.Size(195, 186);
            // 
            // tsmCopiar
            // 
            this.tsmCopiar.Image = ((System.Drawing.Image)(resources.GetObject("tsmCopiar.Image")));
            this.tsmCopiar.Name = "tsmCopiar";
            this.tsmCopiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.tsmCopiar.Size = new System.Drawing.Size(194, 26);
            this.tsmCopiar.Text = "Copiar";
            this.tsmCopiar.Click += new System.EventHandler(this.copiarToolStripMenuItem1_Click);
            // 
            // tsmCortar
            // 
            this.tsmCortar.Image = ((System.Drawing.Image)(resources.GetObject("tsmCortar.Image")));
            this.tsmCortar.Name = "tsmCortar";
            this.tsmCortar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.tsmCortar.Size = new System.Drawing.Size(194, 26);
            this.tsmCortar.Text = "Cortar";
            this.tsmCortar.Click += new System.EventHandler(this.cortarToolStripMenuItem1_Click);
            // 
            // tsmPegar
            // 
            this.tsmPegar.Image = ((System.Drawing.Image)(resources.GetObject("tsmPegar.Image")));
            this.tsmPegar.Name = "tsmPegar";
            this.tsmPegar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.tsmPegar.Size = new System.Drawing.Size(194, 26);
            this.tsmPegar.Text = "Pegar";
            this.tsmPegar.Click += new System.EventHandler(this.pegarToolStripMenuItem1_Click);
            // 
            // tsmGuardar
            // 
            this.tsmGuardar.Image = ((System.Drawing.Image)(resources.GetObject("tsmGuardar.Image")));
            this.tsmGuardar.Name = "tsmGuardar";
            this.tsmGuardar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmGuardar.Size = new System.Drawing.Size(194, 26);
            this.tsmGuardar.Text = "Guardar";
            this.tsmGuardar.Click += new System.EventHandler(this.guardarToolStripMenuItem1_Click);
            // 
            // tsmLimpiarSueño
            // 
            this.tsmLimpiarSueño.Name = "tsmLimpiarSueño";
            this.tsmLimpiarSueño.Size = new System.Drawing.Size(194, 26);
            this.tsmLimpiarSueño.Text = "Limpiar sueño";
            this.tsmLimpiarSueño.Click += new System.EventHandler(this.limpiarSueñoToolStripMenuItem_Click);
            // 
            // tsmCerrarSueño
            // 
            this.tsmCerrarSueño.Image = ((System.Drawing.Image)(resources.GetObject("tsmCerrarSueño.Image")));
            this.tsmCerrarSueño.Name = "tsmCerrarSueño";
            this.tsmCerrarSueño.Size = new System.Drawing.Size(194, 26);
            this.tsmCerrarSueño.Text = "Cerrar sueño";
            this.tsmCerrarSueño.Click += new System.EventHandler(this.cerrarSueñoToolStripMenuItem_Click);
            // 
            // tsmDeshacer
            // 
            this.tsmDeshacer.Name = "tsmDeshacer";
            this.tsmDeshacer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.tsmDeshacer.Size = new System.Drawing.Size(194, 26);
            this.tsmDeshacer.Text = "Deshacer";
            this.tsmDeshacer.Visible = false;
            this.tsmDeshacer.Click += new System.EventHandler(this.deshacerToolStripMenuItem1_Click);
            // 
            // pbWrapper
            // 
            this.pbWrapper.BackColor = System.Drawing.SystemColors.Window;
            this.pbWrapper.Image = ((System.Drawing.Image)(resources.GetObject("pbWrapper.Image")));
            this.pbWrapper.Location = new System.Drawing.Point(3, 268);
            this.pbWrapper.Name = "pbWrapper";
            this.pbWrapper.Size = new System.Drawing.Size(34, 31);
            this.pbWrapper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWrapper.TabIndex = 5;
            this.pbWrapper.TabStop = false;
            this.pbWrapper.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ofdNota
            // 
            this.ofdNota.FileName = "Escriba un nombre";
            this.ofdNota.Filter = "Rich Text(*.rtf)|*.rtf";
            // 
            // sfdNota
            // 
            this.sfdNota.FileName = "Nombre.rtf";
            this.sfdNota.Filter = "Rich Text(*.rtf)|*.rtf";
            // 
            // pnMenu
            // 
            this.pnMenu.Controls.Add(this.btnSinAcabar);
            this.pnMenu.Controls.Add(this.mnPrincipal);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(1171, 48);
            this.pnMenu.TabIndex = 2;
            // 
            // btnSinAcabar
            // 
            this.btnSinAcabar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinAcabar.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinAcabar.Location = new System.Drawing.Point(1031, 3);
            this.btnSinAcabar.Name = "btnSinAcabar";
            this.btnSinAcabar.Size = new System.Drawing.Size(128, 39);
            this.btnSinAcabar.TabIndex = 7;
            this.btnSinAcabar.Tag = "";
            this.btnSinAcabar.Text = "No terminado";
            this.btnSinAcabar.UseVisualStyleBackColor = true;
            this.btnSinAcabar.Visible = false;
            this.btnSinAcabar.Click += new System.EventHandler(this.btnSinAcabar_Click);
            // 
            // mnPrincipal
            // 
            this.mnPrincipal.BackColor = System.Drawing.Color.SteelBlue;
            this.mnPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mnPrincipal.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.mnPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnPrincipal.Name = "mnPrincipal";
            this.mnPrincipal.Size = new System.Drawing.Size(1171, 48);
            this.mnPrincipal.TabIndex = 6;
            this.mnPrincipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.toolStripSeparator,
            this.guardarToolStripMenuItem,
            this.guardarcomoToolStripMenuItem,
            this.toolStripSeparator1,
            this.imprimirToolStripMenuItem,
            this.vistapreviadeimpresiónToolStripMenuItem,
            this.toolStripSeparator2,
            this.cerrarSesionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(81, 44);
            this.archivoToolStripMenuItem.Text = "&Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nuevoToolStripMenuItem.Image")));
            this.nuevoToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.nuevoToolStripMenuItem.Text = "&Nuevo recuerdo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(279, 6);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Enabled = false;
            this.guardarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("guardarToolStripMenuItem.Image")));
            this.guardarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.guardarToolStripMenuItem.Text = "&Guardar";
            this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
            // 
            // guardarcomoToolStripMenuItem
            // 
            this.guardarcomoToolStripMenuItem.Enabled = false;
            this.guardarcomoToolStripMenuItem.Name = "guardarcomoToolStripMenuItem";
            this.guardarcomoToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.guardarcomoToolStripMenuItem.Text = "G&uardar como";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(279, 6);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Enabled = false;
            this.imprimirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("imprimirToolStripMenuItem.Image")));
            this.imprimirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.imprimirToolStripMenuItem.Text = "&Imprimir";
            // 
            // vistapreviadeimpresiónToolStripMenuItem
            // 
            this.vistapreviadeimpresiónToolStripMenuItem.Enabled = false;
            this.vistapreviadeimpresiónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vistapreviadeimpresiónToolStripMenuItem.Image")));
            this.vistapreviadeimpresiónToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.vistapreviadeimpresiónToolStripMenuItem.Name = "vistapreviadeimpresiónToolStripMenuItem";
            this.vistapreviadeimpresiónToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.vistapreviadeimpresiónToolStripMenuItem.Text = "&Vista previa de impresión";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(279, 6);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.salirToolStripMenuItem.Text = "&Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deshacerToolStripMenuItem,
            this.rehacerToolStripMenuItem,
            this.toolStripSeparator3,
            this.cortarToolStripMenuItem,
            this.copiarToolStripMenuItem,
            this.pegarToolStripMenuItem,
            this.toolStripSeparator4,
            this.seleccionartodoToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(68, 44);
            this.editarToolStripMenuItem.Text = "&Editar";
            // 
            // deshacerToolStripMenuItem
            // 
            this.deshacerToolStripMenuItem.Name = "deshacerToolStripMenuItem";
            this.deshacerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.deshacerToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.deshacerToolStripMenuItem.Text = "&Deshacer";
            this.deshacerToolStripMenuItem.Click += new System.EventHandler(this.deshacerToolStripMenuItem_Click);
            // 
            // rehacerToolStripMenuItem
            // 
            this.rehacerToolStripMenuItem.Name = "rehacerToolStripMenuItem";
            this.rehacerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.rehacerToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.rehacerToolStripMenuItem.Text = "&Rehacer";
            this.rehacerToolStripMenuItem.Click += new System.EventHandler(this.rehacerToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(213, 6);
            // 
            // cortarToolStripMenuItem
            // 
            this.cortarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cortarToolStripMenuItem.Image")));
            this.cortarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cortarToolStripMenuItem.Name = "cortarToolStripMenuItem";
            this.cortarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cortarToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.cortarToolStripMenuItem.Text = "Cor&tar";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripMenuItem.Image")));
            this.copiarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.copiarToolStripMenuItem.Text = "&Copiar";
            // 
            // pegarToolStripMenuItem
            // 
            this.pegarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pegarToolStripMenuItem.Image")));
            this.pegarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pegarToolStripMenuItem.Name = "pegarToolStripMenuItem";
            this.pegarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pegarToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.pegarToolStripMenuItem.Text = "&Pegar";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(213, 6);
            // 
            // seleccionartodoToolStripMenuItem
            // 
            this.seleccionartodoToolStripMenuItem.Name = "seleccionartodoToolStripMenuItem";
            this.seleccionartodoToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.seleccionartodoToolStripMenuItem.Text = "&Seleccionar todo";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalizarToolStripMenuItem,
            this.opcionesToolStripMenuItem,
            this.ocultarToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(126, 44);
            this.herramientasToolStripMenuItem.Text = "&Herramientas";
            // 
            // personalizarToolStripMenuItem
            // 
            this.personalizarToolStripMenuItem.Name = "personalizarToolStripMenuItem";
            this.personalizarToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.personalizarToolStripMenuItem.Text = "&Personalizar";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.opcionesToolStripMenuItem.Text = "&Opciones";
            // 
            // ocultarToolStripMenuItem
            // 
            this.ocultarToolStripMenuItem.Name = "ocultarToolStripMenuItem";
            this.ocultarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.ocultarToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.ocultarToolStripMenuItem.Text = "Ocultar/Mostrar";
            this.ocultarToolStripMenuItem.Click += new System.EventHandler(this.ocultarToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contenidoToolStripMenuItem,
            this.índiceToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.toolStripSeparator5,
            this.acercadeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(69, 44);
            this.ayudaToolStripMenuItem.Text = "Ay&uda";
            // 
            // contenidoToolStripMenuItem
            // 
            this.contenidoToolStripMenuItem.Name = "contenidoToolStripMenuItem";
            this.contenidoToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.contenidoToolStripMenuItem.Text = "&Contenido";
            // 
            // índiceToolStripMenuItem
            // 
            this.índiceToolStripMenuItem.Name = "índiceToolStripMenuItem";
            this.índiceToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.índiceToolStripMenuItem.Text = "Índic&e";
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.buscarToolStripMenuItem.Text = "&Buscar";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(174, 6);
            // 
            // acercadeToolStripMenuItem
            // 
            this.acercadeToolStripMenuItem.Name = "acercadeToolStripMenuItem";
            this.acercadeToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.acercadeToolStripMenuItem.Text = "&Acerca de...";
            // 
            // pnPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1171, 630);
            this.Controls.Add(this.mainSlipContainer);
            this.Controls.Add(this.pnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "pnPrincipal";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recuerdos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.pnPrincipal_FormClosing);
            this.cmsTreeView.ResumeLayout(false);
            this.mainSlipContainer.Panel1.ResumeLayout(false);
            this.mainSlipContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSlipContainer)).EndInit();
            this.mainSlipContainer.ResumeLayout(false);
            this.csmTextBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbWrapper)).EndInit();
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            this.mnPrincipal.ResumeLayout(false);
            this.mnPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imgArchivos;
        private System.Windows.Forms.SplitContainer mainSlipContainer;
        private System.Windows.Forms.OpenFileDialog ofdNota;
        private System.Windows.Forms.SaveFileDialog sfdNota;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.MenuStrip mnPrincipal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarcomoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vistapreviadeimpresiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deshacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rehacerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem seleccionartodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contenidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem índiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem acercadeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbWrapper;
        private System.Windows.Forms.Button btnSinAcabar;
        private System.Windows.Forms.ContextMenuStrip cmsTreeView;
        private System.Windows.Forms.ToolStripMenuItem tsmNuevoSueño;
        private System.Windows.Forms.ToolStripMenuItem tsmNuevoRecuerdo;
        private System.Windows.Forms.ToolStripMenuItem tsmOcultarRecuerdos;
        private System.Windows.Forms.ToolStripMenuItem tsmCambiarNombre;
        private System.Windows.Forms.ToolStripMenuItem tsmEliminar;
        public System.Windows.Forms.TreeView tvSuenos;
        private System.Windows.Forms.ContextMenuStrip csmTextBox;
        private System.Windows.Forms.ToolStripMenuItem tsmCopiar;
        private System.Windows.Forms.ToolStripMenuItem tsmCortar;
        private System.Windows.Forms.ToolStripMenuItem tsmPegar;
        private System.Windows.Forms.ToolStripMenuItem tsmGuardar;
        private System.Windows.Forms.ToolStripMenuItem tsmLimpiarSueño;
        private System.Windows.Forms.ToolStripMenuItem tsmCerrarSueño;
        private System.Windows.Forms.ToolStripMenuItem tsmDeshacer;
        private System.Windows.Forms.ToolStripMenuItem ocultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private System.Windows.Forms.RichTextBox txtSueño;
        private System.Windows.Forms.ToolStripMenuItem tipoヾーノToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trabajoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
    }
}

