using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmHelpers;
using MyApp.Models;
using MyApp.Views;
using Xamarin.Forms;

namespace MyApp.ViewModels
{
    public class MainViewMordel : BaseViewModel
    {
        private INavigation _navigation;
        private Contact _contactSelected;
        public List<Contact> Contacts { get; set; }

        public Contact ContactSelected
        {
            get { return _contactSelected; }
            set
            {
                if (_contactSelected != value)
                {
                    _contactSelected = value;
                    if (_contactSelected != null)
                    {
                        _navigation.PushAsync(new DetailView(_contactSelected));
                    }
                }
            }
        }

        public MainViewMordel(INavigation navigation)
        {
            _navigation = navigation;

            Contacts = new List<Contact>(Data.GetContacts());

            Title = "My App";
        }
    }
}
