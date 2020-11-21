using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class ClienteMapper
    {
        #region UTILIDADES
        // MapList transforma un json en una lista
        private static List<Cliente> MapList(string json)
        {
            List<Cliente> list = JsonConvert.DeserializeObject<List<Cliente>>(json);
            return list;
        }
        
        // ReverseMap recibe un objeto y devuelve un NameValueCollection (Serializa)
        private static NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("Dni", cliente.Dni);
            n.Add("Nombre", cliente.Nombre);
            n.Add("Apellido", cliente.Apellido);
            n.Add("Direccion", cliente.Direccion);
            n.Add("Email", cliente.Email);
            n.Add("Telefono", cliente.Telefono);
            n.Add("FechaNacimiento", "12-12-1990");
            n.Add("FechaAlta", DateTime.Today.ToString());
            n.Add("Activo", cliente.Activo.ToString());
            n.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);
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
        public static List<Cliente> TraerTodos()
        {
            string json = WebHelper.Get("/api/v1/cliente/" + ConfigurationManager.AppSettings["Legajo"]);
            List<Cliente> resultado = MapList(json);
            return resultado;
        }

        // Insert da de alta un nuevo objeto en la API
        public static TransactionResult Insert(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);
            string result = WebHelper.Post("/api/v1/cliente", obj);
            TransactionResult resultadoTransaccion = MapResultado(result);
            return resultadoTransaccion;
        }
        #endregion
    }
}
