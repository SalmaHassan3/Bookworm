using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace Bookworms
{
    public class App : Application
    {
        static BookDatabase database;
        public App()
        {
            

            MainPage = new NavigationPage(new Pages.Login())
            {
               
            };

        }
        public static BookDatabase Database { 
        
            get
            {
                if (database == null)
                {
                    database = new BookDatabase(DependencyService.Get<LocalFileHelper>().GetLocalFilePath("BookDb.db3"));
                }
                return database;
            }
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
