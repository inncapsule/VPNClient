namespace VPNClient
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbServerChoice = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnOkNC = new System.Windows.Forms.Button();
            this.btnNewConnection = new System.Windows.Forms.Button();
            this.lblChoose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbServerChoice
            // 
            this.cmbServerChoice.AccessibleName = "cmbServerChoice";
            this.cmbServerChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServerChoice.FormattingEnabled = true;
            this.cmbServerChoice.Location = new System.Drawing.Point(12, 73);
            this.cmbServerChoice.Name = "cmbServerChoice";
            this.cmbServerChoice.Size = new System.Drawing.Size(260, 21);
            this.cmbServerChoice.TabIndex = 0;
            this.cmbServerChoice.SelectedIndexChanged += new System.EventHandler(this.cmbServerChoice_SelectedIndexChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.AccessibleName = "btnConnect";
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnConnect.Location = new System.Drawing.Point(84, 108);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(112, 44);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnOkNC
            // 
            this.btnOkNC.Location = new System.Drawing.Point(145, 213);
            this.btnOkNC.Name = "btnOkNC";
            this.btnOkNC.Size = new System.Drawing.Size(97, 34);
            this.btnOkNC.TabIndex = 10;
            this.btnOkNC.Text = "Close";
            this.btnOkNC.UseVisualStyleBackColor = true;
            this.btnOkNC.Click += new System.EventHandler(this.btnOkNC_Click);
            // 
            // btnNewConnection
            // 
            this.btnNewConnection.Location = new System.Drawing.Point(42, 213);
            this.btnNewConnection.Name = "btnNewConnection";
            this.btnNewConnection.Size = new System.Drawing.Size(97, 34);
            this.btnNewConnection.TabIndex = 11;
            this.btnNewConnection.Text = "New connection";
            this.btnNewConnection.UseVisualStyleBackColor = true;
            this.btnNewConnection.Click += new System.EventHandler(this.btnNewConnection_Click);
            // 
            // lblChoose
            // 
            this.lblChoose.AutoSize = true;
            this.lblChoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblChoose.Location = new System.Drawing.Point(12, 54);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.Size = new System.Drawing.Size(142, 18);
            this.lblChoose.TabIndex = 12;
            this.lblChoose.Text = "Choose connection:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblChoose);
            this.Controls.Add(this.btnNewConnection);
            this.Controls.Add(this.btnOkNC);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.cmbServerChoice);
            this.Name = "MainForm";
            this.Text = "VPN connector";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbServerChoice;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnOkNC;
        private System.Windows.Forms.Button btnNewConnection;
        private System.Windows.Forms.Label lblChoose;
    }
}

