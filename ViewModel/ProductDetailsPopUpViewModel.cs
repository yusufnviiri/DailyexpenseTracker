using attendance.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attendance.ViewModel
{
    public partial class ProductDetailsPopUpViewModel:SharedViewModel
    {

        public ProductDetailsPopUpViewModel(Product product)
        {
            Product = product;
        }
        [ObservableProperty]
        Product product;
    }
}
