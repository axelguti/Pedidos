using PedFast.Models;
using PedFast.Shells;
using PedFast.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PedFast.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Command LoginCommand { get; }

        public LoginViewModel()
        {

            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            if (await Task.Run(() => ValidateUser()))
            {
                Application.Current.MainPage = new InicioShell();
            }
        }
        private async Task<bool> ValidateUser()
        {
            Cliente cliente = new Cliente();
            if (await Task.Run(() => cliente) ==null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
