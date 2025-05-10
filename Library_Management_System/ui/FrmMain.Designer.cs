using System.ComponentModel;

namespace Library_Management_System.ui;

partial class FrmMain
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
        tabControlMain = new System.Windows.Forms.TabControl();
        tabBookManagement = new System.Windows.Forms.TabPage();
        btnAddBook = new System.Windows.Forms.Button();
        btnDeleteBook = new System.Windows.Forms.Button();
        gbBookInfo = new System.Windows.Forms.GroupBox();
        label15 = new System.Windows.Forms.Label();
        btnUpdateBookInfo = new System.Windows.Forms.Button();
        btnPlus = new System.Windows.Forms.Button();
        btnMinus = new System.Windows.Forms.Button();
        txtQuantity = new System.Windows.Forms.TextBox();
        txtGenre = new System.Windows.Forms.TextBox();
        txtAuthor = new System.Windows.Forms.TextBox();
        txtTitle = new System.Windows.Forms.TextBox();
        label6 = new System.Windows.Forms.Label();
        lblAvailableCopies = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        btnSearch = new System.Windows.Forms.Button();
        rbAuthor = new System.Windows.Forms.RadioButton();
        rbGenre = new System.Windows.Forms.RadioButton();
        rbTitle = new System.Windows.Forms.RadioButton();
        txtSearch = new System.Windows.Forms.TextBox();
        lstViewBooks = new System.Windows.Forms.ListView();
        lblBooks = new System.Windows.Forms.Label();
        tabLendBooks = new System.Windows.Forms.TabPage();
        btnMisteryBox = new System.Windows.Forms.Button();
        btnSearchBook = new System.Windows.Forms.Button();
        txtSearchBookString = new System.Windows.Forms.TextBox();
        rbBookAuthor = new System.Windows.Forms.RadioButton();
        rbBookGenre = new System.Windows.Forms.RadioButton();
        rbBookTitle = new System.Windows.Forms.RadioButton();
        lstViewBooksToBorrow = new System.Windows.Forms.ListView();
        lstViewBooksCatalog = new System.Windows.Forms.ListView();
        label20 = new System.Windows.Forms.Label();
        gbBookDetails = new System.Windows.Forms.GroupBox();
        btnRemoveFromList = new System.Windows.Forms.Button();
        btnAddToBorrowList = new System.Windows.Forms.Button();
        lblNumberOfAvailableCopies = new System.Windows.Forms.Label();
        lblGenre = new System.Windows.Forms.Label();
        lblAuthor = new System.Windows.Forms.Label();
        lblTitle = new System.Windows.Forms.Label();
        gbLoanDetails = new System.Windows.Forms.GroupBox();
        btnBorrow = new System.Windows.Forms.Button();
        lblPersonDetails = new System.Windows.Forms.Label();
        txtSearchByCnp = new System.Windows.Forms.TextBox();
        label19 = new System.Windows.Forms.Label();
        btnSearchPerson = new System.Windows.Forms.Button();
        label14 = new System.Windows.Forms.Label();
        label13 = new System.Windows.Forms.Label();
        tabReturnBooks = new System.Windows.Forms.TabPage();
        btnClear = new System.Windows.Forms.Button();
        gbBookDetailsRetur = new System.Windows.Forms.GroupBox();
        lblBorrowDate = new System.Windows.Forms.Label();
        lblGenreRetur = new System.Windows.Forms.Label();
        lblAuthorRetur = new System.Windows.Forms.Label();
        lblTitleRetur = new System.Windows.Forms.Label();
        gbPersonDetails = new System.Windows.Forms.GroupBox();
        btnReturnBooks = new System.Windows.Forms.Button();
        lblPersonDetailsRetur = new System.Windows.Forms.Label();
        txtSearchCnpRetur = new System.Windows.Forms.TextBox();
        label18 = new System.Windows.Forms.Label();
        btnSearchPersonByCnp = new System.Windows.Forms.Button();
        label16 = new System.Windows.Forms.Label();
        cblstBorrowedBooks = new System.Windows.Forms.CheckedListBox();
        tabCreateLoanForm = new System.Windows.Forms.TabPage();
        btnAddPerson = new System.Windows.Forms.Button();
        label12 = new System.Windows.Forms.Label();
        txtCounty = new System.Windows.Forms.TextBox();
        txtCity = new System.Windows.Forms.TextBox();
        txtCnp = new System.Windows.Forms.TextBox();
        txtPhone = new System.Windows.Forms.TextBox();
        txtAddress = new System.Windows.Forms.TextBox();
        txtName = new System.Windows.Forms.TextBox();
        label11 = new System.Windows.Forms.Label();
        label10 = new System.Windows.Forms.Label();
        label9 = new System.Windows.Forms.Label();
        label8 = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        btnClearBorrow = new System.Windows.Forms.Button();
        tabControlMain.SuspendLayout();
        tabBookManagement.SuspendLayout();
        gbBookInfo.SuspendLayout();
        tabLendBooks.SuspendLayout();
        gbBookDetails.SuspendLayout();
        gbLoanDetails.SuspendLayout();
        tabReturnBooks.SuspendLayout();
        gbBookDetailsRetur.SuspendLayout();
        gbPersonDetails.SuspendLayout();
        tabCreateLoanForm.SuspendLayout();
        SuspendLayout();
        // 
        // tabControlMain
        // 
        tabControlMain.Controls.Add(tabBookManagement);
        tabControlMain.Controls.Add(tabLendBooks);
        tabControlMain.Controls.Add(tabReturnBooks);
        tabControlMain.Controls.Add(tabCreateLoanForm);
        tabControlMain.Location = new System.Drawing.Point(0, 1);
        tabControlMain.Name = "tabControlMain";
        tabControlMain.SelectedIndex = 0;
        tabControlMain.Size = new System.Drawing.Size(626, 515);
        tabControlMain.TabIndex = 0;
        // 
        // tabBookManagement
        // 
        tabBookManagement.BackColor = System.Drawing.Color.Thistle;
        tabBookManagement.Controls.Add(btnAddBook);
        tabBookManagement.Controls.Add(btnDeleteBook);
        tabBookManagement.Controls.Add(gbBookInfo);
        tabBookManagement.Controls.Add(label1);
        tabBookManagement.Controls.Add(btnSearch);
        tabBookManagement.Controls.Add(rbAuthor);
        tabBookManagement.Controls.Add(rbGenre);
        tabBookManagement.Controls.Add(rbTitle);
        tabBookManagement.Controls.Add(txtSearch);
        tabBookManagement.Controls.Add(lstViewBooks);
        tabBookManagement.Controls.Add(lblBooks);
        tabBookManagement.Location = new System.Drawing.Point(4, 24);
        tabBookManagement.Name = "tabBookManagement";
        tabBookManagement.Padding = new System.Windows.Forms.Padding(3);
        tabBookManagement.Size = new System.Drawing.Size(618, 487);
        tabBookManagement.TabIndex = 0;
        tabBookManagement.Text = "Book Management";
        // 
        // btnAddBook
        // 
        btnAddBook.BackColor = System.Drawing.Color.Purple;
        btnAddBook.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnAddBook.ForeColor = System.Drawing.Color.White;
        btnAddBook.Location = new System.Drawing.Point(159, 431);
        btnAddBook.Name = "btnAddBook";
        btnAddBook.Size = new System.Drawing.Size(107, 23);
        btnAddBook.TabIndex = 14;
        btnAddBook.Text = "Add Book";
        btnAddBook.UseVisualStyleBackColor = false;
        btnAddBook.Click += btnAddBook_Click;
        // 
        // btnDeleteBook
        // 
        btnDeleteBook.BackColor = System.Drawing.Color.Purple;
        btnDeleteBook.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnDeleteBook.ForeColor = System.Drawing.Color.White;
        btnDeleteBook.Location = new System.Drawing.Point(30, 431);
        btnDeleteBook.Name = "btnDeleteBook";
        btnDeleteBook.Size = new System.Drawing.Size(107, 23);
        btnDeleteBook.TabIndex = 13;
        btnDeleteBook.Text = "Delete book";
        btnDeleteBook.UseVisualStyleBackColor = false;
        btnDeleteBook.Click += btnDeleteBook_Click;
        // 
        // gbBookInfo
        // 
        gbBookInfo.Controls.Add(label15);
        gbBookInfo.Controls.Add(btnUpdateBookInfo);
        gbBookInfo.Controls.Add(btnPlus);
        gbBookInfo.Controls.Add(btnMinus);
        gbBookInfo.Controls.Add(txtQuantity);
        gbBookInfo.Controls.Add(txtGenre);
        gbBookInfo.Controls.Add(txtAuthor);
        gbBookInfo.Controls.Add(txtTitle);
        gbBookInfo.Controls.Add(label6);
        gbBookInfo.Controls.Add(lblAvailableCopies);
        gbBookInfo.Controls.Add(label4);
        gbBookInfo.Controls.Add(label3);
        gbBookInfo.Controls.Add(label2);
        gbBookInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        gbBookInfo.Location = new System.Drawing.Point(307, 122);
        gbBookInfo.Name = "gbBookInfo";
        gbBookInfo.Size = new System.Drawing.Size(283, 345);
        gbBookInfo.TabIndex = 8;
        gbBookInfo.TabStop = false;
        gbBookInfo.Text = "Book Info";
        // 
        // label15
        // 
        label15.AutoSize = true;
        label15.Location = new System.Drawing.Point(28, 203);
        label15.Name = "label15";
        label15.Size = new System.Drawing.Size(96, 15);
        label15.TabIndex = 13;
        label15.Text = "Available copies:";
        // 
        // btnUpdateBookInfo
        // 
        btnUpdateBookInfo.BackColor = System.Drawing.Color.Purple;
        btnUpdateBookInfo.ForeColor = System.Drawing.Color.White;
        btnUpdateBookInfo.Location = new System.Drawing.Point(28, 309);
        btnUpdateBookInfo.Name = "btnUpdateBookInfo";
        btnUpdateBookInfo.Size = new System.Drawing.Size(234, 23);
        btnUpdateBookInfo.TabIndex = 12;
        btnUpdateBookInfo.Text = "Update Book Info";
        btnUpdateBookInfo.UseVisualStyleBackColor = false;
        btnUpdateBookInfo.Click += btnUpdateBookInfo_Click;
        // 
        // btnPlus
        // 
        btnPlus.BackColor = System.Drawing.Color.Purple;
        btnPlus.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnPlus.ForeColor = System.Drawing.Color.White;
        btnPlus.Location = new System.Drawing.Point(187, 253);
        btnPlus.Name = "btnPlus";
        btnPlus.Size = new System.Drawing.Size(75, 23);
        btnPlus.TabIndex = 11;
        btnPlus.Text = "+";
        btnPlus.UseVisualStyleBackColor = false;
        btnPlus.Click += btnPlus_Click;
        // 
        // btnMinus
        // 
        btnMinus.BackColor = System.Drawing.Color.Purple;
        btnMinus.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnMinus.ForeColor = System.Drawing.Color.White;
        btnMinus.Location = new System.Drawing.Point(28, 253);
        btnMinus.Name = "btnMinus";
        btnMinus.Size = new System.Drawing.Size(75, 23);
        btnMinus.TabIndex = 10;
        btnMinus.Text = "-";
        btnMinus.UseVisualStyleBackColor = false;
        btnMinus.Click += btnMinus_Click;
        // 
        // txtQuantity
        // 
        txtQuantity.Enabled = false;
        txtQuantity.Location = new System.Drawing.Point(109, 252);
        txtQuantity.Name = "txtQuantity";
        txtQuantity.Size = new System.Drawing.Size(72, 24);
        txtQuantity.TabIndex = 9;
        // 
        // txtGenre
        // 
        txtGenre.Location = new System.Drawing.Point(28, 166);
        txtGenre.Name = "txtGenre";
        txtGenre.Size = new System.Drawing.Size(234, 24);
        txtGenre.TabIndex = 8;
        // 
        // txtAuthor
        // 
        txtAuthor.Location = new System.Drawing.Point(28, 109);
        txtAuthor.Name = "txtAuthor";
        txtAuthor.Size = new System.Drawing.Size(234, 24);
        txtAuthor.TabIndex = 7;
        // 
        // txtTitle
        // 
        txtTitle.Location = new System.Drawing.Point(28, 53);
        txtTitle.Name = "txtTitle";
        txtTitle.Size = new System.Drawing.Size(234, 24);
        txtTitle.TabIndex = 5;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new System.Drawing.Point(28, 234);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(57, 15);
        label6.TabIndex = 4;
        label6.Text = "Quantity:";
        // 
        // lblAvailableCopies
        // 
        lblAvailableCopies.AutoSize = true;
        lblAvailableCopies.Location = new System.Drawing.Point(130, 203);
        lblAvailableCopies.Name = "lblAvailableCopies";
        lblAvailableCopies.Size = new System.Drawing.Size(14, 15);
        lblAvailableCopies.TabIndex = 3;
        lblAvailableCopies.Text = "0";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new System.Drawing.Point(28, 148);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(55, 15);
        label4.TabIndex = 2;
        label4.Text = "Genre(s):";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new System.Drawing.Point(28, 91);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(61, 15);
        label3.TabIndex = 1;
        label3.Text = "Author(s):";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new System.Drawing.Point(28, 35);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(33, 15);
        label2.TabIndex = 0;
        label2.Text = "Title:";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new System.Drawing.Point(307, 44);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(61, 15);
        label1.TabIndex = 7;
        label1.Text = "Search by:";
        // 
        // btnSearch
        // 
        btnSearch.BackColor = System.Drawing.Color.Purple;
        btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnSearch.ForeColor = System.Drawing.Color.White;
        btnSearch.Location = new System.Drawing.Point(515, 75);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new System.Drawing.Size(75, 23);
        btnSearch.TabIndex = 6;
        btnSearch.Text = "Search";
        btnSearch.UseVisualStyleBackColor = false;
        btnSearch.Click += btnSearch_Click;
        // 
        // rbAuthor
        // 
        rbAuthor.AutoSize = true;
        rbAuthor.Location = new System.Drawing.Point(528, 40);
        rbAuthor.Name = "rbAuthor";
        rbAuthor.Size = new System.Drawing.Size(62, 19);
        rbAuthor.TabIndex = 5;
        rbAuthor.TabStop = true;
        rbAuthor.Text = "Author";
        rbAuthor.UseVisualStyleBackColor = true;
        // 
        // rbGenre
        // 
        rbGenre.AutoSize = true;
        rbGenre.Location = new System.Drawing.Point(453, 40);
        rbGenre.Name = "rbGenre";
        rbGenre.Size = new System.Drawing.Size(56, 19);
        rbGenre.TabIndex = 4;
        rbGenre.TabStop = true;
        rbGenre.Text = "Genre";
        rbGenre.UseVisualStyleBackColor = true;
        // 
        // rbTitle
        // 
        rbTitle.AutoSize = true;
        rbTitle.Location = new System.Drawing.Point(384, 40);
        rbTitle.Name = "rbTitle";
        rbTitle.Size = new System.Drawing.Size(47, 19);
        rbTitle.TabIndex = 3;
        rbTitle.TabStop = true;
        rbTitle.Text = "Title";
        rbTitle.UseVisualStyleBackColor = true;
        // 
        // txtSearch
        // 
        txtSearch.Location = new System.Drawing.Point(307, 75);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new System.Drawing.Size(202, 23);
        txtSearch.TabIndex = 2;
        // 
        // lstViewBooks
        // 
        lstViewBooks.Location = new System.Drawing.Point(30, 40);
        lstViewBooks.MultiSelect = false;
        lstViewBooks.Name = "lstViewBooks";
        lstViewBooks.Size = new System.Drawing.Size(236, 385);
        lstViewBooks.TabIndex = 1;
        lstViewBooks.UseCompatibleStateImageBehavior = false;
        lstViewBooks.SelectedIndexChanged += lstViewBooks_SelectedIndexChanged;
        // 
        // lblBooks
        // 
        lblBooks.AutoSize = true;
        lblBooks.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        lblBooks.Location = new System.Drawing.Point(30, 22);
        lblBooks.Name = "lblBooks";
        lblBooks.Size = new System.Drawing.Size(95, 15);
        lblBooks.TabIndex = 0;
        lblBooks.Text = "Library Catalog:";
        // 
        // tabLendBooks
        // 
        tabLendBooks.BackColor = System.Drawing.Color.Thistle;
        tabLendBooks.Controls.Add(btnMisteryBox);
        tabLendBooks.Controls.Add(btnSearchBook);
        tabLendBooks.Controls.Add(txtSearchBookString);
        tabLendBooks.Controls.Add(rbBookAuthor);
        tabLendBooks.Controls.Add(rbBookGenre);
        tabLendBooks.Controls.Add(rbBookTitle);
        tabLendBooks.Controls.Add(lstViewBooksToBorrow);
        tabLendBooks.Controls.Add(lstViewBooksCatalog);
        tabLendBooks.Controls.Add(label20);
        tabLendBooks.Controls.Add(gbBookDetails);
        tabLendBooks.Controls.Add(gbLoanDetails);
        tabLendBooks.Controls.Add(label14);
        tabLendBooks.Controls.Add(label13);
        tabLendBooks.Location = new System.Drawing.Point(4, 24);
        tabLendBooks.Name = "tabLendBooks";
        tabLendBooks.Padding = new System.Windows.Forms.Padding(3);
        tabLendBooks.Size = new System.Drawing.Size(618, 487);
        tabLendBooks.TabIndex = 1;
        tabLendBooks.Text = "Borrow Books";
        // 
        // btnMisteryBox
        // 
        btnMisteryBox.BackColor = System.Drawing.Color.Purple;
        btnMisteryBox.Font = new System.Drawing.Font("Arial", 9F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnMisteryBox.ForeColor = System.Drawing.Color.White;
        btnMisteryBox.Location = new System.Drawing.Point(29, 444);
        btnMisteryBox.Name = "btnMisteryBox";
        btnMisteryBox.Size = new System.Drawing.Size(195, 23);
        btnMisteryBox.TabIndex = 25;
        btnMisteryBox.Text = "Looking for Book Ideas?";
        btnMisteryBox.UseVisualStyleBackColor = false;
        btnMisteryBox.Click += btnMisteryBox_Click;
        // 
        // btnSearchBook
        // 
        btnSearchBook.BackColor = System.Drawing.Color.Purple;
        btnSearchBook.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnSearchBook.ForeColor = System.Drawing.Color.White;
        btnSearchBook.Location = new System.Drawing.Point(514, 64);
        btnSearchBook.Name = "btnSearchBook";
        btnSearchBook.Size = new System.Drawing.Size(75, 23);
        btnSearchBook.TabIndex = 24;
        btnSearchBook.Text = "Search";
        btnSearchBook.UseVisualStyleBackColor = false;
        btnSearchBook.Click += btnSearchBook_Click;
        // 
        // txtSearchBookString
        // 
        txtSearchBookString.Location = new System.Drawing.Point(255, 64);
        txtSearchBookString.Name = "txtSearchBookString";
        txtSearchBookString.Size = new System.Drawing.Size(253, 23);
        txtSearchBookString.TabIndex = 23;
        // 
        // rbBookAuthor
        // 
        rbBookAuthor.AutoSize = true;
        rbBookAuthor.Location = new System.Drawing.Point(527, 39);
        rbBookAuthor.Name = "rbBookAuthor";
        rbBookAuthor.Size = new System.Drawing.Size(62, 19);
        rbBookAuthor.TabIndex = 22;
        rbBookAuthor.TabStop = true;
        rbBookAuthor.Text = "Author";
        rbBookAuthor.UseVisualStyleBackColor = true;
        // 
        // rbBookGenre
        // 
        rbBookGenre.AutoSize = true;
        rbBookGenre.Location = new System.Drawing.Point(452, 39);
        rbBookGenre.Name = "rbBookGenre";
        rbBookGenre.Size = new System.Drawing.Size(56, 19);
        rbBookGenre.TabIndex = 21;
        rbBookGenre.TabStop = true;
        rbBookGenre.Text = "Genre";
        rbBookGenre.UseVisualStyleBackColor = true;
        // 
        // rbBookTitle
        // 
        rbBookTitle.AutoSize = true;
        rbBookTitle.Location = new System.Drawing.Point(379, 39);
        rbBookTitle.Name = "rbBookTitle";
        rbBookTitle.Size = new System.Drawing.Size(47, 19);
        rbBookTitle.TabIndex = 20;
        rbBookTitle.TabStop = true;
        rbBookTitle.Text = "Title";
        rbBookTitle.UseVisualStyleBackColor = true;
        // 
        // lstViewBooksToBorrow
        // 
        lstViewBooksToBorrow.Location = new System.Drawing.Point(29, 278);
        lstViewBooksToBorrow.MultiSelect = false;
        lstViewBooksToBorrow.Name = "lstViewBooksToBorrow";
        lstViewBooksToBorrow.Size = new System.Drawing.Size(195, 160);
        lstViewBooksToBorrow.TabIndex = 19;
        lstViewBooksToBorrow.UseCompatibleStateImageBehavior = false;
        lstViewBooksToBorrow.SelectedIndexChanged += lstViewBooksToBorrow_SelectedIndexChanged;
        // 
        // lstViewBooksCatalog
        // 
        lstViewBooksCatalog.Location = new System.Drawing.Point(29, 39);
        lstViewBooksCatalog.MultiSelect = false;
        lstViewBooksCatalog.Name = "lstViewBooksCatalog";
        lstViewBooksCatalog.Size = new System.Drawing.Size(195, 204);
        lstViewBooksCatalog.TabIndex = 18;
        lstViewBooksCatalog.UseCompatibleStateImageBehavior = false;
        lstViewBooksCatalog.SelectedIndexChanged += lstViewBooksCatalog_SelectedIndexChanged;
        // 
        // label20
        // 
        label20.AutoSize = true;
        label20.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        label20.Location = new System.Drawing.Point(29, 260);
        label20.Name = "label20";
        label20.Size = new System.Drawing.Size(99, 15);
        label20.TabIndex = 17;
        label20.Text = "Books to borrow:";
        // 
        // gbBookDetails
        // 
        gbBookDetails.Controls.Add(btnRemoveFromList);
        gbBookDetails.Controls.Add(btnAddToBorrowList);
        gbBookDetails.Controls.Add(lblNumberOfAvailableCopies);
        gbBookDetails.Controls.Add(lblGenre);
        gbBookDetails.Controls.Add(lblAuthor);
        gbBookDetails.Controls.Add(lblTitle);
        gbBookDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        gbBookDetails.Location = new System.Drawing.Point(258, 112);
        gbBookDetails.Name = "gbBookDetails";
        gbBookDetails.Size = new System.Drawing.Size(331, 131);
        gbBookDetails.TabIndex = 15;
        gbBookDetails.TabStop = false;
        gbBookDetails.Text = "Book Details";
        // 
        // btnRemoveFromList
        // 
        btnRemoveFromList.BackColor = System.Drawing.Color.Purple;
        btnRemoveFromList.ForeColor = System.Drawing.Color.White;
        btnRemoveFromList.Location = new System.Drawing.Point(239, 65);
        btnRemoveFromList.Name = "btnRemoveFromList";
        btnRemoveFromList.Size = new System.Drawing.Size(75, 23);
        btnRemoveFromList.TabIndex = 14;
        btnRemoveFromList.Text = "Remove";
        btnRemoveFromList.UseVisualStyleBackColor = false;
        btnRemoveFromList.Click += btnRemoveFromList_Click;
        // 
        // btnAddToBorrowList
        // 
        btnAddToBorrowList.BackColor = System.Drawing.Color.Purple;
        btnAddToBorrowList.ForeColor = System.Drawing.Color.White;
        btnAddToBorrowList.Location = new System.Drawing.Point(239, 94);
        btnAddToBorrowList.Name = "btnAddToBorrowList";
        btnAddToBorrowList.Size = new System.Drawing.Size(75, 23);
        btnAddToBorrowList.TabIndex = 13;
        btnAddToBorrowList.Text = "Add to list";
        btnAddToBorrowList.UseVisualStyleBackColor = false;
        btnAddToBorrowList.Click += btnAddToBorrowList_Click;
        // 
        // lblNumberOfAvailableCopies
        // 
        lblNumberOfAvailableCopies.AutoSize = true;
        lblNumberOfAvailableCopies.Location = new System.Drawing.Point(25, 102);
        lblNumberOfAvailableCopies.Name = "lblNumberOfAvailableCopies";
        lblNumberOfAvailableCopies.Size = new System.Drawing.Size(96, 15);
        lblNumberOfAvailableCopies.TabIndex = 3;
        lblNumberOfAvailableCopies.Text = "Available copies:";
        // 
        // lblGenre
        // 
        lblGenre.AutoSize = true;
        lblGenre.Location = new System.Drawing.Point(25, 74);
        lblGenre.Name = "lblGenre";
        lblGenre.Size = new System.Drawing.Size(55, 15);
        lblGenre.TabIndex = 2;
        lblGenre.Text = "Genre(s):";
        // 
        // lblAuthor
        // 
        lblAuthor.AutoSize = true;
        lblAuthor.Location = new System.Drawing.Point(25, 50);
        lblAuthor.Name = "lblAuthor";
        lblAuthor.Size = new System.Drawing.Size(61, 15);
        lblAuthor.TabIndex = 1;
        lblAuthor.Text = "Author(s):";
        // 
        // lblTitle
        // 
        lblTitle.AutoSize = true;
        lblTitle.Location = new System.Drawing.Point(25, 25);
        lblTitle.Name = "lblTitle";
        lblTitle.Size = new System.Drawing.Size(33, 15);
        lblTitle.TabIndex = 0;
        lblTitle.Text = "Title:";
        // 
        // gbLoanDetails
        // 
        gbLoanDetails.Controls.Add(btnClearBorrow);
        gbLoanDetails.Controls.Add(btnBorrow);
        gbLoanDetails.Controls.Add(lblPersonDetails);
        gbLoanDetails.Controls.Add(txtSearchByCnp);
        gbLoanDetails.Controls.Add(label19);
        gbLoanDetails.Controls.Add(btnSearchPerson);
        gbLoanDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        gbLoanDetails.Location = new System.Drawing.Point(257, 278);
        gbLoanDetails.Name = "gbLoanDetails";
        gbLoanDetails.Size = new System.Drawing.Size(332, 189);
        gbLoanDetails.TabIndex = 14;
        gbLoanDetails.TabStop = false;
        gbLoanDetails.Text = "Loan Details";
        // 
        // btnBorrow
        // 
        btnBorrow.BackColor = System.Drawing.Color.Purple;
        btnBorrow.ForeColor = System.Drawing.Color.White;
        btnBorrow.Location = new System.Drawing.Point(240, 157);
        btnBorrow.Name = "btnBorrow";
        btnBorrow.Size = new System.Drawing.Size(75, 23);
        btnBorrow.TabIndex = 17;
        btnBorrow.Text = "Borrow";
        btnBorrow.UseVisualStyleBackColor = false;
        btnBorrow.Click += btnBorrow_Click;
        // 
        // lblPersonDetails
        // 
        lblPersonDetails.AutoSize = true;
        lblPersonDetails.Location = new System.Drawing.Point(34, 96);
        lblPersonDetails.Name = "lblPersonDetails";
        lblPersonDetails.Size = new System.Drawing.Size(85, 15);
        lblPersonDetails.TabIndex = 16;
        lblPersonDetails.Text = "Person details:";
        // 
        // txtSearchByCnp
        // 
        txtSearchByCnp.Location = new System.Drawing.Point(26, 51);
        txtSearchByCnp.Name = "txtSearchByCnp";
        txtSearchByCnp.Size = new System.Drawing.Size(208, 24);
        txtSearchByCnp.TabIndex = 15;
        // 
        // label19
        // 
        label19.AutoSize = true;
        label19.Location = new System.Drawing.Point(26, 32);
        label19.Name = "label19";
        label19.Size = new System.Drawing.Size(129, 15);
        label19.TabIndex = 14;
        label19.Text = "Search person by CNP:";
        // 
        // btnSearchPerson
        // 
        btnSearchPerson.BackColor = System.Drawing.Color.Purple;
        btnSearchPerson.ForeColor = System.Drawing.Color.White;
        btnSearchPerson.Location = new System.Drawing.Point(240, 51);
        btnSearchPerson.Name = "btnSearchPerson";
        btnSearchPerson.Size = new System.Drawing.Size(75, 23);
        btnSearchPerson.TabIndex = 13;
        btnSearchPerson.Text = "Search";
        btnSearchPerson.UseVisualStyleBackColor = false;
        btnSearchPerson.Click += btnSearchPerson_Click;
        // 
        // label14
        // 
        label14.AutoSize = true;
        label14.Location = new System.Drawing.Point(255, 39);
        label14.Name = "label14";
        label14.Size = new System.Drawing.Size(96, 15);
        label14.TabIndex = 13;
        label14.Text = "Search books by:";
        // 
        // label13
        // 
        label13.AutoSize = true;
        label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        label13.Location = new System.Drawing.Point(29, 21);
        label13.Name = "label13";
        label13.Size = new System.Drawing.Size(95, 15);
        label13.TabIndex = 1;
        label13.Text = "Library Catalog:";
        // 
        // tabReturnBooks
        // 
        tabReturnBooks.BackColor = System.Drawing.Color.Thistle;
        tabReturnBooks.Controls.Add(btnClear);
        tabReturnBooks.Controls.Add(gbBookDetailsRetur);
        tabReturnBooks.Controls.Add(gbPersonDetails);
        tabReturnBooks.Controls.Add(label16);
        tabReturnBooks.Controls.Add(cblstBorrowedBooks);
        tabReturnBooks.Location = new System.Drawing.Point(4, 24);
        tabReturnBooks.Name = "tabReturnBooks";
        tabReturnBooks.Padding = new System.Windows.Forms.Padding(3);
        tabReturnBooks.Size = new System.Drawing.Size(618, 487);
        tabReturnBooks.TabIndex = 2;
        tabReturnBooks.Text = "Return Books";
        // 
        // btnClear
        // 
        btnClear.BackColor = System.Drawing.Color.Purple;
        btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnClear.ForeColor = System.Drawing.Color.White;
        btnClear.Location = new System.Drawing.Point(489, 245);
        btnClear.Name = "btnClear";
        btnClear.Size = new System.Drawing.Size(96, 23);
        btnClear.TabIndex = 18;
        btnClear.Text = "Clear";
        btnClear.UseVisualStyleBackColor = false;
        btnClear.Click += btnClear_Click;
        // 
        // gbBookDetailsRetur
        // 
        gbBookDetailsRetur.Controls.Add(lblBorrowDate);
        gbBookDetailsRetur.Controls.Add(lblGenreRetur);
        gbBookDetailsRetur.Controls.Add(lblAuthorRetur);
        gbBookDetailsRetur.Controls.Add(lblTitleRetur);
        gbBookDetailsRetur.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        gbBookDetailsRetur.Location = new System.Drawing.Point(270, 271);
        gbBookDetailsRetur.Name = "gbBookDetailsRetur";
        gbBookDetailsRetur.Size = new System.Drawing.Size(332, 179);
        gbBookDetailsRetur.TabIndex = 16;
        gbBookDetailsRetur.TabStop = false;
        gbBookDetailsRetur.Text = "Book Details";
        // 
        // lblBorrowDate
        // 
        lblBorrowDate.AutoSize = true;
        lblBorrowDate.Location = new System.Drawing.Point(26, 139);
        lblBorrowDate.Name = "lblBorrowDate";
        lblBorrowDate.Size = new System.Drawing.Size(77, 15);
        lblBorrowDate.TabIndex = 3;
        lblBorrowDate.Text = "Borrow date:";
        // 
        // lblGenreRetur
        // 
        lblGenreRetur.AutoSize = true;
        lblGenreRetur.Location = new System.Drawing.Point(26, 101);
        lblGenreRetur.Name = "lblGenreRetur";
        lblGenreRetur.Size = new System.Drawing.Size(55, 15);
        lblGenreRetur.TabIndex = 2;
        lblGenreRetur.Text = "Genre(s):";
        // 
        // lblAuthorRetur
        // 
        lblAuthorRetur.AutoSize = true;
        lblAuthorRetur.Location = new System.Drawing.Point(26, 66);
        lblAuthorRetur.Name = "lblAuthorRetur";
        lblAuthorRetur.Size = new System.Drawing.Size(61, 15);
        lblAuthorRetur.TabIndex = 1;
        lblAuthorRetur.Text = "Author(s):";
        // 
        // lblTitleRetur
        // 
        lblTitleRetur.AutoSize = true;
        lblTitleRetur.Location = new System.Drawing.Point(26, 32);
        lblTitleRetur.Name = "lblTitleRetur";
        lblTitleRetur.Size = new System.Drawing.Size(33, 15);
        lblTitleRetur.TabIndex = 0;
        lblTitleRetur.Text = "Title:";
        // 
        // gbPersonDetails
        // 
        gbPersonDetails.Controls.Add(btnReturnBooks);
        gbPersonDetails.Controls.Add(lblPersonDetailsRetur);
        gbPersonDetails.Controls.Add(txtSearchCnpRetur);
        gbPersonDetails.Controls.Add(label18);
        gbPersonDetails.Controls.Add(btnSearchPersonByCnp);
        gbPersonDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        gbPersonDetails.Location = new System.Drawing.Point(270, 50);
        gbPersonDetails.Name = "gbPersonDetails";
        gbPersonDetails.Size = new System.Drawing.Size(332, 189);
        gbPersonDetails.TabIndex = 15;
        gbPersonDetails.TabStop = false;
        gbPersonDetails.Text = "Loan Details";
        // 
        // btnReturnBooks
        // 
        btnReturnBooks.BackColor = System.Drawing.Color.Purple;
        btnReturnBooks.ForeColor = System.Drawing.Color.White;
        btnReturnBooks.Location = new System.Drawing.Point(219, 157);
        btnReturnBooks.Name = "btnReturnBooks";
        btnReturnBooks.Size = new System.Drawing.Size(96, 23);
        btnReturnBooks.TabIndex = 17;
        btnReturnBooks.Text = "Return books";
        btnReturnBooks.UseVisualStyleBackColor = false;
        btnReturnBooks.Click += btnReturnBooks_Click;
        // 
        // lblPersonDetailsRetur
        // 
        lblPersonDetailsRetur.AutoSize = true;
        lblPersonDetailsRetur.Location = new System.Drawing.Point(34, 96);
        lblPersonDetailsRetur.Name = "lblPersonDetailsRetur";
        lblPersonDetailsRetur.Size = new System.Drawing.Size(85, 15);
        lblPersonDetailsRetur.TabIndex = 16;
        lblPersonDetailsRetur.Text = "Person details:";
        // 
        // txtSearchCnpRetur
        // 
        txtSearchCnpRetur.Location = new System.Drawing.Point(26, 51);
        txtSearchCnpRetur.Name = "txtSearchCnpRetur";
        txtSearchCnpRetur.Size = new System.Drawing.Size(208, 24);
        txtSearchCnpRetur.TabIndex = 15;
        // 
        // label18
        // 
        label18.AutoSize = true;
        label18.Location = new System.Drawing.Point(26, 32);
        label18.Name = "label18";
        label18.Size = new System.Drawing.Size(129, 15);
        label18.TabIndex = 14;
        label18.Text = "Search person by CNP:";
        // 
        // btnSearchPersonByCnp
        // 
        btnSearchPersonByCnp.BackColor = System.Drawing.Color.Purple;
        btnSearchPersonByCnp.ForeColor = System.Drawing.Color.White;
        btnSearchPersonByCnp.Location = new System.Drawing.Point(240, 51);
        btnSearchPersonByCnp.Name = "btnSearchPersonByCnp";
        btnSearchPersonByCnp.Size = new System.Drawing.Size(75, 23);
        btnSearchPersonByCnp.TabIndex = 13;
        btnSearchPersonByCnp.Text = "Search";
        btnSearchPersonByCnp.UseVisualStyleBackColor = false;
        btnSearchPersonByCnp.Click += btnSearchPersonByCnp_Click;
        // 
        // label16
        // 
        label16.AutoSize = true;
        label16.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        label16.Location = new System.Drawing.Point(31, 23);
        label16.Name = "label16";
        label16.Size = new System.Drawing.Size(98, 15);
        label16.TabIndex = 2;
        label16.Text = "Borrowed books:";
        // 
        // cblstBorrowedBooks
        // 
        cblstBorrowedBooks.FormattingEnabled = true;
        cblstBorrowedBooks.Location = new System.Drawing.Point(31, 50);
        cblstBorrowedBooks.Name = "cblstBorrowedBooks";
        cblstBorrowedBooks.Size = new System.Drawing.Size(224, 400);
        cblstBorrowedBooks.TabIndex = 0;
        cblstBorrowedBooks.SelectedIndexChanged += cblstBorrowedBooks_SelectedIndexChanged;
        // 
        // tabCreateLoanForm
        // 
        tabCreateLoanForm.BackColor = System.Drawing.Color.Thistle;
        tabCreateLoanForm.Controls.Add(btnAddPerson);
        tabCreateLoanForm.Controls.Add(label12);
        tabCreateLoanForm.Controls.Add(txtCounty);
        tabCreateLoanForm.Controls.Add(txtCity);
        tabCreateLoanForm.Controls.Add(txtCnp);
        tabCreateLoanForm.Controls.Add(txtPhone);
        tabCreateLoanForm.Controls.Add(txtAddress);
        tabCreateLoanForm.Controls.Add(txtName);
        tabCreateLoanForm.Controls.Add(label11);
        tabCreateLoanForm.Controls.Add(label10);
        tabCreateLoanForm.Controls.Add(label9);
        tabCreateLoanForm.Controls.Add(label8);
        tabCreateLoanForm.Controls.Add(label7);
        tabCreateLoanForm.Controls.Add(label5);
        tabCreateLoanForm.Location = new System.Drawing.Point(4, 24);
        tabCreateLoanForm.Name = "tabCreateLoanForm";
        tabCreateLoanForm.Padding = new System.Windows.Forms.Padding(3);
        tabCreateLoanForm.Size = new System.Drawing.Size(618, 487);
        tabCreateLoanForm.TabIndex = 3;
        tabCreateLoanForm.Text = "Create Loan Form";
        // 
        // btnAddPerson
        // 
        btnAddPerson.BackColor = System.Drawing.Color.Purple;
        btnAddPerson.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnAddPerson.ForeColor = System.Drawing.Color.White;
        btnAddPerson.Location = new System.Drawing.Point(374, 407);
        btnAddPerson.Name = "btnAddPerson";
        btnAddPerson.Size = new System.Drawing.Size(149, 32);
        btnAddPerson.TabIndex = 13;
        btnAddPerson.Text = "Get Them Reading!";
        btnAddPerson.UseVisualStyleBackColor = false;
        btnAddPerson.Click += btnAddPerson_Click;
        // 
        // label12
        // 
        label12.AutoSize = true;
        label12.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)(System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic)), System.Drawing.GraphicsUnit.Point, ((byte)0));
        label12.Location = new System.Drawing.Point(211, 18);
        label12.Name = "label12";
        label12.Size = new System.Drawing.Size(164, 25);
        label12.TabIndex = 12;
        label12.Text = "Add a Book Lover";
        // 
        // txtCounty
        // 
        txtCounty.Location = new System.Drawing.Point(324, 357);
        txtCounty.Name = "txtCounty";
        txtCounty.Size = new System.Drawing.Size(199, 23);
        txtCounty.TabIndex = 11;
        // 
        // txtCity
        // 
        txtCity.Location = new System.Drawing.Point(98, 357);
        txtCity.Name = "txtCity";
        txtCity.Size = new System.Drawing.Size(199, 23);
        txtCity.TabIndex = 10;
        // 
        // txtCnp
        // 
        txtCnp.Location = new System.Drawing.Point(98, 287);
        txtCnp.Name = "txtCnp";
        txtCnp.Size = new System.Drawing.Size(425, 23);
        txtCnp.TabIndex = 9;
        txtCnp.KeyPress += txtCnp_KeyPress;
        // 
        // txtPhone
        // 
        txtPhone.Location = new System.Drawing.Point(98, 221);
        txtPhone.Name = "txtPhone";
        txtPhone.Size = new System.Drawing.Size(425, 23);
        txtPhone.TabIndex = 8;
        txtPhone.KeyPress += txtPhone_KeyPress;
        // 
        // txtAddress
        // 
        txtAddress.Location = new System.Drawing.Point(98, 154);
        txtAddress.Name = "txtAddress";
        txtAddress.Size = new System.Drawing.Size(425, 23);
        txtAddress.TabIndex = 7;
        // 
        // txtName
        // 
        txtName.Location = new System.Drawing.Point(98, 88);
        txtName.Name = "txtName";
        txtName.Size = new System.Drawing.Size(425, 23);
        txtName.TabIndex = 6;
        // 
        // label11
        // 
        label11.AutoSize = true;
        label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label11.Location = new System.Drawing.Point(324, 337);
        label11.Name = "label11";
        label11.Size = new System.Drawing.Size(51, 17);
        label11.TabIndex = 5;
        label11.Text = "County:";
        // 
        // label10
        // 
        label10.AutoSize = true;
        label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label10.Location = new System.Drawing.Point(98, 337);
        label10.Name = "label10";
        label10.Size = new System.Drawing.Size(32, 17);
        label10.TabIndex = 4;
        label10.Text = "City:";
        // 
        // label9
        // 
        label9.AutoSize = true;
        label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label9.Location = new System.Drawing.Point(98, 267);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(36, 17);
        label9.TabIndex = 3;
        label9.Text = "CNP:";
        // 
        // label8
        // 
        label8.AutoSize = true;
        label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label8.Location = new System.Drawing.Point(98, 201);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(96, 17);
        label8.TabIndex = 2;
        label8.Text = "Phone number:";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label7.Location = new System.Drawing.Point(98, 134);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(59, 17);
        label7.TabIndex = 1;
        label7.Text = "Address:";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.Location = new System.Drawing.Point(98, 68);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(46, 17);
        label5.TabIndex = 0;
        label5.Text = "Name:";
        // 
        // btnClearBorrow
        // 
        btnClearBorrow.BackColor = System.Drawing.Color.Purple;
        btnClearBorrow.ForeColor = System.Drawing.Color.White;
        btnClearBorrow.Location = new System.Drawing.Point(240, 80);
        btnClearBorrow.Name = "btnClearBorrow";
        btnClearBorrow.Size = new System.Drawing.Size(75, 23);
        btnClearBorrow.TabIndex = 18;
        btnClearBorrow.Text = "Clear";
        btnClearBorrow.UseVisualStyleBackColor = false;
        btnClearBorrow.Click += btnClearBorrow_Click;
        // 
        // FrmMain
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.Thistle;
        ClientSize = new System.Drawing.Size(626, 516);
        Controls.Add(tabControlMain);
        Text = "Library Management System";
        FormClosing += FrmMain_FormClosing;
        Load += FrmMain_Load;
        tabControlMain.ResumeLayout(false);
        tabBookManagement.ResumeLayout(false);
        tabBookManagement.PerformLayout();
        gbBookInfo.ResumeLayout(false);
        gbBookInfo.PerformLayout();
        tabLendBooks.ResumeLayout(false);
        tabLendBooks.PerformLayout();
        gbBookDetails.ResumeLayout(false);
        gbBookDetails.PerformLayout();
        gbLoanDetails.ResumeLayout(false);
        gbLoanDetails.PerformLayout();
        tabReturnBooks.ResumeLayout(false);
        tabReturnBooks.PerformLayout();
        gbBookDetailsRetur.ResumeLayout(false);
        gbBookDetailsRetur.PerformLayout();
        gbPersonDetails.ResumeLayout(false);
        gbPersonDetails.PerformLayout();
        tabCreateLoanForm.ResumeLayout(false);
        tabCreateLoanForm.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btnClearBorrow;

    private System.Windows.Forms.Button btnClear;

    private System.Windows.Forms.Button btnMisteryBox;

    private System.Windows.Forms.Label lblBorrowDate;

    private System.Windows.Forms.GroupBox gbBookDetailsRetur;
    private System.Windows.Forms.Label lblGenreRetur;
    private System.Windows.Forms.Label lblAuthorRetur;
    private System.Windows.Forms.Label lblTitleRetur;

    private System.Windows.Forms.CheckedListBox cblstBorrowedBooks;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.GroupBox gbPersonDetails;
    private System.Windows.Forms.Button btnReturnBooks;
    private System.Windows.Forms.Label lblPersonDetailsRetur;
    private System.Windows.Forms.TextBox txtSearchCnpRetur;
    private System.Windows.Forms.Label label18;
    private System.Windows.Forms.Button btnSearchPersonByCnp;

    private System.Windows.Forms.Label label15;

    private System.Windows.Forms.Button btnBorrow;

    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Button btnRemoveFromList;

    private System.Windows.Forms.TextBox txtSearchBookString;

    private System.Windows.Forms.Button btnSearchPerson;
    private System.Windows.Forms.Button btnAddToBorrowList;
    private System.Windows.Forms.ListView lstViewBooksCatalog;
    private System.Windows.Forms.ListView lstViewBooksToBorrow;

    private System.Windows.Forms.Label lblGenre;
    private System.Windows.Forms.Label lblNumberOfAvailableCopies;
    private System.Windows.Forms.Label label19;
    private System.Windows.Forms.Label label20;

    private System.Windows.Forms.Label lblAuthor;

    private System.Windows.Forms.GroupBox gbBookDetails;
    private System.Windows.Forms.Label lblPersonDetails;

    private System.Windows.Forms.GroupBox gbLoanDetails;

    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Button btnSearchBook;
    private System.Windows.Forms.RadioButton rbBookAuthor;
    private System.Windows.Forms.RadioButton rbBookGenre;
    private System.Windows.Forms.RadioButton rbBookTitle;
    private System.Windows.Forms.TextBox txtSearchByCnp;

    private System.Windows.Forms.Button btnAddPerson;

    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.TextBox txtAddress;
    private System.Windows.Forms.TextBox txtPhone;
    private System.Windows.Forms.TextBox txtCnp;
    private System.Windows.Forms.TextBox txtCity;
    private System.Windows.Forms.TextBox txtCounty;
    private System.Windows.Forms.Label label12;

    private System.Windows.Forms.Label label11;

    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.Button btnMinus;
    private System.Windows.Forms.Button btnPlus;
    private System.Windows.Forms.Button btnAddBook;
    private System.Windows.Forms.TabPage tabCreateLoanForm;

    private System.Windows.Forms.TextBox txtGenre;
    private System.Windows.Forms.TextBox txtQuantity;
    private System.Windows.Forms.Button btnUpdateBookInfo;
    private System.Windows.Forms.Button btnDeleteBook;

    private System.Windows.Forms.TextBox txtTitle;
    private System.Windows.Forms.TextBox txtAuthor;

    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Label lblAvailableCopies;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.GroupBox gbBookInfo;

    private System.Windows.Forms.RadioButton rbTitle;
    private System.Windows.Forms.RadioButton rbAuthor;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.RadioButton rbGenre;

    private System.Windows.Forms.ListView lstViewBooks;

    private System.Windows.Forms.TabPage tabReturnBooks;
    private System.Windows.Forms.Label lblBooks;

    private System.Windows.Forms.TabControl tabControlMain;
    private System.Windows.Forms.TabPage tabBookManagement;
    private System.Windows.Forms.TabPage tabLendBooks;

    #endregion
}