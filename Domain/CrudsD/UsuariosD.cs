using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess.CrudsDA;

namespace Domain.CrudsD {
    public class UsuariosD {
        private UsuariosDA usuarios = new UsuariosDA();

        public DataTable Mostrar() {
            DataTable tabla = new DataTable();
            tabla = usuarios.Mostrar();
            return tabla;
        }

        public DataTable Insertar( int empleadoID, string usuario, string contrasenia, int tipo ) {
            DataTable tabla = new DataTable();
            tabla = usuarios.Insertar( empleadoID, usuario, contrasenia, tipo );
            return tabla;
        }

        public DataTable Actualizar( int codigo, int empleadoID, string usuario, string contrasenia, int tipo ) {
            DataTable tabla = new DataTable();
            tabla = usuarios.Actualizar( codigo, empleadoID, usuario, contrasenia, tipo );
            return tabla;
        }

        public DataTable Eliminar( int codigo ) {
            DataTable tabla = new DataTable();
            tabla = usuarios.Eliminar( codigo );
            return tabla;
        }
    }
}
