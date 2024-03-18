using Ank16ProductApplication.DAL.Context;
using Ank16ProductApplication.DAL.Entities;
using Ank16ProductApplication.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ank16ProductApplication.DAL.Repository.Concrete
{
    public class ProductRepository:Repository<Product>
    {
        public ProductRepository(ProductDbContext db):base(db)
        {
            
        }
    }
}
