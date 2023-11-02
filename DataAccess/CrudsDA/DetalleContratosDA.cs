using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.CrudsDA {
    public class DetalleContratosDA : ConnectionToSql {
        public int Detalle_Contrato_Id { get; set; }
        public string Contrato_Id { get; set; }
        public int Producto_Id { get; set; }
        public int Cantidad { get; set; }
        public double Impuesto { get; set; }
        public double Descuento { get; set; }

        // Metodos
        public void insertData( IEnumerable<DetalleContratosDA> detailsList ) {
            // Crear Tabla
            var table = new DataTable();
            table.Columns.Add( "Detalle_Contrato_Id", typeof( int ) );
            table.Columns.Add( "Contrato_Id", typeof( string ) );
            table.Columns.Add( "Producto_Id", typeof( int ) );
            table.Columns.Add( "Cantidad", typeof( double ) );
            table.Columns.Add( "Impuesto", typeof( double ) );
            table.Columns.Add( "Descuento", typeof( double ) );

            foreach ( var itemDetail in detailsList ) {
                table.Rows.Add( new object[] { 0, itemDetail.Contrato_Id, itemDetail.Producto_Id, itemDetail.Cantidad, itemDetail.Impuesto, itemDetail.Descuento } );
            }
                

            // Insertar datos a sql
            using ( var connection = GetConnection() ) {
                connection.Open();

                using ( SqlTransaction transaction = connection.BeginTransaction() ) {
                    using ( SqlBulkCopy bulkCopy = new SqlBulkCopy( connection, SqlBulkCopyOptions.Default, transaction ) ) {
                        try {
                            bulkCopy.DestinationTableName = "dbo.Detalle_Contrato";
                            bulkCopy.WriteToServer( table );
                            transaction.Commit();
                        } catch ( Exception __unusedException1__ ) {
                            transaction.Rollback();
                            connection.Close();
                            throw;
                        }
                    }
                }
            }
        }
    }
}
