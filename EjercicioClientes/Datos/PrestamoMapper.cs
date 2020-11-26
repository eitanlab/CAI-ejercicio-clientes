using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Newtonsoft.Json;

namespace Datos
{
    public static class PrestamoMapper
    {
        #region UTILIDADES
        // MapList transforma un json en una lista
        private static List<Prestamo> MapList(string json)
        {
            List<Prestamo> list = JsonConvert.DeserializeObject<List<Prestamo>>(json);
            return list;
        }
        private static Prestamo MapItem(string json)
        {
            Prestamo prestamo = JsonConvert.DeserializeObject<Prestamo>(json);
            return prestamo;
        }

        // ReverseMap recibe un objeto y devuelve un NameValueCollection (Serializa)
        private static NameValueCollection ReverseMap(Prestamo prestamo)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("linea", prestamo.Linea);
            n.Add("tna", prestamo.TNA.ToString());
            n.Add("plazo", prestamo.Plazo.ToString());
            n.Add("monto", prestamo.Monto.ToString());
            n.Add("usuario", ConfigurationManager.AppSettings["Legajo"]);
            n.Add("cuota", prestamo.Cuota.ToString());
            
            return n;
        }

        // MapList transforma un json en un TransactionResult
        private static TransactionResult MapResultado(string json)
        {
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }
        #endregion

        #region GET POST
        // TraerTodos trae todos los elementos de una entidad. 
        // Llama a la API, convierte el json en una lista con Maplist
        // Retorna la lista
        public static List<Prestamo> TraerTodos()
        {
            string json = WebHelper.Get("/api/v1/prestamo/" + ConfigurationManager.AppSettings["Legajo"]);
            List<Prestamo> resultado = MapList(json);
            return resultado;
        }
        public static Prestamo TraerPrestamoPorCliente(string idCliente)
        {
            string json = WebHelper.Get("/api/v1/prestamo/" + ConfigurationManager.AppSettings["Legajo"] + "/" + idCliente);
            Prestamo resultado = MapItem(json);
            return resultado;
        }

        // Insert da de alta un nuevo objeto en la DB
        public static TransactionResult Insert(Prestamo prestamo)
        {
            NameValueCollection obj = ReverseMap(prestamo);
            string result = WebHelper.Post("/api/v1/prestamo", obj);
            TransactionResult resultadoTransaccion = MapResultado(result);
            return resultadoTransaccion;
        }
        #endregion
    }
}
