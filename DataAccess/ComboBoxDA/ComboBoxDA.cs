using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ComboBoxDA {
    public class ComboBoxDA : ConnectionToSql {
        private SqlDataReader leer;
        private DataTable table = new DataTable();

        public DataTable ListarPais() {
            using ( var connection = GetConnection() ) {
                connection.Open();
                using ( var command = new SqlCommand() ) {
                    command.Connection = connection;
                    command.CommandText = "MostrarComboBox";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@accion", "ListarPaises" );
                    leer = command.ExecuteReader();
                    table.Load( leer );
                    connection.Close();

                    DataRow fila = table.NewRow();
                    fila[ "Nombre_Pais" ] = "Seleccione un Pais";
                    table.Rows.InsertAt( fila, 0 );

                }
            }
            return table;
        }
        
        public DataTable ListarCiudades(int pais) {
            using ( var connection = GetConnection() ) {
                connection.Open();
                using ( var command = new SqlCommand() ) {
                    command.Connection = connection;
                    command.CommandText = "MostrarComboBox";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@paisID", pais );
                    command.Parameters.AddWithValue( "@accion", "ListarCiudades" );
                    leer = command.ExecuteReader();
                    table.Load( leer );
                    connection.Close();

                    DataRow fila = table.NewRow();
                    fila[ "nombreCiudad" ] = "Seleccione una ciudad";
                    table.Rows.InsertAt( fila, 0 );
                }
            }
            return table;
        }

        public DataTable ListarUsuarios() {
            using ( var connection = GetConnection() ) {
                connection.Open();
                using ( var command = new SqlCommand() ) {
                    command.Connection = connection;
                    command.CommandText = "MostrarComboBox";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@paisID", "" );
                    command.Parameters.AddWithValue( "@accion", "ListarCiudades" );
                    leer = command.ExecuteReader();
                    table.Load( leer );
                    connection.Close();

                    DataRow fila = table.NewRow();
                    fila[ "nombreCiudad" ] = "Seleccione una opción";
                    table.Rows.InsertAt( fila, 0 );
                }
            }
            return table;
        }

        public DataTable ListarTipoProductos() {
            using ( var connection = GetConnection() ) {
                connection.Open();
                using ( var command = new SqlCommand() ) {
                    command.Connection = connection;
                    command.CommandText = "MostrarComboBox";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@paisID", "" );
                    command.Parameters.AddWithValue( "@accion", "ListarTipoP" );
                    leer = command.ExecuteReader();
                    table.Load( leer );
                    connection.Close();

                    DataRow fila = table.NewRow();
                    fila[ "Nombre_Producto" ] = "Seleccione una opción";
                    table.Rows.InsertAt( fila, 0 );
                }
            }
            return table;
        }

        public DataTable ListarCargos() {
            using ( var connection = GetConnection() ) {
                connection.Open();
                using ( var command = new SqlCommand() ) {
                    command.Connection = connection;
                    command.CommandText = "MostrarComboBox";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@paisID", "" );
                    command.Parameters.AddWithValue( "@accion", "ListarCargos" );
                    leer = command.ExecuteReader();
                    table.Load( leer );
                    connection.Close();

                    DataRow fila = table.NewRow();
                    fila[ "Nombre_Cargo" ] = "Seleccione una opción";
                    table.Rows.InsertAt( fila, 0 );
                }
            }
            return table;
        }
        
        public DataTable ListarTipoUsuarios() {
            using ( var connection = GetConnection() ) {
                connection.Open();
                using ( var command = new SqlCommand() ) {
                    command.Connection = connection;
                    command.CommandText = "MostrarComboBox";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@paisID", "" );
                    command.Parameters.AddWithValue( "@accion", "ListarTipoU" );
                    leer = command.ExecuteReader();
                    table.Load( leer );
                    connection.Close();

                    DataRow fila = table.NewRow();
                    fila[ "Nivel_Usuario" ] = "Seleccione una opción";
                    table.Rows.InsertAt( fila, 0 );
                }
            }
            return table;
        }
        
        public DataTable ListarMonedas() {
            using ( var connection = GetConnection() ) {
                connection.Open();
                using ( var command = new SqlCommand() ) {
                    command.Connection = connection;
                    command.CommandText = "MostrarComboBox";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@paisID", "" );
                    command.Parameters.AddWithValue( "@accion", "ListarMonedas" );
                    leer = command.ExecuteReader();
                    table.Load( leer );
                    connection.Close();

                    //DataRow fila = table.NewRow();
                    //fila[ "Nombre_Moneda" ] = "Seleccione una opción";
                    //table.Rows.InsertAt( fila, 0 );
                }
            }
            return table;
        }
    }
}
