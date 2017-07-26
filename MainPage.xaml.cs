using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tab
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public async void CustomVisionClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new CustomVision());

        }
        public async void AzureTableClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AzureTable());

        }
        public async void HomePage(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }
    }
}
