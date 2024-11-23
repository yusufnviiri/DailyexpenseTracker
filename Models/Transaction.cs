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
        public string? ProductName { get; set; }
        public int Quantity { get; set; }
        public string AgentName { get; set; } = string.Empty;
        public decimal SaleValue { get; set; }
        public DateTime DateOfTransaction { get; set; } = DateTime.Now;
        public string DateString { get; set; } = $"{DateTime.Now.Day}/{DateTime.Now.Month}/{DateTime.Now.Year}";

    }
}
