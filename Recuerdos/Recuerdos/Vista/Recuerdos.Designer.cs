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
            this.nuevaCarpetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoRecuerdoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocultarSueñosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imgArchivos = new System.Windows.Forms.ImageList(this.components);
            this.mainSlipContainer = new System.Windows.Forms.SplitContainer();
            this.pbWrapper = new System.Windows.Forms.PictureBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.csmTextBox = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copiarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cortarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarSueñoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSueñoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdNota = new System.Windows.Forms.OpenFileDialog();
            this.sfdNota = new System.Windows.Forms.SaveFileDialog();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnSinAcabar = new System.Windows.Forms.Button();
            this.mnPrincipal = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarcomoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vistapreviadeimpresiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
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
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contenidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.índiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.acercadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deshacerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTreeView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSlipContainer)).BeginInit();
            this.mainSlipContainer.Panel1.SuspendLayout();
            this.mainSlipContainer.Panel2.SuspendLayout();
            this.mainSlipContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbWrapper)).BeginInit();
            this.csmTextBox.SuspendLayout();
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
            this.tvSuenos.LabelEdit = true;
            this.tvSuenos.LineColor = System.Drawing.Color.White;
            this.tvSuenos.Location = new System.Drawing.Point(0, 0);
            this.tvSuenos.Name = "tvSuenos";
            this.tvSuenos.SelectedImageIndex = 0;
            this.tvSuenos.Size = new System.Drawing.Size(261, 578);
            this.tvSuenos.TabIndex = 0;
            this.tvSuenos.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.tvSuenos_NodeMouseHover);
            this.tvSuenos.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tvSuenos_MouseDoubleClick);
            // 
            // cmsTreeView
            // 
            this.cmsTreeView.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaCarpetaToolStripMenuItem,
            this.nuevoRecuerdoToolStripMenuItem,
            this.ocultarSueñosToolStripMenuItem,
            this.cambiarNombreToolStripMenuItem,
            this.eliminarcToolStripMenuItem});
            this.cmsTreeView.Name = "cmsTreeView";
            this.cmsTreeView.Size = new System.Drawing.Size(261, 124);
            // 
            // nuevaCarpetaToolStripMenuItem
            // 
            this.nuevaCarpetaToolStripMenuItem.Name = "nuevaCarpetaToolStripMenuItem";
            this.nuevaCarpetaToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.nuevaCarpetaToolStripMenuItem.Text = "Nueva sueño";
            this.nuevaCarpetaToolStripMenuItem.Click += new System.EventHandler(this.nuevaCarpetaToolStripMenuItem_Click);
            // 
            // nuevoRecuerdoToolStripMenuItem
            // 
            this.nuevoRecuerdoToolStripMenuItem.Name = "nuevoRecuerdoToolStripMenuItem";
            this.nuevoRecuerdoToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.nuevoRecuerdoToolStripMenuItem.Text = "Nuevo recuerdo (❤ ω ❤)";
            // 
            // ocultarSueñosToolStripMenuItem
            // 
            this.ocultarSueñosToolStripMenuItem.Name = "ocultarSueñosToolStripMenuItem";
            this.ocultarSueñosToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.ocultarSueñosToolStripMenuItem.Text = "Ocultar sueños";
            this.ocultarSueñosToolStripMenuItem.Click += new System.EventHandler(this.ocultarSueñosToolStripMenuItem_Click);
            // 
            // cambiarNombreToolStripMenuItem
            // 
            this.cambiarNombreToolStripMenuItem.Name = "cambiarNombreToolStripMenuItem";
            this.cambiarNombreToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.cambiarNombreToolStripMenuItem.Text = "Cambiar nombre";
            this.cambiarNombreToolStripMenuItem.Click += new System.EventHandler(this.cambiarNombreToolStripMenuItem_Click);
            // 
            // eliminarcToolStripMenuItem
            // 
            this.eliminarcToolStripMenuItem.Name = "eliminarcToolStripMenuItem";
            this.eliminarcToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.eliminarcToolStripMenuItem.Text = "Eliminar :c";
            this.eliminarcToolStripMenuItem.Click += new System.EventHandler(this.eliminarcToolStripMenuItem_Click);
            // 
            // imgArchivos
            // 
            this.imgArchivos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgArchivos.ImageStream")));
            this.imgArchivos.TransparentColor = System.Drawing.Color.Transparent;
            this.imgArchivos.Images.SetKeyName(0, "Captura.PNG");
            this.imgArchivos.Images.SetKeyName(1, "104647.png");
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
            this.mainSlipContainer.Panel2.Controls.Add(this.pbWrapper);
            this.mainSlipContainer.Panel2.Controls.Add(this.txtNota);
            this.mainSlipContainer.Panel2MinSize = 100;
            this.mainSlipContainer.Size = new System.Drawing.Size(1171, 582);
            this.mainSlipContainer.SplitterDistance = 265;
            this.mainSlipContainer.SplitterWidth = 5;
            this.mainSlipContainer.TabIndex = 1;
            this.mainSlipContainer.MouseHover += new System.EventHandler(this.mainSlipContainer_MouseHover);
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
            // txtNota
            // 
            this.txtNota.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtNota.ContextMenuStrip = this.csmTextBox;
            this.txtNota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNota.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNota.Location = new System.Drawing.Point(0, 0);
            this.txtNota.Multiline = true;
            this.txtNota.Name = "txtNota";
            this.txtNota.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNota.Size = new System.Drawing.Size(897, 578);
            this.txtNota.TabIndex = 4;
            // 
            // csmTextBox
            // 
            this.csmTextBox.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.csmTextBox.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem1,
            this.cortarToolStripMenuItem1,
            this.pegarToolStripMenuItem1,
            this.guardarToolStripMenuItem1,
            this.limpiarSueñoToolStripMenuItem,
            this.cerrarSueñoToolStripMenuItem,
            this.deshacerToolStripMenuItem1});
            this.csmTextBox.Name = "csmTextBox";
            this.csmTextBox.Size = new System.Drawing.Size(191, 172);
            // 
            // copiarToolStripMenuItem1
            // 
            this.copiarToolStripMenuItem1.Name = "copiarToolStripMenuItem1";
            this.copiarToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copiarToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.copiarToolStripMenuItem1.Text = "Copiar";
            this.copiarToolStripMenuItem1.Click += new System.EventHandler(this.copiarToolStripMenuItem1_Click);
            // 
            // cortarToolStripMenuItem1
            // 
            this.cortarToolStripMenuItem1.Name = "cortarToolStripMenuItem1";
            this.cortarToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cortarToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.cortarToolStripMenuItem1.Text = "Cortar";
            this.cortarToolStripMenuItem1.Click += new System.EventHandler(this.cortarToolStripMenuItem1_Click);
            // 
            // pegarToolStripMenuItem1
            // 
            this.pegarToolStripMenuItem1.Name = "pegarToolStripMenuItem1";
            this.pegarToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pegarToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.pegarToolStripMenuItem1.Text = "Pegar";
            this.pegarToolStripMenuItem1.Click += new System.EventHandler(this.pegarToolStripMenuItem1_Click);
            // 
            // guardarToolStripMenuItem1
            // 
            this.guardarToolStripMenuItem1.Name = "guardarToolStripMenuItem1";
            this.guardarToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.guardarToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.guardarToolStripMenuItem1.Text = "Guardar";
            this.guardarToolStripMenuItem1.Click += new System.EventHandler(this.guardarToolStripMenuItem1_Click);
            // 
            // limpiarSueñoToolStripMenuItem
            // 
            this.limpiarSueñoToolStripMenuItem.Name = "limpiarSueñoToolStripMenuItem";
            this.limpiarSueñoToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.limpiarSueñoToolStripMenuItem.Text = "Limpiar sueño";
            this.limpiarSueñoToolStripMenuItem.Click += new System.EventHandler(this.limpiarSueñoToolStripMenuItem_Click);
            // 
            // cerrarSueñoToolStripMenuItem
            // 
            this.cerrarSueñoToolStripMenuItem.Name = "cerrarSueñoToolStripMenuItem";
            this.cerrarSueñoToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.cerrarSueñoToolStripMenuItem.Text = "Cerrar sueño";
            this.cerrarSueñoToolStripMenuItem.Click += new System.EventHandler(this.cerrarSueñoToolStripMenuItem_Click);
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
            this.abrirToolStripMenuItem,
            this.toolStripSeparator,
            this.guardarToolStripMenuItem,
            this.guardarcomoToolStripMenuItem,
            this.toolStripSeparator1,
            this.imprimirToolStripMenuItem,
            this.vistapreviadeimpresiónToolStripMenuItem,
            this.toolStripSeparator2,
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
            this.nuevoToolStripMenuItem.Text = "&Nuevo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripMenuItem.Image")));
            this.abrirToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.abrirToolStripMenuItem.Text = "&Abrir";
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
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(282, 26);
            this.salirToolStripMenuItem.Text = "&Salir";
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
            // 
            // rehacerToolStripMenuItem
            // 
            this.rehacerToolStripMenuItem.Name = "rehacerToolStripMenuItem";
            this.rehacerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.rehacerToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.rehacerToolStripMenuItem.Text = "&Rehacer";
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
            this.opcionesToolStripMenuItem});
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(126, 44);
            this.herramientasToolStripMenuItem.Text = "&Herramientas";
            // 
            // personalizarToolStripMenuItem
            // 
            this.personalizarToolStripMenuItem.Name = "personalizarToolStripMenuItem";
            this.personalizarToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.personalizarToolStripMenuItem.Text = "&Personalizar";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.opcionesToolStripMenuItem.Text = "&Opciones";
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
            // deshacerToolStripMenuItem1
            // 
            this.deshacerToolStripMenuItem1.Name = "deshacerToolStripMenuItem1";
            this.deshacerToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.deshacerToolStripMenuItem1.Size = new System.Drawing.Size(190, 24);
            this.deshacerToolStripMenuItem1.Text = "Deshacer";
            this.deshacerToolStripMenuItem1.Visible = false;
            this.deshacerToolStripMenuItem1.Click += new System.EventHandler(this.deshacerToolStripMenuItem1_Click);
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
            this.cmsTreeView.ResumeLayout(false);
            this.mainSlipContainer.Panel1.ResumeLayout(false);
            this.mainSlipContainer.Panel2.ResumeLayout(false);
            this.mainSlipContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainSlipContainer)).EndInit();
            this.mainSlipContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbWrapper)).EndInit();
            this.csmTextBox.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.MenuStrip mnPrincipal;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem nuevaCarpetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoRecuerdoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ocultarSueñosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarcToolStripMenuItem;
        public System.Windows.Forms.TreeView tvSuenos;
        private System.Windows.Forms.ContextMenuStrip csmTextBox;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cortarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pegarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem limpiarSueñoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSueñoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deshacerToolStripMenuItem1;
    }
}

