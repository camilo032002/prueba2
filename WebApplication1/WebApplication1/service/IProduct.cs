using WebApplication1.Models;

namespace WebApplication1.service
{
    public interface IProduct
    {
        public IEnumerable<tienda> get();

        public tienda? get(int id);



    }
}
