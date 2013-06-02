namespace VPNClient
{
    partial class NewConnectionForm
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
            this.lblConnectionName = new System.Windows.Forms.Label();
            this.txtConnectionNameNC = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddressNC = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnCancelNC = new System.Windows.Forms.Button();
            this.btnOkNC = new System.Windows.Forms.Button();
            this.cboxRememberNC = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblConnectionName
            // 
            this.lblConnectionName.AutoSize = true;
            this.lblConnectionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblConnectionName.Location = new System.Drawing.Point(12, 46);
            this.lblConnectionName.Name = "lblConnectionName";
            this.lblConnectionName.Size = new System.Drawing.Size(129, 18);
            this.lblConnectionName.TabIndex = 0;
            this.lblConnectionName.Text = "Connection name:";
            // 
            // txtConnectionNameNC
            // 
            this.txtConnectionNameNC.Location = new System.Drawing.Point(12, 67);
            this.txtConnectionNameNC.Name = "txtConnectionNameNC";
            this.txtConnectionNameNC.Size = new System.Drawing.Size(260, 20);
            this.txtConnectionNameNC.TabIndex = 1;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblAddress.Location = new System.Drawing.Point(9, 93);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(62, 18);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address";
            // 
            // txtAddressNC
            // 
            this.txtAddressNC.Location = new System.Drawing.Point(12, 115);
            this.txtAddressNC.Name = "txtAddressNC";
            this.txtAddressNC.Size = new System.Drawing.Size(260, 20);
            this.txtAddressNC.TabIndex = 3;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblUserName.Location = new System.Drawing.Point(12, 159);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(81, 18);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "Username:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(12, 181);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(260, 20);
            this.txtUserName.TabIndex = 5;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblPassword.Location = new System.Drawing.Point(12, 208);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(79, 18);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsTab = true;
            this.txtPassword.Location = new System.Drawing.Point(12, 230);
            this.txtPassword.MaxLength = 100;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(260, 20);
            this.txtPassword.TabIndex = 7;
            // 
            // btnCancelNC
            // 
            this.btnCancelNC.Location = new System.Drawing.Point(147, 289);
            this.btnCancelNC.Name = "btnCancelNC";
            this.btnCancelNC.Size = new System.Drawing.Size(97, 34);
            this.btnCancelNC.TabIndex = 8;
            this.btnCancelNC.Text = "Cancel";
            this.btnCancelNC.UseVisualStyleBackColor = true;
            this.btnCancelNC.Click += new System.EventHandler(this.btnCancelNC_Click);
            // 
            // btnOkNC
            // 
            this.btnOkNC.Location = new System.Drawing.Point(44, 289);
            this.btnOkNC.Name = "btnOkNC";
            this.btnOkNC.Size = new System.Drawing.Size(97, 34);
            this.btnOkNC.TabIndex = 9;
            this.btnOkNC.Text = "OK";
            this.btnOkNC.UseVisualStyleBackColor = true;
            this.btnOkNC.Click += new System.EventHandler(this.btnOkNC_Click);
            // 
            // cboxRememberNC
            // 
            this.cboxRememberNC.AutoSize = true;
            this.cboxRememberNC.Location = new System.Drawing.Point(15, 257);
            this.cboxRememberNC.Name = "cboxRememberNC";
            this.cboxRememberNC.Size = new System.Drawing.Size(195, 17);
            this.cboxRememberNC.TabIndex = 10;
            this.cboxRememberNC.Text = "Remember username and password";
            this.cboxRememberNC.UseVisualStyleBackColor = true;
            // 
            // NewConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 334);
            this.Controls.Add(this.cboxRememberNC);
            this.Controls.Add(this.btnOkNC);
            this.Controls.Add(this.btnCancelNC);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtAddressNC);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtConnectionNameNC);
            this.Controls.Add(this.lblConnectionName);
            this.Name = "NewConnectionForm";
            this.Text = "New connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConnectionName;
        private System.Windows.Forms.TextBox txtConnectionNameNC;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddressNC;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCancelNC;
        private System.Windows.Forms.Button btnOkNC;
        private System.Windows.Forms.CheckBox cboxRememberNC;
    }
}