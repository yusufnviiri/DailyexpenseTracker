using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attendance.Models
{
  public  class Transaction
    {
        [PrimaryKey, AutoIncrement]
        public int TransactionId { get; set; }
        public int ProductId { get; set; } 
        public int Quantity { get; set; }
        public string AgentName { get; set; } = string.Empty;
        public DateTime DateTime { get; set; } = DateTime.Now;
        public decimal SaleValue { get; set; }
    }
}
