using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuieroPizza.BL
{
    public class ProductosBL
    {
        public List<Producto> ObtenerProductos()
        {
            var producto = new Producto { Id = 1, Descripcion = "Pizza 6 quesos", Precio = 200 };

            var producto1 = new Producto { Id = 2, Descripcion = "Pizza 4 estaciones", Precio = 150 };

            var producto2 = new Producto { Id = 3, Descripcion = "Pizza Haiwaniana", Precio = 180 };

            var listadeProductos = new List<Producto>();
            listadeProductos.Add(producto);
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);

            return listadeProductos;
        }
    }
}
