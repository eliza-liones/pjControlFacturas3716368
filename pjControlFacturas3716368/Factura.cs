using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjControlFacturas3716368
{
    public class Factura
    {
        private int _numFactura;
        private DateTime _fechaFact;
        private double _montoFact;

        static private double acumulado;
        static private int n;

        public Factura(int numFactura, DateTime fechaFact, double montoFact)
        {
            _numFactura = numFactura;
            _fechaFact = fechaFact;
            _montoFact = montoFact;

            acumulado += montoFact;
            n++;
        }

        public int numFacura
        {
            get { return _numFactura; }
        }
        public DateTime fechaFact
        {
            get { return _fechaFact; }
        }
        public double montoFact
        {
            get { return _montoFact; }
        }
        public int totalFacturas()
        {
            return n;
        }
        public double calculaTotalSubtotal() 
        { 
            return acumulado;
        }
        public double calculaComision()
        {
            return 0.12 * calculaTotalSubtotal();
        }
    }
}
