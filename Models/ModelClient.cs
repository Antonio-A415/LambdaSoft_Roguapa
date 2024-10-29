using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSoft_RoGuapa.Models
{
    public class ModelClient: BaseModel
    {
        private string _nombre;
        private int _contadorCompras;
        private string _telefono;
        private string _direccion;
        private bool _esFrecuente;

        public string Nombre
        {
            get => _nombre;
            set => SetProperty(ref _nombre, value);
        }

        public int ContadorCompras
        {
            get => _contadorCompras;
            set => SetProperty(ref _contadorCompras, value);
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

        public bool EsFrecuente
        {
            get => _esFrecuente;
            set => SetProperty(ref _esFrecuente, value);
        }
    }
}
