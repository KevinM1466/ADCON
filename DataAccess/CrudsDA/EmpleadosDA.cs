using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Guna.UI2.Native.WinApi;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace DataAccess.CrudsDA {
    public class EmpleadosDA : ConnectionToSql {
        private SqlDataReader leer;
        private DataTable table = new DataTable();
        private SqlCommand command = new SqlCommand();

        public DataTable Mostrar() {
            using ( var connection = GetConnection() ) {
                connection.Open();
                using ( var command = new SqlCommand() ) {
                    command.Connection = connection;
                    command.CommandText = "CRUD_EMPLEADOS";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@codigo", 0 );
                    command.Parameters.AddWithValue( "@nombre", "" );
                    command.Parameters.AddWithValue( "@apellido", "" );
                    command.Parameters.AddWithValue( "@direccion", "" );
                    command.Parameters.AddWithValue( "@correo", "" );
                    command.Parameters.AddWithValue( "@cargo", 0 );
                    command.Parameters.AddWithValue( "@accion", "Mostrar" );
                    leer = command.ExecuteReader();
                    table.Load( leer );
                    connection.Close();
                }
            }
            return table;
        }

        public DataTable Insertar( string nombre, string apellido, string direccion, string correo, int cargo ) {
            using ( var connection = GetConnection() ) {
                connection.Open();
                using ( var command = new SqlCommand() ) {
                    command.Connection = connection;
                    command.CommandText = "CRUD_EMPLEADOS";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@nombre", nombre );
                    command.Parameters.AddWithValue( "@apellido", apellido );
                    command.Parameters.AddWithValue( "@direccion", direccion );
                    command.Parameters.AddWithValue( "@correo", correo );
                    command.Parameters.AddWithValue( "@cargo", cargo );
                    command.Parameters.AddWithValue( "@accion", "Insertar" );
                    leer = command.ExecuteReader();
                    table.Load( leer );
                    connection.Close();
                }
            }
            return table;
        }

        public DataTable Actualizar( int codigo, string nombre, string apellido, string direccion, string correo, int cargo ) {
            using ( var connection = GetConnection() ) {
                connection.Open();
                using ( var command = new SqlCommand() ) {
                    command.Connection = connection;
                    command.CommandText = "CRUD_EMPLEADOS";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@codigo", codigo );
                    command.Parameters.AddWithValue( "@nombre", nombre );
                    command.Parameters.AddWithValue( "@apellido", apellido );
                    command.Parameters.AddWithValue( "@direccion", direccion );
                    command.Parameters.AddWithValue( "@correo", correo );
                    command.Parameters.AddWithValue( "@cargo", cargo );
                    command.Parameters.AddWithValue( "@accion", "Actualizar" );
                    leer = command.ExecuteReader();
                    table.Load( leer );
                    connection.Close();
                }
            }
            return table;
        }

        public DataTable Eliminar( int codigo ) {
            using ( var connection = GetConnection() ) {
                connection.Open();
                using ( var command = new SqlCommand() ) {
                    command.Connection = connection;
                    command.CommandText = "CRUD_EMPLEADOS";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@codigo", codigo );
                    command.Parameters.AddWithValue( "@nombre", "" );
                    command.Parameters.AddWithValue( "@apellido", "" );
                    command.Parameters.AddWithValue( "@direccion", "" );
                    command.Parameters.AddWithValue( "@correo", "" );
                    command.Parameters.AddWithValue( "@cargo", 0 );
                    command.Parameters.AddWithValue( "@accion", "Eliminar" );
                    leer = command.ExecuteReader();
                    table.Load( leer );
                    connection.Close();
                }
            }
            return table;
        }
    }
}
