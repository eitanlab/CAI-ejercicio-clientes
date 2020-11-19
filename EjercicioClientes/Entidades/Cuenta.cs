using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [DataContract]
    public class Cuenta
    {
        int _nroCuenta;
        string _descripcion;
        int _saldo;
        string _fechaApertura;
        string _fechaModificacion;
        bool _activo;
        int _idCliente;
        int _id;
        public Cuenta(int nro, string desc, int idCliente)
        {
            _nroCuenta = nro;
            _descripcion = desc;
            _saldo = 0;
            _fechaApertura = DateTime.Today.ToString();
            _fechaModificacion = DateTime.Today.ToString();
            _activo = true;
            _idCliente = idCliente;
        }
        public Cuenta(int nro, string desc,int saldo,string fechaApertura, string fechaModificacion,bool activo,int idCliente, int id) {
            _nroCuenta = nro;
            _descripcion = desc;
            _saldo = saldo;
            _fechaApertura = fechaApertura;
            _fechaModificacion = fechaModificacion;
            _activo = activo;
            _idCliente = idCliente;
            _id = id;
        }
        [DataMember]
        public int NroCuenta { get => _nroCuenta; set => _nroCuenta = value; }
        [DataMember]
        public string Descripcion { get => _descripcion; set => _descripcion= value; }
        [DataMember]
        public int Saldo { get => _saldo; set => _saldo= value; }
        [DataMember]
        public string FechaApertura{ get => _fechaApertura; set => _fechaApertura= value; }
        [DataMember]
        public string FechaModificacion { get => _fechaModificacion; set => _fechaModificacion = value; }
        [DataMember]
        public bool Activo { get => _activo; set => _activo= value; }
        [DataMember]
        public int IdCliente { get => _idCliente; set => _idCliente= value; }
        [DataMember]
        public int Id { get => _id; set => _id = value; }
    }
}
