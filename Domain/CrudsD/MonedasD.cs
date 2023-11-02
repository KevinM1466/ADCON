using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess.Cruds;
using DataAccess.CrudsDA;

namespace Domain.CrudsD {
    public class MonedasD {
        private MonedasDA monedas = new MonedasDA();

        public DataTable Mostrar() {
            DataTable tabla = new DataTable();
            tabla = monedas.Mostrar();
            return tabla;
        }

        public DataTable Insertar( string codigoMoneda, string nombreMoneda, string abreviatura, string signo ) {
            DataTable tabla = new DataTable();
            tabla = monedas.Insertar( codigoMoneda, nombreMoneda, abreviatura, signo );
            return tabla;
        }

        public DataTable Actualizar( string codigoMoneda, string nombreMoneda, string abreviatura, string signo ) {
            DataTable tabla = new DataTable();
            tabla = monedas.Actualizar(codigoMoneda, nombreMoneda, abreviatura, signo );
            return tabla;
        }

        public DataTable Eliminar( string codigoMoneda ) {
            DataTable tabla = new DataTable();
            tabla = monedas.Eliminar( codigoMoneda );
            return tabla;
        }
    }
}
