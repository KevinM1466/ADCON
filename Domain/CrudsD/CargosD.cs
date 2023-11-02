using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess.CrudsDA;

namespace Domain.CrudsD {
    public class CargosD {
        private CargosDA cargos = new CargosDA();

        public DataTable Mostrar() {
            DataTable tabla = new DataTable();
            tabla = cargos.Mostrar();
            return tabla;
        }

        public DataTable Insertar( string cargo, string descripcion ) {
            DataTable tabla = new DataTable();
            tabla = cargos.Insertar( cargo, descripcion );
            return tabla;
        }

        public DataTable Actualizar( int codigo, string cargo, string descripcion ) {
            DataTable tabla = new DataTable();
            tabla = cargos.Actualizar(codigo, cargo, descripcion );
            return tabla;
        }

        public DataTable Eliminar( int codigo ) {
            DataTable tabla = new DataTable();
            tabla = cargos.Eliminar( codigo );
            return tabla;
        }
    }
}
