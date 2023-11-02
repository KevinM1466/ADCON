using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases {
    public class Conversor {
        double moneda;

        public double dolar(double cambio) {
            moneda = cambio / 24.64;
            return moneda;
        }

        public double euro( double cambio ) {
            moneda = cambio / 26.13;
            return moneda;
        }
    }
}
