using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Clases;

using Domain.CrudsD;

namespace BIT_ADCON.Forms.Productos {
    public partial class frmMenuProductos : Form {
        MetodosListados metodos = new MetodosListados();
        ProductosD productos = new ProductosD();
        bool isEdit = false;
        public frmMenuProductos() {
            InitializeComponent();
        }

        private void frmMenuProductos_Load( object sender, EventArgs e ) {
            metodos.MostrarProductos( dgDatosProductos );
        }

        private void Cargar() {
            txtCodigo.Text = dgDatosProductos.CurrentRow.Cells[ 0 ].Value.ToString();
            txtProducto.Text = dgDatosProductos.CurrentRow.Cells[ 1 ].Value.ToString();
            txtMarca.Text = dgDatosProductos.CurrentRow.Cells[ 2 ].Value.ToString();
            txtModelo.Text = dgDatosProductos.CurrentRow.Cells[ 3 ].Value.ToString();
            txtVersion.Text = dgDatosProductos.CurrentRow.Cells[ 4 ].Value.ToString();
            txtPrecio.Text = dgDatosProductos.CurrentRow.Cells[ 5 ].Value.ToString();
            btnEliminarProductos.Enabled = true;
        }

        private void Limpiar() {
            txtCodigo.Clear();
            txtProducto.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtVersion.Clear();
            txtPrecio.Clear();
            isEdit = false;
            btnEliminarProductos.Enabled = false;
        }

        private void btnGuardarProductos_Click( object sender, EventArgs e ) {
            try {
                if ( isEdit == false ) {
                    productos.Insertar( txtProducto.Text, txtMarca.Text, txtModelo.Text, txtVersion.Text, decimal.Parse( txtPrecio.Text ) );
                    MessageBox.Show( "Datos gurdados con éxito", "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    metodos.MostrarProductos( dgDatosProductos );
                    Limpiar();
                } else {
                    productos.Actualizar( int.Parse( txtCodigo.Text ), txtProducto.Text, txtMarca.Text, txtModelo.Text, txtVersion.Text, decimal.Parse( txtPrecio.Text ) );
                    MessageBox.Show( "Datos actualizados con éxito", "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    metodos.MostrarProductos( dgDatosProductos );
                    Limpiar();
                }
            } catch ( Exception ex ) {
                MessageBox.Show( ex.Message, "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
        }

        private void btnEliminarProductos_Click( object sender, EventArgs e ) {
            try {
                productos.Eliminar( int.Parse( txtCodigo.Text ) );
                MessageBox.Show( "Datos eliminados con éxito", "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
                metodos.MostrarProductos( dgDatosProductos );
                Limpiar();
            } catch ( Exception ex ) {
                MessageBox.Show( ex.Message, "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
        }

        private void dgDatosProductos_CellClick( object sender, DataGridViewCellEventArgs e ) {
            Cargar();
            isEdit = true;
        }
    }
}
