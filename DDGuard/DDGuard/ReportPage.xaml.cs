using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace DDGuard
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ReportPage : ContentPage
    {
        public ReportPage()
        {
            this.Title = "DDGuard Report";
            InitializeComponent();

            HappyButton.Text = "I was " + Statics.Happy + " times happy.";
            SadButton.Text = "I was " + Statics.Sad + " times sad.";
            AngerButton.Text = "I was " + Statics.Anger + " times anger.";
            AnxientButton.Text = "I was " + Statics.Anxient + " times anxient.";

         
        }

        private async void BackButton_Clicked(object sender, EventArgs e)
        {
            await this.Navigation.PopAsync();
        }

        private async void HappyButton_Clicked(object sender, EventArgs e)
        {
            //Xamarin.Essentials: Text To Speech
            await TextToSpeech.SpeakAsync(HappyButton.Text);
        }

        private async void SadButton_Clicked(object sender, EventArgs e)
        {
            //Xamarin.Essentials: Text To Speech
            await TextToSpeech.SpeakAsync(SadButton.Text);
        }

        private async void AngerButton_Clicked(object sender, EventArgs e)
        {
            //Xamarin.Essentials: Text To Speech
            await TextToSpeech.SpeakAsync(AngerButton.Text);
        }

        private async void AnxientButton_Clicked(object sender, EventArgs e)
        {
            //Xamarin.Essentials: Text To Speech
            await TextToSpeech.SpeakAsync(AnxientButton.Text);
        }



#region other
        //Reportpage()
        //Xamarin.Essentials: AppInfo
        //AppNameLabel.Text += " " + AppInfo.Name;
        //AppPackageLabel.Text += " " + AppInfo.PackageName;
        //AppVersionLabel.Text += " " + AppInfo.VersionString;
        //AppBuildLabel.Text += " " + AppInfo.BuildString;

        ////Xamarin.Essentials: DeviceInfo
        //DeviceModelLabel.Text += " " + DeviceInfo.Model;
        //DeviceManufacturerLabel.Text += " " + DeviceInfo.Manufacturer;
        //DevicePlatformLabel.Text += " " + DeviceInfo.Platform;
        //DeviceOSLabel.Text += " " + DeviceInfo.VersionString;
#endregion
    }
}