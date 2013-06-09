using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotRas;

namespace VPNClient
{
    class Data
    {
        //public static List<NewEntry> RasEntries = new List<NewEntry>();
        //public static List<RasEntry> RasEntries2 = new List<RasEntry>();
        public static RasPhoneBook Pbk = new RasPhoneBook();
        public static String PbkPath = RasPhoneBook.GetPhoneBookPath(RasPhoneBookType.User);

    }
}
