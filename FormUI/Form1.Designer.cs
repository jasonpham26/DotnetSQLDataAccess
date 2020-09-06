namespace FormUI
{
    partial class Form1
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
            this.PeopleFoundListBox = new System.Windows.Forms.ListBox();
            this.label = new System.Windows.Forms.Label();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.FirstNameInsText = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.LastNameInsText = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.EmailInsText = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.PhoneNumberInsText = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.BtnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PeopleFoundListBox
            // 
            this.PeopleFoundListBox.FormattingEnabled = true;
            this.PeopleFoundListBox.ItemHeight = 16;
            this.PeopleFoundListBox.Location = new System.Drawing.Point(66, 102);
            this.PeopleFoundListBox.Name = "PeopleFoundListBox";
            this.PeopleFoundListBox.Size = new System.Drawing.Size(417, 260);
            this.PeopleFoundListBox.TabIndex = 0;
            this.PeopleFoundListBox.UseWaitCursor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(61, 15);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(76, 17);
            this.label.TabIndex = 4;
            this.label.Text = "Last Name";
            this.label.UseWaitCursor = true;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(143, 12);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(139, 22);
            this.lastNameText.TabIndex = 5;
            this.lastNameText.UseWaitCursor = true;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(148, 56);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(99, 28);
            this.SearchButton.TabIndex = 6;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.UseWaitCursor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // FirstNameInsText
            // 
            this.FirstNameInsText.Location = new System.Drawing.Point(678, 233);
            this.FirstNameInsText.Name = "FirstNameInsText";
            this.FirstNameInsText.Size = new System.Drawing.Size(139, 22);
            this.FirstNameInsText.TabIndex = 8;
            this.FirstNameInsText.UseWaitCursor = true;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(569, 233);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 17);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.UseWaitCursor = true;
            // 
            // LastNameInsText
            // 
            this.LastNameInsText.Location = new System.Drawing.Point(678, 261);
            this.LastNameInsText.Name = "LastNameInsText";
            this.LastNameInsText.Size = new System.Drawing.Size(139, 22);
            this.LastNameInsText.TabIndex = 10;
            this.LastNameInsText.UseWaitCursor = true;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(569, 263);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 17);
            this.lblLastName.TabIndex = 9;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.UseWaitCursor = true;
            // 
            // EmailInsText
            // 
            this.EmailInsText.Location = new System.Drawing.Point(678, 293);
            this.EmailInsText.Name = "EmailInsText";
            this.EmailInsText.Size = new System.Drawing.Size(139, 22);
            this.EmailInsText.TabIndex = 12;
            this.EmailInsText.UseWaitCursor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(569, 296);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            this.lblEmail.UseWaitCursor = true;
            // 
            // PhoneNumberInsText
            // 
            this.PhoneNumberInsText.Location = new System.Drawing.Point(678, 324);
            this.PhoneNumberInsText.Name = "PhoneNumberInsText";
            this.PhoneNumberInsText.Size = new System.Drawing.Size(139, 22);
            this.PhoneNumberInsText.TabIndex = 14;
            this.PhoneNumberInsText.UseWaitCursor = true;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(569, 327);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(103, 17);
            this.lblPhoneNumber.TabIndex = 13;
            this.lblPhoneNumber.Text = "Phone Number";
            this.lblPhoneNumber.UseWaitCursor = true;
            // 
            // BtnInsert
            // 
            this.BtnInsert.Location = new System.Drawing.Point(678, 352);
            this.BtnInsert.Name = "BtnInsert";
            this.BtnInsert.Size = new System.Drawing.Size(139, 24);
            this.BtnInsert.TabIndex = 15;
            this.BtnInsert.Text = "Insert";
            this.BtnInsert.UseVisualStyleBackColor = true;
            this.BtnInsert.UseWaitCursor = true;
            this.BtnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 493);
            this.Controls.Add(this.BtnInsert);
            this.Controls.Add(this.PhoneNumberInsText);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.EmailInsText);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.LastNameInsText);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.FirstNameInsText);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.label);
            this.Controls.Add(this.PeopleFoundListBox);
            this.Name = "Form1";
            this.Text = "SQL Data Access";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PeopleFoundListBox;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox FirstNameInsText;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox LastNameInsText;
        private System.Windows.Forms.TextBox EmailInsText;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox PhoneNumberInsText;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button BtnInsert;
    }
}

