using AccesoAdatos;
using pfentidades;
using pfentidades.Modeladores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pfnegocio
{
    public class PlazoFijoNegocio
    {
        private PlazoFijoMapper _plazoFijoMapper;
        private List<PlazoFijo> _plazosFijos;
        private PlazoFijo _plazoFijo;

        public PlazoFijoNegocio()
        {
            _plazoFijoMapper = new PlazoFijoMapper();
            _plazosFijos = new List<PlazoFijo>();
            _plazoFijo = new PlazoFijo();


        }

        public List<PlazoFijo> TraerPlazosFijos()
        {
            _plazosFijos = _plazoFijoMapper.TraerTodos();
            return _plazosFijos;
        }

        public TransactionResult Alta(PlazoFijo _plazoFijo)
        {
            TransactionResult _resultado = new TransactionResult();
            if (_plazoFijo.CapitalInicial > 1000000)

            {
                throw new Exception("El monto maximo de capital no puede superar 1000000");
            }

            if (_plazoFijo.Tipo == 1)
            {
                if (_plazoFijo.dias > 365 || _plazoFijo.Tasa < 30)
                {
                    throw new Exception("Ingrese una cantidad de dias entre 30 y 365");

                }
            
            }

            if (_plazoFijo.Tipo == 2)
            {
                if (_plazoFijo.dias < 180  || _plazoFijo.dias >= 365)
                {
                    throw new Exception("Ingrese una cantidad de dias entre 180 y 365");

                }

            }
            _resultado = _plazoFijoMapper.Insertar(_plazoFijo);

            if (!_resultado.Isok)
            {
                throw new Exception(_resultado.Error);
            }
            return _resultado;
        }
    }
}
