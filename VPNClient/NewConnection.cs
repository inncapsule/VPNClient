using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VPNClient
{
    class NewConnection
    {
        protected String connectionName= null;
        protected String connectionAddress = null;
        protected String connectionUsername = null;
        protected String connectionSecret = null;


        public NewConnection()
        {

        }

        /// <summary>
        /// Creates a new connection object without username and password
        /// </summary>
        /// <param name="cnName">Connection name</param>
        /// <param name="cnAddress">Connection address</param>
        public NewConnection(String cnName, String cnAddress)
        {
            setConnectionName(cnName);
            setConnectionAddress(cnAddress);
        }

        /// <summary>
        /// Creates a new connection object with username and password
        /// </summary>
        /// <param name="cnName">Connection name</param>
        /// <param name="cnAddress">Connection address</param>
        /// <param name="usrname">VPN username</param>
        /// <param name="secret">VPN password</param>
        public NewConnection(String cnName, String cnAddress, String usrname, String secret)
        {
            setConnectionName(cnName);
            setConnectionAddress(cnAddress);
            setConnectionUsername(usrname);
            setConnectionPassword(secret);
        }

        private void setConnectionName(String name) 
        {
            this.connectionName = name;
        }

        private void setConnectionAddress(String address) 
        {
            this.connectionAddress = address;
        }

        private void setConnectionUsername(String username) 
        {
            this.connectionUsername = username;
        }

        private void setConnectionPassword(String secret)
        {
            this.connectionSecret = secret;
        }

        public String getConnectionName()
        {
            return this.connectionName;
        }

        public String getConnectionAddress()
        {
            return this.connectionAddress;
        }

    }

}
