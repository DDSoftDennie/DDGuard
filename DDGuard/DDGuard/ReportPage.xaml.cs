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

            //Xamarin.Essentials: AppInfo
            AppNameLabel.Text += " " + AppInfo.Name;
            AppPackageLabel.Text += " " + AppInfo.PackageName;
            AppVersionLabel.Text += " " + AppInfo.VersionString;
            AppBuildLabel.Text += " " + AppInfo.BuildString;

            //Xamarin.Essentials: DeviceInfo
            DeviceModelLabel.Text += " " + DeviceInfo.Model;
            DeviceManufacturerLabel.Text += " " + DeviceInfo.Manufacturer;
            DevicePlatformLabel.Text += " " + DeviceInfo.Platform;
            DeviceOSLabel.Text += " " + DeviceInfo.VersionString;

            HappyButton.Text = "I was " + Statics.Happy + " times happy.";
            SadButton.Text = "I was " + Statics.Sad + " times sad.";
            CrisisButton.Text = "I was " + Statics.Crisis + " times in crisis.";

         
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

        private async void CrisisButton_Clicked(object sender, EventArgs e)
        {
            //Xamarin.Essentials: Text To Speech
            await TextToSpeech.SpeakAsync(CrisisButton.Text);
        }
    }
}