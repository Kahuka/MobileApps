using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using InstagramApp.Data;
using System.IO;

namespace InstagramApp
{
    public partial class App : Application
    {
        static  Database _dbContext;

        public static Database dbContext
        {
            get
            {
                if(_dbContext == null)
                {
                    _dbContext = new Database(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Images.db3"));
                }
                return _dbContext;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
