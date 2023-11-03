using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Common.cache;
using Guna.UI2.WinForms;

namespace DataAccess.SqlServer {
    public class userDao : ConnectionToSql {
        private SqlDataReader leer;
        private DataTable table = new DataTable();

        public bool Login( string user, string pass ) {
            using ( var connection = GetConnection() ) {
                connection.Open();
                using ( var command = new SqlCommand() ) {
                    command.Connection = connection;
                    command.CommandText = "IniciarSesion";
                    command.Parameters.AddWithValue( "@user", user );
                    command.Parameters.AddWithValue( "@pass", pass );
                    command.Parameters.AddWithValue( "@accion", "Mostrar" );
                    command.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = command.ExecuteReader();
                    if ( reader.HasRows ) {
                        while ( reader.Read() ) {
                            UserLoginCache.userID = reader.GetInt32( 0 );
                            UserLoginCache.empleadoID = reader.GetInt32( 1 );
                            UserLoginCache.firstName = reader.GetString( 2 );
                            UserLoginCache.lastName = reader.GetString( 3 );
                            UserLoginCache.nombreUsuario = reader.GetString( 4 );
                            UserLoginCache.tipoUsuario = reader.GetInt32( 5 );
                            UserLoginCache.nivelUsuario = reader.GetString( 6 );
                        }
                        return true;
                    } else return false;
                }
            }
        }

        public void Permisos( Guna2Button contratos, Guna2Button productos, Guna2Button compania, Guna2Button reportes ) {
            if ( UserLoginCache.nivelUsuario == Cargos.Administrador ) {
                contratos.Visible = true;
                productos.Visible = true;
                compania.Visible = true;
                reportes.Visible = true;
            } else {
                contratos.Visible = true;
                productos.Visible = false;
                compania.Visible = false;
                reportes.Visible = false;
            }
        }
    }
}
