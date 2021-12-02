using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pfentidades.Entidades
{
    public class TipoPlazoFijo
    {
        private int _id;
        private string descripcion;
        private double _tasa;

        public TipoPlazoFijo()
        {
        }

        public TipoPlazoFijo(int id, string desc, double tasa)
         {
           
            _id = id;
            descripcion = desc;
            _tasa = tasa;

         }

        public int id { get=> _id; set=> _id =value; }
        public string description { get => descripcion; set => descripcion = value; }
        public double tasa { get => _tasa; set => _tasa = value; }

        public List<TipoPlazoFijo> CargarLista()
        {
            List<TipoPlazoFijo> _plazosFijos = new List<TipoPlazoFijo>();
            _plazosFijos.Add(new TipoPlazoFijo(1, "Plazo Fijo Web", 43));
            _plazosFijos.Add(new TipoPlazoFijo(2, "Plazo Fijo UVA", 2));

            return _plazosFijos;
        }

        public override string ToString()
        {
            return string.Format("{0}-{1}-{2}" , this.id,this.descripcion,this.tasa);
        }


    }
}
