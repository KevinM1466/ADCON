using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.cache {
    public class ContratosCache {
        public static DateTime fechaIncio  { get; set; }
        public static DateTime fechaFinal  { get; set; }
        public static int clienteID { get; set; }
        public static string Cliente { get; set; }
        public static string codigoMoneda { get; set; }
        public static string moneda { get; set; }
        public static string tipoF { get; set; }
        public static int cantidadCuotas { get; set; }
        public static string comentario { get; set; }
        public static bool renovacion { get; set; }
    }
}
