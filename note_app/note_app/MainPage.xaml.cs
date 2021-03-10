using note_app.models;
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
        NotePage page;
        public MainPage()
        {
            InitializeComponent();
            page = new NotePage();

        }

        async void createButton_Clicked(object sender, EventArgs e)
        {
            page.titile = entryTitle.Text;
            page.details = editorMain.Text;
            page.date = datePicker1.Date;
            if (checkBoxStatus.IsChecked)
            {
                page.checkBox = true;

            }
            else
            {
                page.checkBox = false;

            }
            NoteDetailsPage note = new NoteDetailsPage(page);
            await Navigation.PushModalAsync(note);
        }
    
    }
}
