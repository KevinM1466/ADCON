using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess.CrudsDA;

namespace Domain.CrudsD {
    public class ProductosD {
        private ProductosDA productos = new ProductosDA();

        public DataTable Mostrar() {
            DataTable tabla = new DataTable();
            tabla = productos.Mostrar();
            return tabla;
        }

        public DataTable Insertar( string producto, string marca, string modelo, string version, decimal precio ) {
            DataTable tabla = new DataTable();
            tabla = productos.Insertar( producto, marca, modelo, version, precio );
            return tabla;
        }

        public DataTable Actualizar( int codigo, string producto, string marca, string modelo, string version, decimal precio ) {
            DataTable tabla = new DataTable();
            tabla = productos.Actualizar( codigo, producto, marca, modelo, version, precio );
            return tabla;
        }

        public DataTable Eliminar( int codigo ) {
            DataTable tabla = new DataTable();
            tabla = productos.Eliminar( codigo );
            return tabla;
        }
    }
}
