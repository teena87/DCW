using CarWashBillingSystem.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using static CarWashBillingSystem.Model.MainWindowModel;

namespace CarWashBillingSystem.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        bool isPackage1Checked = false;
        bool isPackage2Checked = false;
        bool isPackage3Checked = false;

        Package1 pac1 = new Package1();
        Package2 pac2 = new Package2();
        Package3 pac3 = new Package3();

        bool isServiceChecked = false;
        public MainWindowViewModel()
        {
           
        }
        public bool Package1Checked
        {
            get { return isPackage1Checked; }
            set
            {
                isPackage1Checked = value;
                if(isPackage1Checked)
                {
                    if (SelectedServices != null)
                        SelectedServices.Clear();
                    SelectedServices = new ObservableCollection<ServicesModel>(pac1.GetServices());                    
                    OnPropertyChanged("SelectedServices");
                }
                   
            }
        }
        public bool Package2Checked
        {
            get { return isPackage2Checked; }
            set
            {
                isPackage2Checked = value;
                if (isPackage2Checked)
                {
                    if (SelectedServices != null)
                        SelectedServices.Clear();
                    SelectedServices = new ObservableCollection<ServicesModel>(pac2.GetServices());
                    OnPropertyChanged("SelectedServices");
                }
            }
        }
        public bool Package3Checked
        {
            get { return isPackage3Checked; }
            set
            {
                isPackage3Checked = value;
                if (isPackage3Checked)
                {
                    if (SelectedServices != null)
                        SelectedServices.Clear();
                    SelectedServices = new ObservableCollection<ServicesModel>(pac3.GetServices());
                    OnPropertyChanged("SelectedServices");
                }
            }
        }

        //public bool IsServiceChecked
        //{
        //    get { return isServiceChecked;  }
        //    set
        //    {
        //        isServiceChecked = value;
        //        OnPropertyChanged("IsServiceChecked");
        //    }
        //}

        private ICommand calculate;
        public ICommand Calculate
        {
            get
            {                
                //return calculate ?? (calculate = new CommandHandler(() => DoCalculate(), () => CanExecute));
                return calculate = new CommandHandler(DoCalculate);
            }    
        }

        ObservableCollection<ServicesModel> _selectedServices;

        public ObservableCollection<ServicesModel> SelectedServices
        {
            get { return _selectedServices; }
            set { _selectedServices = value; }
        }

        public bool CanExecute
        {
            get
            {
                return true;
            }
        }
        public void DoCalculate()
        {

            //To do
            //check which checkbox is selected
            //Add to a list
            //check which package selected
            


            if (Package1Checked)
            {               
                //billAmt = pac1.TotalBill().ToString();
                double price = 0.00;
                foreach (ServicesModel service in SelectedServices)
                {
                    if(service.IsChecked == true)
                        price = price + service.Price;
                }
                billAmt = CustomerDetails + "\n" + price.ToString();
            }
            else if (Package2Checked)
            {
                // billAmt = pac2.TotalBill().ToString();
                double price = 0.00;
                foreach (ServicesModel service in SelectedServices)
                {
                    if (service.IsChecked == true)
                        price = price + service.Price;
                }
                billAmt = CustomerDetails +"\n" + price.ToString();
            }

            else if (Package3Checked)
            {
                // billAmt = pac3.TotalBill().ToString();
                double price = 0.00;
                foreach (ServicesModel service in SelectedServices)
                {
                    if (service.IsChecked == true)
                        price = price + service.Price;
                }
                billAmt = CustomerDetails +"\n" + price.ToString();
            }            
            OnPropertyChanged("BillAmount");
        }
        private string billAmt = "";
        public string BillAmount
        {
            get { return billAmt; }
            set { billAmt = value; }
        }

        private string customerDet = "";
        public string CustomerDetails
        {
            get { return customerDet; }
            set
            {
                customerDet = value;
                OnPropertyChanged("CustomerDetails");
            }
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
