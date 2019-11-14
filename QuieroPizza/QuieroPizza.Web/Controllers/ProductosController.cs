using QuieroPizza.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuieroPizza.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var producto = new ProductoModel { Id = 1, Descripcion = "Pizza 6 quesos" };

            var producto1 = new ProductoModel { Id = 2, Descripcion = "Pizza 4 estaciones" };
            
            var producto2 = new ProductoModel { Id = 3, Descripcion = "Pizza Haiwaniana" };

            var listadeProductos = new List<ProductoModel>();
            listadeProductos.Add(producto);
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);

            return View(listadeProductos);
        }
    }
}