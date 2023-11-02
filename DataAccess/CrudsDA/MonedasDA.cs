using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.CrudsDA {
    public class MonedasDA : ConnectionToSql{
        private SqlDataReader leer;
        private DataTable table = new DataTable();
        private SqlCommand command = new SqlCommand();

        public DataTable Mostrar() {
            using ( var connection = GetConnection() ) {
                connection.Open();
                using ( var command = new SqlCommand() ) {
                    command.Connection = connection;
                    command.CommandText = "CRUD_MONEDAS";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@codigoMoneda", "" );
                    command.Parameters.AddWithValue( "@nombreMoneda", "" );
                    command.Parameters.AddWithValue( "@abreviatura", "" );
                    command.Parameters.AddWithValue( "@signo", "" );
                    command.Parameters.AddWithValue( "@accion", "Mostrar" );
                    leer = command.ExecuteReader();
                    table.Load( leer );
                    connection.Close();
                }
            }
            return table;
        }

        public DataTable Insertar( string codigoMoneda, string nombreMoneda, string abreviatura, string signo ) {
            using ( var connection = GetConnection() ) {
                connection.Open();
                using ( var command = new SqlCommand() ) {
                    command.Connection = connection;
                    command.CommandText = "CRUD_MONEDAS";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@codigoMoneda", codigoMoneda );
                    command.Parameters.AddWithValue( "@nombreMoneda", nombreMoneda );
                    command.Parameters.AddWithValue( "@abreviatura", abreviatura );
                    command.Parameters.AddWithValue( "@signo", signo );
                    command.Parameters.AddWithValue( "@accion", "Insertar" );
                    leer = command.ExecuteReader();
                    table.Load( leer );
                    connection.Close();
                }
            }
            return table;
        }

        public DataTable Actualizar( string codigoMoneda, string nombreMoneda, string abreviatura, string signo ) {
            using ( var connection = GetConnection() ) {
                connection.Open();
                using ( var command = new SqlCommand() ) {
                    command.Connection = connection;
                    command.CommandText = "CRUD_MONEDAS";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@codigoMoneda", codigoMoneda );
                    command.Parameters.AddWithValue( "@nombreMoneda", nombreMoneda );
                    command.Parameters.AddWithValue( "@abreviatura", abreviatura );
                    command.Parameters.AddWithValue( "@signo", signo );
                    command.Parameters.AddWithValue( "@accion", "Actualizar" );
                    leer = command.ExecuteReader();
                    table.Load( leer );
                    connection.Close();
                }
            }
            return table;
        }

        public DataTable Eliminar( string codigoMoneda ) {
            using ( var connection = GetConnection() ) {
                connection.Open();
                using ( var command = new SqlCommand() ) {
                    command.Connection = connection;
                    command.CommandText = "CRUD_MONEDAS";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@codigoMoneda", codigoMoneda );
                    command.Parameters.AddWithValue( "@nombreMoneda", "" );
                    command.Parameters.AddWithValue( "@abreviatura", "" );
                    command.Parameters.AddWithValue( "@signo", "" );
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
