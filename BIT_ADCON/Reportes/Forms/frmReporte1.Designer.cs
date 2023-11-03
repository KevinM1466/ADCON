namespace BIT_ADCON.Reportes.Forms {
    partial class frmReporte1 {
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bIT_ADCONDataSet1 = new BIT_ADCON.BIT_ADCONDataSet();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.rpContratosClienteTableAdapter1 = new BIT_ADCON.BIT_ADCONDataSetTableAdapters.rpContratosClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bIT_ADCONDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bindingSource1;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "BIT_ADCON.Reportes.Informes.Report1.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1205, 685);
            this.reportViewer2.TabIndex = 0;
            // 
            // bIT_ADCONDataSet1
            // 
            this.bIT_ADCONDataSet1.DataSetName = "BIT_ADCONDataSet";
            this.bIT_ADCONDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "rpContratosCliente";
            this.bindingSource1.DataSource = this.bIT_ADCONDataSet1;
            // 
            // rpContratosClienteTableAdapter1
            // 
            this.rpContratosClienteTableAdapter1.ClearBeforeFill = true;
            // 
            // frmReporte1
            // 
            this.ClientSize = new System.Drawing.Size(1205, 685);
            this.Controls.Add(this.reportViewer2);
            this.Name = "frmReporte1";
            this.Load += new System.EventHandler(this.frmReporte1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.bIT_ADCONDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource bITADCONDataSetBindingSource;
        private BIT_ADCONDataSet bIT_ADCONDataSet;
        private System.Windows.Forms.BindingSource rpContratosClienteBindingSource;
        private BIT_ADCONDataSetTableAdapters.rpContratosClienteTableAdapter rpContratosClienteTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private BIT_ADCONDataSet bIT_ADCONDataSet1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private BIT_ADCONDataSetTableAdapters.rpContratosClienteTableAdapter rpContratosClienteTableAdapter1;
    }
}