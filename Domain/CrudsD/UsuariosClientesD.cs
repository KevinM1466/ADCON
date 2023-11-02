using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess.CrudsDA;

namespace Domain.CrudsD {
    public class UsuariosClientesD {
        private UsuariosClientesDA usuariosClientes = new UsuariosClientesDA();

        public DataTable Mostrar() {
            DataTable tabla = new DataTable();
            tabla = usuariosClientes.Mostrar();
            return tabla;
        }

        public DataTable Insertar( int contrato, string nombre, string direccion, string telefono, string correo, string puesto ) {
            DataTable tabla = new DataTable();
            tabla = usuariosClientes.Insertar( contrato, nombre, direccion, telefono, correo, puesto );
            return tabla;
        }

        public DataTable Actualizar( int codigo, int contrato, string nombre, string direccion, string telefono, string correo, string puesto ) {
            DataTable tabla = new DataTable();
            tabla = usuariosClientes.Actualizar( codigo, contrato, nombre, direccion, telefono, correo, puesto );
            return tabla;
        }

        public DataTable Eliminar( int codigo ) {
            DataTable tabla = new DataTable();
            tabla = usuariosClientes.Eliminar( codigo );
            return tabla;
        }
    }
}
