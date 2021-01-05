﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace MotorControl.Commons.Shared
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private bool _isLoaded;
        public virtual void Initialize() { }

        public virtual void OnLoaded(object sender, RoutedEventArgs args)
        {
            if (!_isLoaded)
            {
                _isLoaded = true;
            }
        }

        public virtual void OnUnloaded(object sender, RoutedEventArgs args)
        {
            if (_isLoaded)
            {
                _isLoaded = false;
            }
        }
    }
}