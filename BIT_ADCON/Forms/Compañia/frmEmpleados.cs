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
using BIT_ADCON.Forms.Contratos;

using Clases;

using Guna.UI2.WinForms;

namespace BIT_ADCON.Forms.Empresa {
    public partial class frmEmpleados : Form {
        MetodosListados metodos = new MetodosListados();
        public frmEmpleados() {
            InitializeComponent();
        }

        private void dgDatosEmpleados_CellDoubleClick( object sender, DataGridViewCellEventArgs e ) {
            try {
                frmMenuCompania frm = (frmMenuCompania)Owner;
                if ( frm != null ) {
                    frm.txtEmpleadoIDUser.Text = dgDatosEmpleados.CurrentRow.Cells[ 0 ].Value.ToString();
                    frm.txtEmpleado.Text = dgDatosEmpleados.CurrentRow.Cells[ 1 ].Value.ToString() + " " + dgDatosEmpleados.CurrentRow.Cells[ 2 ].Value.ToString();
                    this.Close();
                }
            } catch ( Exception ) {
                MessageDialog.Show( "No puede seleccionar estos datos", "Soporte Tecnasa", MessageDialogButtons.OK, MessageDialogIcon.Information );
            }
        }

        private void frmEmpleados_Load( object sender, EventArgs e ) {
            metodos.MostrarEmpleados(dgDatosEmpleados);
        }
    }
}
