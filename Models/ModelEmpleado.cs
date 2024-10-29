using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSoft_RoGuapa.Models
{
    public class ModelEmpleado:BaseModel
    {
        private string _nombre;
        private char _rol;
        private string _telefono;
        private string _direccion;
        private string _contrasenia;

        public string Nombre
        {
            get => _nombre;
            set => SetProperty(ref _nombre, value);
        }

        public char Rol
        {
            get => _rol;
            set => SetProperty(ref _rol, value);
        }

        public string Telefono
        {
            get => _telefono;
            set => SetProperty(ref _telefono, value);
        }

        public string Direccion
        {
            get => _direccion;
            set => SetProperty(ref _direccion, value);
        }

        public string Contrasenia
        {
            get => _contrasenia;
            set => SetProperty(ref _contrasenia, value);
        }
    }
}
