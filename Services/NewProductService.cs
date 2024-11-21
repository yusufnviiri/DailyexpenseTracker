using attendance.Models;
using attendance.ViewModel;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attendance.Services
{
    public class NewProductService
    {
        private readonly SQLiteAsyncConnection _database;

        public NewProductService()
        {
            _database = new SQLiteAsyncConnection(ApplicationDb.DatabasePath, ApplicationDb.Flags);
        }
        public async Task<IEnumerable<Product>> GetItemsAsync()
        {
            var products = await _database.Table<Product>().ToListAsync();
            return products;
           
        }
        public async Task<Product> GetItemAsync(int id) => await _database.FindAsync<Product>(id);
        public async Task CreateItemAsync(Product item)
        {
            if (item.ProductId != 0) // Update existing item
                await _database.UpdateAsync(item);
            else // Insert new item
                await _database.InsertAsync(item);

        }
        public async Task<int> DeleteItemAsync(Product item) => await _database.DeleteAsync(item);
    }
}
