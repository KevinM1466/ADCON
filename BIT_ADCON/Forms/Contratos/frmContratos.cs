using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BIT_ADCON.Forms.Contratos;
using BIT_ADCON.Forms.Empresa;
using BIT_ADCON.Forms.Productos;

using Clases;

using Common;

using DataAccess.CrudsDA;

using Domain.CrudsD;

namespace BIT_ADCON.Forms {
    public partial class frmContratos : Form {
        MetodosListados metodos = new MetodosListados();
        ContratosD contratos = new ContratosD();
        Conversor conversor = new Conversor();
        double impuesto = 0;
        double descuento = 0;
        int cantidad = 0;

        double Impuesto = 0;
        double SubTotales = 0;
        double Descuento = 0;
        double Total = 0;
        public frmContratos() {
            InitializeComponent();
        }

        private void frmContratos_Load( object sender, EventArgs e ) {
            metodos.ListarMonedas( cmbMoneda );

            txtPrecio.Text = "0.00";
            txtImpuesto.Text = "0.00";
            txtDescuento.Text = "0.00";
        }

        private void CargarDatos() {
            try {
                if ( txtPrecio.Text != "0.00" ) {
                    cantidad = int.Parse( txtCantidad.Text );
                    impuesto = double.Parse( txtCantidad.Text ) * double.Parse( txtPrecio.Text ) * 0.15;
                    txtImpuesto.Text = impuesto.ToString( "N2" );
                    if ( cantidad >= 10 ) {
                        descuento = double.Parse( txtPrecio.Text ) * double.Parse( txtCantidad.Text ) * 0.05;
                        txtDescuento.Text = descuento.ToString( "N2" );
                    } else if ( cantidad >= 20 ) {
                        descuento = double.Parse( txtPrecio.Text ) * double.Parse( txtCantidad.Text ) * 0.12;
                        txtDescuento.Text = descuento.ToString( "N2" );
                    } else if ( cantidad >= 40 ) {
                        descuento = double.Parse( txtPrecio.Text ) * double.Parse( txtCantidad.Text ) * 0.2;
                        txtDescuento.Text = descuento.ToString( "N2" );
                    } else if ( cantidad >= 50 ) {
                        descuento = double.Parse( txtPrecio.Text ) * double.Parse( txtCantidad.Text ) * 0.25;
                        txtDescuento.Text = descuento.ToString( "N2" );
                    } else if ( cantidad <= 9 ) {
                        descuento = 0;
                        txtDescuento.Text = descuento.ToString( "N2" );
                    }
                } else {
                    txtCantidad.Text = "";
                }
            } catch ( Exception ex ) {
                txtCantidad.Text = "";
                txtImpuesto.Text = "0.00";
                txtDescuento.Text = "0.00";
            }
        }

        private void LimpiarDetalle() {
            txtProductoID.Clear();
            txtProducto.Clear();
            txtPrecio.Text = "0.00";
            txtCantidad.Clear();
            txtImpuesto.Text = "0.00";
            txtDescuento.Text = "0.00";
            lblConversion.Text = "0.00";
        }

        private void LimpiarContratros() {
            txtContrato.Clear();
            txtClienteID.Clear();
            txtCliente.Clear();
            cmbMoneda.StartIndex = 0;
            txtCantidad.Clear();
            cmbTipo.SelectedIndex = 0;
            txtComentario.Text = "N/A";
            txtCantidadCuotas.Clear();
            swtRenovacion.Checked = false;
            dgDatos.Columns.Clear();
            txtImpuesto.Text = "0.00";
            txtDescuento.Text = "0.00";
            lblTotal.Text = "0.00";
            lblSubTotal.Text = "0.00";
        }

        private void btnBuscarCliente_Click( object sender, EventArgs e ) {
            frmClientes frm = new frmClientes();
            AddOwnedForm( frm );
            frm.ShowDialog();
        }

        private void btnBuscarProducto_Click( object sender, EventArgs e ) {
            frmProductos frm = new frmProductos();
            AddOwnedForm( frm );
            frm.ShowDialog();
        }

        private void txtCantidad_TextChanged( object sender, EventArgs e ) {
            CargarDatos();
        }

        private void txtPrecio_TextChanged( object sender, EventArgs e ) {
            CargarDatos();
        }

        private void btnAgregar_Click( object sender, EventArgs e ) {
            if ( txtProducto.Text == "" || txtCantidad.Text == "" ) {
                MessageBox.Show( "Lo siento pero no puede dejar los campos vacios", "SODISA", MessageBoxButtons.OK, MessageBoxIcon.Error );
            } else {
                double subTotal = float.Parse( txtCantidad.Text ) * float.Parse( txtPrecio.Text );
                string sub = subTotal.ToString( "N2" );
                double descuento = float.Parse( txtDescuento.Text );
                double impuesto = float.Parse( txtImpuesto.Text );
                dgDatos.Rows.Add( txtProductoID.Text, txtProducto.Text, txtCantidad.Text, txtPrecio.Text, txtComentario.Text, sub, txtImpuesto.Text, txtDescuento.Text );
                Impuesto += impuesto;
                SubTotales += subTotal;
                Descuento += descuento;

                lblSubTotal.Text = SubTotales.ToString( "N2" );
                lblImpuesto.Text = Impuesto.ToString( "N2" );
                lblDescuento.Text = Descuento.ToString( "N2" );
                Total = double.Parse( lblSubTotal.Text ) + double.Parse( lblImpuesto.Text ) - double.Parse( lblDescuento.Text );
                lblTotal.Text = Total.ToString( "N2" );
                LimpiarDetalle();
            }
        }

        private void btnQuitar_Click( object sender, EventArgs e ) {
            double subTotal = double.Parse( dgDatos.CurrentRow.Cells[ 5 ].Value.ToString() );
            double impuesto = double.Parse( dgDatos.CurrentRow.Cells[ 6 ].Value.ToString() );
            double descuento = double.Parse( dgDatos.CurrentRow.Cells[ 7 ].Value.ToString() );

            if ( dgDatos.Rows.Count > 0 ) {
                for ( int i = dgDatos.SelectedRows.Count - 1; i >= 0; i += -1 ) {
                    dgDatos.Rows.RemoveAt( dgDatos.SelectedRows[ i ].Index );
                }
                Impuesto -= impuesto;
                Descuento -= descuento;
                SubTotales -= subTotal;
                lblImpuesto.Text = Impuesto.ToString( "N2" );
                lblSubTotal.Text = SubTotales.ToString( "N2" );
                Total = double.Parse( lblSubTotal.Text ) + double.Parse( lblImpuesto.Text ) - double.Parse( lblDescuento.Text );
                lblTotal.Text = Total.ToString( "N2" );
            } else {
                MessageBox.Show( "Por favor Selecciona una fila", "ADCON", MessageBoxButtons.OK, MessageBoxIcon.Question );
            }
        }

        private void cmbMoneda_SelectedIndexChanged( object sender, EventArgs e ) {
            double moneda;
            if ( cmbMoneda.SelectedIndex == 0 ) {
                txtPrecio.Text = lblConversion.Text;
            } else if ( cmbMoneda.SelectedIndex == 1 ) {
                moneda = conversor.dolar( double.Parse( lblConversion.Text ) );
                txtPrecio.Text = moneda.ToString( "N2" );
            } else if ( cmbMoneda.SelectedIndex == 2 ) {
                moneda = conversor.euro( double.Parse( lblConversion.Text ) );
                txtPrecio.Text = moneda.ToString( "N2" );
            }
        }

        private void btnGuardar_Click( object sender, EventArgs e ) {
            try {
                Random rdn = new Random();
                string contraseniaAleatoria = string.Empty;
                string caracteres = "1234567890";
                int longitud = caracteres.Length;
                char letra;
                int longitudContrasenia = 5;

                for ( int i = 0; i < longitudContrasenia; i++ ) {
                    letra = caracteres[ rdn.Next( longitud ) ];
                    contraseniaAleatoria += letra.ToString();
                }

                txtContrato.Text = "CO" + contraseniaAleatoria;

                contratos.Insertar( txtContrato.Text, dtpFechaInicio.Value, dtpFechaFinal.Value, cmbMoneda.SelectedValue.ToString(), "Aprobado", int.Parse( txtClienteID.Text ), UserLoginCache.empleadoID, cmbTipo.Text, int.Parse( txtCantidadCuotas.Text ), txtComentario.Text, swtRenovacion.Checked );
                List<DetalleContratosDA> objectDetailList = new List<DetalleContratosDA>();

                foreach ( DataGridViewRow dgvRow in dgDatos.Rows ) {
                    var detail = new DetalleContratosDA() {
                        Contrato_Id = txtContrato.Text,
                        Producto_Id = Convert.ToInt32( dgvRow.Cells[ 0 ].Value ),
                        Cantidad = Convert.ToInt32( dgvRow.Cells[ 2 ].Value ),
                        Impuesto = Convert.ToDouble( dgvRow.Cells[ 6 ].Value ),
                        Descuento = Convert.ToDouble( dgvRow.Cells[ 7 ].Value )
                    };
                    objectDetailList.Add( detail );
                }

                DetalleContratosDA detailModel = new DetalleContratosDA();
                detailModel.insertData( objectDetailList );
                MessageBox.Show( "Datos gurdados con éxito", "ADCON", MessageBoxButtons.OK, MessageBoxIcon.Information );
                LimpiarContratros();
            } catch ( Exception ex ) {
                MessageBox.Show( ex.Message, "ADCON", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
        }

        private void btnMostrarContratos_Click( object sender, EventArgs e ) {
            //Form formBG = new Form();
            using ( frmMostrarContratos frm = new frmMostrarContratos() ) {
                //formBG.StartPosition = FormStartPosition.Manual;
                //formBG.FormBorderStyle = FormBorderStyle.None;
                //formBG.Opacity = .70d;
                //formBG.BackColor = Color.Black;
                //formBG.WindowState = FormWindowState.Maximized;
                //formBG.TopMost = true;
                //formBG.Location = this.Location;
                //formBG.ShowInTaskbar = false;
                //formBG.Show();

                //frm.Owner = formBG;
                AddOwnedForm( frm );
                frm.ShowDialog();

                //formBG.Dispose();
            }
        }
    }
}