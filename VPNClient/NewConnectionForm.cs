using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DotRas;
using System.Security;

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
            if (!Data.NameExists(txtConnectionNameNC.Text))
            {
                new NewEntry(txtConnectionNameNC.Text, txtAddressNC.Text, txtUserName.Text, txtPassword.Text, true);

                this.Close();
            }
            else
            {
                MessageBox.Show("A connection with the name \"" + txtConnectionNameNC.Text + "\" already exists." +
                                "\nPlease input a different name.", "Name error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
            {
                ProcessDialogKey(Keys.Back);
            }
            else
                ProcessDialogChar(e.KeyChar);

            e.Handled = true;
                
        }


        private void btnCancelNC_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
