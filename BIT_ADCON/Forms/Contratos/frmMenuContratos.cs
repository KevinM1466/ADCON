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

using Guna.UI2.WinForms;

namespace BIT_ADCON.Forms.Contratos {
    public partial class frmMenuContratos : Form {
        private Panel leftBorderBtn;
        public Form currentChildForm;
        MetodosListados metodos = new MetodosListados();
        ClientesD clientes = new ClientesD();
        MonedasD monedas = new MonedasD();
        PaisesD paises = new PaisesD();
        bool isEdit = false;

        public frmMenuContratos() {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size( 7, 60 );
            tabPage1.Controls.Add( leftBorderBtn );

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void frmMenuContratos_Load( object sender, EventArgs e ) {
            cmbPais.StartIndex = 0;
            metodos.ListarPaises(cmbPais);
            metodos.ListarPaises(cmbPaisCiudad);
            metodos.ListarCiudades( cmbCiudad, int.Parse(cmbPais.SelectedValue.ToString()) );
            metodos.MostrarClientes(dgDatos);
            //metodos.MostrarMonedas(dgDatosMonedas);
            metodos.MostrarPaises(dgDatosPaises);
            metodos.MostrarCiudades(dgDatosCiudades);
            OpenChildForm( new frmContratos() );
        }

        private void OpenChildForm( Form childForm ) {
            if ( currentChildForm != null ) {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            childForm.FormBorderStyle = FormBorderStyle.None;
            tabPage1.Controls.Add( childForm );
            tabPage1.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        private void CargarClientes() {
            txtCodigo.Text = dgDatos.CurrentRow.Cells[ 0 ].Value.ToString();
            txtCompania.Text = dgDatos.CurrentRow.Cells[ 1 ].Value.ToString();
            txtRTN.Text = dgDatos.CurrentRow.Cells[ 2 ].Value.ToString();
            txtDireccion.Text = dgDatos.CurrentRow.Cells[ 3 ].Value.ToString();
            cmbPais.Text = dgDatos.CurrentRow.Cells[ 4 ].Value.ToString();
            txtTelefono.Text = dgDatos.CurrentRow.Cells[ 5 ].Value.ToString();
            txtPaginaWeb.Text = dgDatos.CurrentRow.Cells[ 6 ].Value.ToString();
            txtCorreo.Text = dgDatos.CurrentRow.Cells[ 7 ].Value.ToString();
            txtRepresentante.Text = dgDatos.CurrentRow.Cells[ 8 ].Value.ToString();
            txtPuesto.Text = dgDatos.CurrentRow.Cells[ 9 ].Value.ToString();
            btnEliminar.Enabled = true;
        }

        //private void CargarMonedas() {
        //    txtCodigoMoneda.Text = dgDatosMonedas.CurrentRow.Cells[ 0 ].Value.ToString();
        //    txtMoneda.Text = dgDatosMonedas.CurrentRow.Cells[ 1 ].Value.ToString();
        //    txtAbrev.Text = dgDatosMonedas.CurrentRow.Cells[ 2 ].Value.ToString();
        //    cmbSimbolo.Text = dgDatosMonedas.CurrentRow.Cells[ 3 ].Value.ToString();
        //    btnEliminarMoneda.Enabled = true;
        //}

        private void CargarPaises() {
            txtPaisID.Text = dgDatosPaises.CurrentRow.Cells[ 0 ].Value.ToString();
            txtPais.Text = dgDatosPaises.CurrentRow.Cells[ 1 ].Value.ToString();
            txtISO.Text = dgDatosPaises.CurrentRow.Cells[ 2 ].Value.ToString();
            btnEliminarPaises.Enabled = true;
        }

        private void CargarCiudades() {
            txtCiudadID.Text = dgDatosCiudades.CurrentRow.Cells[ 0 ].Value.ToString();
            txtCiudades.Text = dgDatosCiudades.CurrentRow.Cells[ 1 ].Value.ToString();
            cmbPaisCiudad.Text = dgDatosCiudades.CurrentRow.Cells[ 2 ].Value.ToString();
            btnEliminarPaises.Enabled = true;
        }

        private void LimpiarClientes() {
            txtCodigo.Clear();
            txtCompania.Clear();
            txtRTN.Clear();
            txtDireccion.Clear();
            cmbPais.SelectedIndex = 0;
            txtTelefono.Clear();
            txtPaginaWeb.Clear();
            txtCorreo.Clear();
            txtRepresentante.Clear();
            txtPuesto.Clear();
            isEdit = false;
            btnEliminar.Enabled = false;
        }

        //private void LimpiarMonedas() {
        //    txtCodigoMoneda.Clear();
        //    txtMoneda.Clear();
        //    txtAbrev.Clear();
        //    cmbSimbolo.SelectedIndex = 0;
        //    isEdit = false;
        //    btnEliminarMoneda.Enabled = false;
        //    txtCodigoMoneda.Enabled = true;
        //}

        private void LimpiarPaises() {
            txtPaisID.Clear();
            txtPais.Clear();
            txtISO.Clear();
            isEdit = false;
            btnEliminarPaises.Enabled = false;
        }

        private void LimpiarCiudades() {
            txtCiudadID.Clear();
            txtCiudades.Clear();
            cmbPaisCiudad.StartIndex = 0;
            isEdit = false;
            btnEliminarPaises.Enabled = false;
        }

        private void cmbPais_SelectedIndexChanged( object sender, EventArgs e ) {
            try {
                if ( cmbPais.SelectedValue.ToString() != null ) {
                    metodos.ListarCiudades( cmbCiudad, int.Parse( cmbPais.SelectedValue.ToString() ) );
                }
            } catch ( Exception ex ) {
                //MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click( object sender, EventArgs e ) {
            try {
                if ( isEdit == false ) {
                    clientes.Insertar( txtCompania.Text, txtRTN.Text, txtDireccion.Text, int.Parse( cmbPais.SelectedValue.ToString() ), txtTelefono.Text, txtPaginaWeb.Text, txtCorreo.Text, txtRepresentante.Text, txtPuesto.Text );
                    MessageBox.Show( "Datos gurdados con éxito", "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    metodos.MostrarClientes( dgDatos );
                    LimpiarClientes();
                } else {
                    clientes.Actualizar(int.Parse(txtCodigo.Text), txtCompania.Text, txtRTN.Text, txtDireccion.Text, int.Parse( cmbPais.SelectedValue.ToString() ), txtTelefono.Text, txtPaginaWeb.Text, txtCorreo.Text, txtRepresentante.Text, txtPuesto.Text);
                    MessageBox.Show( "Datos actualizados con éxito", "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    metodos.MostrarClientes( dgDatos );
                    LimpiarClientes();
                }
            } catch ( Exception ex ) {
                MessageBox.Show( ex.Message, "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
        }

        private void dgDatos_CellClick( object sender, DataGridViewCellEventArgs e ) {
            CargarClientes();
            isEdit = true;
        }

        private void btnEliminar_Click( object sender, EventArgs e ) {
            try {
                clientes.Eliminar(int.Parse(txtCodigo.Text));
                MessageBox.Show( "Datos eliminados con éxito", "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
                metodos.MostrarClientes( dgDatos );
                LimpiarClientes();
            } catch ( Exception ex ) {
                MessageBox.Show( ex.Message, "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
        }

        //Monedas

        //private void btnGuardarMonedas_Click( object sender, EventArgs e ) {
        //    try {
        //        if ( isEdit == false ) {
        //            monedas.Insertar( txtCodigoMoneda.Text, txtMoneda.Text, txtAbrev.Text, cmbSimbolo.Text );
        //            MessageBox.Show( "Datos gurdados con éxito", "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
        //            metodos.MostrarMonedas( dgDatosMonedas );
        //            LimpiarMonedas();
        //        } else {
        //            monedas.Actualizar( txtCodigoMoneda.Text, txtMoneda.Text, txtAbrev.Text, cmbSimbolo.Text );
        //            MessageBox.Show( "Datos actualizados con éxito", "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
        //            metodos.MostrarMonedas( dgDatosMonedas );
        //            LimpiarMonedas();
        //        }
        //    } catch ( Exception ex ) {
        //        MessageBox.Show( ex.Message, "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
        //    }
        //}

        //private void dgDatosMonedas_CellClick( object sender, DataGridViewCellEventArgs e ) {
        //    CargarMonedas();
        //    txtCodigoMoneda.Enabled = false;
        //    isEdit = true;
        //}

        //private void btnEliminarMoneda_Click( object sender, EventArgs e ) {
        //    try {
        //        monedas.Eliminar( txtCodigoMoneda.Text );
        //        MessageBox.Show( "Datos eliminados con éxito", "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
        //        metodos.MostrarMonedas( dgDatosMonedas );
        //        LimpiarMonedas();
        //    } catch ( Exception ex ) {
        //        MessageBox.Show( ex.Message, "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
        //    }
        //}

        //Paises
        private void btnGuardarPais_Click( object sender, EventArgs e ) {
            try {
                if ( isEdit == false ) {
                    paises.Insertar( txtPais.Text, txtISO.Text );
                    MessageBox.Show( "Datos gurdados con éxito", "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    metodos.MostrarPaises( dgDatosPaises );
                    LimpiarPaises();
                } else {
                    paises.Actualizar( int.Parse(txtPaisID.Text), txtPais.Text, txtISO.Text );
                    MessageBox.Show( "Datos actualizados con éxito", "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    metodos.MostrarPaises( dgDatosPaises );
                    LimpiarPaises();
                }
            } catch ( Exception ex ) {
                MessageBox.Show( ex.Message, "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
        }

        private void btnEliminarPaises_Click( object sender, EventArgs e ) {
            try {
                paises.Eliminar( int.Parse( txtPaisID.Text ) );
                MessageBox.Show( "Datos eliminados con éxito", "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
                metodos.MostrarPaises( dgDatosPaises );
                LimpiarPaises();
            } catch ( Exception ex ) {
                MessageBox.Show( ex.Message, "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
        }

        private void dgDatosPaises_CellClick( object sender, DataGridViewCellEventArgs e ) {
            CargarPaises();
            isEdit = true;
        }

        private void guna2TabControl1_Click( object sender, EventArgs e ) {
            OpenChildForm( new frmContratos() );
        }

        private void tabPage1_Click( object sender, EventArgs e ) {

        }

        //Ciudades
        private void btnGuardarCiudades_Click( object sender, EventArgs e ) {
            
        }

        private void dgDatosCiudades_CellClick( object sender, DataGridViewCellEventArgs e ) {

        }

        private void btnEliminarCiudades_Click( object sender, EventArgs e ) {
            try {
                paises.EliminarCiudades( int.Parse( txtCiudadID.Text ) );
                MessageBox.Show( "Datos eliminados con éxito", "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
                metodos. MostrarCiudades( dgDatosCiudades );
                LimpiarCiudades();
            } catch ( Exception ex ) {
                MessageBox.Show( ex.Message, "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
        }

        private void dgDatosCiudades_CellDoubleClick( object sender, DataGridViewCellEventArgs e ) {
            CargarCiudades();
            isEdit = true;
        }

        private void txtCodigoCiudad_TextChanged( object sender, EventArgs e ) {

        }

        private void dgDatosCiudades_CellClick_1( object sender, DataGridViewCellEventArgs e ) {
            CargarCiudades();
            isEdit = true;
        }

        private void btnGuardarCiudad_Click( object sender, EventArgs e ) {
            try {
                if ( isEdit == false ) {
                    paises.InsertarCiudades( txtCiudades.Text, int.Parse( cmbPaisCiudad.SelectedValue.ToString() ) );
                    MessageBox.Show( "Datos gurdados con éxito", "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    metodos.MostrarCiudades( dgDatosCiudades );
                    LimpiarCiudades();
                } else {
                    paises.ActualizarCiudades( int.Parse( dgDatosCiudades.CurrentRow.Cells[ 0 ].Value.ToString() ), txtCiudades.Text, int.Parse( cmbPaisCiudad.SelectedValue.ToString() ) );
                    MessageBox.Show( "Datos actualizados con éxito", "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    metodos.MostrarCiudades( dgDatosCiudades );
                    LimpiarCiudades();
                }
            } catch ( Exception ex ) {
                MessageBox.Show( ex.Message, "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
        }
    }
}
