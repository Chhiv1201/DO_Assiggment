namespace DeliveryOrder.Forms.Menu
{
    partial class MainMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabNewItem = new System.Windows.Forms.TabPage();
            this.gdNewItem = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPick = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCusAddress = new System.Windows.Forms.TextBox();
            this.tbDescribtion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbCusPhone = new System.Windows.Forms.TextBox();
            this.tbToLocation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabDeliveringItem = new System.Windows.Forms.TabPage();
            this.gdDeliveringItem = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.tabCompleteItem = new System.Windows.Forms.TabPage();
            this.gdCompleteItem = new System.Windows.Forms.DataGridView();
            this.lbltest = new System.Windows.Forms.Label();
            this.lbUser = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tab.SuspendLayout();
            this.tabNewItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdNewItem)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabDeliveringItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdDeliveringItem)).BeginInit();
            this.tabCompleteItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gdCompleteItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product Delivery System";
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabNewItem);
            this.tab.Controls.Add(this.tabDeliveringItem);
            this.tab.Controls.Add(this.tabCompleteItem);
            this.tab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tab.Location = new System.Drawing.Point(19, 110);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(953, 539);
            this.tab.TabIndex = 1;
            this.tab.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tab_Selecting);
            // 
            // tabNewItem
            // 
            this.tabNewItem.Controls.Add(this.gdNewItem);
            this.tabNewItem.Controls.Add(this.groupBox2);
            this.tabNewItem.Controls.Add(this.groupBox1);
            this.tabNewItem.Location = new System.Drawing.Point(4, 34);
            this.tabNewItem.Name = "tabNewItem";
            this.tabNewItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabNewItem.Size = new System.Drawing.Size(945, 501);
            this.tabNewItem.TabIndex = 0;
            this.tabNewItem.Text = "New Item";
            this.tabNewItem.UseVisualStyleBackColor = true;
            // 
            // gdNewItem
            // 
            this.gdNewItem.AllowUserToAddRows = false;
            this.gdNewItem.AllowUserToDeleteRows = false;
            this.gdNewItem.AllowUserToOrderColumns = true;
            this.gdNewItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdNewItem.Location = new System.Drawing.Point(6, 265);
            this.gdNewItem.MultiSelect = false;
            this.gdNewItem.Name = "gdNewItem";
            this.gdNewItem.ReadOnly = true;
            this.gdNewItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdNewItem.Size = new System.Drawing.Size(933, 230);
            this.gdNewItem.TabIndex = 16;
            this.gdNewItem.SelectionChanged += new System.EventHandler(this.gdNewItem_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPick);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.Edit);
            this.groupBox2.Controls.Add(this.Cancel);
            this.groupBox2.Location = new System.Drawing.Point(819, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(120, 253);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operation";
            // 
            // btnPick
            // 
            this.btnPick.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPick.Location = new System.Drawing.Point(6, 179);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(108, 31);
            this.btnPick.TabIndex = 9;
            this.btnPick.Tag = "admin";
            this.btnPick.Text = "Pick Up";
            this.btnPick.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(6, 48);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(108, 31);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Edit
            // 
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.Location = new System.Drawing.Point(6, 85);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(108, 31);
            this.Edit.TabIndex = 8;
            this.Edit.Text = "Edit";
            this.Edit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(6, 216);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(108, 31);
            this.Cancel.TabIndex = 10;
            this.Cancel.Text = "Cancel";
            this.Cancel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbProductName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbCusAddress);
            this.groupBox1.Controls.Add(this.tbDescribtion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbCusPhone);
            this.groupBox1.Controls.Add(this.tbToLocation);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(807, 253);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Item Information";
            // 
            // tbProductName
            // 
            this.tbProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProductName.Location = new System.Drawing.Point(200, 49);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(601, 27);
            this.tbProductName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer Address";
            // 
            // tbCusAddress
            // 
            this.tbCusAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCusAddress.Location = new System.Drawing.Point(200, 118);
            this.tbCusAddress.Name = "tbCusAddress";
            this.tbCusAddress.Size = new System.Drawing.Size(601, 27);
            this.tbCusAddress.TabIndex = 3;
            // 
            // tbDescribtion
            // 
            this.tbDescribtion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescribtion.Location = new System.Drawing.Point(200, 190);
            this.tbDescribtion.Name = "tbDescribtion";
            this.tbDescribtion.Size = new System.Drawing.Size(601, 27);
            this.tbDescribtion.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Customer Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Describtion";
            // 
            // tbCusPhone
            // 
            this.tbCusPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCusPhone.Location = new System.Drawing.Point(200, 82);
            this.tbCusPhone.Name = "tbCusPhone";
            this.tbCusPhone.Size = new System.Drawing.Size(601, 27);
            this.tbCusPhone.TabIndex = 2;
            // 
            // tbToLocation
            // 
            this.tbToLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbToLocation.Location = new System.Drawing.Point(200, 154);
            this.tbToLocation.Name = "tbToLocation";
            this.tbToLocation.Size = new System.Drawing.Size(601, 27);
            this.tbToLocation.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "To Location";
            // 
            // tabDeliveringItem
            // 
            this.tabDeliveringItem.Controls.Add(this.gdDeliveringItem);
            this.tabDeliveringItem.Controls.Add(this.btnCancel);
            this.tabDeliveringItem.Controls.Add(this.btnComplete);
            this.tabDeliveringItem.Location = new System.Drawing.Point(4, 34);
            this.tabDeliveringItem.Name = "tabDeliveringItem";
            this.tabDeliveringItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeliveringItem.Size = new System.Drawing.Size(945, 501);
            this.tabDeliveringItem.TabIndex = 1;
            this.tabDeliveringItem.Text = "Delivering Item";
            this.tabDeliveringItem.UseVisualStyleBackColor = true;
            // 
            // gdDeliveringItem
            // 
            this.gdDeliveringItem.AllowUserToAddRows = false;
            this.gdDeliveringItem.AllowUserToDeleteRows = false;
            this.gdDeliveringItem.AllowUserToOrderColumns = true;
            this.gdDeliveringItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdDeliveringItem.Location = new System.Drawing.Point(6, 49);
            this.gdDeliveringItem.MultiSelect = false;
            this.gdDeliveringItem.Name = "gdDeliveringItem";
            this.gdDeliveringItem.ReadOnly = true;
            this.gdDeliveringItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdDeliveringItem.Size = new System.Drawing.Size(933, 446);
            this.gdDeliveringItem.TabIndex = 17;
            this.gdDeliveringItem.SelectionChanged += new System.EventHandler(this.gdDeliveringItem_SelectionChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(839, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 37);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Tag = "admin";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(723, 6);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(110, 37);
            this.btnComplete.TabIndex = 1;
            this.btnComplete.Tag = "admin";
            this.btnComplete.Text = "Complete";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // tabCompleteItem
            // 
            this.tabCompleteItem.Controls.Add(this.gdCompleteItem);
            this.tabCompleteItem.Location = new System.Drawing.Point(4, 34);
            this.tabCompleteItem.Name = "tabCompleteItem";
            this.tabCompleteItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompleteItem.Size = new System.Drawing.Size(945, 501);
            this.tabCompleteItem.TabIndex = 2;
            this.tabCompleteItem.Text = "Closed Item";
            this.tabCompleteItem.UseVisualStyleBackColor = true;
            // 
            // gdCompleteItem
            // 
            this.gdCompleteItem.AllowUserToAddRows = false;
            this.gdCompleteItem.AllowUserToDeleteRows = false;
            this.gdCompleteItem.AllowUserToOrderColumns = true;
            this.gdCompleteItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdCompleteItem.Location = new System.Drawing.Point(6, 6);
            this.gdCompleteItem.MultiSelect = false;
            this.gdCompleteItem.Name = "gdCompleteItem";
            this.gdCompleteItem.ReadOnly = true;
            this.gdCompleteItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gdCompleteItem.Size = new System.Drawing.Size(933, 489);
            this.gdCompleteItem.TabIndex = 18;
            this.gdCompleteItem.SelectionChanged += new System.EventHandler(this.gdCompleteItem_SelectionChanged);
            // 
            // lbltest
            // 
            this.lbltest.AutoSize = true;
            this.lbltest.Location = new System.Drawing.Point(312, 66);
            this.lbltest.Name = "lbltest";
            this.lbltest.Size = new System.Drawing.Size(46, 13);
            this.lbltest.TabIndex = 4;
            this.lbltest.Text = "TakerID";
            // 
            // lbUser
            // 
            this.lbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbUser.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUser.Location = new System.Drawing.Point(407, 17);
            this.lbUser.Name = "lbUser";
            this.lbUser.Size = new System.Drawing.Size(565, 31);
            this.lbUser.TabIndex = 2;
            this.lbUser.Text = "User";
            this.lbUser.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(881, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 36);
            this.button1.TabIndex = 3;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbltest);
            this.Controls.Add(this.lbUser);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.label1);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.tab.ResumeLayout(false);
            this.tabNewItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdNewItem)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabDeliveringItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdDeliveringItem)).EndInit();
            this.tabCompleteItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gdCompleteItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabNewItem;
        private System.Windows.Forms.TabPage tabDeliveringItem;
        private System.Windows.Forms.TabPage tabCompleteItem;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbDescribtion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbToLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCusPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCusAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbUser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Label lbltest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView gdNewItem;
        private System.Windows.Forms.DataGridView gdDeliveringItem;
        private System.Windows.Forms.DataGridView gdCompleteItem;
    }
}