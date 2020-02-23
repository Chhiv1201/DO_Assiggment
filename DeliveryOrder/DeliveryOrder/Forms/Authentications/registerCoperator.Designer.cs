namespace DeliveryOrder.Forms.Authentications
{
    partial class registerCoperator
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.gbLogin = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbComContact = new System.Windows.Forms.TextBox();
            this.tbComLocation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.gbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(440, 536);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(167, 43);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // gbLogin
            // 
            this.gbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLogin.Controls.Add(this.label6);
            this.gbLogin.Controls.Add(this.label4);
            this.gbLogin.Controls.Add(this.tbComContact);
            this.gbLogin.Controls.Add(this.tbComLocation);
            this.gbLogin.Controls.Add(this.label5);
            this.gbLogin.Controls.Add(this.tbCompanyName);
            this.gbLogin.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLogin.Location = new System.Drawing.Point(12, 12);
            this.gbLogin.Name = "gbLogin";
            this.gbLogin.Size = new System.Drawing.Size(595, 208);
            this.gbLogin.TabIndex = 9;
            this.gbLogin.TabStop = false;
            this.gbLogin.Text = "Info";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Company Location";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 31);
            this.label4.TabIndex = 7;
            this.label4.Text = "Company Contact";
            // 
            // tbComContact
            // 
            this.tbComContact.Location = new System.Drawing.Point(270, 128);
            this.tbComContact.Name = "tbComContact";
            this.tbComContact.Size = new System.Drawing.Size(319, 39);
            this.tbComContact.TabIndex = 3;
            // 
            // tbComLocation
            // 
            this.tbComLocation.Location = new System.Drawing.Point(270, 83);
            this.tbComLocation.Name = "tbComLocation";
            this.tbComLocation.Size = new System.Drawing.Size(319, 39);
            this.tbComLocation.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = "Company Name";
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Location = new System.Drawing.Point(270, 38);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(319, 39);
            this.tbCompanyName.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 536);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 43);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // registerCoperator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 591);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gbLogin);
            this.Controls.Add(this.btnBack);
            this.Name = "registerCoperator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registerCoperator";
            this.gbLogin.ResumeLayout(false);
            this.gbLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox gbLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbComLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCompanyName;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox tbComContact;
    }
}