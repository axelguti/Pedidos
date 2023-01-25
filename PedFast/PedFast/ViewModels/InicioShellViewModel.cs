using PedFast.Shells;
using PedFast.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PedFast.ViewModels
{
    public class InicioShellViewModel
    {
        public InicioShellViewModel()
        {
            Routing.RegisterRoute("home", typeof(AboutPage));
        }

    }
}
