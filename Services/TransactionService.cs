using attendance.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attendance.Services { 

public class TransactionService
{
    private readonly SQLiteAsyncConnection _database;

    public TransactionService()
    {
        _database = new SQLiteAsyncConnection(ApplicationDb.DatabasePath, ApplicationDb.Flags);
    }
    public async Task<IEnumerable<Transaction>> GetItemsAsync()
    {
        var transactions = await _database.Table<Transaction>().ToListAsync();
        //return products.OrderByDescending(k=>k.ProductId);
        //return products.OrderBy(k=>k.ProductId).Reverse();
        return transactions.OrderBy(k => k.DateOfTransaction);
    }
    public async Task<Transaction> GetItemAsync(int id) => await _database.FindAsync<Transaction>(id);
    public async Task CreateItemAsync(Transaction item)
    {
        if (item.TransactionId != 0) // Update existing item
            await _database.UpdateAsync(item);
        else // Insert new item
            await _database.InsertAsync(item);
    }
    public async Task<int> DeleteItemAsync(Transaction item) => await _database.DeleteAsync(item);
} }