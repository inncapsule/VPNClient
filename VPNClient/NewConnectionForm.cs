using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DotRas;

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
            //Data.ConnectionList.Add(new NewConnection(txtConnectionNameNC.Text, txtAddressNC.Text, txtUserName.T()ext, txtPassword.Text));
            new NewEntry(txtConnectionNameNC.Text, txtAddressNC.Text);
            this.Close();           
        }

        private void btnCancelNC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboxRememberNC_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxRememberNC.Checked)
            {
                
            }
        }
    }
}
