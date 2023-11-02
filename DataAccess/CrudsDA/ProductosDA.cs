using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.CrudsDA {
    public class ProductosDA : ConnectionToSql {
        private SqlDataReader leer;
        private DataTable table = new DataTable();
        private SqlCommand command = new SqlCommand();

        public DataTable Mostrar() {
            using ( var connection = GetConnection() ) {
                connection.Open();
                using ( var command = new SqlCommand() ) {
                    command.Connection = connection;
                    command.CommandText = "CRUD_PRODUCTOS";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@codigo", 0 );
                    command.Parameters.AddWithValue( "@producto", "" );
                    command.Parameters.AddWithValue( "@marca", "" );
                    command.Parameters.AddWithValue( "@modelo", "" );
                    command.Parameters.AddWithValue( "@version", "" );
                    command.Parameters.AddWithValue( "@precio", 0 );
                    command.Parameters.AddWithValue( "@accion", "Mostrar" );
                    leer = command.ExecuteReader();
                    table.Load( leer );
                    connection.Close();
                }
            }
            return table;
        }

        public DataTable Insertar( string producto, string marca, string modelo, string version, decimal precio ) {
            using ( var connection = GetConnection() ) {
                connection.Open();
                using ( var command = new SqlCommand() ) {
                    command.Connection = connection;
                    command.CommandText = "CRUD_PRODUCTOS";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@producto", producto );
                    command.Parameters.AddWithValue( "@marca", marca );
                    command.Parameters.AddWithValue( "@modelo", modelo );
                    command.Parameters.AddWithValue( "@version", version );
                    command.Parameters.AddWithValue( "@precio", precio );
                    command.Parameters.AddWithValue( "@accion", "Insertar" );
                    leer = command.ExecuteReader();
                    table.Load( leer );
                    connection.Close();
                }
            }
            return table;
        }

        public DataTable Actualizar( int codigo, string producto, string marca, string modelo, string version, decimal precio ) {
            using ( var connection = GetConnection() ) {
                connection.Open();
                using ( var command = new SqlCommand() ) {
                    command.Connection = connection;
                    command.CommandText = "CRUD_PRODUCTOS";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@codigo", codigo );
                    command.Parameters.AddWithValue( "@producto", producto );
                    command.Parameters.AddWithValue( "@marca", marca );
                    command.Parameters.AddWithValue( "@modelo", modelo );
                    command.Parameters.AddWithValue( "@version", version );
                    command.Parameters.AddWithValue( "@precio", precio );
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
                    command.CommandText = "CRUD_PRODUCTOS";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@codigo", codigo );
                    command.Parameters.AddWithValue( "@producto", "" );
                    command.Parameters.AddWithValue( "@marca", "" );
                    command.Parameters.AddWithValue( "@modelo", "" );
                    command.Parameters.AddWithValue( "@version", "" );
                    command.Parameters.AddWithValue( "@precio", 0 );
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
