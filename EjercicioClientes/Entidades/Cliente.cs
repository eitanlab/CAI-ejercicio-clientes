using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        int _dni;
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
        public Cliente(int dni,string nombre, string apellido, string direccion, string email,string telefono,string fechaNacimiento,string fechaAlta, bool activo,string usuario,string host,int id) {
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
        public Cliente(int dni, string nombre, string apellido, string direccion, string email, string telefono, string fechaNacimiento, string usuario)
        {
            _dni = dni;
            _nombre = nombre;
            _apellido = apellido;
            _direccion = direccion;
            _email = email;
            _telefono = telefono;
            _fechaNacimiento = fechaNacimiento;
            _usuario = usuario;
        }
        public int Dni { get => _dni; set => _dni = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Email { get => _email; set => _email= value; }
        public string Telefono { get => _telefono; set => _telefono= value; }
        public string FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public string FechaAlta { get => _fechaAlta; set => _fechaAlta= value; }
        public bool Activo { get => _activo; set => _activo= value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public string Host { get => _host; set => _host = value; }
        public int Id { get => _id; set => _id = value; }


    }
}
