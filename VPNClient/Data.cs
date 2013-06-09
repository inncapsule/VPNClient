using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotRas;

namespace VPNClient
{
    class Data
    {
        public static RasPhoneBook Pbk = new RasPhoneBook();
        public static String PbkPath = RasPhoneBook.GetPhoneBookPath(RasPhoneBookType.User);

        public static bool NameExists(String name)
        {
            foreach (RasEntry pbkEntry in Data.Pbk.Entries)
            {
                if (pbkEntry.Name.Equals(name))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
