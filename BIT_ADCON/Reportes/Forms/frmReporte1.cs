using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIT_ADCON.Reportes.Forms {
    public partial class frmReporte1 : Form {
        public frmReporte1() {
            InitializeComponent();
        }

        private void frmReporte1_Load_1( object sender, EventArgs e ) {
            // TODO: esta línea de código carga datos en la tabla 'bIT_ADCONDataSet1.rpContratosCliente' Puede moverla o quitarla según sea necesario.
            this.rpContratosClienteTableAdapter1.Fill( this.bIT_ADCONDataSet1.rpContratosCliente );

            this.reportViewer2.RefreshReport();
        }
    }
}
