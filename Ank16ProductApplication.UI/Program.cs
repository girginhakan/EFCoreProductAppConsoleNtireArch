using Ank16ProductApplication.BL.Manager.Concrete;
using Ank16ProductApplication.BL.Models;

namespace Ank16ProductApplication.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ProductManager productManager = new ProductManager();
            ProductModel model = new ProductModel();
            model.Name = "Ekmek";
            model.Price = 100.0d;
            productManager.Add(model);

            foreach (var item in productManager.GetAll())
            {
                Console.WriteLine("Ürün Id : " + item.Id + "Ürün adı : " + item.Name + "Fiyatı : " + item.Price);
            }
        }
    }
}
