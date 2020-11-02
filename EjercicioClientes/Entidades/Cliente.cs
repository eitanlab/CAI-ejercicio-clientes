using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [DataContract]
    public class Cliente
    {
        string _dni;
        string _nombre;
        string _apellido;
        string _direccion;
        string _email;
        string _telefono;
        string _fechaNacimiento;
        string _fechaAlta;
        bool _activo;
        string _usuario;
        string _host;
        int _id;
        public Cliente() { }
        public Cliente(string dni,string nombre,string apellido)
        {
            _dni = dni;
            _nombre = nombre;
            _apellido = apellido;
        }
        public Cliente(string dni,string nombre, string apellido, string direccion, string email,string telefono,string fechaNacimiento,string fechaAlta, bool activo,string usuario,string host,int id) {
            _dni = dni;
            _nombre = nombre;
            _apellido = apellido;
            _direccion = direccion;
            _email = email;
            _telefono = telefono;
            _fechaNacimiento = fechaNacimiento;
            _fechaAlta = fechaAlta;
            _activo = activo;
            _usuario = usuario;
            _host = host;
            _id = id;
        }
        public Cliente(string dni, string nombre, string apellido, string direccion)
        {
            _dni = dni;
            _nombre = nombre;
            _apellido = apellido;
            _direccion = direccion;
        }

        [DataMember]
        public string Dni { get => _dni; set => _dni = value; }
        [DataMember]
        public string Nombre { get => _nombre; set => _nombre = value; }
        [DataMember]
        public string Apellido { get => _apellido; set => _apellido = value; }
        [DataMember]
        public string Direccion { get => _direccion; set => _direccion = value; }
        [DataMember]
        public string Email { get => _email; set => _email= value; }
        [DataMember]
        public string Telefono { get => _telefono; set => _telefono= value; }
        [DataMember]
        public string FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        [DataMember]
        public string FechaAlta { get => _fechaAlta; set => _fechaAlta= value; }
        [DataMember]
        public bool Activo { get => _activo; set => _activo= value; }
        [DataMember]
        public string Usuario { get => _usuario; set => _usuario = value; }
        [DataMember]
        public string Host { get => _host; set => _host = value; }
        [DataMember]
        public int Id { get => _id; set => _id = value; }

        public override string ToString()
        {
            return "Nombre: " + _nombre + " Apellido: " + _apellido;
        }
    }
}
