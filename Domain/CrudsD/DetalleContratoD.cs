using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess.CrudsDA;

namespace Domain.CrudsD {
    public class DetalleContratoD {
        DetalleContratosDA detalle = new DetalleContratosDA();

        public int Detalle_Contrato_Id { get; set; }
        public int Contrato_Id { get; set; }
        public int Producto_Id { get; set; }
        public int Cantidad { get; set; }
        public double Impuesto { get; set; }
        public double Descuento { get; set; }
        public string Descripcion { get; set; }

        public void InsertarData( IEnumerable<DetalleContratosDA> detailsList ) {
            detalle.insertData(detailsList);
        }
    }
}
