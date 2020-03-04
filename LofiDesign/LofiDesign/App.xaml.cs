using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LofiDesign
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //adding basic stack navigation with root page
            var nav = new NavigationPage(new ChooseExercise());
            //setting startup page
            MainPage = nav;
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
