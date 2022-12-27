using System.Xml.Linq;
using WebApplication1.Models;

namespace WebApplication1.service
{
    public class ProductService : IProduct
    {
        private List<tienda> _tiendas = new List<tienda>()
        {
            new tienda() { id = 1, nombre = "camilo", producto = "colageno"},
            new tienda() { id = 2, nombre = "perez", producto = "camisa"}
         };


        public IEnumerable<tienda> get() => _tiendas;

        public tienda? get(int id) => _tiendas.FirstOrDefault(t => t.id == id);
    }
}
