using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace note_app
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        async void createButton_Clicked(object sender, EventArgs e)
        {
            NoteDetailsPage note = new NoteDetailsPage();
            await Navigation.PushModalAsync(note);
        }
    
    }
}
