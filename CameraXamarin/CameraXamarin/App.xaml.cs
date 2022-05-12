using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using CameraXamarin.db;

namespace CameraXamarin
{
    public partial class App : Application
    {
        public const string DB_Name = "clientsProj.db";
        public static CRUDOperation DB;

        public static CRUDOperation Db
        {
            get
            {
                if (DB == null)
                {
                    DB = new CRUDOperation(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DB_Name));
                }
                return DB;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
