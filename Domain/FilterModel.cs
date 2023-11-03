using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataAccess.SqlServer;
using Guna.UI2.WinForms;

namespace Domain {
    public class FilterModel {
        FiltrosDao filtroDao = new FiltrosDao();

        public void FiltrarContratos( string contratos, Guna2DataGridView dgDatos ) {
            filtroDao.FiltrarContratos( contratos, dgDatos );
        }
    }
}
