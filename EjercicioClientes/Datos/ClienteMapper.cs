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
    public class ClienteMapper
    {
        
        private List<Cliente> MapList(string json)
        {
            List<Cliente> list = JsonConvert.DeserializeObject<List<Cliente>>(json);
            return list;
        }
        public List<Cliente> TraerTodos() { 
            string json = WebHelper.Get("/api/v1/cliente");
            List<Cliente> resultado = MapList(json);
            return resultado;
        }
        public TransactionResult Insert(Cliente cliente)
        {
            NameValueCollection obj = ReverseMap(cliente);
            string result = WebHelper.Post("/api/v1/cliente", obj);
            TransactionResult resultadoTransaccion = MapResultado(result);
            return resultadoTransaccion;
        }
        private NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("Dni", cliente.Dni);
            n.Add("Nombre", cliente.Nombre);
            n.Add("Apellido", cliente.Apellido);
            n.Add("Direccion", cliente.Direccion);
            n.Add("Usuario", ConfigurationManager.AppSettings["Legajo"]);
            n.Add("Email", cliente.Email);
            n.Add("Telefono", cliente.Telefono);
            n.Add("FechaNacimiento", "12-12-1990");
            n.Add("FechaAlta", DateTime.Today.ToString());
            n.Add("Activo", cliente.Activo.ToString());
            n.Add("Usuario", cliente.Usuario);
            return n;
        }
        private TransactionResult MapResultado(string json)
        {
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }
        

    }
}
