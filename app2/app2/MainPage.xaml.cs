using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace app2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Transit_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
        private void Calculate_Clicked(object sender, EventArgs e)
        {
            bool parse = false;
            double perimetr;
            double p;
            double square;
            double side1, side2, side3;
            if (!int.TryParse(x1Text.Text, out int x1))
            {
                x1Text.TextColor = Color.Red;
                parse = true;
            }
            if (!int.TryParse(x2Text.Text, out int x2))
            {
                x2Text.TextColor = Color.Red;
                parse = true;
            }
            if(!int.TryParse(x3Text.Text, out int x3))
            {
                x3Text.TextColor = Color.Red;
                parse = true;
            }
            if (!int.TryParse(y1Text.Text, out int y1))
            {
                y1Text.TextColor = Color.Red;
                parse = true;
            }
            if (!int.TryParse(y2Text.Text, out int y2))
            {
                y2Text.TextColor = Color.Red;
                parse = true;
            }
            if (!int.TryParse(y3Text.Text, out int y3))
            {
                y3Text.TextColor = Color.Red;
                parse = true;
            }
            if (!parse)
            {
                side1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                side2 = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
                side3 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
                p = (side1 + side2 + side3) / 2;
                square = Math.Round(Math.Sqrt(p * (p - side1) * (p - side2) * (p - side3)), 2);
                perimetr = Math.Round(side1 + side2 + side3, 2);
                squareOut.Text = $"Площадь треугольника: {square}";
                perimetrOut.Text = $"Периметр треугольника: {perimetr}";
                x1Text.TextColor = Color.Black;
                x2Text.TextColor = Color.Black;
                x3Text.TextColor = Color.Black;
                y1Text.TextColor = Color.Black;
                y2Text.TextColor = Color.Black;
                y3Text.TextColor = Color.Black;
            }
        }

        private void Text_TextChanged(object sender, TextChangedEventArgs e)
        {
            squareOut.Text = "Площадь треугольника:";
            perimetrOut.Text = "Периметр треугольника:";
        }
    }
}
