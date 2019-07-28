using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace DDGuard
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
   // [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
            this.Title = "DDGuard";
           
            //Xamarin.Essentials: Preferences
            Statics.Happy = Preferences.Get("Happy", 0);
            Statics.Sad = Preferences.Get("Sad", 0);
            Statics.Anger = Preferences.Get("Anger", 0);
            Statics.Anxient = Preferences.Get("Anxient", 0);         
        }

    
        private async void SiteButton_Clicked(object sender, EventArgs e)
        {
            if(CheckInternetConnection() == true)
            {
                //Xamarin.Essentials: Launcher
                await Launcher.OpenAsync("https://www.youtube.com/watch?v=nPbWxaF0D-U");
            }
        }

        private bool CheckInternetConnection()
        {
            //Xamarin.Essentials: Connectivity
            var connection = Connectivity.NetworkAccess;
            if(connection == NetworkAccess.Internet)
            {
                NoConnectionButton.IsVisible = false;
                return true;
            }
            else
            {
                NoConnectionButton.IsVisible = true;
                return false;
            }

        }

        private async void NoConnectionButton_Clicked(object sender, EventArgs e)
        {
          await TextToSpeech.SpeakAsync("Error: No internet aviable");
        }

        private async void ReportButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new ReportPage());
        }

        private void HappyButton_Clicked(object sender, EventArgs e)
        {
            Statics.Happy++;
            //Xamarin.Essentials: Preferences
            Preferences.Set("Happy", Statics.Happy);
        }

        private void SadButton_Clicked(object sender, EventArgs e)
        {
            Statics.Sad++;
            //Xamarin.Essentials: Preferences
            Preferences.Set("Sad", Statics.Sad);
        }

        private void AngerButton_Clicked(object sender, EventArgs e)
        {

            Statics.Anger++;
            //Xamarin.Essentials: Preferences
            Preferences.Set("Anger", Statics.Anger);
        }

        private void AnxientButton_Clicked(object sender, EventArgs e)
        {

            Statics.Anxient++;
            //Xamarin.Essentials: Preferences
            Preferences.Set("Anxient", Statics.Anger);
        }


    }
}
