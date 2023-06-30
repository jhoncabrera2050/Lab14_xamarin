﻿using Lab14.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Lab14.ViewModels
{
    public class BaseProductViewModel:INotifyPropertyChanged
    {
        private Productinfo _productinfo;
        public Productinfo Productinfo
        {
            get { return _productinfo; }
            set { _productinfo = value; OnPropertyChanged(); }
        }

        bool isBusy = false;
        public bool IsBussy
        {
            get { return isBusy; }
            set
            {
                SetProperty(ref isBusy, value);
            }
        }

        protected bool SetProperty<T>(ref T backingStore,T value,
            [CallerMemberName] string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;
            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            var changed = PropertyChanged;
            if (changed == null)
            {
                return;
                changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
