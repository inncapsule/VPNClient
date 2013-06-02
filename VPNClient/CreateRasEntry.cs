using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotRas;

namespace VPNClient
{
    class CreateRasEntry 
    {
        private String entryName = null;
        private String entryAddress = null;
        private String entryUsername = null;
        private String entrySecret = null;

        public CreateRasEntry()
        { 
        
        }

        public CreateRasEntry(String ConnectionName, String address)
        {
            setEntryName(ConnectionName);
            setEntryAddress(address);

            if (!entryName.Equals(null) || !entryName.Equals(""))
            {
                NewRasEntry();
            }
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
            String entryDevice = entryName + "Device";

            CreateRasEntry newRas = new CreateRasEntry();
            
            RasEntry.CreateVpnEntry(entryName, entryAddress, RasVpnStrategy.PptpOnly, RasDevice.Create(entryDevice, RasDeviceType.Vpn), false);
            
        }
    }
}
