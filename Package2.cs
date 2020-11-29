using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CarWashBillingSystem.Model
{
    public class Package2
    {      

        public List<ServicesModel> GetServices()
        {
            List<ServicesModel> services = new List<ServicesModel>();

            services.Add(new ServicesModel { ServiceName = "PreSoak", IsChecked = true, Visibility = Visibility.Visible, Price = 20.00 });
            services.Add(new ServicesModel { ServiceName = "Drying Agent", IsChecked = true, Visibility = Visibility.Visible, Price = 20.00 });
            services.Add(new ServicesModel { ServiceName = "Softened Water", IsChecked = true, Visibility = Visibility.Visible, Price = 20.00 });
            services.Add(new ServicesModel { ServiceName = "Tyre Shine", IsChecked = true, Visibility = Visibility.Visible, Price = 20.00 });
            services.Add(new ServicesModel { ServiceName = "Rain Sheild", IsChecked = true, Visibility = Visibility.Visible, Price = 20.00 });

            return services;
        }
    }
}
