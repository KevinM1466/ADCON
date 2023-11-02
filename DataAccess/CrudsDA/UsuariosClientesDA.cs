using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.CrudsDA {
    public class UsuariosClientesDA : ConnectionToSql {
        private SqlDataReader leer;
        private DataTable table = new DataTable();
        private SqlCommand command = new SqlCommand();

        public DataTable Mostrar() {
            using ( var connection = GetConnection() ) {
                connection.Open();
                using ( var command = new SqlCommand() ) {
                    command.Connection = connection;
                    command.CommandText = "CRUD_USUARIOS_CLIENTES";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@codigo", 0 );
                    command.Parameters.AddWithValue( "@contratoID", 0 );
                    command.Parameters.AddWithValue( "@nombre", "" );
                    command.Parameters.AddWithValue( "@direccion", "" );
                    command.Parameters.AddWithValue( "@telefono", "" );
                    command.Parameters.AddWithValue( "@correo", "" );
                    command.Parameters.AddWithValue( "@puesto", "" );
                    command.Parameters.AddWithValue( "@accion", "Mostrar" );
                    leer = command.ExecuteReader();
                    table.Load( leer );
                    connection.Close();
                }
            }
            return table;
        }

        public DataTable Insertar( int contrato, string nombre, string direccion, string telefono, string correo, string puesto ) {
            using ( var connection = GetConnection() ) {
                connection.Open();
                using ( var command = new SqlCommand() ) {
                    command.Connection = connection;
                    command.CommandText = "CRUD_USUARIOS_CLIENTES";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@contratoID", contrato );
                    command.Parameters.AddWithValue( "@nombre", nombre );
                    command.Parameters.AddWithValue( "@direccion", direccion );
                    command.Parameters.AddWithValue( "@telefono", telefono );
                    command.Parameters.AddWithValue( "@correo", correo );
                    command.Parameters.AddWithValue( "@puesto", puesto );
                    command.Parameters.AddWithValue( "@accion", "Insertar" );
                    leer = command.ExecuteReader();
                    table.Load( leer );
                    connection.Close();
                }
            }
            return table;
        }

        public DataTable Actualizar( int codigo, int contrato, string nombre, string direccion, string telefono, string correo, string puesto ) {
            using ( var connection = GetConnection() ) {
                connection.Open();
                using ( var command = new SqlCommand() ) {
                    command.Connection = connection;
                    command.CommandText = "CRUD_USUARIOS_CLIENTES";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@codigo", codigo );
                    command.Parameters.AddWithValue( "@contratoID", contrato );
                    command.Parameters.AddWithValue( "@nombre", nombre );
                    command.Parameters.AddWithValue( "@direccion", direccion );
                    command.Parameters.AddWithValue( "@telefono", telefono );
                    command.Parameters.AddWithValue( "@correo", correo );
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
                    command.CommandText = "CRUD_USUARIOS_CLIENTES";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@codigo", codigo );
                    command.Parameters.AddWithValue( "@contratoID", 0 );
                    command.Parameters.AddWithValue( "@nombre", "" );
                    command.Parameters.AddWithValue( "@direccion", "" );
                    command.Parameters.AddWithValue( "@telefono", "" );
                    command.Parameters.AddWithValue( "@correo", "" );
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
