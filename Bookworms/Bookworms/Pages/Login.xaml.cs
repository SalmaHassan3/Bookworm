using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Bookworms.Pages
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
            register.Clicked += Register_Clicked;
            enter.Clicked += Enter_Clicked;
        }

      async  private void Enter_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new MainPage());
        }

        async private void Register_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Register());
        }
    }
}
