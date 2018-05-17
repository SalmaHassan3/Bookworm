using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Bookworms.Pages
{
    public partial class Edit : ContentPage
    {
        public Edit()
        {
            InitializeComponent();
            BindingContext = new Book();
            done.Clicked += Done_Clicked;
        }

       async private void Done_Clicked(object sender, EventArgs e)
        {
            MainPage.book.name = n.Text;
            MainPage.book.author = a.Text;
            MainPage.book.state = s.Text;
            await App.Database.SaveBookAsync(MainPage.book);
            await Navigation.PopAsync();
        }
    }
}
