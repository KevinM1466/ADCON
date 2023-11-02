using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace DataAccess.Cruds {
    public class ClientesDA : ConnectionToSql {
        private SqlDataReader leer;
        private DataTable table = new DataTable();
        private SqlCommand command = new SqlCommand();

        public DataTable Mostrar() {
            using ( var connection = GetConnection() ) {
                connection.Open();
                using ( var command = new SqlCommand() ) {
                    command.Connection = connection;
                    command.CommandText = "CRUD_CLIENTES";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@codigo", 0 );
                    command.Parameters.AddWithValue( "@nombre", "" );
                    command.Parameters.AddWithValue( "@rtn", "" );
                    command.Parameters.AddWithValue( "@direccion", "" );
                    command.Parameters.AddWithValue( "@paisID", 0 );
                    command.Parameters.AddWithValue( "@telefono", "" );
                    command.Parameters.AddWithValue( "@paginaWeb", "" );
                    command.Parameters.AddWithValue( "@correo", "" );
                    command.Parameters.AddWithValue( "@representante", "" );
                    command.Parameters.AddWithValue( "@puesto", "" );
                    command.Parameters.AddWithValue( "@accion", "Mostrar" );
                    leer = command.ExecuteReader();
                    table.Load( leer );
                    connection.Close();
                }
            }
            return table;
        }

        public DataTable Insertar(string nombre, string rtn, string direccion, int paisID, string telefono, string paginaWeb, string correo, string representante, string puesto) {
            using ( var connection = GetConnection() ) {
                connection.Open();
                using ( var command = new SqlCommand() ) {
                    command.Connection = connection;
                    command.CommandText = "CRUD_CLIENTES";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@nombre", nombre );
                    command.Parameters.AddWithValue( "@rtn", rtn );
                    command.Parameters.AddWithValue( "@direccion", direccion );
                    command.Parameters.AddWithValue( "@paisID", paisID );
                    command.Parameters.AddWithValue( "@telefono", telefono );
                    command.Parameters.AddWithValue( "@paginaWeb", paginaWeb );
                    command.Parameters.AddWithValue( "@correo", correo );
                    command.Parameters.AddWithValue( "@representante", representante );
                    command.Parameters.AddWithValue( "@puesto", puesto );
                    command.Parameters.AddWithValue( "@accion", "Insertar" );
                    leer = command.ExecuteReader();
                    table.Load( leer );
                    connection.Close();
                }
            }
            return table;
        }

        public DataTable Actualizar( int codigo, string nombre, string rtn, string direccion, int paisID, string telefono, string paginaWeb, string correo, string representante, string puesto ) {
            using ( var connection = GetConnection() ) {
                connection.Open();
                using ( var command = new SqlCommand() ) {
                    command.Connection = connection;
                    command.CommandText = "CRUD_CLIENTES";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@codigo", codigo );
                    command.Parameters.AddWithValue( "@nombre", nombre );
                    command.Parameters.AddWithValue( "@rtn", rtn );
                    command.Parameters.AddWithValue( "@direccion", direccion );
                    command.Parameters.AddWithValue( "@paisID", paisID );
                    command.Parameters.AddWithValue( "@telefono", telefono );
                    command.Parameters.AddWithValue( "@paginaWeb", paginaWeb );
                    command.Parameters.AddWithValue( "@correo", correo );
                    command.Parameters.AddWithValue( "@representante", representante );
                    command.Parameters.AddWithValue( "@puesto", puesto );
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
                    command.CommandText = "CRUD_CLIENTES";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@codigo", codigo );
                    command.Parameters.AddWithValue( "@nombre", "" );
                    command.Parameters.AddWithValue( "@rtn", "" );
                    command.Parameters.AddWithValue( "@direccion", "" );
                    command.Parameters.AddWithValue( "@paisID", 0 );
                    command.Parameters.AddWithValue( "@telefono", "" );
                    command.Parameters.AddWithValue( "@paginaWeb", "" );
                    command.Parameters.AddWithValue( "@correo", "" );
                    command.Parameters.AddWithValue( "@representante", "" );
                    command.Parameters.AddWithValue( "@puesto", "" );
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
