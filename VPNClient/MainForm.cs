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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void btnConnect_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void cmbServerChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int connections = 0; connections < Data.ConnectionList.Count; connections++)
            {
                cmbServerChoice.Items.Add(Data.ConnectionList[connections].getConnectionName());
            }
        }

        private void btnNewConnection_Click(object sender, EventArgs e)
        {
            new NewConnectionForm().ShowDialog();

        }

        private void btnOkNC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cmbServerChoice.DataSource = Data.ConnectionList;
        }
    }
}
