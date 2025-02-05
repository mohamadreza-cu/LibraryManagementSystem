﻿using System;

using System.Windows.Forms;

using LibraryManagementSystem.BusinessLogic;

using LibraryManagementSystem.Models;



namespace LibraryManagementSystem.Presentation

{

    public partial class BookForm : Form

    {

        private BookBLL bookBLL = new BookBLL();



        public BookForm()

        {

            InitializeComponent();

            //LoadBooks();

        }



        private void button1_Click(object sender, EventArgs e)
        {

            try

            {

                Book book = new Book

                {

                    Title = txtTitle.Text.Trim(),

                    Author = txtAuthor.Text.Trim(),

                    ISBN = txtISBN.Text.Trim(),

                    Publisher = txtPublisher.Text.Trim(),

                    Year = int.Parse(txtYear.Text.Trim())

                };



                bookBLL.AddBook(book);

                MessageBox.Show("Book added successfully!");

                //LoadBooks();

                ClearFields();

            }

            catch (Exception ex)

            {

                MessageBox.Show($"Error: {ex.Message}");

            }

        }



        //private void LoadBooks()

        //{

        //    dgvBooks.DataSource = bookBLL.GetBooks();

        //}

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtISBN = new TextBox();
            txtPublisher = new TextBox();
            txtYear = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 0;
            label1.Text = "Book Details";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 50);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 1;
            label2.Text = "Title";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 87);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 126);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 3;
            label4.Text = "ISBN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 167);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 4;
            label5.Text = "Publisher";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 203);
            label6.Name = "label6";
            label6.Size = new Size(37, 20);
            label6.TabIndex = 5;
            label6.Text = "Year";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(100, 46);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(100, 27);
            txtTitle.TabIndex = 6;
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(100, 86);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(100, 27);
            txtAuthor.TabIndex = 7;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(100, 123);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(100, 27);
            txtISBN.TabIndex = 8;
            // 
            // txtPublisher
            // 
            txtPublisher.Location = new Point(100, 163);
            txtPublisher.Name = "txtPublisher";
            txtPublisher.Size = new Size(100, 27);
            txtPublisher.TabIndex = 9;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(100, 206);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 27);
            txtYear.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(242, 101);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 11;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BookForm
            // 
            ClientSize = new Size(345, 261);
            Controls.Add(button1);
            Controls.Add(txtYear);
            Controls.Add(txtPublisher);
            Controls.Add(txtISBN);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "BookForm";
            ResumeLayout(false);
            PerformLayout();
        }

        private void ClearFields()

        {

            txtTitle.Clear();

            txtAuthor.Clear();

            txtISBN.Clear();

            txtPublisher.Clear();

            txtYear.Clear();

        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtISBN;
        private TextBox txtPublisher;
        private Button button1;

        //private Button btnAdd_Click;

        //private Button btnAdd_Click;
        private TextBox txtYear;

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        



        // Implement Update and Delete event handlers 

    }

}