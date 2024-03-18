using Ank16ProductApplication.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ank16ProductApplication.DAL.Repository.Abstract
{
    public abstract class Entity : IEntity
    {
        public int Id { get ; set ; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime DeletedDate { get; set; }
        public Status Status { get; set; }
    }
}
