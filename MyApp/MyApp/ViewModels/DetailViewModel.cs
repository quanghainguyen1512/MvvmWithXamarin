﻿using MvvmHelpers;
using MyApp.Models;

namespace MyApp.ViewModels
{
    public class DetailViewModel : BaseViewModel
    {
        private Contact _contact;

        public Contact Contact
        {
            get { return _contact; }
            set => SetProperty(ref _contact, value);
            //OR
            //set{
            //if (_contact !=  value)
            //{
            //    _contact = value;
            //    OnPropertyChanged(nameof(Contact));
            //}}
        }

        public DetailViewModel()
        {
            
        }

        public void SetData(Contact contact)
        {
            Contact = contact;

            Title = Contact.FullName;
        }
    }
}
