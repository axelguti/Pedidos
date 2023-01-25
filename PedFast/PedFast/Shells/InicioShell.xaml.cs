using PedFast.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PedFast.Shells
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InicioShell : Shell
    {
        public InicioShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute("home", typeof(AboutPage));
            Items.Add(new ShellContent()
            {
                Content = new AboutPage(),
                Route = "home"
            });

        }
    }
}