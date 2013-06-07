using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotRas;
using System.Collections.ObjectModel;

namespace VPNClient
{
    class NewEntry 
    {
        private String entryName = null;
        private String entryAddress = null;
        private String entryUsername = null;
        private String entrySecret = null;
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

        private void setEntryName(String name)
        {
            this.entryName = name;
        }

        private void setEntryAddress(String address)
        {
            this.entryAddress = address;
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
            Data.PBook.Entries.Add(newRas);

        }
    }
}
