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
            for (int numberOfConnection = 0; numberOfConnection < Data.RasEntries.Count; numberOfConnection++)
            {
                if (cmbServerChoice.SelectedItem.Equals(Data.RasEntries[numberOfConnection].getEntryName())) ;
                {
                    RasDialer dial = new RasDialer();

                    dial.EntryName = Data.RasEntries[numberOfConnection].getEntryName();
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
            for (int connection = 0; connection < Data.RasEntries.Count; connection++)
            {
                cmbServerChoice.Items.Add(Data.RasEntries[connection].getEntryName());
            }
        }
    }
}
