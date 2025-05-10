using System.ComponentModel;

namespace Library_Management_System.ui;

partial class FrmMysteryBox
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
        cblstGeneratedBooks = new System.Windows.Forms.CheckedListBox();
        label2 = new System.Windows.Forms.Label();
        txtNumberOfBooks = new System.Windows.Forms.TextBox();
        btnGenerate = new System.Windows.Forms.Button();
        gbBookDetails = new System.Windows.Forms.GroupBox();
        lblAvailableCopies = new System.Windows.Forms.Label();
        lblGenre = new System.Windows.Forms.Label();
        lblAuthor = new System.Windows.Forms.Label();
        lblTitle = new System.Windows.Forms.Label();
        btnAddSelectedToList = new System.Windows.Forms.Button();
        pbChest = new System.Windows.Forms.PictureBox();
        gbBookDetails.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pbChest).BeginInit();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(129, 21);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(331, 20);
        label1.TabIndex = 0;
        label1.Text = "The Mystery Box: What Should You Read Next?";
        // 
        // cblstGeneratedBooks
        // 
        cblstGeneratedBooks.FormattingEnabled = true;
        cblstGeneratedBooks.Location = new System.Drawing.Point(25, 75);
        cblstGeneratedBooks.Name = "cblstGeneratedBooks";
        cblstGeneratedBooks.Size = new System.Drawing.Size(181, 238);
        cblstGeneratedBooks.TabIndex = 1;
        cblstGeneratedBooks.SelectedIndexChanged += cblstGeneratedBooks_SelectedIndexChanged;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new System.Drawing.Point(230, 75);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(103, 15);
        label2.TabIndex = 2;
        label2.Text = "Number of books:";
        // 
        // txtNumberOfBooks
        // 
        txtNumberOfBooks.Location = new System.Drawing.Point(339, 75);
        txtNumberOfBooks.Name = "txtNumberOfBooks";
        txtNumberOfBooks.Size = new System.Drawing.Size(179, 23);
        txtNumberOfBooks.TabIndex = 3;
        txtNumberOfBooks.KeyPress += txtNumberOfBooks_KeyPress;
        // 
        // btnGenerate
        // 
        btnGenerate.BackColor = System.Drawing.Color.Purple;
        btnGenerate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnGenerate.ForeColor = System.Drawing.Color.White;
        btnGenerate.Location = new System.Drawing.Point(524, 75);
        btnGenerate.Name = "btnGenerate";
        btnGenerate.Size = new System.Drawing.Size(78, 23);
        btnGenerate.TabIndex = 4;
        btnGenerate.Text = "Generate";
        btnGenerate.UseVisualStyleBackColor = false;
        btnGenerate.Click += btnGenerate_Click;
        // 
        // gbBookDetails
        // 
        gbBookDetails.Controls.Add(lblAvailableCopies);
        gbBookDetails.Controls.Add(lblGenre);
        gbBookDetails.Controls.Add(lblAuthor);
        gbBookDetails.Controls.Add(lblTitle);
        gbBookDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        gbBookDetails.Location = new System.Drawing.Point(212, 340);
        gbBookDetails.Name = "gbBookDetails";
        gbBookDetails.Size = new System.Drawing.Size(132, 23);
        gbBookDetails.TabIndex = 5;
        gbBookDetails.TabStop = false;
        gbBookDetails.Text = "Book Details";
        // 
        // lblAvailableCopies
        // 
        lblAvailableCopies.AutoSize = true;
        lblAvailableCopies.Location = new System.Drawing.Point(19, 150);
        lblAvailableCopies.Name = "lblAvailableCopies";
        lblAvailableCopies.Size = new System.Drawing.Size(96, 15);
        lblAvailableCopies.TabIndex = 3;
        lblAvailableCopies.Text = "Available copies:";
        // 
        // lblGenre
        // 
        lblGenre.AutoSize = true;
        lblGenre.Location = new System.Drawing.Point(19, 111);
        lblGenre.Name = "lblGenre";
        lblGenre.Size = new System.Drawing.Size(55, 15);
        lblGenre.TabIndex = 2;
        lblGenre.Text = "Genre(s):";
        // 
        // lblAuthor
        // 
        lblAuthor.AutoSize = true;
        lblAuthor.Location = new System.Drawing.Point(19, 72);
        lblAuthor.Name = "lblAuthor";
        lblAuthor.Size = new System.Drawing.Size(61, 15);
        lblAuthor.TabIndex = 1;
        lblAuthor.Text = "Author(s):";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Location = new System.Drawing.Point(19, 36);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(33, 15);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Title:";
        // 
        // btnAddSelectedToList
        // 
        btnAddSelectedToList.BackColor = System.Drawing.Color.Purple;
        btnAddSelectedToList.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnAddSelectedToList.ForeColor = System.Drawing.Color.White;
        btnAddSelectedToList.Location = new System.Drawing.Point(25, 319);
        btnAddSelectedToList.Name = "btnAddSelectedToList";
        btnAddSelectedToList.Size = new System.Drawing.Size(181, 23);
        btnAddSelectedToList.TabIndex = 6;
        btnAddSelectedToList.Text = "Add selected books to borrow list";
        btnAddSelectedToList.UseVisualStyleBackColor = false;
        btnAddSelectedToList.Click += btnAddSelectedToList_Click;
        // 
        // pbChest
        // 
        pbChest.Location = new System.Drawing.Point(285, 129);
        pbChest.Name = "pbChest";
        pbChest.Size = new System.Drawing.Size(267, 184);
        pbChest.TabIndex = 7;
        pbChest.TabStop = false;
        // 
        // FrmMysteryBox
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.Thistle;
        ClientSize = new System.Drawing.Size(629, 375);
        Controls.Add(pbChest);
        Controls.Add(btnAddSelectedToList);
        Controls.Add(gbBookDetails);
        Controls.Add(btnGenerate);
        Controls.Add(txtNumberOfBooks);
        Controls.Add(label2);
        Controls.Add(cblstGeneratedBooks);
        Controls.Add(label1);
        Text = "Mystery Box";
        Load += FrmMysteryBox_Load;
        gbBookDetails.ResumeLayout(false);
        gbBookDetails.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pbChest).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.PictureBox pbChest;

    private System.Windows.Forms.Label lblAuthor;
    private System.Windows.Forms.Label lblGenre;
    private System.Windows.Forms.Label lblAvailableCopies;

    private System.Windows.Forms.Label lblTitle;

    private System.Windows.Forms.CheckedListBox cblstGeneratedBooks;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtNumberOfBooks;
    private System.Windows.Forms.Button btnGenerate;
    private System.Windows.Forms.GroupBox gbBookDetails;
    private System.Windows.Forms.Button btnAddSelectedToList;

    private System.Windows.Forms.Label label1;

    #endregion
}