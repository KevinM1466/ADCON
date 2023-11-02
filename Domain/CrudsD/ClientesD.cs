using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess.Cruds;

namespace Domain.CrudsD {
    public class ClientesD {
        private ClientesDA clientes = new ClientesDA();

        public DataTable Mostrar() {
            DataTable tabla = new DataTable();
            tabla = clientes.Mostrar();
            return tabla;
        }

        public DataTable Insertar( string nombre, string rtn, string direccion, int paisID, string telefono, string paginaWeb, string correo, string representante, string puesto ) {
            DataTable tabla = new DataTable();
            tabla = clientes.Insertar( nombre, rtn, direccion, paisID, telefono, paginaWeb, correo, representante, puesto );
            return tabla;
        }
        
        public DataTable Actualizar( int codigo, string nombre, string rtn, string direccion, int paisID, string telefono, string paginaWeb, string correo, string representante, string puesto ) {
            DataTable tabla = new DataTable();
            tabla = clientes.Actualizar( codigo, nombre, rtn, direccion, paisID, telefono, paginaWeb, correo, representante, puesto );
            return tabla;
        }
        
        public DataTable Eliminar( int codigo ) {
            DataTable tabla = new DataTable();
            tabla = clientes.Eliminar( codigo );
            return tabla;
        }
    }
}
