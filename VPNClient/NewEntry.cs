using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotRas;
using System.Collections.ObjectModel;
using System.Net.NetworkInformation;
using System.Net;
using System.Security;

namespace VPNClient
{
    class NewEntry 
    {
        private String entryName = null;
        private String entryAddress = null;
        private String entryUsername = null;
        private String entrySecret = null;
        private Boolean rememberSecret = false;
        private RasEntry newRas;
        private RasDevice rDevice;


        public NewEntry()
        { 
        
        }

        public NewEntry(String ConnectionName, String address)
        {
            setEntryName(ConnectionName);
            setEntryAddress(address);
            NewRasEntry();
        }

        public NewEntry(String ConnectionName, String address, String username, String secret, Boolean remember)
        {
            setEntryName(ConnectionName);
            setEntryAddress(address);
            setUserName(username);
            setSecret(secret);
            NewRasEntry();
            

        }

        private void setEntryName(String name)
        {
            this.entryName = name;
        }

        private void setEntryAddress(String address)
        {
            this.entryAddress = address;
        }

        private void setUserName(String username)
        {
            this.entryUsername = username;
        }

        private void setSecret(String secret)
        {
            this.entrySecret = secret;
        }

        public String getEntryName()
        {
            return this.entryName;
        }

        public String getEntryAddress()
        {
            return this.entryAddress;
        }

        public void NewRasEntry()
        {
            ReadOnlyCollection<RasDevice> devices = RasDevice.GetDevices();

            foreach (RasDevice modem in devices)
            {
                if (modem.Name.ToLower().Contains("(pptp)"))
                {
                    this.rDevice = modem;
                }
            }

            newRas = RasEntry.CreateVpnEntry(entryName, entryAddress, RasVpnStrategy.PptpOnly, rDevice, false);

            newRas.Options.RemoteDefaultGateway = false;
            newRas.Options.IPv6RemoteDefaultGateway = false;
            newRas.NetworkProtocols.IPv6 = false;
            newRas.IdleDisconnectSeconds = 10;
            newRas.Options.RequireMSChap2 = true;

            newRas.Options.Internet = false;

            newRas.Options.UseLogOnCredentials = true;

            NetworkCredential cred = new NetworkCredential();
            cred.UserName = this.entryUsername;
            cred.Password = this.entrySecret;
           

            Data.Pbk.Entries.Add(newRas);
            Data.Pbk.Entries[Data.Pbk.Entries.Last().Name].UpdateCredentials(cred);
        }
    }
}
