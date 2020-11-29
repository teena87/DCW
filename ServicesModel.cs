using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CarWashBillingSystem.Model
{
    public class ServicesModel :INotifyPropertyChanged
    {
        private bool isChecked = false;
        private Visibility isVisible;
        private string _serviceName;
        private double _price;
        public bool IsChecked
        {
            get { return isChecked; }
            set
            {
                isChecked = value;
                OnPropertyChanged("IsChecked");
            }
        }
       
        public string ServiceName
        {
            get { return _serviceName; }
            set { _serviceName = value; }
        }

        public Visibility Visibility
        {
            get { return isVisible; }
            set { isVisible = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = (double)value; }
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

    }
}
