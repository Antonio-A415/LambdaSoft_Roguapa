using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaSoft_RoGuapa.Models
{
    public class ModelCategoria:BaseModel
    {
        private string _nombre;
        private string _descripcion;

        public string Nombre
        {
            get => _nombre;
            set => SetProperty(ref _nombre, value);
        }

        public string Descripcion
        {
            get => _descripcion;
            set => SetProperty(ref _descripcion, value);
        }

        /*
        public DataTable MostrarProducto()
        {
            DataTable productos = new DataTable();
            string query = "SELECT * FROM Productos;";

            using(MySqlConnection conn = miconexion.GetConnection())
            {
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter=new MySqlDataAdapter(command);


                
                adapter.Fill(productos);
            }
            return productos;
        }*/
    }
}
