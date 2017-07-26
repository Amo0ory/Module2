
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Microsoft.WindowsAzure.MobileServices;
using Tab;
using Microsoft.WindowsAzure.ServiceRuntime;

namespace Tab
{
    public partial class AzureTable : ContentPage
    {


        public AzureTable()
        {
            InitializeComponent();

        }

        public List<myTable> ItemsSource { get; private set; }

        async void Handle_ClickedAsync(object sender, EventArgs e)
        {
            List<myTable> myEasyTableInformation = await AzureManager.AzureManagerInstance.GetmyEasyTableInformation();
            ListView myListView = new ListView();
            myListView.ItemsSource = myEasyTableInformation;
        }

    }

}
