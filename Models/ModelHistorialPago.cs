using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSoft_RoGuapa.Models
{
    public class ModelHistorialPago : BaseModel
    {
        private float _montoPagado;
        private DateTime _fechaPago;
        private string _estado;
        private string _metodoPago;
        private string _observacion;
        private int _creditoId;
        private ModelCredito _credito;

        public float MontoPagado
        {
            get => _montoPagado;
            set => SetProperty(ref _montoPagado, value);
        }

        public DateTime FechaPago
        {
            get => _fechaPago;
            set => SetProperty(ref _fechaPago, value);
        }

        public string Estado
        {
            get => _estado;
            set => SetProperty(ref _estado, value);
        }

        public string MetodoPago
        {
            get => _metodoPago;
            set => SetProperty(ref _metodoPago, value);
        }

        public string Observacion
        {
            get => _observacion;
            set => SetProperty(ref _observacion, value);
        }

        public int CreditoId
        {
            get => _creditoId;
            set => SetProperty(ref _creditoId, value);
        }

        public ModelCredito Credito
        {
            get => _credito;
            set => SetProperty(ref _credito, value);
        }
    }
}
