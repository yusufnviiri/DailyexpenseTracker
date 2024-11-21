using attendance.Models;
using SQLite;
using System.Collections.ObjectModel;

namespace attendance.oldFiles;

public partial class NewProduct : ContentPage
{

    private readonly SQLiteAsyncConnection _database;
    public ObservableCollection<Product> ProductCollection { get; set; } = new ObservableCollection<Product>();


    public NewProduct()
    {
        InitializeComponent();
        _database = new SQLiteAsyncConnection(ApplicationDb.DatabasePath, ApplicationDb.Flags);
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await GetItemsAsync();
    }
    public async Task GetItemsAsync()
    {
        var products = await _database.Table<Product>().ToListAsync();
        ProductCollection.Clear();
        foreach (var item in products)
        {
            ProductCollection.Add(item);
        }
        ProductList.ItemsSource = ProductCollection;
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

    private async void Save(object sender, EventArgs e)
    {
        Product item = new Product() { Cost = Convert.ToDecimal(pCost.Text), ProductName = pName.Text };
        pName.Text = pCost.Text = "";
        await CreateItemAsync(item);
        await GetItemsAsync();
    }

    private async void GetProductsFromDb(object sender, EventArgs e)
    {
        await GetItemsAsync();

    }
}