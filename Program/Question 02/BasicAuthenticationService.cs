using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Question_02
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        private string username;
        private string password;
        private string role;

        public BasicAuthenticationService(string _username, string _password , string _role)
        {
            this.username = _username;
            this.password = _password;
            this.role = _role;
        }

        public bool AuthenticateUser(string _username, string _password)
        {
            return this.username == _username && this.password == _password;
        }
        public bool AuthorizeUser(string _username, string _role)
        { 
            return this.username == _username && this.role == _role;
        }
    }
}
