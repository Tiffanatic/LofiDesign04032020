using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LofiDesign
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChooseExercise : ContentPage
    {
        public ChooseExercise()
        {
            InitializeComponent();
            title.Text = "Choose Exercise from code";
        }

        public async void OnExerciseClick(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ExercisePage());
        }
    }
}