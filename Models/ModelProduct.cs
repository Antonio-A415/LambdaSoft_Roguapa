using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSoft_RoGuapa.Models
{
    public class ModelProduct:BaseModel
    {
        private string _nombre;
        private float _precioVenta;
        private float _precioCompra;
        private string _marca;
        private string _slug;
        private bool? _merma;
        private int _categoriaId;
        private int _inventarioId;
        private ModelCategoria _categoria;
        private ModelInventario _inventario;

        public string Nombre
        {
            get => _nombre;
            set => SetProperty(ref _nombre, value);
        }

        public float PrecioVenta
        {
            get => _precioVenta;
            set => SetProperty(ref _precioVenta, value);
        }

        public float PrecioCompra
        {
            get => _precioCompra;
            set => SetProperty(ref _precioCompra, value);
        }

        public string Marca
        {
            get => _marca;
            set => SetProperty(ref _marca, value);
        }

        public string Slug
        {
            get => _slug;
            set => SetProperty(ref _slug, value);
        }

        public bool? Merma
        {
            get => _merma;
            set => SetProperty(ref _merma, value);
        }

        public int CategoriaId
        {
            get => _categoriaId;
            set => SetProperty(ref _categoriaId, value);
        }

        public int InventarioId
        {
            get => _inventarioId;
            set => SetProperty(ref _inventarioId, value);
        }

        public ModelCategoria Categoria
        {
            get => _categoria;
            set => SetProperty(ref _categoria, value);
        }

        public ModelInventario Inventario
        {
            get => _inventario;
            set => SetProperty(ref _inventario, value);
        }



    }
}
