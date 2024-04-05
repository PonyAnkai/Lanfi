using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Lanfi
{
    internal class StartPage : ContentPage
    {
        public StartPage()
        {
            Label header = new Label()
            {
                Text = "It`s StartPage"
            };
            this.Content = header;
        }
    }
}
