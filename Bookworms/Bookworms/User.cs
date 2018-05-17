using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 namespace Bookworms
{
    public class User
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string bio { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public Date dateOfBirth { get; set; }
        public List<Book> books;
        
    }
}
