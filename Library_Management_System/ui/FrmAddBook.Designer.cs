using System.ComponentModel;

namespace Library_Management_System.ui;

partial class FrmAddBook
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        txtTitle = new System.Windows.Forms.TextBox();
        txtAuthor = new System.Windows.Forms.TextBox();
        txtGenre = new System.Windows.Forms.TextBox();
        txtQuantity = new System.Windows.Forms.TextBox();
        btnAddBook = new System.Windows.Forms.Button();
        label5 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(38, 25);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(35, 17);
        label1.TabIndex = 0;
        label1.Text = "Title:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(38, 93);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(64, 17);
        label2.TabIndex = 1;
        label2.Text = "Author(s):";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(38, 161);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(60, 17);
        label3.TabIndex = 2;
        label3.Text = "Genre(s):";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.Location = new System.Drawing.Point(38, 231);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(59, 17);
        label4.TabIndex = 3;
        label4.Text = "Quantity:";
        // 
        // txtTitle
        // 
        txtTitle.Location = new System.Drawing.Point(38, 45);
        txtTitle.Name = "txtTitle";
        txtTitle.Size = new System.Drawing.Size(260, 23);
        txtTitle.TabIndex = 4;
        // 
        // txtAuthor
        // 
        txtAuthor.Location = new System.Drawing.Point(38, 113);
        txtAuthor.Name = "txtAuthor";
        txtAuthor.Size = new System.Drawing.Size(260, 23);
        txtAuthor.TabIndex = 5;
        // 
        // txtGenre
        // 
        txtGenre.Location = new System.Drawing.Point(38, 181);
        txtGenre.Name = "txtGenre";
        txtGenre.Size = new System.Drawing.Size(260, 23);
        txtGenre.TabIndex = 6;
        // 
        // txtQuantity
        // 
        txtQuantity.Location = new System.Drawing.Point(38, 251);
        txtQuantity.Name = "txtQuantity";
        txtQuantity.Size = new System.Drawing.Size(260, 23);
        txtQuantity.TabIndex = 7;
        txtQuantity.KeyPress += txtQuantity_KeyPress;
        // 
        // btnAddBook
        // 
        btnAddBook.Location = new System.Drawing.Point(223, 291);
        btnAddBook.Name = "btnAddBook";
        btnAddBook.Size = new System.Drawing.Size(75, 23);
        btnAddBook.TabIndex = 8;
        btnAddBook.Text = "Add book";
        btnAddBook.UseVisualStyleBackColor = true;
        btnAddBook.Click += btnAddBook_Click;
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.ForeColor = System.Drawing.Color.Red;
        label5.Location = new System.Drawing.Point(110, 165);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(188, 13);
        label5.TabIndex = 9;
        label5.Text = "Enter genres, separated by commas";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.ForeColor = System.Drawing.Color.Red;
        label6.Location = new System.Drawing.Point(105, 97);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(193, 13);
        label6.TabIndex = 10;
        label6.Text = "Enter authors, separated by commas";
        // 
        // FrmAddBook
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(339, 341);
        Controls.Add(label6);
        Controls.Add(label5);
        Controls.Add(btnAddBook);
        Controls.Add(txtQuantity);
        Controls.Add(txtGenre);
        Controls.Add(txtAuthor);
        Controls.Add(txtTitle);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
        Text = "Add Book";
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtTitle;
    private System.Windows.Forms.TextBox txtAuthor;
    private System.Windows.Forms.TextBox txtGenre;
    private System.Windows.Forms.TextBox txtQuantity;
    private System.Windows.Forms.Button btnAddBook;

    private System.Windows.Forms.Label label1;

    #endregion
}