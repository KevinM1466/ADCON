using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess.CrudsDA;

namespace Domain.CrudsD {
    public class TipoUsuarioD {
        private TipoUsuarioDA tipoUsuarios = new TipoUsuarioDA();

        public DataTable Mostrar() {
            DataTable tabla = new DataTable();
            tabla = tipoUsuarios.Mostrar();
            return tabla;
        }

        public DataTable Insertar( string nivel ) {
            DataTable tabla = new DataTable();
            tabla = tipoUsuarios.Insertar( nivel );
            return tabla;
        }

        public DataTable Actualizar( int codigo, string nivel ) {
            DataTable tabla = new DataTable();
            tabla = tipoUsuarios.Actualizar( codigo, nivel );
            return tabla;
        }

        public DataTable Eliminar( int codigo ) {
            DataTable tabla = new DataTable();
            tabla = tipoUsuarios.Eliminar( codigo );
            return tabla;
        }
    }
}
