using note_app.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System.IO;

namespace note_app
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NoteDetailsPage : ContentPage
    {
        string _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notes.txt");
        


        NotePage page2;
        public NoteDetailsPage(NotePage page)
        {
            InitializeComponent();
            page2 = page;

            BindingContext = new Note();
            if (File.Exists(_fileName))
            {
                editor2.Text = File.ReadAllText(_fileName);
            }

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

        private async void shareBtn_Clicked(object sender, EventArgs e)
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Text = editor2.Text,
                Title="share"
            }
            ) ;
        }

        private  void saveBtn_Clicked(object sender, EventArgs e)
        {
            File.WriteAllText(_fileName, editor2.Text);


        }
    }
}