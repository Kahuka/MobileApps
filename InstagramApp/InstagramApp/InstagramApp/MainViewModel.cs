using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using InstagramApp.Data;
using Xamarin.Forms;
using System.Windows.Input;
using Plugin.Media;

namespace InstagramApp
{
    public class MainViewModel : INotifyPropertyChanged
    {

        public MainViewModel()
        {
            Images = new ObservableCollection<ImageInfo>();
            GetPictureCommand = new Command(OnGetPictureCommand);
            TakePictureCommand = new Command(OnTakePictureCommand);
        }

        private ObservableCollection<ImageInfo> _images;
        public ObservableCollection<ImageInfo> Images
        {
            get { return _images; }
            set
            {
                if (_images != value)
                {
                    _images = value;
                    OnPropertyChanged(nameof(Images));
                }
            }
        }
        public ICommand TakePictureCommand { get; private set; }


        private async void OnTakePictureCommand()
        {
            await CrossMedia.Current.Initialize();


            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                return;
            }

            var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                Directory = "Sample",
                Name = "test.jpg"
            });

            if (file == null)
                return;

            var image = new ImageInfo();
            image.Name = "New picture";
            //image.Source = ImageSource.FromStream(file.Path);


            image.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                return stream;
            });

            Images.Add(image);
        }

        public ICommand GetPictureCommand { get; private set; }

        private async void OnGetPictureCommand()
        {
            await CrossMedia.Current.Initialize();

            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                return;
            }

            var file = await CrossMedia.Current.PickPhotoAsync();


            if (file == null)
            {
                return;
            }
            var image = new ImageInfo();
            image.Name = "New picture";
            image.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                file.Dispose();
                return stream;
            });
            Images.Add(image);
        }

        public void RefreshList()
        {
            var test = "asd";
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
