using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pfentidades;
using pfentidades.Modeladores;

namespace AccesoAdatos
{
    public class PlazoFijoMapper
    {
        public List<PlazoFijo> TraerTodos()
        {
            string json = WebHelper.Get("PlazoFijo/889350");
            List<PlazoFijo> _resultado = MapList(json);
            return _resultado;
        }

        public List<PlazoFijo> MapList(string json)
        {
            List<PlazoFijo> _resultado = JsonConvert.DeserializeObject<List<PlazoFijo>>(json);
            return _resultado;

        }

        public TransactionResult Insertar(PlazoFijo plazoFijo)
        {
            NameValueCollection objecto = ReverseMap(plazoFijo);
            string json = WebHelper.Post("PlazoFijo", objecto);
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;

        }

        public NameValueCollection ReverseMap(PlazoFijo plazofijo)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", "0");
            n.Add("idCliente", "0");
            n.Add("Tipo", Convert.ToString(plazofijo.Tipo));
            n.Add("CapitalInicial", Convert.ToString(plazofijo.CapitalInicial));
            n.Add("Tasa", Convert.ToString(plazofijo.Tasa));
            n.Add("Dias", Convert.ToString(plazofijo.dias));
            n.Add("Interes", Convert.ToString(plazofijo.Interes));
            n.Add("MontoFinal", Convert.ToString(plazofijo.MontoFinal));
            n.Add("Usuario", "889350");

            return n;

        }
    }
}
