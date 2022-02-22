using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MVCDemo.Controllers
{
    public class ControllerBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}