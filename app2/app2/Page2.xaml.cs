using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Calculate_Clicked(object sender, EventArgs e)
        {
            int first, second, third;
            int sum, product;
            if (int.TryParse(numberText.Text, out int number) && number > 99)
            {
                first = number / 100;
                second = (number % 100) / 10;
                third = number % 10;
                sum = first + second + third;
                product = first * second * third;
                numberText.TextColor = Color.Black;
                sumOut.Text = $"Сумма цифр: {sum}";
                prodOut.Text = $"Произведение цифр: {product}";
            }
            else
            {
                numberText.TextColor = Color.Red;
            }
        }

        private void numberText_TextChanged(object sender, TextChangedEventArgs e)
        {
            sumOut.Text = "Сумма цифр:";
            prodOut.Text = "Произведение цифр:";
        }
    }
}