using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using attendance.Models;
using Microsoft.VisualBasic;
using Microsoft.Data.Sqlite;
using System.IO;
using FileSystem = Microsoft.Maui.Storage.FileSystem;
namespace attendance.Services
{
    public class DatabaseService
    {
        private readonly SQLiteAsyncConnection _database;
        //string DbPath = Path.Combine(FileSystem.AppDataDirectory, "TodouioyhiutuoItems.db3");
        private string DbPath => Path.Combine(FileSystem.AppDataDirectory, "demo.db");
        //private string DbPath => Path.Combine(FileSystem.AppDataDirectory, "demdddo.db");

        public bool DatabaseExists()
        {
            // Check if the database file exists
            if (File.Exists(ApplicationDb.DatabasePath))
            { return true; }
            else
            {

                return false;
            }
        }
       
          
          
        
        public DatabaseService()
        {

            //if (!DatabaseExists() && _database is not null) return;
            if (DatabaseExists()) return;

            if ( _database is not null) return;

         _database = new SQLiteAsyncConnection(ApplicationDb.DatabasePath, ApplicationDb.Flags);
        _database.CreateTableAsync<Product>().Wait();
        _database.CreateTableAsync<Transaction>().Wait();


    }

      
    }

}
