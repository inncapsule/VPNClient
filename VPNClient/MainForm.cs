using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DotRas;

namespace VPNClient
{
    public partial class MainForm : Form
    {

        private RasDialer dial = new RasDialer();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Data.Pbk.Open(Data.PbkPath);
            refreshServerChoice();
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            proBarMain.Visible = true;


            for (int barValue = 0; barValue < 70; barValue++)
            {
                proBarMain.Value = barValue;                
            }

            if (!cmbServerChoice.Text.Equals(""))
            {
                for (int connectionNumber = 0; connectionNumber < Data.Pbk.Entries.Count; connectionNumber++)
                {
                    if (cmbServerChoice.SelectedItem.Equals(Data.Pbk.Entries[connectionNumber].Name))
                    {
                        dial.EntryName = Data.Pbk.Entries[connectionNumber].Name;
                        dial.Credentials = Data.Pbk.Entries[connectionNumber].GetCredentials();
                        dial.PhoneBookPath = RasPhoneBook.GetPhoneBookPath(RasPhoneBookType.User);
                        dial.DialAsync();

                        if (dial.Credentials.Password.Equals(""))
                        {
                            dial.DialAsyncCancel();
                        }

                        dial.Error += new EventHandler<ErrorEventArgs>(dial_Error);
                        dial.DialCompleted += new EventHandler<DialCompletedEventArgs>(dial_DialCompleted);

                    }
                }
            }
            else proBarMain.Visible = false;
        }

        private void cmbServerChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbServerChoice.MaxDropDownItems = 5;
        }   

        private void btnNewConnection_Click(object sender, EventArgs e)
        {
            NewConnectionForm newC = new NewConnectionForm();

            newC.FormClosed +=new FormClosedEventHandler(newC_FormClosed);
            newC.Show();

        }

        private void btnOkNC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newC_FormClosed(object sender, FormClosedEventArgs e)
        {
            refreshServerChoice();
        }

        private void dial_Error(object sender, ErrorEventArgs e)
        {
            MessageBox.Show("Test");
        }

        private void dial_DialCompleted(object sender, DialCompletedEventArgs e)
        {
            while (proBarMain.Value < 100)
            {
                proBarMain.Value += 1;
            }

            cmbServerChoice.Enabled = false;
            btnConnect.Visible = false;
            btnDisconnect.Visible = true;
        }

        private void refreshServerChoice()
        {
            cmbServerChoice.Items.Clear();

            for (int pbkEntry = 0; pbkEntry < Data.Pbk.Entries.Count; pbkEntry++)
            {
                cmbServerChoice.Items.Add(Data.Pbk.Entries[pbkEntry].Name);
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            foreach (RasConnection connection in RasConnection.GetActiveConnections())
            {
                if (connection.EntryName.Equals(dial.EntryName))
                {
                    connection.HangUp();
                    btnDisconnect.Visible = false;
                    btnConnect.Visible = true;
                    cmbServerChoice.Enabled = true;

                    while (proBarMain.Value > 0)
                    {
                        proBarMain.Value -= 1;
                    }                  
                }
            }
        }
    }
}
