using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Domain;
using Domain.CrudsD;

using Guna.UI2.WinForms;

namespace Clases {
    public class MetodosListados {
        //Mostrar en DataGrids
        Font prFont = new Font( "Poppins", 12, FontStyle.Bold );

        public void MostrarClientes( DataGridView dgDatos ) {
            ClientesD objeto = new ClientesD();
            dgDatos.DataSource = objeto.Mostrar();
            dgDatos.Columns[ 0 ].Visible = false;

            dgDatos.Columns[ 1 ].HeaderText = "Compañia";
            dgDatos.Columns[ 2 ].HeaderText = "RTN";
            dgDatos.Columns[ 3 ].HeaderText = "Direccion";
            dgDatos.Columns[ 4 ].HeaderText = "País";
            dgDatos.Columns[ 5 ].HeaderText = "Telefono";
            dgDatos.Columns[ 6 ].HeaderText = "Página Web";
            dgDatos.Columns[ 7 ].HeaderText = "Correo";
            dgDatos.Columns[ 8 ].HeaderText = "Representante";
            dgDatos.Columns[ 9 ].HeaderText = "Puesto";

            dgDatos.Columns[ 1 ].HeaderCell.Style.Font = prFont;
            dgDatos.Columns[ 2 ].HeaderCell.Style.Font = prFont;
            dgDatos.Columns[ 3 ].HeaderCell.Style.Font = prFont;
            dgDatos.Columns[ 4 ].HeaderCell.Style.Font = prFont;
            dgDatos.Columns[ 5 ].HeaderCell.Style.Font = prFont;
            dgDatos.Columns[ 6 ].HeaderCell.Style.Font = prFont;
            dgDatos.Columns[ 7 ].HeaderCell.Style.Font = prFont;
            dgDatos.Columns[ 8 ].HeaderCell.Style.Font = prFont;
            dgDatos.Columns[ 9 ].HeaderCell.Style.Font = prFont;
        }

        public void MostrarMonedas( DataGridView dgDatos ) {
            MonedasD objeto = new MonedasD();
            dgDatos.DataSource = objeto.Mostrar();
            dgDatos.Columns[ 0 ].HeaderText = "Codigo";
            dgDatos.Columns[ 1 ].HeaderText = "Moneda";
            dgDatos.Columns[ 2 ].HeaderText = "Abreviatura";
            dgDatos.Columns[ 3 ].HeaderText = "Simbolo";

            //dgDatos.Columns[ 1 ].HeaderCell.Style.Font = prFont;
            //dgDatos.Columns[ 2 ].HeaderCell.Style.Font = prFont;
            //dgDatos.Columns[ 3 ].HeaderCell.Style.Font = prFont;
            //dgDatos.Columns[ 4 ].HeaderCell.Style.Font = prFont;
        }

        public void MostrarPaises( DataGridView dgDatos ) {
            PaisesD objeto = new PaisesD();
            dgDatos.DataSource = objeto.Mostrar();
            dgDatos.Columns[ 0 ].HeaderText = "Codigo";
            dgDatos.Columns[ 1 ].HeaderText = "Pais";
            dgDatos.Columns[ 2 ].HeaderText = "Codigo ISO";

            //dgDatos.Columns[ 1 ].HeaderCell.Style.Font = prFont;
            //dgDatos.Columns[ 2 ].HeaderCell.Style.Font = prFont;
            //dgDatos.Columns[ 3 ].HeaderCell.Style.Font = prFont;
            //dgDatos.Columns[ 4 ].HeaderCell.Style.Font = prFont;
        }

        public void MostrarCiudades( DataGridView dgDatos ) {
            PaisesD objeto = new PaisesD();
            dgDatos.DataSource = objeto.MostrarCiudades();
            dgDatos.Columns[ 0 ].HeaderText = "Codigo";
            dgDatos.Columns[ 1 ].HeaderText = "Ciudad";
            dgDatos.Columns[ 3 ].HeaderText = "Pais";

            dgDatos.Columns[ 2 ].Visible = false;
        }

        public void MostrarUsuariosClientes( DataGridView dgDatos ) {
            UsuariosClientesD objeto = new UsuariosClientesD();
            dgDatos.DataSource = objeto.Mostrar();
            dgDatos.Columns[ 0 ].HeaderText = "Codigo";
            dgDatos.Columns[ 1 ].HeaderText = "Contrato #";
            dgDatos.Columns[ 2 ].HeaderText = "Nombre Completo";
            dgDatos.Columns[ 3 ].HeaderText = "Direccion";
            dgDatos.Columns[ 4 ].HeaderText = "Telefono";
            dgDatos.Columns[ 5 ].HeaderText = "Correo";
            dgDatos.Columns[ 6 ].HeaderText = "Puesto";

            //dgDatos.Columns[ 1 ].HeaderCell.Style.Font = prFont;
            //dgDatos.Columns[ 2 ].HeaderCell.Style.Font = prFont;
            //dgDatos.Columns[ 3 ].HeaderCell.Style.Font = prFont;
            //dgDatos.Columns[ 4 ].HeaderCell.Style.Font = prFont;
        }

        public void MostrarProductos( DataGridView dgDatos ) {
            ProductosD objeto = new ProductosD();
            dgDatos.DataSource = objeto.Mostrar();
            dgDatos.Columns[ 0 ].HeaderText = "Codigo";
            dgDatos.Columns[ 1 ].HeaderText = "Producto";
            dgDatos.Columns[ 2 ].HeaderText = "Marca";
            dgDatos.Columns[ 3 ].HeaderText = "Modelo";
            dgDatos.Columns[ 4 ].HeaderText = "Version";
            dgDatos.Columns[ 5 ].HeaderText = "Precio";

            //dgDatos.Columns[ 1 ].HeaderCell.Style.Font = prFont;
            //dgDatos.Columns[ 2 ].HeaderCell.Style.Font = prFont;
            //dgDatos.Columns[ 3 ].HeaderCell.Style.Font = prFont;
            //dgDatos.Columns[ 4 ].HeaderCell.Style.Font = prFont;
        }

        public void MostrarCargos( DataGridView dgDatos ) {
            CargosD objeto = new CargosD();
            dgDatos.DataSource = objeto.Mostrar();
            dgDatos.Columns[ 0 ].HeaderText = "Codigo";
            dgDatos.Columns[ 1 ].HeaderText = "Cargo";
            dgDatos.Columns[ 2 ].HeaderText = "Descripción";

            //dgDatos.Columns[ 1 ].HeaderCell.Style.Font = prFont;
            //dgDatos.Columns[ 2 ].HeaderCell.Style.Font = prFont;
            //dgDatos.Columns[ 3 ].HeaderCell.Style.Font = prFont;
            //dgDatos.Columns[ 4 ].HeaderCell.Style.Font = prFont;
        }

        public void MostrarTipoUsuario( DataGridView dgDatos ) {
            TipoUsuarioD objeto = new TipoUsuarioD();
            dgDatos.DataSource = objeto.Mostrar();
            dgDatos.Columns[ 0 ].HeaderText = "Codigo";
            dgDatos.Columns[ 1 ].HeaderText = "Nivel de Usuario";

            //dgDatos.Columns[ 1 ].HeaderCell.Style.Font = prFont;
            //dgDatos.Columns[ 2 ].HeaderCell.Style.Font = prFont;
            //dgDatos.Columns[ 3 ].HeaderCell.Style.Font = prFont;
            //dgDatos.Columns[ 4 ].HeaderCell.Style.Font = prFont;
        }

        public void MostrarUsuarios( DataGridView dgDatos ) {
            UsuariosD objeto = new UsuariosD();
            dgDatos.DataSource = objeto.Mostrar();
            dgDatos.Columns[ 0 ].HeaderText = "Codigo";
            dgDatos.Columns[ 1 ].HeaderText = "Codigo";
            dgDatos.Columns[ 2 ].HeaderText = "Nombres";
            dgDatos.Columns[ 3 ].HeaderText = "Apellidos";
            dgDatos.Columns[ 4 ].HeaderText = "Contraseña";
            dgDatos.Columns[ 5 ].HeaderText = "Tipo de Usuario";

            dgDatos.Columns[ 0 ].Visible = false;
            //dgDatos.Columns[ 1 ].HeaderCell.Style.Font = prFont;
            //dgDatos.Columns[ 2 ].HeaderCell.Style.Font = prFont;
            //dgDatos.Columns[ 3 ].HeaderCell.Style.Font = prFont;
            //dgDatos.Columns[ 4 ].HeaderCell.Style.Font = prFont;
        }

        public void MostrarEmpleados( DataGridView dgDatos ) {
            EmpleadoD objeto = new EmpleadoD();
            dgDatos.DataSource = objeto.Mostrar();
            dgDatos.Columns[ 0 ].HeaderText = "Codigo";
            dgDatos.Columns[ 1 ].HeaderText = "Nombres";
            dgDatos.Columns[ 2 ].HeaderText = "Apellidos";
            dgDatos.Columns[ 3 ].HeaderText = "CargoID";
            dgDatos.Columns[ 4 ].HeaderText = "Cargo";
            dgDatos.Columns[ 5 ].HeaderText = "Direccion";
            dgDatos.Columns[ 6 ].HeaderText = "Correo";

            dgDatos.Columns[ 0 ].Visible = false;
            dgDatos.Columns[ 3 ].Visible = false;

            //dgDatos.Columns[ 1 ].HeaderCell.Style.Font = prFont;
            //dgDatos.Columns[ 2 ].HeaderCell.Style.Font = prFont;
            //dgDatos.Columns[ 3 ].HeaderCell.Style.Font = prFont;
            //dgDatos.Columns[ 4 ].HeaderCell.Style.Font = prFont;
        }

        public void MostrarContratos( DataGridView dgDatos) {
            ContratosD objeto = new ContratosD();
            dgDatos.DataSource = objeto.Mostrar();
            dgDatos.Columns[ 0 ].HeaderText = "id";
            dgDatos.Columns[ 1 ].HeaderText = "Producto";
            dgDatos.Columns[ 2 ].HeaderText = "Cantidad";
            dgDatos.Columns[ 3 ].HeaderText = "Precio";
            dgDatos.Columns[ 4 ].HeaderText = "Comentarios";
            dgDatos.Columns[ 5 ].HeaderText = "Impuesto";
            dgDatos.Columns[ 6 ].HeaderText = "Descuento";
            dgDatos.Columns[ 7 ].HeaderText = "Subtotal";

            dgDatos.Columns[ 0 ].Visible = false;
            dgDatos.Columns[ 5 ].Visible = false;
            dgDatos.Columns[ 6 ].Visible = false;

            //dgDatos.Columns[ 1 ].HeaderCell.Style.Font = prFont;
            //dgDatos.Columns[ 2 ].HeaderCell.Style.Font = prFont;
            //dgDatos.Columns[ 3 ].HeaderCell.Style.Font = prFont;
            //dgDatos.Columns[ 4 ].HeaderCell.Style.Font = prFont;
        }

        //Mostrar ComboBoxs
        public void ListarPaises( Guna2ComboBox cmbDatos ) {
            ComboBoxD objeto = new ComboBoxD();
            cmbDatos.DataSource = objeto.ListarPaises();
            cmbDatos.DisplayMember = "Nombre_Pais";
            cmbDatos.ValueMember = "Pais_ID";
        }

        public void ListarCiudades( Guna2ComboBox cmbDatos, int pais ) {
            ComboBoxD objeto = new ComboBoxD();
            cmbDatos.DataSource = objeto.ListarCiudades( pais );
            cmbDatos.DisplayMember = "nombreCiudad";
            cmbDatos.ValueMember = "ciudadID";
        }

        public void ListarCargos( Guna2ComboBox cmbDatos ) {
            ComboBoxD objeto = new ComboBoxD();
            cmbDatos.DataSource = objeto.ListarCargos();
            cmbDatos.DisplayMember = "Nombre_Cargo";
            cmbDatos.ValueMember = "Cargo_Id";
        }

        public void ListarTipoU( Guna2ComboBox cmbDatos ) {
            ComboBoxD objeto = new ComboBoxD();
            cmbDatos.DataSource = objeto.ListarTipoU();
            cmbDatos.DisplayMember = "Nivel_Usuario";
            cmbDatos.ValueMember = "Tipo_Usuario_Id";
        }

        public void ListarMonedas( Guna2ComboBox cmbDatos ) {
            ComboBoxD objeto = new ComboBoxD();
            cmbDatos.DataSource = objeto.ListarMonedas();
            cmbDatos.DisplayMember = "Nombre_Moneda";
            cmbDatos.ValueMember = "Codigo_Moneda";
        }

        public void ListarContratos( Guna2ComboBox cmbDatos ) {
            ComboBoxD objeto = new ComboBoxD();
            cmbDatos.DataSource = objeto.ListarContratos();
            cmbDatos.DisplayMember = "Contrato_Id";
            cmbDatos.ValueMember = "Contrato_Id";
        }
    }
}
