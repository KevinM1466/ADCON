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
    public partial class frmReporte2 : Form {
        public frmReporte2() {
            InitializeComponent();
        }

        private void frmReporte2_Load( object sender, EventArgs e ) {
            // TODO: esta línea de código carga datos en la tabla 'bIT_ADCONDataSet2.rpProductos_Mas_Vendidos' Puede moverla o quitarla según sea necesario.

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
