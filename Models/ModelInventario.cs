using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSoft_RoGuapa.Models
{
    public class ModelInventario:BaseModel
    {
        private int _stock;

        public int Stock
        {
            get => _stock;
            set => SetProperty(ref _stock, value);
        }
    }
}
