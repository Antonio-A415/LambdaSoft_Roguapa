using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSoft_RoGuapa.Models
{
    internal class ModelVenta:BaseModel
    {
        private DateTime _fecha;
        private float _monto;
        private int _empleadoId;
        private int _productoId;
        private int _productoCategoriaId;
        private int _productoInventarioId;
        private ModelEmpleado _empleado;
        private ModelProduct _producto;

        public DateTime Fecha
        {
            get => _fecha;
            set => SetProperty(ref _fecha, value);
        }

        public float Monto
        {
            get => _monto;
            set => SetProperty(ref _monto, value);
        }

        public int EmpleadoId
        {
            get => _empleadoId;
            set => SetProperty(ref _empleadoId, value);
        }

        public int ProductoId
        {
            get => _productoId;
            set => SetProperty(ref _productoId, value);
        }

        public int ProductoCategoriaId
        {
            get => _productoCategoriaId;
            set => SetProperty(ref _productoCategoriaId, value);
        }

        public int ProductoInventarioId
        {
            get => _productoInventarioId;
            set => SetProperty(ref _productoInventarioId, value);
        }

        public ModelEmpleado Empleado
        {
            get => _empleado;
            set => SetProperty(ref _empleado, value);
        }

        public ModelProduct Producto
        {
            get => _producto;
            set => SetProperty(ref _producto, value);
        }
    }
}
