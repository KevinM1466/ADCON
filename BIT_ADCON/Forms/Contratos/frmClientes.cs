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

namespace BIT_ADCON.Forms.Contratos {
    public partial class frmClientes : Form {
        MetodosListados metodos = new MetodosListados();
        public frmClientes() {
            InitializeComponent();
        }

        private void frmClientes_Load( object sender, EventArgs e ) {
            metodos.MostrarClientes(dgDatos);
        }

        private void dgDatos_CellDoubleClick( object sender, DataGridViewCellEventArgs e ) {
            try {
                frmContratos frm = (frmContratos)Owner;
                if ( frm != null ) {
                    frm.txtClienteID.Text = dgDatos.CurrentRow.Cells[ 0 ].Value.ToString();
                    frm.txtCliente.Text = dgDatos.CurrentRow.Cells[ 1 ].Value.ToString();
                    this.Close();
                }
            } catch ( Exception ) {
                MessageDialog.Show( "No puede seleccionar estos datos", "Soporte Tecnasa", MessageDialogButtons.OK, MessageDialogIcon.Information );
            }
        }
    }
}
