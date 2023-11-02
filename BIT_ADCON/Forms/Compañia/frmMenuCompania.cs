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

using Clases;

using Domain.CrudsD;

using Guna.UI2.WinForms;

namespace BIT_ADCON.Forms.Compañia {
    public partial class frmMenuCompania : Form {
        MetodosListados metodos = new MetodosListados();
        EmpleadoD empleados = new EmpleadoD();
        UsuariosD usuarios = new UsuariosD();
        TipoUsuarioD tipos = new TipoUsuarioD();
        CargosD cargos = new CargosD();

        bool isEdit = false;
        public frmMenuCompania() {
            InitializeComponent();
        }

        private void frmMenuCompania_Load( object sender, EventArgs e ) {
            cmbCargo.StartIndex = 0;
            metodos.MostrarEmpleados(dgDatosEmpleados);
            metodos.MostrarUsuarios(dgDatosUsuarios);
            metodos.MostrarCargos(dgDatosCargos);
            metodos.MostrarTipoUsuario(dgDatosTipo);
            metodos.ListarCargos( cmbCargo );
            metodos.ListarTipoU( cmbTipoUsuario );
        }

        private void CargarEmpleados() {
            txtEmpleadoID.Text = dgDatosEmpleados.CurrentRow.Cells[ 0 ].Value.ToString();
            txtNombre.Text = dgDatosEmpleados.CurrentRow.Cells[ 1 ].Value.ToString();
            txtApellido.Text = dgDatosEmpleados.CurrentRow.Cells[ 2 ].Value.ToString();
            cmbCargo.Text = dgDatosEmpleados.CurrentRow.Cells[ 4 ].Value.ToString();
            txtDireccion.Text = dgDatosEmpleados.CurrentRow.Cells[ 5 ].Value.ToString();
            txtCorreo.Text = dgDatosEmpleados.CurrentRow.Cells[ 6 ].Value.ToString();
            btnEliminarEmpleado.Enabled = true;
        }

        private void CargarCargos() {
            txtCargoID.Text = dgDatosCargos.CurrentRow.Cells[0].Value.ToString();
            txtCargo.Text = dgDatosCargos.CurrentRow.Cells[1].Value.ToString();
            txtDescripcion.Text = dgDatosCargos.CurrentRow.Cells[2].Value.ToString();
            btnEliminarCargos.Enabled = true;
        }

        private void CargarUsuarios() {
            txtUsuarioID.Text = dgDatosCargos.CurrentRow.Cells[ 0 ].Value.ToString();
            txtEmpleadoIDUser.Text = dgDatosCargos.CurrentRow.Cells[ 1 ].Value.ToString();
            txtEmpleado.Text = dgDatosCargos.CurrentRow.Cells[ 2 ].Value.ToString();
            txtUsuario.Text = dgDatosCargos.CurrentRow.Cells[ 3 ].Value.ToString();
            txtContrasenia.Text = dgDatosCargos.CurrentRow.Cells[ 4 ].Value.ToString();
            cmbTipoUsuario.Text = dgDatosCargos.CurrentRow.Cells[ 5 ].Value.ToString();
            btnEliminarUsuario.Enabled = true;
        }

        private void CargarTipoUsuario() {
            txtNivelID.Text = dgDatosCargos.CurrentRow.Cells[ 0 ].Value.ToString();
            txtNivelUsuario.Text = dgDatosCargos.CurrentRow.Cells[ 1 ].Value.ToString();
            btnEliminarTipo.Enabled = true;
        }

        private void LimpiarEmpleados() {
            txtEmpleadoID.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            cmbCargo.StartIndex = 0;
            txtApellido.Clear();
            txtDireccion.Clear();
            txtCorreo.Clear();
            btnEliminarCargos.Enabled = false;
        }

        private void LimpiarCargos() {
            txtCargoID.Clear();
            txtCargo.Clear();
            txtDescripcion.Clear();
            btnEliminarCargos.Enabled = false;
        }

        private void LimpiarUsuario() {
            txtUsuarioID.Clear();
            txtEmpleadoIDUser.Clear();
            txtEmpleado.Clear();
            txtUsuario.Clear();
            txtContrasenia.Clear();
            cmbTipoUsuario.StartIndex = 0;
            btnEliminarUsuario.Enabled = false;
        }

        private void LimpiarTipoUsuarios() {
            txtNivelID.Clear();
            txtNivelUsuario.Clear();
            btnEliminarTipo.Enabled = false;
        }

        //Empleado
        private void btnGuardarEmpleado_Click( object sender, EventArgs e ) {
            try {
                if ( isEdit == false ) {
                    empleados.Insertar( txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtCorreo.Text, int.Parse(cmbCargo.SelectedValue.ToString()) );
                    MessageBox.Show( "Datos guardados con éxito", "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    metodos.MostrarEmpleados( dgDatosEmpleados );
                    LimpiarEmpleados();
                } else {
                    empleados.Actualizar( int.Parse( txtEmpleadoID.Text ), txtNombre.Text, txtApellido.Text, txtDireccion.Text, txtCorreo.Text, int.Parse( cmbCargo.SelectedValue.ToString() ) );
                    MessageBox.Show( "Datos actualizados con éxito", "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    metodos.MostrarEmpleados( dgDatosEmpleados );
                    LimpiarEmpleados();
                }
            } catch ( Exception ex ) {
                MessageBox.Show( ex.Message, "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
        }

        private void btnEliminarEmpleado_Click( object sender, EventArgs e ) {
            try {
                cargos.Eliminar( int.Parse( txtEmpleadoID.Text ) );
                MessageBox.Show( "Datos eliminados con éxito", "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
                metodos.MostrarEmpleados( dgDatosEmpleados );
                LimpiarEmpleados();
            } catch ( Exception ex ) {
                MessageBox.Show( ex.Message, "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
        }

        private void dgDatosEmpleados_CellClick( object sender, DataGridViewCellEventArgs e ) {
            CargarEmpleados();
            isEdit = true;
        }

        //Cargos
        private void btnGuardarCargos_Click( object sender, EventArgs e ) {
            try {
                if ( isEdit == false ) {
                    cargos.Insertar( txtCargo.Text, txtDescripcion.Text );
                    MessageBox.Show( "Datos guardados con éxito", "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    metodos.MostrarCargos( dgDatosCargos );
                    LimpiarCargos();
                } else {
                    cargos.Actualizar( int.Parse( txtCargoID.Text ), txtCargo.Text, txtDescripcion.Text );
                    MessageBox.Show( "Datos actualizados con éxito", "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    metodos.MostrarCargos( dgDatosCargos );
                    LimpiarCargos();
                }
            } catch ( Exception ex ) {
                MessageBox.Show( ex.Message, "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
        }

        private void btnEliminarCargos_Click( object sender, EventArgs e ) {
            try {
                cargos.Eliminar( int.Parse( txtCargoID.Text ) );
                MessageBox.Show( "Datos eliminados con éxito", "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
                metodos.MostrarCargos( dgDatosCargos );
                LimpiarCargos();
            } catch ( Exception ex ) {
                MessageBox.Show( ex.Message, "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
        }

        private void dgDatosCargos_Click( object sender, EventArgs e ) {
            CargarCargos();
            isEdit = true;
        }

        //Usuarios
        private void btnGuardarUsuario_Click( object sender, EventArgs e ) {
            //try {
                if ( isEdit == false ) {
                    usuarios.Insertar( int.Parse( txtEmpleadoIDUser.Text ), txtUsuario.Text, txtContrasenia.Text, int.Parse(cmbTipoUsuario.SelectedValue.ToString()) );
                    MessageBox.Show( "Datos gurdados con éxito", "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    metodos.MostrarUsuarios( dgDatosUsuarios );
                    LimpiarUsuario();
                } else {
                    usuarios.Actualizar( int.Parse( txtUsuarioID.Text ), int.Parse( txtEmpleadoIDUser.Text ), txtUsuario.Text, txtContrasenia.Text, int.Parse(cmbTipoUsuario.ValueMember.ToString()) );
                    MessageBox.Show( "Datos actualizados con éxito", "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    metodos.MostrarUsuarios( dgDatosUsuarios );
                    LimpiarUsuario();
                }
            //} catch ( Exception ex ) {
            //    MessageBox.Show( ex.Message, "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
            //}
        }

        private void btnEliminarUsuario_Click( object sender, EventArgs e ) {
            try {
                cargos.Eliminar( int.Parse( txtUsuarioID.Text ) );
                MessageBox.Show( "Datos eliminados con éxito", "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
                metodos.MostrarUsuarios( dgDatosUsuarios );
                LimpiarUsuario();
            } catch ( Exception ex ) {
                MessageBox.Show( ex.Message, "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
        }

        private void btnBuscarEmpleado_Click( object sender, EventArgs e ) {
            frmEmpleados frm = new frmEmpleados();
            AddOwnedForm( frm );
            frm.ShowDialog();
        }

        private void dgDatosUsuarios_Click( object sender, EventArgs e ) {
            CargarUsuarios();
            isEdit = true;
        }

        //TipoUsuario
        private void btnGuardarTipo_Click( object sender, EventArgs e ) {
            try {
                if ( isEdit == false ) {
                    tipos.Insertar( txtNivelUsuario.Text );
                    MessageBox.Show( "Datos gurdados con éxito", "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    metodos.MostrarTipoUsuario ( dgDatosTipo );
                    LimpiarTipoUsuarios();
                } else {
                    tipos.Actualizar( int.Parse( txtNivelID.Text ), txtNivelUsuario.Text );
                    MessageBox.Show( "Datos actualizados con éxito", "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    metodos.MostrarTipoUsuario( dgDatosTipo );
                    LimpiarTipoUsuarios();
                }
            } catch ( Exception ex ) {
                MessageBox.Show( ex.Message, "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
        }

        private void btnEliminarTipo_Click( object sender, EventArgs e ) {
            try {
                tipos.Eliminar( int.Parse( txtNivelID.Text ) );
                MessageBox.Show( "Datos eliminados con éxito", "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
                metodos.MostrarTipoUsuario( dgDatosTipo );
                LimpiarTipoUsuarios();
            } catch ( Exception ex ) {
                MessageBox.Show( ex.Message, "ADCOM", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
        }

        private void dgDatosTipo_Click( object sender, EventArgs e ) {
            CargarTipoUsuario();
            isEdit = true;
        }

        private void dgDatosEmpleados_CellDoubleClick( object sender, DataGridViewCellEventArgs e ) {
            
        }

        private void tabPage1_Click( object sender, EventArgs e ) {

        }
    }
}
