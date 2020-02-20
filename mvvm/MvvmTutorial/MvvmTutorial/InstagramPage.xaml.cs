using Plugin.Media;
using Plugin.Media.Abstractions;
using System;
using System.Collections.Generic;
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
                //imageView.Source = ImageSource.FromStream(() => _mediaFile.GetStream());
                //UploadedUrl.Text = "Image URL:";
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

                //if (_mediaFile == null) return;
                //imageView.Source = ImageSource.FromStream(() => _mediaFile.GetStream());
                //var mediaOption = new PickMediaOptions()
                //{
                //    PhotoSize = PhotoSize.Medium
                //};
                //UploadedUrl.Text = "Image URL:";
            }
        }

        private void btnUploadPic_Clicked(object sender, EventArgs e)
        {

        }
    }
}