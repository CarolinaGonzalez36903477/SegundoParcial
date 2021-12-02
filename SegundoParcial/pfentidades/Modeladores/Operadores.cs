using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pfentidades.Modeladores
{
    public class Operadores
    {
        private List<PlazoFijo> _plazosFijos;

        public Operadores(List<PlazoFijo> plazoFijos)
        {
            _plazosFijos = plazoFijos;
        }
        public Operadores()
        {
            
        }


        public Double MontoTotal()
        {
            double montoTotal = 0;
            foreach (PlazoFijo pf in _plazosFijos)
            {
                montoTotal = +pf.CapitalInicial;
            }

            return montoTotal;
        }

        public double ComisitiontOTAL()
        {
            double comisiontotal = 0;
            foreach(PlazoFijo pf in _plazosFijos)
            {

                comisiontotal = +15 + pf.Interes * 0.1;
            }

            return comisiontotal; 
        }
    }
}
