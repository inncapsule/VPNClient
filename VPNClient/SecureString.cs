using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security;

namespace VPNClient
{
    class SecureString
    {
        char _passwordChar = '●';
        SecureString _secureString = new SecureString();

        public SecureString secureString
        {
            get { return _secureString; } 
        }

        public char PasswordChar
        {
            get { return _passwordChar; }
            set { _passwordChar = value; }
        }
    }
}
