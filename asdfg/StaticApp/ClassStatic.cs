using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asdfg.StaticApp
{
    public class ClassStatic
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string ForWho { get; set; }
        public ClassStatic(string name, string login, string password, string forWho)
        {
            Name = name;
            Login = login;
            Password = password;
            ForWho = forWho;
        }
    }
}
