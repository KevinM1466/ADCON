namespace BIT_ADCON.Forms.Contratos {
    partial class frmMostrarContratos {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if ( disposing && ( components != null ) ) {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgDatos = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2HtmlLabel17 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cmbContratos = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel11 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtCliente = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtComentario = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtClienteID = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.swtRenovacion = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpFechaFinal = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dtpFechaInicio = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel32 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtCantidadCuotas = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel35 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel36 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtMoneda = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTipo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCodigoMoneda = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnCargar = new Guna.UI2.WinForms.Guna2Button();
            this.lblTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel18 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblDescuento = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel15 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblImpuesto = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblSubTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDatos
            // 
            this.dgDatos.AllowUserToAddRows = false;
            this.dgDatos.AllowUserToOrderColumns = true;
            this.dgDatos.AllowUserToResizeColumns = false;
            this.dgDatos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDatos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgDatos.ColumnHeadersHeight = 30;
            this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDatos.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgDatos.Location = new System.Drawing.Point(115, 425);
            this.dgDatos.Margin = new System.Windows.Forms.Padding(8, 13, 8, 13);
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgDatos.RowHeadersVisible = false;
            this.dgDatos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgDatos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgDatos.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgDatos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgDatos.RowTemplate.Height = 26;
            this.dgDatos.RowTemplate.ReadOnly = true;
            this.dgDatos.Size = new System.Drawing.Size(1247, 417);
            this.dgDatos.TabIndex = 371;
            this.dgDatos.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WetAsphalt;
            this.dgDatos.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.dgDatos.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgDatos.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgDatos.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgDatos.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgDatos.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.dgDatos.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(199)))), ((int)(((byte)(206)))));
            this.dgDatos.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dgDatos.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgDatos.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgDatos.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgDatos.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgDatos.ThemeStyle.HeaderStyle.Height = 30;
            this.dgDatos.ThemeStyle.ReadOnly = true;
            this.dgDatos.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.dgDatos.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgDatos.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgDatos.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgDatos.ThemeStyle.RowsStyle.Height = 26;
            this.dgDatos.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(133)))), ((int)(((byte)(147)))));
            this.dgDatos.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDatos_CellDoubleClick);
            // 
            // guna2HtmlLabel17
            // 
            this.guna2HtmlLabel17.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel17.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel17.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2HtmlLabel17.Location = new System.Drawing.Point(115, 22);
            this.guna2HtmlLabel17.Margin = new System.Windows.Forms.Padding(8, 13, 8, 13);
            this.guna2HtmlLabel17.Name = "guna2HtmlLabel17";
            this.guna2HtmlLabel17.Size = new System.Drawing.Size(173, 50);
            this.guna2HtmlLabel17.TabIndex = 370;
            this.guna2HtmlLabel17.Text = "CONTRATOS";
            // 
            // cmbContratos
            // 
            this.cmbContratos.BackColor = System.Drawing.Color.Transparent;
            this.cmbContratos.BorderRadius = 13;
            this.cmbContratos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbContratos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbContratos.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbContratos.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbContratos.Font = new System.Drawing.Font("Poppins", 12F);
            this.cmbContratos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbContratos.ItemHeight = 30;
            this.cmbContratos.Location = new System.Drawing.Point(115, 116);
            this.cmbContratos.MaxLength = 8;
            this.cmbContratos.Name = "cmbContratos";
            this.cmbContratos.Size = new System.Drawing.Size(243, 36);
            this.cmbContratos.TabIndex = 372;
            this.cmbContratos.SelectedIndexChanged += new System.EventHandler(this.cmbContratos_SelectedIndexChanged);
            this.cmbContratos.SelectionChangeCommitted += new System.EventHandler(this.cmbContratos_SelectionChangeCommitted);
            // 
            // guna2HtmlLabel11
            // 
            this.guna2HtmlLabel11.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel11.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel11.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2HtmlLabel11.Location = new System.Drawing.Point(399, 258);
            this.guna2HtmlLabel11.Name = "guna2HtmlLabel11";
            this.guna2HtmlLabel11.Size = new System.Drawing.Size(162, 30);
            this.guna2HtmlLabel11.TabIndex = 400;
            this.guna2HtmlLabel11.Text = "Tipo de Facturación";
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(673, 171);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(98, 30);
            this.guna2HtmlLabel10.TabIndex = 402;
            this.guna2HtmlLabel10.Text = "Comentario";
            // 
            // txtCliente
            // 
            this.txtCliente.BorderRadius = 13;
            this.txtCliente.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCliente.DefaultText = "";
            this.txtCliente.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCliente.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCliente.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCliente.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCliente.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCliente.Font = new System.Drawing.Font("Poppins", 12F);
            this.txtCliente.ForeColor = System.Drawing.Color.Black;
            this.txtCliente.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCliente.Location = new System.Drawing.Point(399, 116);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.PasswordChar = '\0';
            this.txtCliente.PlaceholderText = "";
            this.txtCliente.SelectedText = "";
            this.txtCliente.Size = new System.Drawing.Size(245, 41);
            this.txtCliente.TabIndex = 398;
            // 
            // txtComentario
            // 
            this.txtComentario.BorderRadius = 13;
            this.txtComentario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtComentario.DefaultText = "N/A";
            this.txtComentario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtComentario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtComentario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComentario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtComentario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComentario.Font = new System.Drawing.Font("Poppins", 12F);
            this.txtComentario.ForeColor = System.Drawing.Color.Black;
            this.txtComentario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtComentario.Location = new System.Drawing.Point(673, 204);
            this.txtComentario.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.PasswordChar = '\0';
            this.txtComentario.PlaceholderText = "";
            this.txtComentario.SelectedText = "";
            this.txtComentario.Size = new System.Drawing.Size(227, 128);
            this.txtComentario.TabIndex = 401;
            // 
            // txtClienteID
            // 
            this.txtClienteID.BorderRadius = 13;
            this.txtClienteID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClienteID.DefaultText = "";
            this.txtClienteID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtClienteID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtClienteID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClienteID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClienteID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClienteID.Font = new System.Drawing.Font("Poppins", 12F);
            this.txtClienteID.ForeColor = System.Drawing.Color.Black;
            this.txtClienteID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClienteID.Location = new System.Drawing.Point(399, 116);
            this.txtClienteID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.PasswordChar = '\0';
            this.txtClienteID.PlaceholderText = "";
            this.txtClienteID.SelectedText = "";
            this.txtClienteID.Size = new System.Drawing.Size(228, 41);
            this.txtClienteID.TabIndex = 397;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(936, 83);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(196, 30);
            this.guna2HtmlLabel4.TabIndex = 396;
            this.guna2HtmlLabel4.Text = "Renovación Automatica";
            // 
            // swtRenovacion
            // 
            this.swtRenovacion.CheckedState.BorderColor = System.Drawing.Color.Green;
            this.swtRenovacion.CheckedState.FillColor = System.Drawing.Color.Green;
            this.swtRenovacion.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.swtRenovacion.CheckedState.InnerColor = System.Drawing.Color.White;
            this.swtRenovacion.Location = new System.Drawing.Point(936, 116);
            this.swtRenovacion.Name = "swtRenovacion";
            this.swtRenovacion.Size = new System.Drawing.Size(55, 28);
            this.swtRenovacion.TabIndex = 395;
            this.swtRenovacion.UncheckedState.BorderColor = System.Drawing.Color.Red;
            this.swtRenovacion.UncheckedState.FillColor = System.Drawing.Color.Red;
            this.swtRenovacion.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.swtRenovacion.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(399, 83);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(59, 30);
            this.guna2HtmlLabel2.TabIndex = 394;
            this.guna2HtmlLabel2.Text = "Cliente";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.BorderRadius = 10;
            this.dtpFechaFinal.Checked = true;
            this.dtpFechaFinal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtpFechaFinal.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFechaFinal.Location = new System.Drawing.Point(117, 319);
            this.dtpFechaFinal.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaFinal.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(241, 38);
            this.dtpFechaFinal.TabIndex = 393;
            this.dtpFechaFinal.Value = new System.DateTime(2023, 10, 21, 23, 7, 6, 254);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(115, 258);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(210, 55);
            this.guna2HtmlLabel1.TabIndex = 392;
            this.guna2HtmlLabel1.Text = "Fecha de Finalización del Contrato";
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.BorderRadius = 10;
            this.dtpFechaInicio.Checked = true;
            this.dtpFechaInicio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtpFechaInicio.Font = new System.Drawing.Font("Poppins", 9.75F);
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpFechaInicio.Location = new System.Drawing.Point(117, 204);
            this.dtpFechaInicio.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFechaInicio.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(241, 38);
            this.dtpFechaInicio.TabIndex = 391;
            this.dtpFechaInicio.Value = new System.DateTime(2023, 10, 21, 23, 7, 6, 254);
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(399, 171);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(69, 30);
            this.guna2HtmlLabel3.TabIndex = 390;
            this.guna2HtmlLabel3.Text = "Moneda";
            // 
            // guna2HtmlLabel32
            // 
            this.guna2HtmlLabel32.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel32.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel32.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2HtmlLabel32.Location = new System.Drawing.Point(673, 83);
            this.guna2HtmlLabel32.Name = "guna2HtmlLabel32";
            this.guna2HtmlLabel32.Size = new System.Drawing.Size(165, 30);
            this.guna2HtmlLabel32.TabIndex = 388;
            this.guna2HtmlLabel32.Text = "Cantidad de Cuotas";
            // 
            // txtCantidadCuotas
            // 
            this.txtCantidadCuotas.BorderRadius = 13;
            this.txtCantidadCuotas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidadCuotas.DefaultText = "";
            this.txtCantidadCuotas.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCantidadCuotas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCantidadCuotas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantidadCuotas.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantidadCuotas.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCantidadCuotas.Font = new System.Drawing.Font("Poppins", 12F);
            this.txtCantidadCuotas.ForeColor = System.Drawing.Color.Black;
            this.txtCantidadCuotas.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCantidadCuotas.Location = new System.Drawing.Point(673, 116);
            this.txtCantidadCuotas.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtCantidadCuotas.Name = "txtCantidadCuotas";
            this.txtCantidadCuotas.PasswordChar = '\0';
            this.txtCantidadCuotas.PlaceholderText = "";
            this.txtCantidadCuotas.SelectedText = "";
            this.txtCantidadCuotas.Size = new System.Drawing.Size(228, 41);
            this.txtCantidadCuotas.TabIndex = 387;
            // 
            // guna2HtmlLabel35
            // 
            this.guna2HtmlLabel35.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel35.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel35.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2HtmlLabel35.Location = new System.Drawing.Point(116, 171);
            this.guna2HtmlLabel35.Name = "guna2HtmlLabel35";
            this.guna2HtmlLabel35.Size = new System.Drawing.Size(227, 30);
            this.guna2HtmlLabel35.TabIndex = 386;
            this.guna2HtmlLabel35.Text = "Fecha de Inicio del Contrato";
            // 
            // guna2HtmlLabel36
            // 
            this.guna2HtmlLabel36.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel36.Font = new System.Drawing.Font("Poppins", 12F);
            this.guna2HtmlLabel36.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2HtmlLabel36.Location = new System.Drawing.Point(116, 83);
            this.guna2HtmlLabel36.Name = "guna2HtmlLabel36";
            this.guna2HtmlLabel36.Size = new System.Drawing.Size(91, 30);
            this.guna2HtmlLabel36.TabIndex = 385;
            this.guna2HtmlLabel36.Text = "Contrato #";
            // 
            // txtMoneda
            // 
            this.txtMoneda.BorderRadius = 13;
            this.txtMoneda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMoneda.DefaultText = "";
            this.txtMoneda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMoneda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMoneda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoneda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoneda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoneda.Font = new System.Drawing.Font("Poppins", 12F);
            this.txtMoneda.ForeColor = System.Drawing.Color.Black;
            this.txtMoneda.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoneda.Location = new System.Drawing.Point(399, 204);
            this.txtMoneda.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtMoneda.Name = "txtMoneda";
            this.txtMoneda.PasswordChar = '\0';
            this.txtMoneda.PlaceholderText = "";
            this.txtMoneda.SelectedText = "";
            this.txtMoneda.Size = new System.Drawing.Size(245, 41);
            this.txtMoneda.TabIndex = 404;
            // 
            // txtTipo
            // 
            this.txtTipo.BorderRadius = 13;
            this.txtTipo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTipo.DefaultText = "";
            this.txtTipo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTipo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTipo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTipo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTipo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTipo.Font = new System.Drawing.Font("Poppins", 12F);
            this.txtTipo.ForeColor = System.Drawing.Color.Black;
            this.txtTipo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTipo.Location = new System.Drawing.Point(399, 297);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.PasswordChar = '\0';
            this.txtTipo.PlaceholderText = "";
            this.txtTipo.SelectedText = "";
            this.txtTipo.Size = new System.Drawing.Size(245, 41);
            this.txtTipo.TabIndex = 405;
            // 
            // txtCodigoMoneda
            // 
            this.txtCodigoMoneda.BorderRadius = 13;
            this.txtCodigoMoneda.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoMoneda.DefaultText = "";
            this.txtCodigoMoneda.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCodigoMoneda.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCodigoMoneda.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoMoneda.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoMoneda.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigoMoneda.Font = new System.Drawing.Font("Poppins", 12F);
            this.txtCodigoMoneda.ForeColor = System.Drawing.Color.Black;
            this.txtCodigoMoneda.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigoMoneda.Location = new System.Drawing.Point(399, 204);
            this.txtCodigoMoneda.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtCodigoMoneda.Name = "txtCodigoMoneda";
            this.txtCodigoMoneda.PasswordChar = '\0';
            this.txtCodigoMoneda.PlaceholderText = "";
            this.txtCodigoMoneda.SelectedText = "";
            this.txtCodigoMoneda.Size = new System.Drawing.Size(245, 41);
            this.txtCodigoMoneda.TabIndex = 406;
            // 
            // btnCargar
            // 
            this.btnCargar.BorderRadius = 13;
            this.btnCargar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCargar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCargar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCargar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCargar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(98)))), ((int)(((byte)(137)))));
            this.btnCargar.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Location = new System.Drawing.Point(115, 368);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(100, 41);
            this.btnCargar.TabIndex = 407;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTotal.Location = new System.Drawing.Point(1320, 230);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(36, 30);
            this.lblTotal.TabIndex = 415;
            this.lblTotal.Text = "0.00";
            // 
            // guna2HtmlLabel18
            // 
            this.guna2HtmlLabel18.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel18.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel18.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2HtmlLabel18.Location = new System.Drawing.Point(1201, 230);
            this.guna2HtmlLabel18.Name = "guna2HtmlLabel18";
            this.guna2HtmlLabel18.Size = new System.Drawing.Size(49, 30);
            this.guna2HtmlLabel18.TabIndex = 414;
            this.guna2HtmlLabel18.Text = "Total:";
            // 
            // lblDescuento
            // 
            this.lblDescuento.BackColor = System.Drawing.Color.Transparent;
            this.lblDescuento.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblDescuento.Location = new System.Drawing.Point(1320, 194);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(36, 30);
            this.lblDescuento.TabIndex = 413;
            this.lblDescuento.Text = "0.00";
            // 
            // guna2HtmlLabel15
            // 
            this.guna2HtmlLabel15.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel15.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel15.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2HtmlLabel15.Location = new System.Drawing.Point(1153, 194);
            this.guna2HtmlLabel15.Name = "guna2HtmlLabel15";
            this.guna2HtmlLabel15.Size = new System.Drawing.Size(97, 30);
            this.guna2HtmlLabel15.TabIndex = 412;
            this.guna2HtmlLabel15.Text = "Descuento:";
            // 
            // lblImpuesto
            // 
            this.lblImpuesto.BackColor = System.Drawing.Color.Transparent;
            this.lblImpuesto.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpuesto.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblImpuesto.Location = new System.Drawing.Point(1320, 158);
            this.lblImpuesto.Name = "lblImpuesto";
            this.lblImpuesto.Size = new System.Drawing.Size(36, 30);
            this.lblImpuesto.TabIndex = 411;
            this.lblImpuesto.Text = "0.00";
            // 
            // guna2HtmlLabel13
            // 
            this.guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel13.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel13.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2HtmlLabel13.Location = new System.Drawing.Point(1163, 158);
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.Size = new System.Drawing.Size(87, 30);
            this.guna2HtmlLabel13.TabIndex = 410;
            this.guna2HtmlLabel13.Text = "Impuesto:";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTotal.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSubTotal.Location = new System.Drawing.Point(1320, 122);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(36, 30);
            this.lblSubTotal.TabIndex = 409;
            this.lblSubTotal.Text = "0.00";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.Gainsboro;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(1169, 122);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(81, 30);
            this.guna2HtmlLabel5.TabIndex = 408;
            this.guna2HtmlLabel5.Text = "SubTotal:";
            // 
            // frmMostrarContratos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1460, 853);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.guna2HtmlLabel18);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.guna2HtmlLabel15);
            this.Controls.Add(this.lblImpuesto);
            this.Controls.Add(this.guna2HtmlLabel13);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtMoneda);
            this.Controls.Add(this.guna2HtmlLabel11);
            this.Controls.Add(this.guna2HtmlLabel10);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.txtClienteID);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.swtRenovacion);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel32);
            this.Controls.Add(this.txtCantidadCuotas);
            this.Controls.Add(this.guna2HtmlLabel35);
            this.Controls.Add(this.guna2HtmlLabel36);
            this.Controls.Add(this.cmbContratos);
            this.Controls.Add(this.dgDatos);
            this.Controls.Add(this.guna2HtmlLabel17);
            this.Controls.Add(this.txtCodigoMoneda);
            this.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmMostrarContratos";
            this.Text = "frmMostrarContratos";
            this.Load += new System.EventHandler(this.frmMostrarContratos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Guna.UI2.WinForms.Guna2DataGridView dgDatos;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel17;
        public Guna.UI2.WinForms.Guna2ComboBox cmbContratos;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel11;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        public Guna.UI2.WinForms.Guna2TextBox txtCliente;
        public Guna.UI2.WinForms.Guna2TextBox txtComentario;
        public Guna.UI2.WinForms.Guna2TextBox txtClienteID;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        public Guna.UI2.WinForms.Guna2ToggleSwitch swtRenovacion;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        public Guna.UI2.WinForms.Guna2DateTimePicker dtpFechaFinal;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        public Guna.UI2.WinForms.Guna2DateTimePicker dtpFechaInicio;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel32;
        public Guna.UI2.WinForms.Guna2TextBox txtCantidadCuotas;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel35;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel36;
        public Guna.UI2.WinForms.Guna2TextBox txtMoneda;
        public Guna.UI2.WinForms.Guna2TextBox txtTipo;
        public Guna.UI2.WinForms.Guna2TextBox txtCodigoMoneda;
        private Guna.UI2.WinForms.Guna2Button btnCargar;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblTotal;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel18;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblDescuento;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel15;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblImpuesto;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblSubTotal;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
    }
}