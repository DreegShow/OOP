namespace pz6kashka
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PhoneList = new ListView();
            FirstName = new ColumnHeader();
            LastName = new ColumnHeader();
            PhoneNumber = new ColumnHeader();
            Gmail = new ColumnHeader();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtPhoneNumber = new TextBox();
            txtGmail = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            txtSearch = new TextBox();
            SuspendLayout();
            // 
            // PhoneList
            // 
            PhoneList.Columns.AddRange(new ColumnHeader[] { FirstName, LastName, PhoneNumber, Gmail });
            PhoneList.Location = new Point(378, 86);
            PhoneList.Name = "PhoneList";
            PhoneList.Size = new Size(401, 291);
            PhoneList.TabIndex = 0;
            PhoneList.UseCompatibleStateImageBehavior = false;
            PhoneList.View = View.Details;
            // 
            // FirstName
            // 
            FirstName.Text = "Імя";
            // 
            // LastName
            // 
            LastName.Text = "Прізвище";
            LastName.Width = 100;
            // 
            // PhoneNumber
            // 
            PhoneNumber.Text = "Номер телефона";
            PhoneNumber.TextAlign = HorizontalAlignment.Center;
            PhoneNumber.Width = 120;
            // 
            // Gmail
            // 
            Gmail.Text = "Gmail";
            Gmail.TextAlign = HorizontalAlignment.Center;
            Gmail.Width = 110;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(130, 150);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(130, 179);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 2;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(130, 218);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(100, 23);
            txtPhoneNumber.TabIndex = 3;
            // 
            // txtGmail
            // 
            txtGmail.Location = new Point(130, 247);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(100, 23);
            txtGmail.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ButtonFace;
            btnAdd.Location = new Point(252, 150);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 120);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Додати контакт";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(378, 382);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(401, 23);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Удалить контакт";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(378, 57);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(401, 23);
            txtSearch.TabIndex = 7;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtGmail);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(PhoneList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView PhoneList;
        private ColumnHeader FirstName;
        private ColumnHeader LastName;
        private ColumnHeader PhoneNumber;
        private ColumnHeader Gmail;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtPhoneNumber;
        private TextBox txtGmail;
        private Button btnAdd;
        private Button btnDelete;
        private TextBox txtSearch;
    }
}
