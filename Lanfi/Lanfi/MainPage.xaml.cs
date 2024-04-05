using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lanfi
{
    public partial class MainPage : ContentPage
    {
        int BoxValue = 0;
        Label label = new Label
        {
            Text = "0",
            FontSize = 25
        };
        public MainPage()
        {
            //InitializeComponent();
            RelativeLayout relativeLayout = new RelativeLayout();

            string BoxValueString = BoxValue.ToString();
            label.Text = BoxValueString;
            
            Button button = new Button 
            { 
                Text= "Click on me",
                FontSize = 16, 
                BackgroundColor= Color.Red,
            };
            button.Clicked += OnButtonClicked;

            relativeLayout.Children.Add(label,
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Width * 0.5 - 50;    // установка координаты X
                }),
                Constraint.RelativeToParent((parent) =>
                {
                    return parent.Height * 0.5 - 150;   // установка координаты Y
                })
            );

            relativeLayout.Children.Add(button,
                Constraint.RelativeToView(label, (parent, view) =>
                {
                    return label.X - 30;    // установка координаты X
                }),
                Constraint.RelativeToView(label, (parent, view) =>
                {
                    return label.Y + 30;    // установка координаты Y
                }),
                Constraint.Constant(150), // установка ширины
                Constraint.Constant(100) // установка высоты
            );


            Content = relativeLayout;
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            BoxValue += 1;
            string BoxValueString = BoxValue.ToString();
            label.Text = BoxValueString;
        }
    }
}   
