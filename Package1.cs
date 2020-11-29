using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CarWashBillingSystem.Model
{
    public class Package1
    {
        public List<ServicesModel> GetServices()
        {
            List<ServicesModel> services = new List<ServicesModel>();

            services.Add(new ServicesModel { ServiceName = "PreSoak", Visibility = Visibility.Visible, Price = 10.00 });
            services.Add(new ServicesModel { ServiceName = "Softened Water", Visibility = Visibility.Visible, Price = 10.00 });
            services.Add(new ServicesModel { ServiceName = "Drying Agent", Visibility = Visibility.Visible, Price = 10.00 });

            return services;
        }
    }
}
