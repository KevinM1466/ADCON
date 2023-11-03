using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess.Cruds;
using DataAccess.CrudsDA;
using DataAccess.SqlServer;

namespace Domain.CrudsD {
    public class ContratosD {
        private ContratosDA contratos = new ContratosDA();

        public DataTable Mostrar() {
            DataTable tabla = new DataTable();
            tabla = contratos.Mostrar();
            return tabla;
        }

        public bool MostrarDatos( string contrato ) {
            return contratos.MostrarDatos( contrato );
        }

        public DataTable Insertar(string contratoID, DateTime fechaInicio, DateTime fechaFinal, string moneda, string estado, int cliente, int empleado, string tipoFacturacion, int cantidadCuotas, string comentarios, bool renovacion ) {
            DataTable tabla = new DataTable();
            tabla = contratos.Insertar( contratoID, fechaInicio, fechaFinal, moneda, estado, cliente, empleado, tipoFacturacion, cantidadCuotas, comentarios, renovacion );
            return tabla;
        }

        public DataTable Actualizar( int codigo, DateTime fechaInicio, DateTime fechaFinal, string moneda, string estado, int cliente, int empleado, string tipoFacturacion, int cantidadCuotas, string comentarios, bool renovacion ) {
            DataTable tabla = new DataTable();
            tabla = contratos.Actualizar(codigo, fechaInicio, fechaFinal, moneda, estado, cliente, empleado, tipoFacturacion, cantidadCuotas, comentarios, renovacion );
            return tabla;
        }
    }
}
