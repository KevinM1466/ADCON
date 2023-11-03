using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;
using System.Windows.Forms;

namespace DataAccess.SqlServer {
    public class FiltrosDao : ConnectionToSql{
        public SqlDataAdapter adaptador;
        public DataTable dt;

        public SqlCommand comman;
        public SqlDataReader dr;

        public void FiltrarContratos( string contrato, Guna2DataGridView dgDatos ) {
            using ( var connection = GetConnection() ) {
                connection.Open();
                // El simbolo de % se le llama comodín.
                //try {
                    //AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
                    adaptador = new SqlDataAdapter( @"SELECT  F.Producto_Id, F.Nombre_Producto, B.Cantidad, f.Precio_Producto, A.Comentarios, B.Impuesto, B.Descuento,
				                                                                        Subtotal = (Precio_Producto * Cantidad) + Impuesto - Descuento
		                                                                        FROM [dbo].[Contratos] A INNER JOIN [dbo].[Detalle_Contrato] B
		                                                                        ON
		                                                                        A.Contrato_Id = B.Contrato_Id INNER JOIN [dbo].[Moneda] C
		                                                                        ON
		                                                                        A.Moneda_Id = C.Codigo_Moneda INNER JOIN [dbo].[Clientes] D
		                                                                        ON
		                                                                        A.Cliente_Id = D.Cliente_Id INNER JOIN [dbo].[Empleados] E
		                                                                        ON
		                                                                        A.Empleado_Encargado_ID = E.Empleado_Id INNER JOIN [dbo].[Productos] F
		                                                                        ON
		                                                                        B.Producto_Id = F.Producto_Id
		                                                                        WHERE a.Contrato_Id LIKE '" + "%" + contrato + "%" + "' ", connection );
                    dt = new DataTable();
                    adaptador.Fill( dt );
                    dgDatos.DataSource = dt;
                //} catch ( Exception ex ) {
                //    MessageBox.Show( "Error de servidor", "Tecnasa Honduras", MessageBoxButtons.OK, MessageBoxIcon.Error );
                //}
            }
        }
    }
}
