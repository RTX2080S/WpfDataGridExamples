using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Data;

namespace DataGrid
{
    public class MainWindowViewModel
    {
        public ICollectionView Customers { get; private set; }
        public ICollectionView GroupedCustomers { get; private set; }


        public MainWindowViewModel()
        {
            var _customers = new List<Customer>
                                 {
                                     new Customer
                                         {
                                             FirstName = "Christian",
                                             LastName = "Moser",
                                             Gender = Gender.Male,
                                             WebSite = new Uri("http://www.wpftutorial.net"),
                                             ReceiveNewsletter = true,
                                             Image = "Images/christian.jpg"
                                         },
                                     new Customer
                                         {
                                             FirstName = "Peter",
                                             LastName = "Meyer",
                                             Gender = Gender.Male,
                                             WebSite = new Uri("http://www.petermeyer.com"),
                                             Image = "Images/peter.jpg"
                                         },
                                     new Customer
                                         {
                                             FirstName = "Lisa",
                                             LastName = "Simpson",
                                             Gender = Gender.Female,
                                             WebSite = new Uri("http://www.thesimpsons.com"),
                                             Image = "Images/lisa.jpg"
                                         },
                                     new Customer
                                         {
                                             FirstName = "Betty",
                                             LastName = "Bossy",
                                             Gender = Gender.Female,
                                             WebSite = new Uri("http://www.bettybossy.ch"),
                                             Image = "Images/betty.jpg"
                                         }
                                 };

            Customers = CollectionViewSource.GetDefaultView(_customers);

            GroupedCustomers = new ListCollectionView(_customers);
            GroupedCustomers.GroupDescriptions.Add(new PropertyGroupDescription("Gender"));

            
        }
    }
}
