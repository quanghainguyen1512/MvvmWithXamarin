using MvvmHelpers;
using MyApp.Views;
using Xamarin.Forms;

namespace MyApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string _username;
        private string _password;

        public string Username
        {
            get { return _username; }
            set
            {
                if (_username != value)
                {
                    _username = value;
                    LoginCommand.ChangeCanExecute();
                }
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    LoginCommand.ChangeCanExecute();
                }
            }
        }

        public Command LoginCommand { get; }

        private readonly INavigation _navigation;
        public LoginViewModel(INavigation navigation)
        {
            LoginCommand = new Command(LoginExecute, CanLoginExecute);
            _navigation = navigation;
        }

        private bool CanLoginExecute()
        {
            return !string.IsNullOrEmpty(Username) && !string.IsNullOrEmpty(Password);
        }

        private void LoginExecute()
        {
            if (Username == "H" && Password == "1")
            {
                _navigation.PushAsync(new MainView());  
            }
        }
    }
}
