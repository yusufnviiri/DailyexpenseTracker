﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace attendance.ViewModel
{
    public class BaseVMGeneric : INotifyPropertyChanged
    {
        bool isBusy;
        string title;
        public string Title
        {
            get => title;
            set
            {
                if (title == value) return;
                title = value; OnPropertyChanged();
            }
        }
        public bool IsNotBusy => !IsBusy;
            public bool IsBusy  
        {
            get => isBusy;
            set
            {
                if (isBusy == value) return;
                isBusy = value; OnPropertyChanged();
                OnPropertyChanged(nameof(IsNotBusy));

            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged( [CallerMemberName]string? name =null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
    }
   
}
