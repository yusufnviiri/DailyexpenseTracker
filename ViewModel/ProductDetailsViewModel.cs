using attendance.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attendance.ViewModel
{
    
    [QueryProperty("Product","ProductParam")]

    public partial class ProductDetailsViewModel:SharedViewModel
    {
        public ProductDetailsViewModel()
        {

            
        }
        [ObservableProperty]
        Product product;
    }
}
