namespace LibraryManagementSystem
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
            btnManageMembers = new Button();
            btnManageBorrowing = new Button();
            btnManageBooks = new Button();
            SuspendLayout();
            // 
            // btnManageMembers
            // 
            btnManageMembers.Location = new Point(66, 125);
            btnManageMembers.Name = "btnManageMembers";
            btnManageMembers.Size = new Size(287, 52);
            btnManageMembers.TabIndex = 1;
            btnManageMembers.Text = "Manage Members";
            btnManageMembers.UseVisualStyleBackColor = true;
            // 
            // btnManageBorrowing
            // 
            btnManageBorrowing.Location = new Point(66, 212);
            btnManageBorrowing.Name = "btnManageBorrowing";
            btnManageBorrowing.Size = new Size(287, 49);
            btnManageBorrowing.TabIndex = 2;
            btnManageBorrowing.Text = "Manage Borrowing";
            btnManageBorrowing.UseVisualStyleBackColor = true;
            btnManageBorrowing.Click += btnManageBorrowing_Click;
            // 
            // btnManageBooks
            // 
            btnManageBooks.Location = new Point(66, 36);
            btnManageBooks.Name = "btnManageBooks";
            btnManageBooks.Size = new Size(287, 55);
            btnManageBooks.TabIndex = 3;
            btnManageBooks.Text = "Manage Books";
            btnManageBooks.UseVisualStyleBackColor = true;
            btnManageBooks.Click += btnManageBooks_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnManageBooks);
            Controls.Add(btnManageBorrowing);
            Controls.Add(btnManageMembers);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion
        private Button btnManageMembers;
        private Button btnManageBorrowing;
        private Button btnManageBooks;
    }
}