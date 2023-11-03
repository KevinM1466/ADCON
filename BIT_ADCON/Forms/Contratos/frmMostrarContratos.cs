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

using Common.cache;

using DataAccess.CrudsDA;

using Domain;
using Domain.CrudsD;

namespace BIT_ADCON.Forms.Contratos {
    public partial class frmMostrarContratos : Form {
        MetodosListados metodos = new MetodosListados();
        FilterModel filtro = new FilterModel();
        ContratosD contratos = new ContratosD();

        double impuesto = 0;
        double descuento = 0;
        int cantidad = 0;

        double Impuesto = 0;
        double SubTotales = 0;
        double Descuento = 0;
        double Total = 0;
        public frmMostrarContratos() {
            InitializeComponent();
        }

        private void frmMostrarContratos_Load( object sender, EventArgs e ) {
            metodos.MostrarContratos( dgDatos );
            metodos.ListarContratos(cmbContratos);

            cmbContratos.StartIndex = -1;
        }

        private void dgDatos_CellDoubleClick( object sender, DataGridViewCellEventArgs e ) {
            //frmContratos frm = (frmContratos)Owner;
            //if ( frm != null ) {
            //    frm.txtContrato.Text = dgDatos.CurrentRow.Cells[ 0 ].Value.ToString();
            //    frm.cmbMoneda.Text = dgDatos.CurrentRow.Cells[ 5 ].Value.ToString();
            //    frm.txtClienteID.Text = dgDatos.CurrentRow.Cells[ 6 ].Value.ToString();
            //    frm.txtCliente.Text = dgDatos.CurrentRow.Cells[ 7 ].Value.ToString();
            //    frm.cmbTipo.Text = dgDatos.CurrentRow.Cells[ 10 ].Value.ToString();
            //    frm.txtCantidadCuotas.Text = dgDatos.CurrentRow.Cells[ 11 ].Value.ToString();
            //    frm.txtComentario.Text = dgDatos.CurrentRow.Cells[ 12 ].Value.ToString();
            //    frm.swtRenovacion.Checked = bool.Parse( dgDatos.CurrentRow.Cells[ 13 ].Value.ToString() );
            //    this.Close();
            //}
        }

        private void cmbContratos_SelectedIndexChanged( object sender, EventArgs e ) {
            
        }

        private void cmbContratos_SelectionChangeCommitted( object sender, EventArgs e ) {
            try {
                filtro.FiltrarContratos( cmbContratos.Text, dgDatos );
                var cargar = contratos.MostrarDatos(cmbContratos.Text);

                if ( cargar == true ) {
                    txtClienteID.Text = ContratosCache.clienteID.ToString();
                    txtCliente.Text = ContratosCache.Cliente.ToString();
                    dtpFechaInicio.Value = DateTime.Parse( ContratosCache.fechaIncio.ToString() );
                    dtpFechaFinal.Value = ContratosCache.fechaFinal;
                    txtCodigoMoneda.Text = ContratosCache.codigoMoneda.ToString();
                    txtMoneda.Text = ContratosCache.moneda.ToString();
                    txtTipo.Text = ContratosCache.tipoF.ToString();
                    txtCantidadCuotas.Text = ContratosCache.cantidadCuotas.ToString();
                    txtComentario.Text = ContratosCache.comentario.ToString();
                    swtRenovacion.Checked = ContratosCache.renovacion;
                }

                double subtotal = 0;
                double impuesto = 0;
                double descuento = 0;
                double total = 0;
                foreach ( DataGridViewRow row in dgDatos.Rows ) {
                    impuesto += Convert.ToDouble( row.Cells[ 5 ].Value );
                    descuento += Convert.ToDouble( row.Cells[ 6 ].Value );
                    subtotal += Convert.ToDouble( row.Cells[ 7 ].Value );
                }
                lblDescuento.Text = descuento.ToString("N2");
                lblSubTotal.Text = subtotal.ToString("N2");
                lblImpuesto.Text = impuesto.ToString("N2");
                total = Convert.ToDouble( lblSubTotal.Text ) + Convert.ToDouble( lblImpuesto.Text ) - Convert.ToDouble( lblDescuento.Text );

                lblTotal.Text = total.ToString("N2" );


            } catch ( Exception ex ) {

            }
        }

        private void btnCargar_Click( object sender, EventArgs e ) {
            frmContratos frm = (frmContratos)Owner;
            if ( frm != null ) {
                frm.txtContrato.Text = cmbContratos.Text;
                frm.cmbMoneda.Text = txtMoneda.Text;
                frm.txtClienteID.Text = txtClienteID.Text;
                frm.txtCliente.Text = txtCliente.Text;
                frm.cmbTipo.Text = txtTipo.Text;
                frm.txtCantidadCuotas.Text = txtCantidadCuotas.Text;
                frm.txtComentario.Text = txtComentario.Text;
                frm.swtRenovacion.Checked = swtRenovacion.Checked;
                frm.lblSubTotal.Text = lblSubTotal.Text;
                frm.lblImpuesto.Text = lblImpuesto.Text;
                frm.lblDescuento.Text = lblDescuento.Text;
                frm.lblTotal.Text = lblTotal.Text;
            }
            varEnviarDatos enviar = Owner as varEnviarDatos;
            DataGridViewRow fila = dgDatos.SelectedRows[ 0 ] as DataGridViewRow;
            enviar.CargarDatos( fila );
        }
    }
}
