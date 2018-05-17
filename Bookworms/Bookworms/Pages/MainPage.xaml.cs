using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Bookworms.Pages
{
    public partial class MainPage : TabbedPage
    {
       public static Book book = new Book();
        public MainPage()
        {
            InitializeComponent();
           // BindingContext = new Book();
            add.Clicked += Add_Clicked;
            //refreshCommand = new Command(RefreshList);
            booklist.ItemSelected += Booklist_ItemSelected;
            delete.Clicked += Delete_Clicked;
            edit.Clicked += Edit_Clicked;
        }

       async private void Edit_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Edit());
        }

        async private void Delete_Clicked(object sender, EventArgs e)
        {
            await App.Database.DeleteBookAsync(book);
            booklist.ItemsSource = await App.Database.GetBooksAsync();
            delete.IsEnabled = false;
            edit.IsEnabled = false;
        }

         private void Booklist_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                book = e.SelectedItem as Book;
                delete.IsEnabled = true;
                edit.IsEnabled = true;
            
            }
        }

        async private void Add_Clicked(object sender, EventArgs e)
        {
           // var book1 = (Book)BindingContext;
           Book book1 = new Book();
            book1.name = n.Text;
            book1.author = a.Text;
            book1.state = s.Text;
            await App.Database.SaveBookAsync(book1);
            booklist.ItemsSource = await App.Database.GetBooksAsync();
          
        }
         protected async override void OnAppearing()
        {
            base.OnAppearing();

            booklist.ItemsSource = await App.Database.GetBooksAsync();
            delete.IsEnabled = false;
            edit.IsEnabled = false;
        }

       // Command refreshCommand;
         //   public Command RefreshCommand
      //  {
       //     get { return refreshCommand; }
       // }
      //  async void RefreshList()
      //  {
       //     booklist.ItemsSource = await App.Database.GetBooksAsync();
       // }
        
    }

}

