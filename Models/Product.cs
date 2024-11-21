using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attendance.Models
{
   public class Product
    {
        [PrimaryKey, AutoIncrement]
        public int ProductId { get; set; }
        public string ProductName { get; set; }= string.Empty;
        public decimal Cost {  get; set; }
    }
}
