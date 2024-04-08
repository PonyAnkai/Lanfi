using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lanfi
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewConnectPage : ContentPage
    {
        public NewConnectPage()
        {
            InitializeComponent();
        }

        private void AddNewConnect(object sender, EventArgs e)
        {
            string ip, desc = "";

            ip = IPAdressField.Text.Trim();
            desc = DescField.Text.Trim();

            if (ip == "")
            {
                ip = "<Пустое подключение>";
            }

            if (desc == "")
            {
                desc = "<Отсутствует описание>";
            };

            Connections item = new Connections()
            {
                IP = ip,
                Description = desc,
                Status = "<Offline>"

            };

            App.Db.SaveConnections(item);

            Succses.Text = "Подключение добавлено";

        }
        
        private void DropOfWrited(object sender, EventArgs e)
        {
            IPAdressField.Text = "";
            DescField.Text = "";

        }
    }
}