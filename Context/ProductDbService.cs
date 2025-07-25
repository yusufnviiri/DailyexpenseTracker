using attendance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attendance.Context
{
 public class ProductDbService:RepoManager<Product>
    {
        public ProductDbService(AppDbContext db):base(db) { }
       
    }
}
