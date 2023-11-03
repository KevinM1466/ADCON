using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Common.cache;

namespace DataAccess.CrudsDA {
    public class ContratosDA : ConnectionToSql{
        private SqlDataReader leer;
        private DataTable table = new DataTable();
        private SqlCommand command = new SqlCommand();

        public DataTable Mostrar() {
            using ( var connection = GetConnection() ) {
                connection.Open();
                using ( var command = new SqlCommand() ) {
                    command.Connection = connection;
                    command.CommandText = "CRUD_CONTRATOS";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@contratoID", 0 );
                    command.Parameters.AddWithValue( "@fechaInicio", null );
                    command.Parameters.AddWithValue( "@fechaFinal", null );
                    command.Parameters.AddWithValue( "@moneda", "" );
                    command.Parameters.AddWithValue( "@estado", "" );
                    command.Parameters.AddWithValue( "@cliente", 0 );
                    command.Parameters.AddWithValue( "@empleado", 0 );
                    command.Parameters.AddWithValue( "@tipoFacturacion", "" );
                    command.Parameters.AddWithValue( "@cantidadCuotas", 0 );
                    command.Parameters.AddWithValue( "@comentarios", "" );
                    command.Parameters.AddWithValue( "@renovacion", null );
                    command.Parameters.AddWithValue( "@accion", "Mostrar" );
                    leer = command.ExecuteReader();
                    table.Load( leer );
                    connection.Close();
                }
            }
            return table;
        }

        public bool MostrarDatos(string contrato) {
            using ( var connection = GetConnection() ) {
                connection.Open();
                using ( var command = new SqlCommand() ) {
                    command.Connection = connection;
                    command.CommandText = "CRUD_CONTRATOS";
                    command.Parameters.AddWithValue( "@contratoID", contrato );
                    command.Parameters.AddWithValue( "@fechaInicio", null );
                    command.Parameters.AddWithValue( "@fechaFinal", null );
                    command.Parameters.AddWithValue( "@moneda", "" );
                    command.Parameters.AddWithValue( "@estado", "" );
                    command.Parameters.AddWithValue( "@cliente", 0 );
                    command.Parameters.AddWithValue( "@empleado", 0 );
                    command.Parameters.AddWithValue( "@tipoFacturacion", "" );
                    command.Parameters.AddWithValue( "@cantidadCuotas", 0 );
                    command.Parameters.AddWithValue( "@comentarios", "" );
                    command.Parameters.AddWithValue( "@renovacion", null );
                    command.Parameters.AddWithValue( "@accion", "MostrarDatos" );
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    if ( reader.HasRows ) {
                        while ( reader.Read() ) {
                            ContratosCache.fechaIncio = reader.GetDateTime( 2 );
                            ContratosCache.fechaFinal = reader.GetDateTime( 3 );
                            ContratosCache.clienteID = reader.GetInt32( 6 );
                            ContratosCache.Cliente = reader.GetString( 7 );
                            ContratosCache.codigoMoneda = reader.GetString( 4 );
                            ContratosCache.moneda = reader.GetString( 5 );
                            ContratosCache.tipoF = reader.GetString( 10 );
                            ContratosCache.cantidadCuotas = reader.GetInt32( 11 );
                            ContratosCache.comentario = reader.GetString( 12 );
                            ContratosCache.renovacion = reader.GetBoolean( 13 );
                        }
                        return true;
                    } else return false;
                }
            }
        }

        public DataTable Insertar( string contratoID, DateTime fechaInicio, DateTime fechaFinal, string moneda, string estado, int cliente, int empleado, string tipoFacturacion, int cantidadCuotas, string comentarios, bool renovacion ) {
            using ( var connection = GetConnection() ) {
                connection.Open();
                using ( var command = new SqlCommand() ) {
                    command.Connection = connection;
                    command.CommandText = "CRUD_CONTRATOS";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@contratoID", contratoID );
                    command.Parameters.AddWithValue( "@fechaInicio", fechaInicio );
                    command.Parameters.AddWithValue( "@fechaFinal", fechaFinal );
                    command.Parameters.AddWithValue( "@moneda", moneda );
                    command.Parameters.AddWithValue( "@estado", estado );
                    command.Parameters.AddWithValue( "@cliente", cliente);
                    command.Parameters.AddWithValue( "@empleado", empleado );
                    command.Parameters.AddWithValue( "@tipoFacturacion", tipoFacturacion );
                    command.Parameters.AddWithValue( "@cantidadCuotas", cantidadCuotas );
                    command.Parameters.AddWithValue( "@comentarios", comentarios );
                    command.Parameters.AddWithValue( "@renovacion", renovacion );
                    command.Parameters.AddWithValue( "@accion", "Insertar" );
                    leer = command.ExecuteReader();
                    table.Load( leer );
                    connection.Close();
                }
            }
            return table;
        }

        public DataTable Actualizar( int codigo, DateTime fechaInicio, DateTime fechaFinal, string moneda, string estado, int cliente, int empleado, string tipoFacturacion, int cantidadCuotas, string comentarios, bool renovacion ) {
            using ( var connection = GetConnection() ) {
                connection.Open();
                using ( var command = new SqlCommand() ) {
                    command.Connection = connection;
                    command.CommandText = "CRUD_CONTRATOS";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue( "@codigo", codigo );
                    command.Parameters.AddWithValue( "@fechaInicio", fechaInicio );
                    command.Parameters.AddWithValue( "@fechaFinal", fechaFinal );
                    command.Parameters.AddWithValue( "@moneda", moneda );
                    command.Parameters.AddWithValue( "@estado", estado );
                    command.Parameters.AddWithValue( "@cliente", cliente );
                    command.Parameters.AddWithValue( "@empleado", empleado );
                    command.Parameters.AddWithValue( "@tipoFacturacion", tipoFacturacion );
                    command.Parameters.AddWithValue( "@cantidadCuotas", cantidadCuotas );
                    command.Parameters.AddWithValue( "@comentarios", comentarios );
                    command.Parameters.AddWithValue( "@renovacion", renovacion );
                    command.Parameters.AddWithValue( "@accion", "Actualizar" );
                    leer = command.ExecuteReader();
                    table.Load( leer );
                    connection.Close();
                }
            }
            return table;
        }
    }
}
