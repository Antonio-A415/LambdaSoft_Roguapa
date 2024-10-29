using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSoft_RoGuapa.Models
{
    public class ModelCaja:BaseModel
    {

        private float _montoApertura;
        private float _montoCierre;
        private DateTime _fecha;
        private int _empleadoId;
        private ModelEmpleado _empleado;

        public float MontoApertura
        {
            get => _montoApertura;
            set => SetProperty(ref _montoApertura, value);
        }

        public float MontoCierre
        {
            get => _montoCierre;
            set => SetProperty(ref _montoCierre, value);
        }

        public DateTime Fecha
        {
            get => _fecha;
            set => SetProperty(ref _fecha, value);
        }

        public int EmpleadoId
        {
            get => _empleadoId;
            set => SetProperty(ref _empleadoId, value);
        }

        public ModelEmpleado Empleado
        {
            get => _empleado;
            set => SetProperty(ref _empleado, value);
        }
    }
}
