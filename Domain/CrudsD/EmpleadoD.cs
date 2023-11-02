using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess.CrudsDA;

namespace Domain.CrudsD {
    public class EmpleadoD {
        private EmpleadosDA empleados = new EmpleadosDA();

        public DataTable Mostrar() {
            DataTable tabla = new DataTable();
            tabla = empleados.Mostrar();
            return tabla;
        }

        public DataTable Insertar( string nombre, string apellido, string direccion, string correo, int cargo ) {
            DataTable tabla = new DataTable();
            tabla = empleados.Insertar( nombre, apellido, direccion, correo, cargo );
            return tabla;
        }

        public DataTable Actualizar( int codigo, string nombre, string apellido, string direccion, string correo, int cargo ) {
            DataTable tabla = new DataTable();
            tabla = empleados.Actualizar( codigo, nombre, apellido, direccion, correo, cargo );
            return tabla;
        }

        public DataTable Eliminar( int codigo ) {
            DataTable tabla = new DataTable();
            tabla = empleados.Eliminar( codigo );
            return tabla;
        }
    }
}
