using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class User
    {
        public int id { get; set; } 
        public string? name { get; set; }
        
        public User(int id, string? name, string? email) 
        { 
            this.id = id;
            this.name = name;
            this.email = email;
        }

        public string? email { get; set; }
    }
}
