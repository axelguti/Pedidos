using PedFast.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PedFast.ViewModels
{
    public class LoginShellViewModel
    {
        public LoginShellViewModel()
        {
            Routing.RegisterRoute("Login", typeof(LoginPage));
        }
    }
}
