using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookworms
{
   public  class BookDatabase
    {
        readonly SQLiteAsyncConnection database ; 
        public BookDatabase(string dbpath)
        {
            database = new SQLiteAsyncConnection(dbpath);
            database.CreateTableAsync<Book>().Wait();

        }
        public Task<List<Book>> GetBooksAsync()
        {
            return database.Table<Book>().ToListAsync();
        }
        public Task<Book> GetBookAsync(int id)
        {
            return database.Table<Book>().Where(i => i.id == id).FirstOrDefaultAsync();
        }
        public Task<int> SaveBookAsync(Book book)
        {
            if (book.id == 0)
                return database.InsertAsync(book);
            else
                return database.UpdateAsync(book);
        }
        public Task<int> DeleteBookAsync(Book book)
        {
            return database.DeleteAsync(book);
        }
    }
}
