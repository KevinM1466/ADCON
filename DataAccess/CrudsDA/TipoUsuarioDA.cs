using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.CrudsDA {
    public class TipoUsuarioDA : ConnectionToSql {
        private SqlDataReader leer;
        private DataTable table = new DataTable();
        private SqlCommand command = new SqlCommand();

        public DataTable Mostrar() {
            using ( var connection = GetConnection() ) {
                connection.Open();
                using ( var command = new SqlCommand() ) {
                    command.Connection = connection;
                    command.CommandText = "CRUD_TIPO_USUARIO";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@codigo", 0 );
                    command.Parameters.AddWithValue( "@nivel", "" );
                    command.Parameters.AddWithValue( "@accion", "Mostrar" );
                    leer = command.ExecuteReader();
                    table.Load( leer );
                    connection.Close();
                }
            }
            return table;
        }

        public DataTable Insertar( string nivel ) {
            using ( var connection = GetConnection() ) {
                connection.Open();
                using ( var command = new SqlCommand() ) {
                    command.Connection = connection;
                    command.CommandText = "CRUD_TIPO_USUARIO";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@nivel", nivel );
                    command.Parameters.AddWithValue( "@accion", "Insertar" );
                    leer = command.ExecuteReader();
                    table.Load( leer );
                    connection.Close();
                }
            }
            return table;
        }

        public DataTable Actualizar( int codigo, string nivel ) {
            using ( var connection = GetConnection() ) {
                connection.Open();
                using ( var command = new SqlCommand() ) {
                    command.Connection = connection;
                    command.CommandText = "CRUD_TIPO_USUARIO";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@codigo", codigo );
                    command.Parameters.AddWithValue( "@nivel", nivel );
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
                    command.CommandText = "CRUD_TIPO_USUARIO";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@codigo", codigo );
                    command.Parameters.AddWithValue( "@nivel", "" );
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
