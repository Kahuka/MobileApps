using Microsoft.WindowsAzure.Storage;
using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmTutorial
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InstagramPage : ContentPage
    {
        public InstagramPage()
        {
            InitializeComponent();
        }

        private MediaFile _mediaFile;
        private string URL { get; set; }
        bool IsCameraAvailable { get; }

        private async void btnSelectPic_Clicked(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                await DisplayAlert("Error", "This is not support on your device.", "OK");
                return;
            }
            else
            {
                var mediaOption = new PickMediaOptions()
                {
                    PhotoSize = PhotoSize.Medium
                };
                _mediaFile = await CrossMedia.Current.PickPhotoAsync();
                if (_mediaFile == null) return;
                imgPreView.Source = ImageSource.FromStream(() => _mediaFile.GetStream());
                UploadedUrl.Text = "Image URL:";
            }

        }

        private async void btnTakePic_Clicked(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("No Camera", ":(No Camera available.)", "OK");
                return;
            }
            else
            {
                _mediaFile = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
                {
                    Directory = "Sample",
                    Name = "myImage.jpg"
                });

                if (_mediaFile == null) return;
                imgPreView.Source = ImageSource.FromStream(() => _mediaFile.GetStream());
                var mediaOption = new PickMediaOptions()
                {
                    PhotoSize = PhotoSize.Medium
                };
                UploadedUrl.Text = "Image URL:";
            }
        }

        private async void btnUploadPic_Clicked(object sender, EventArgs e)
        {
            if (_mediaFile == null)
            {
                await DisplayAlert("Error", "There was an error when trying to get your image.", "OK");
                return;
            }
            else
            {
                UploadImage(_mediaFile.GetStream());
            }
        }

        private async void UploadImage(Stream stream)
        {
            Busy();
            var account = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=xamarinblobstoragekahuka;AccountKey=krgjJcX+YSvgnj0AQZndg10hhsVVaUEhgKz6Hw44zvHCOPRRk+vPA+hS+tMvAj2E0kxuvqxNhZ0OCcViTwmrEQ==;EndpointSuffix=core.windows.net");
            var client = account.CreateCloudBlobClient();
            var container = client.GetContainerReference("images");
            await container.CreateIfNotExistsAsync();
            var name = Guid.NewGuid().ToString();
            var blockBlob = container.GetBlockBlobReference($"{name}.png");
            await blockBlob.UploadFromStreamAsync(stream);
            URL = blockBlob.Uri.OriginalString;
            UploadedUrl.Text = URL;
            NotBusy();
            await DisplayAlert("Uploaded", "Image uploaded to Blob Storage Successfully!", "OK");

        }

        public void Busy()
        {
            uploadIndicator.IsVisible = true;
            uploadIndicator.IsRunning = true;
            btnSelectPic.IsEnabled = false;
            btnTakePic.IsEnabled = false;
            btnUploadPic.IsEnabled = false;
        }

        public void NotBusy()
        {
            uploadIndicator.IsVisible = false;
            uploadIndicator.IsRunning = false;
            btnSelectPic.IsEnabled = true;
            btnTakePic.IsEnabled = true;
            btnUploadPic.IsEnabled = true;
        }


    }
}