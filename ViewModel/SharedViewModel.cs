﻿using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attendance.ViewModel
{
    //[INotifyPropertyChanged]
   public partial class SharedViewModel:ObservableObject
    {
        public SharedViewModel()
        {
            
        }
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(IsNotBusy))]
        bool isBusy;
        [ObservableProperty]

        string title;
        public bool IsNotBusy=>!isBusy;
    }
}
