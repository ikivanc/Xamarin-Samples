using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFormsHelloPCL
{
    class AnaSayfa : ContentPage
    {
        Button button = new Button();

        public AnaSayfa()
        {
            var listView = new ListView();
            var label = new Label();

            button.Text = "Tikla";

            listView.ItemsSource = new string[] { "iOS 'ta çalışabiliyor", "Android'de çalışabiliyor", "Universal Windows'da çalışabiliyor", "AppleWatch'ta çalışabiliyor", "Android Wear'da çalışıyor", "Mac Masaüstünde de çalışıyor" };

            listView.ItemSelected += (sender, e) =>
            {
                DisplayAlert(DateTime.Now.ToString(), e.SelectedItem.ToString(), "Tamam");
            };

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                Children = { label, listView, button }
            };

            button.Clicked += Button_Clicked;
        }
        int a = 0;
        private void Button_Clicked(object sender, EventArgs e)
        {
            a++;
            button.Text = a.ToString() + " kez tıklandı!";
        }
    }
}
