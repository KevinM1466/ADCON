using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess.ComboBoxDA;

namespace Domain
{
    public class ComboBoxD
    {
        private ComboBoxDA objetoCD = new ComboBoxDA();

        public DataTable ListarPaises() {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ListarPais();
            return tabla;
        }

        public DataTable ListarCiudades(int pais) {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ListarCiudades(pais);
            return tabla;
        }

        public DataTable ListarUsuarios( int pais ) {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ListarCiudades( pais );
            return tabla;
        }

        public DataTable ListarCargos( ) {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ListarCargos();
            return tabla;
        }
        
        public DataTable ListarTipoU( ) {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ListarTipoUsuarios();
            return tabla;
        }
        
        public DataTable ListarMonedas( ) {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ListarMonedas();
            return tabla;
        }
    }
}
