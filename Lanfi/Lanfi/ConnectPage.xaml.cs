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

        private void DeleteConnectDo(object sender, EventArgs e)
        {
            var button = (Button)sender;
            Connections item = new Connections()
            {
                ID = Convert.ToInt32(button.ClassId)
            };
            App.Db.DeleteConnections(item);
            OnAppearing();
        }

        private void TryReconectDo(object sender, EventArgs e)
        {

        }

        private void ConnectToChat(object sender, EventArgs e)
        {

        }
    }
}