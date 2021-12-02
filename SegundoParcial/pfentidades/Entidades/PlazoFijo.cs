using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pfentidades
{
    public class PlazoFijo
    {
        private int _id;
        private int _idCliente;
        private int _tipo;
        private double _montoFinal;
        private double _tasa;
        private int _dias;
        private double _capitalInicial;
        private double _interes;
        private string _usuario;

        public PlazoFijo()
        { }

        public int id { get=> _id; set=> _id=value; }
        public int idCliente { get => _idCliente; set => _idCliente = value; }
        public int Tipo { get => _tipo; set => _tipo = value; }
        public int dias { get => _dias; set => _dias = value; }
        public double Tasa { get => _tasa; set => _tasa = value; }
        public double CapitalInicial { get => _capitalInicial; set => _capitalInicial = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }

        public double Interes
        {
            set { _interes = value; }
            get
            {
                _interes = ((_tasa / 365) * _capitalInicial) / 100;
                return _interes;
            }

        }
        public double MontoFinal
        {
            set{ _montoFinal = value; }
            get
            {
                _montoFinal = (_capitalInicial+ Interes);
                return _montoFinal;
            }
        
        }

      

        public override string ToString()
        {
            return string.Format("{0})-{1}-{2} ARS-({3})- tipo:{4}", this.id, this.dias, this.CapitalInicial, this.Interes, this.Tipo);
        }
    }
}
