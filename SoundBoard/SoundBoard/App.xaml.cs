using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace SoundBoard
{
    public partial class App : Application
    {
        public static string FolderPath { get; set; }

        public string myName = "Rashid";

        public App()
        {
            InitializeComponent();
            FolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData));
            //MainPage = new NavigationPage(new NotesPage());
            //MainPage = new NavigationPage(new MainPage());
            //MainPage = new NavigationPage(new LabelsTutorial());
            MainPage = new NavigationPage(new ButtonsTutorial());

        }

        
        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
        
    }
}
