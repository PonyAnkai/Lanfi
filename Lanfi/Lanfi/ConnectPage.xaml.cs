using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lanfi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConnectPage : ContentPage
    {
        public ConnectPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            ShowConnection();
        }

        private void ShowConnection()
        {
            serverCollections.ItemsSource = App.Db.GetConnections();
        }

        private async void NewConnect(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NewConnectPage(), false);
        }
        private async void Refresh(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            await Navigation.PushModalAsync(new MainPage(), false);
        }
    }
}