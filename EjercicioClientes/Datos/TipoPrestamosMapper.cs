using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Newtonsoft.Json;

namespace Datos
{
    public static class TipoPrestamosMapper
    {
        #region UTILIDADES
        // MapList transforma un json en una lista
        private static List<TipoPrestamo> MapList(string json)
        {
            List<TipoPrestamo> list = JsonConvert.DeserializeObject<List<TipoPrestamo>>(json);
            return list;
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
        public static List<TipoPrestamo> TraerTodos()
        {
            string json = WebHelper.Get("/api/v1/prestamotipo");
            List<TipoPrestamo> resultado = MapList(json);
            return resultado;
        }
        #endregion
    }
}
