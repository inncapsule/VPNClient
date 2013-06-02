using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VPNClient
{
    public partial class NewConnectionForm : Form
    {
        public NewConnectionForm()
        {
            InitializeComponent();
        }

        private void btnOkNC_Click(object sender, EventArgs e)
        {
            Data.ConnectionList.Add(new NewConnection(txtConnectionNameNC.Text, txtAddressNC.Text, txtUserName.Text, txtPassword.Text));
            this.Close();
            
            

        }

        private void btnCancelNC_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
