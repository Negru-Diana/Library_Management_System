using Library_Management_System.domain;
using Library_Management_System.service;
using Library_Management_System.utils.events;

namespace Library_Management_System.ui;

public partial class FrmMain : Form, utils.observer.IObserver<IEvent>
{
    private ObservableService _observableService;
    public FrmMain(ObservableService observableService)
    {
        this._observableService = observableService;
        
        InitializeComponent();
        
        this.StartPosition = FormStartPosition.CenterScreen;
        lstViewBooks.MultiSelect = false;
        lstViewBooksCatalog.MultiSelect = false;
        lstViewBooksToBorrow.MultiSelect = false;
        
        btnRemoveFromList.Location = btnAddToBorrowList.Location;
        
        
        lstViewBooksToBorrow.Items.Clear();
        
        lstViewBooksToBorrow.View = View.Details;
        lstViewBooksToBorrow.HeaderStyle = ColumnHeaderStyle.None;
        lstViewBooksToBorrow.Columns.Clear();
        lstViewBooksToBorrow.Columns.Add("", lstViewBooksCatalog.Width - 30);
    }


    private void FrmMain_Load(object sender, EventArgs e)
    {
        _observableService.AddObserver(this);
        
        gbBookInfo.Visible = false;
        gbBookDetails.Visible = false;
        gbBookDetailsRetur.Visible = false;
        
        //Default text for label
        lblBooks.Text = "Library Catalog:";
        
        //Default checked radio button for search
        rbTitle.Checked = true;
        rbAuthor.Checked = false;
        rbGenre.Checked = false;
        
        rbBookTitle.Checked = true;
        rbBookAuthor.Checked = false;
        rbGenre.Checked = false;

        LoadLibraryCatalog(_observableService.GetAllBooks());
        LoadBookCatalogBorrowing(_observableService.GetAllBooks());
    }


    public void Update(IEvent eventData)
    {
        if (eventData is EntityChangeEvent<Book> bookEvent)
        {
            LoadLibraryCatalog(_observableService.GetAllBooks());
            LoadBookCatalogBorrowing(_observableService.GetAllBooks());

            if (bookEvent.Type == ChangeEventType.UpdateBook)
            {
                Book b1 = txtTitle.Tag as Book;
                Book b2 = lblTitle.Tag as Book;
                
                if (b1 != null && b1.Id == bookEvent.Data.Id)
                {
                    LoadBookData(bookEvent.Data);
                }

                if (b2 != null && b2.Id == bookEvent.Data.Id)
                {
                    LoadBookDataBorrow(bookEvent.Data);
                }
            }

            if (bookEvent.Type == ChangeEventType.MoveBook)
            {
                AddBookToBorrowList(bookEvent.Data);
            }
        }

        if (eventData is EntityChangeEvent<PersonForm> personFormEvent)
        {
            Console.WriteLine("Update lista persoane");
        }

        if (eventData is EntityChangeEvent<Borrow> borrowEvent)
        {
            LoadLibraryCatalog(_observableService.GetAllBooks());
            LoadBookCatalogBorrowing(_observableService.GetAllBooks());

            if (borrowEvent.Type == ChangeEventType.ReturnBooks)
            {
                PersonForm person = lblPersonDetailsRetur.Tag as PersonForm;
            
                LoadBorrowedBooks(_observableService.GetBorrowedCopies(person));
                gbBookDetailsRetur.Visible = false;
                gbBookDetails.Visible = false;
                gbBookInfo.Visible = false;
            }
        }
    }

    private void AddBookToBorrowList(Book book)
    {
        
        
        if (book == null)
        {
            MessageBox.Show("It occurs a problem adding the book to borrow list.");
            return;
        }

        int copies = 0;
        foreach (ListViewItem it in lstViewBooksCatalog.Items)
        {
            if (it.Tag is Book b && b.Id == book.Id)
            {
                copies = b.Quantity - _observableService.GetNumberOfBorrowedCopies(b.Id);
                break;
            }
        }

        int count = 0;
        foreach (ListViewItem it in lstViewBooksToBorrow.Items)
        {
            if (it.Tag is Book b && b.Id == book.Id)
            {
                count++;
            }
        }
        
        if (copies == 0 || count>=copies)
        {
            MessageBox.Show("The book is not available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        
        var item = new ListViewItem(book.Title);
        item.Tag = book;
        lstViewBooksToBorrow.Items.Add(item);
    }


    private void LoadBookData(Book book)
    {
        txtTitle.Text = book.Title;
        txtAuthor.Text = book.Author;
        txtGenre.Text = book.Genre;
        txtQuantity.Text = book.Quantity.ToString();
        int copies = book.Quantity - _observableService.GetNumberOfBorrowedCopies(book.Id);
        lblAvailableCopies.Text = copies.ToString();
        txtTitle.Tag = book;
    }
    
    
    private void LoadBookDataBorrow(Book book)
    {
        lblTitle.Text = "Title: " + book.Title;
        lblAuthor.Text = "Author(s): " + book.Author;
        lblGenre.Text = "Genre(s): " + book.Genre;
        int copies = book.Quantity - _observableService.GetNumberOfBorrowedCopies(book.Id);
        lblNumberOfAvailableCopies.Text = "Available copies: " + copies;
        lblNumberOfAvailableCopies.Tag = copies;
        lblTitle.Tag = book;
    }
    
    private void LoadBookDataRetur(Borrow borrow)
    {
        lblTitleRetur.Text = "Title: " + borrow.Book.Title;
        lblAuthorRetur.Text = "Author(s): " + borrow.Book.Author;
        lblGenreRetur.Text = "Genre(s): " + borrow.Book.Genre;
        lblBorrowDate.Text = "Borrow date: " + borrow.BorrowDate.ToString("MM/dd/yyyy");
    }

    //Method to load all books into the lstViewBooks (tabBookManagement)
    private void LoadLibraryCatalog(IEnumerable<Book> books)
    {
        lstViewBooks.Items.Clear();
        
        lstViewBooks.View = View.Details;
        lstViewBooks.HeaderStyle = ColumnHeaderStyle.None;
        lstViewBooks.Columns.Clear();
        lstViewBooks.Columns.Add("", lstViewBooks.Width - 50);
        
        
        if (books.Count() == 0)
        {
            MessageBox.Show("There are no books in the library catalog.");
            return;
        }
        
        foreach (var book in books)
        {
            var item = new ListViewItem(book.Title);
            item.Tag = book;
            lstViewBooks.Items.Add(item);
        }
    }


    private void LoadBookCatalogBorrowing(IEnumerable<Book> books)
    {
        lstViewBooksCatalog.Items.Clear();
        
        lstViewBooksCatalog.View = View.Details;
        lstViewBooksCatalog.HeaderStyle = ColumnHeaderStyle.None;
        lstViewBooksCatalog.Columns.Clear();
        lstViewBooksCatalog.Columns.Add("", lstViewBooksCatalog.Width - 30);
        
        if (books.Count() == 0)
        {
            MessageBox.Show("There are no books in the library catalog.");
            return;
        }
        
        foreach (var book in books)
        {
            var item = new ListViewItem(book.Title);
            item.Tag = book;
            lstViewBooksCatalog.Items.Add(item);
        }
    }
    
    private Dictionary<string, Borrow> borrowDictionary = new Dictionary<string, Borrow>();
    private void LoadBorrowedBooks(IEnumerable<Borrow> borrows)
    {
        cblstBorrowedBooks.Items.Clear();
        borrowDictionary.Clear();

        try
        {
            foreach (var borrow in borrows)
            {
                cblstBorrowedBooks.Items.Add(borrow.Book.Title, false);
                borrowDictionary[borrow.Book.Title] = borrow;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }



    private void btnAddBook_Click(object sender, EventArgs e)
    {
        FrmAddBook frmAddBook = new FrmAddBook(_observableService);
        frmAddBook.Size = new Size(355, 380);
        frmAddBook.Show();
    }

    private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
        _observableService.RemoveObserver(this);
    }

    private void btnDeleteBook_Click(object sender, EventArgs e)
    {
        if (lstViewBooks.SelectedItems.Count == 0)
        {
            MessageBox.Show("You must select a book to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        var selectedBook = lstViewBooks.SelectedItems[0];
        if (selectedBook != null)
        {
            try
            {
                _observableService.DeleteBook(selectedBook.Tag as Book);
                MessageBox.Show("Book deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gbBookInfo.Visible = false;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
        {
            MessageBox.Show("It occurs an error trying to delete the book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void lstViewBooks_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lstViewBooks.SelectedItems.Count == 0)
        {
            gbBookInfo.Visible = false;
            return;
        }

        var selectedBook = lstViewBooks.SelectedItems[0];
        if (selectedBook != null)
        { 
            gbBookInfo.Visible = true;
            Book selectedBookBook = (Book)selectedBook.Tag;
            LoadBookData(selectedBookBook);
        }
        else
        {
            gbBookInfo.Visible = false;
        }

    }

    private void btnMinus_Click(object sender, EventArgs e)
    {
        string quantityString = txtQuantity.Text;
        int quantity;
        try
        {
            quantity = int.Parse(quantityString);
            int copies = int.Parse(lblAvailableCopies.Text);
            copies -= 1;
            lblAvailableCopies.Text = copies.ToString();
        }
        catch (Exception)
        {
            MessageBox.Show("It ocurrs a problem with decreasing quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        quantity -= 1;
        txtQuantity.Text = quantity.ToString();
    }

    private void btnPlus_Click(object sender, EventArgs e)
    {
        string quantityString = txtQuantity.Text;
        int quantity;
        try
        {
            quantity = int.Parse(quantityString);
            int copies = int.Parse(lblAvailableCopies.Text);
            copies += 1;
            lblAvailableCopies.Text = copies.ToString();
        }
        catch (Exception)
        {
            MessageBox.Show("It ocurrs a problem with increasing quantity!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        quantity += 1;
        txtQuantity.Text = quantity.ToString();
    }

    private void btnUpdateBookInfo_Click(object sender, EventArgs e)
    {
        string title = txtTitle.Text;
        string author = txtAuthor.Text;
        string genre = txtGenre.Text;
        string quantityString = txtQuantity.Text;
        int quantity;

        if (title == "" || author == "" || genre == "" || quantityString == "")
        {
            MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        try
        {
            quantity = int.Parse(quantityString);
        }
        catch (Exception)
        {
            MessageBox.Show("The quantity must be a natural number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (quantity <= 0)
        {
            MessageBox.Show("The quantity must be a positive number!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        try
        {
            Book selectedBook = txtTitle.Tag as Book;
            selectedBook.Title = title;
            selectedBook.Author = author;
            selectedBook.Genre = genre;
            selectedBook.Quantity = quantity;
            _observableService.UpdateBook(selectedBook);
            MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnSearch_Click(object senderi, EventArgs e)
    {
        gbBookInfo.Visible = false;
        string searchString = txtSearch.Text;
        if (searchString == "")
        {
            LoadLibraryCatalog(_observableService.GetAllBooks());
            return;
        }

        string column = "title";
        if (rbAuthor.Checked == true)
        {
            column = "author";
        }
        if (rbGenre.Checked == true)
        {
            column = "genre";
        }

        try
        {
            LoadLibraryCatalog(_observableService.GetBooksBySearchString(column, searchString));
        }
        catch (Exception)
        {
            MessageBox.Show("It occurs a problem finding the books.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
    }

    private void btnAddPerson_Click(object sender, EventArgs e)
    {
        string name = txtName.Text;
        string address = txtAddress.Text;
        string phone = txtPhone.Text;
        string cnp = txtCnp.Text;
        string city = txtCity.Text;
        string county = txtCounty.Text;

        if (name == "" || address == "" || phone == "" || cnp == "" || city == "" || county == "")
        {
            MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (phone.Length != 10)
        {
            MessageBox.Show("The phone number is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        if (cnp.Length != 13)
        {
            MessageBox.Show("The cnp is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        try
        {
            _observableService.AddPersonForm(name, address, phone, cnp, city, county);
            MessageBox.Show("Person added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearPersonFormData();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ClearPersonFormData()
    {
        txtName.Text = "";
        txtAddress.Text = "";
        txtPhone.Text = "";
        txtCnp.Text = "";
        txtCity.Text = "";
        txtCounty.Text = "";
    }

    private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
        {
            e.Handled = true;
            txtPhone.Focus();
        }
    }

    private void txtCnp_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
        {
            e.Handled = true;
            txtCnp.Focus();
        }
    }

    private void lstViewBooksCatalog_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lstViewBooksCatalog.SelectedItems.Count == 0)
        {
            gbBookDetails.Visible = false;
            return;
        }

        var selectedBook = lstViewBooksCatalog.SelectedItems[0];
        if (selectedBook != null)
        { 
            gbBookDetails.Visible = true;
            btnAddToBorrowList.Visible = true;
            btnRemoveFromList.Visible = false;
            Book selectedBookBook = (Book)selectedBook.Tag;
            LoadBookDataBorrow(selectedBookBook);
        }
        else
        {
            gbBookDetails.Visible = false;
        }
    }

    private void lstViewBooksToBorrow_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (lstViewBooksToBorrow.SelectedItems.Count == 0)
        {
            gbBookDetails.Visible = false;
            return;
        }

        var selectedBook = lstViewBooksToBorrow.SelectedItems[0];
        if (selectedBook != null)
        { 
            gbBookDetails.Visible = true;
            btnAddToBorrowList.Visible = false;
            btnRemoveFromList.Visible = true;
            Book selectedBookBook = (Book)selectedBook.Tag;
            LoadBookDataBorrow(selectedBookBook);
        }
        else
        {
            gbBookDetails.Visible = false;
        }
    }

    private void btnSearchBook_Click(object sender, EventArgs e)
    {
        gbBookDetails.Visible = false;
        string searchString = txtSearchBookString.Text;
        if (searchString == "")
        {
            LoadBookCatalogBorrowing(_observableService.GetAllBooks());
            return;
        }

        string column = "title";
        if (rbBookAuthor.Checked == true)
        {
            column = "author";
        }
        if (rbBookGenre.Checked == true)
        {
            column = "genre";
        }

        try
        {
            LoadBookCatalogBorrowing(_observableService.GetBooksBySearchString(column, searchString));
        }
        catch (Exception)
        {
            MessageBox.Show("It occurs a problem finding the books.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnAddToBorrowList_Click(object sender, EventArgs e)
    {
        Book book = lblTitle.Tag as Book;
        if (book == null)
        {
            MessageBox.Show("It occurs a problem adding the book to borrow list.");
            return;
        }
        
        int copies;
        try
        {
            copies = int.Parse(lblNumberOfAvailableCopies.Tag.ToString());
        }
        catch (Exception)
        {
            MessageBox.Show("It occurs a problem adding the book to borrow list.");
            return;
        }

        int count = 0;
        foreach (ListViewItem it in lstViewBooksToBorrow.Items)
        {
            if (it.Tag is Book b && b.Id == book.Id)
            {
                count++;
            }
        }
        
        if (copies == 0 || count>=copies)
        {
            MessageBox.Show("The book is not available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        
        var item = new ListViewItem(book.Title);
        item.Tag = book;
        lstViewBooksToBorrow.Items.Add(item);
    }

    private void btnRemoveFromList_Click(object sender, EventArgs e)
    {
        Book book = lblTitle.Tag as Book;
        if (book == null)
        {
            MessageBox.Show("It occurs a problem removing the book from borrow list.");
            return;
        }
        
        
        foreach (ListViewItem item in lstViewBooksToBorrow.Items)
        {
            if (item.Tag is Book b && b.Title == book.Title)
            {
                lstViewBooksToBorrow.Items.Remove(item);
                return;
            }
        }
    }

    private void btnSearchPerson_Click(object sender, EventArgs e)
    {
        string cnp = txtSearchByCnp.Text;
        if (cnp == "" || cnp.Length != 13)
        {
            MessageBox.Show("Cnp is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        try
        {
            PersonForm person = _observableService.GetPersonFormByCnp(cnp);
            lblPersonDetails.Text = "Person Details: \n" + person.Name + "\n" + person.Address + "\n" + person.Phone + "\n" + person.City;
            lblPersonDetails.Tag = person;
            
            IEnumerable<Borrow> borrowed = _observableService.GetBorrowedCopies(person);
            if (borrowed.Count() != 0)
            {
                MessageBox.Show("There are " + borrowed.Count() + " borrowed books by this person that has not been returned.");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnBorrow_Click(object sender, EventArgs e)
    {
        List<Book> booksToBorrow = new List<Book>();

        foreach (ListViewItem item in lstViewBooksToBorrow.Items)
        {
            if (item.Tag is Book book)
            {
                booksToBorrow.Add(book);
            }
        }

        PersonForm person = lblPersonDetails.Tag as PersonForm;
        if (person == null)
        {
            MessageBox.Show("Who is borrowing?");
            return;
        }
        
        if (booksToBorrow.Count == 0)
        {
            MessageBox.Show("There are no borrowing books in the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        try
        {
            _observableService.BorrowBooks(booksToBorrow, person);
            MessageBox.Show("Borrowed Books Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lstViewBooksToBorrow.Items.Clear();
            txtCnp.Text = "";
            lblPersonDetails.Text = "";
            gbBookDetails.Visible = false;
            txtSearchByCnp.Text = "";
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnSearchPersonByCnp_Click(object sender, EventArgs e)
    {
        string cnp = txtSearchCnpRetur.Text;
        if (cnp == "" || cnp.Length != 13)
        {
            MessageBox.Show("Cnp is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        try
        {
            PersonForm person = _observableService.GetPersonFormByCnp(cnp);
            lblPersonDetailsRetur.Text = "Person Details: \n" + person.Name + "\n" + person.Address + "\n" + person.Phone + "\n" + person.City;
            lblPersonDetailsRetur.Tag = person;
            
            LoadBorrowedBooks(_observableService.GetBorrowedCopies(person));
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void cblstBorrowedBooks_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cblstBorrowedBooks.SelectedIndex == -1) 
        {
            gbBookDetailsRetur.Visible = false;
            return;
        }
        
        string selectedBookTitle = cblstBorrowedBooks.SelectedItem.ToString();

        if (borrowDictionary.ContainsKey(selectedBookTitle))
        {
            var selectedBorrow = borrowDictionary[selectedBookTitle];

            gbBookDetailsRetur.Visible = true;
            LoadBookDataRetur(selectedBorrow);
        }
        else
        {
            gbBookDetailsRetur.Visible = false;
        }
    }

    private void btnReturnBooks_Click(object sender, EventArgs e)
    {
        var checkedBooks = new List<Borrow>();
        
        for (int i = 0; i < cblstBorrowedBooks.Items.Count; i++)
        {
            if (cblstBorrowedBooks.GetItemChecked(i))
            {
                string bookTitle = cblstBorrowedBooks.Items[i].ToString();
                
                if (borrowDictionary.ContainsKey(bookTitle))
                {
                    checkedBooks.Add(borrowDictionary[bookTitle]);
                }
            }
        }

        if (checkedBooks.Count == 0)
        {
            MessageBox.Show("There are no books selected to be returned.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        try
        {
            _observableService.ReturnBorrowedBooks(checkedBooks);
            MessageBox.Show("Returned Books Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        cblstBorrowedBooks.Items.Clear();
        gbBookDetailsRetur.Visible = false;
        txtSearchCnpRetur.Text = "";
        lblPersonDetailsRetur.Text = "Person details: ";
    }

    private void btnMisteryBox_Click(object sender, EventArgs e)
    {
        PersonForm person = lblPersonDetails.Tag as PersonForm;
        if (person == null)
        {
            MessageBox.Show("Who is borrowing?", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        
        FrmMysteryBox frmMisteryBox = new FrmMysteryBox(_observableService, person);
        frmMisteryBox.Show();
    }

    private void btnClearBorrow_Click(object sender, EventArgs e)
    {
        lstViewBooksToBorrow.Items.Clear();
        txtSearchByCnp.Text = "";
        lblPersonDetails.Text = "Person details: ";
        lblPersonDetails.Tag = null;
        gbBookDetails.Visible = false;
    }
}