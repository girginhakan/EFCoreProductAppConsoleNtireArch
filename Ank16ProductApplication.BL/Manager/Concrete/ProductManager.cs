using Ank16ProductApplication.BL.Manager.Abstract;
using Ank16ProductApplication.BL.Models;
using Ank16ProductApplication.DAL.Context;
using Ank16ProductApplication.DAL.Entities;
using Ank16ProductApplication.DAL.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ank16ProductApplication.BL.Manager.Concrete
{
    public class ProductManager:Manager<ProductModel,Product>
    {
        public ProductManager()
        {
            _repository = new ProductRepository(new ProductDbContext());
        }
    }
}
