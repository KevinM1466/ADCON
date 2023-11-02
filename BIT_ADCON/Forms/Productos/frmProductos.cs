using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BIT_ADCON.Forms.Compañia;

using Clases;

using Guna.UI2.WinForms;

namespace BIT_ADCON.Forms.Productos {
    public partial class frmProductos : Form {
        MetodosListados metodos = new MetodosListados();
        public frmProductos() {
            InitializeComponent();
        }

        private void frmProductos_Load( object sender, EventArgs e ) {
            metodos.MostrarProductos( dgDatos );
        }

        private void dgDatos_CellDoubleClick( object sender, DataGridViewCellEventArgs e ) {
            try {
                frmContratos frm = (frmContratos)Owner;
                if ( frm != null ) {
                    frm.txtProductoID.Text = dgDatos.CurrentRow.Cells[ 0 ].Value.ToString();
                    frm.txtProducto.Text = dgDatos.CurrentRow.Cells[ 1 ].Value.ToString();
                    frm.txtPrecio.Text = dgDatos.CurrentRow.Cells[ 5 ].Value.ToString();
                    frm.lblConversion.Text = dgDatos.CurrentRow.Cells[ 5 ].Value.ToString();
                    this.Close();
                }
            } catch ( Exception ) {
                MessageDialog.Show( "No puede seleccionar estos datos", "Soporte Tecnasa", MessageDialogButtons.OK, MessageDialogIcon.Information );
            }
        }
    }
}
