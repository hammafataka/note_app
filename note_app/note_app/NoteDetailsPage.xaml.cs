using note_app.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace note_app
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NoteDetailsPage : ContentPage
    {
        NotePage page2;
        public NoteDetailsPage(NotePage page)
        {
            InitializeComponent();
            page2 = page;
           


        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            titleLbl.Text = page2.titile;
            dateLbl.Text = page2.date.ToString();
            if (page2.checkBox == true)
            {
                statusLbl.Text = "Status: Completed";
            }
            else
            {
                statusLbl.Text = "Status: Not Completed";

            }
            editor2.Text = page2.details;


        }
    }
}