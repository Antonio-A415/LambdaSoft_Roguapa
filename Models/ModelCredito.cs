using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSoft_RoGuapa.Models
{
    public class ModelCredito:BaseModel
    {
        private float _monto;
        private DateTime _fecha;
        private int _plazos;
        private float _montoAbono;
        private int _clienteId;
        private int _empleadoId;
        private DateTime _fechaLimite;
        private ModelClient _cliente;
        private ModelEmpleado _empleado;

        public float Monto
        {
            get => _monto;
            set => SetProperty(ref _monto, value);
        }

        public DateTime Fecha
        {
            get => _fecha;
            set => SetProperty(ref _fecha, value);
        }

        public int Plazos
        {
            get => _plazos;
            set => SetProperty(ref _plazos, value);
        }

        public float MontoAbono
        {
            get => _montoAbono;
            set => SetProperty(ref _montoAbono, value);
        }

        public int ClienteId
        {
            get => _clienteId;
            set => SetProperty(ref _clienteId, value);
        }

        public int EmpleadoId
        {
            get => _empleadoId;
            set => SetProperty(ref _empleadoId, value);
        }

        public DateTime FechaLimite
        {
            get => _fechaLimite;
            set => SetProperty(ref _fechaLimite, value);
        }

        public ModelClient Cliente
        {
            get => _cliente;
            set => SetProperty(ref _cliente, value);
        }

        public ModelEmpleado Empleado
        {
            get => _empleado;
            set => SetProperty(ref _empleado, value);
        }
    }
}
