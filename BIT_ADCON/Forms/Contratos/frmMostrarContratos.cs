using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

using Clases;

namespace BIT_ADCON.Forms.Contratos {
    public partial class frmMostrarContratos : Form {
        MetodosListados metodos = new MetodosListados();
        public frmMostrarContratos() {
            InitializeComponent();
        }

        private void frmMostrarContratos_Load( object sender, EventArgs e ) {
            metodos.MostrarContratos( dgDatos );
        }

        private void dgDatos_CellDoubleClick( object sender, DataGridViewCellEventArgs e ) {
            frmContratos frm = (frmContratos)Owner;
            if ( frm != null ) {
                frm.txtContrato.Text = dgDatos.CurrentRow.Cells[ 0 ].Value.ToString();
                frm.cmbMoneda.Text = dgDatos.CurrentRow.Cells[ 5 ].Value.ToString();
                frm.txtClienteID.Text = dgDatos.CurrentRow.Cells[ 6 ].Value.ToString();
                frm.txtCliente.Text = dgDatos.CurrentRow.Cells[ 7 ].Value.ToString();
                frm.cmbTipo.Text = dgDatos.CurrentRow.Cells[ 10 ].Value.ToString();
                frm.txtCantidadCuotas.Text = dgDatos.CurrentRow.Cells[ 11 ].Value.ToString();
                frm.txtComentario.Text = dgDatos.CurrentRow.Cells[ 12 ].Value.ToString();
                frm.swtRenovacion.Checked = bool.Parse( dgDatos.CurrentRow.Cells[ 13 ].Value.ToString() );
                this.Close();
            }
        }
    }
}
