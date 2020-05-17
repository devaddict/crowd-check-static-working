using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App1.Models;
using App1.Views;
using App1.ViewModels;

namespace App1.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        StoreListViewModel viewModel;
        public ItemsPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new StoreListViewModel();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.stores.Count == 0)
                viewModel.IsBusy = true;
        }

        #region testing code
        //        public async void btnGetLocationAsync(object sender, EventArgs e)
        //        {
        //            try
        //            {
        //                var locationManager = new LocationMonanager();
        //#if DEBUG
        //                var currentLocation = new Location(43.842330, -79.074900);
        //#else
        //                 var currentLocation = await locationManager.GetLocationCache();
        //#endif

        //                if (currentLocation.IsFromMockProvider)
        //                {
        //                    Console.WriteLine("This is a mock location");
        //                }
        //                var address = editor.Text;
        //                var addressLocation = await locationManager.GetLocationByAddress(address);
        //                double miles = Location.CalculateDistance(currentLocation, addressLocation, DistanceUnits.Kilometers);
        //                Distance.Text = miles + "Miles";
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine(ex.Message); 
        //            }
        //        }


        //        public async void btnAddAsync(object sender, EventArgs e)
        //        {
        //            await Navigation.PushAsync(new AddFeedBack());
        //        }

        //        public async void btnCheckAsync(object sender, EventArgs e)
        //        {
        //            await Navigation.PushAsync(new Check());
        //        }
        #endregion
    }
}