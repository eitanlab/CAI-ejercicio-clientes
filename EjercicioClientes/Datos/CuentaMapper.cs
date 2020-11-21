using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public static class CuentaMapper
    {
        #region UTILIDADES
        private static List<Cuenta> MapList(string json)
        {
            List<Cuenta> list = JsonConvert.DeserializeObject<List<Cuenta>>(json);
            return list;
        }
        private static NameValueCollection ReverseMap(Cuenta cuenta)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("nroCuenta", cuenta.NroCuenta);
            n.Add("descripcion", cuenta.Descripcion);
            n.Add("saldo", cuenta.Saldo.ToString());
            n.Add("fechaApertura", cuenta.FechaApertura);
            n.Add("fechaModificacion", cuenta.FechaModificacion);
            n.Add("activo", cuenta.Activo.ToString());
            n.Add("idCliente", cuenta.IdCliente);
            return n;
        }
        private static TransactionResult MapResultado(string json)
        {
            TransactionResult lst = JsonConvert.DeserializeObject<TransactionResult>(json);
            return lst;
        }
        #endregion

        #region GET POST
        public static List<Cuenta> TraerTodos()
        {
            string json = WebHelper.Get("/api/v1/Cuenta");
            List<Cuenta> resultado = MapList(json);
            return resultado;
        }
        public static TransactionResult Insert(Cuenta cuenta)
        {
            NameValueCollection obj = ReverseMap(cuenta);
            string result = WebHelper.Post("api/v1/cuenta", obj);
            TransactionResult resultadoTransaccion = MapResultado(result);
            return resultadoTransaccion; 
        }

        #endregion
    }
}
