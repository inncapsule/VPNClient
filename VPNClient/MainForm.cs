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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {

            for (int connectionNumber = 0; connectionNumber < Data.Pbk.Entries.Count; connectionNumber++)
            {
                if (cmbServerChoice.SelectedItem.Equals(Data.Pbk.Entries[connectionNumber].Name))
                {
                    
                    RasDialer dial = new RasDialer();

                    dial.EntryName = Data.Pbk.Entries[connectionNumber].Name;
                    dial.PhoneBookPath = RasPhoneBook.GetPhoneBookPath(RasPhoneBookType.User);
                    dial.Dial();
                    
                }
            }
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
            cmbServerChoice.Items.Clear();
            for (int connection = 0; connection < Data.Pbk.Entries.Count; connection++)
            {
                cmbServerChoice.Items.Add(Data.Pbk.Entries[connection].Name);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Data.Pbk.Open(Data.PbkPath);


            for (int pbkEntry = 0; pbkEntry < Data.Pbk.Entries.Count; pbkEntry++)
            {
                cmbServerChoice.Items.Add(Data.Pbk.Entries[pbkEntry].Name);
                Console.WriteLine(pbkEntry);
            }
        }
    }
}
