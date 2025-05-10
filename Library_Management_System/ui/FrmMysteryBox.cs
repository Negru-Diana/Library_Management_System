using Library_Management_System.domain;
using Library_Management_System.service;

namespace Library_Management_System.ui;

public partial class FrmMysteryBox : Form
{
    private ObservableService _observableService;
    private PersonForm _person;
    
    public FrmMysteryBox(ObservableService observableService, PersonForm person)
    {
        InitializeComponent();
        
        this._observableService = observableService;
        this._person = person;

        gbBookDetails.Size = new Size(372, 194);
        gbBookDetails.Location = new Point(230, 119);

        pbChest.SizeMode = PictureBoxSizeMode.StretchImage;
        pbChest.Visible = true;
        pbChest.Image = Image.FromFile("images/closedChest.png");
    }

    
    
    /// <summary>
    /// Ensures that only numeric input is allowed in the number of books textbox.
    /// </summary>
    /// <param name="sender">The control raising the event.</param>
    /// <param name="e">Key press event arguments.</param>
    private void txtNumberOfBooks_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
        {
            e.Handled = true;
            txtNumberOfBooks.Focus();
        }
    }
    
    
    private Dictionary<string, Book> generatedDictionary = new Dictionary<string, Book>();
    
    
    
    /// <summary>
    /// Loads generated books into the checklist and updates the internal dictionary.
    /// </summary>
    /// <param name="generated">The books generated for the Mystery Box.</param>
    private void LoadGeneratedBooks(IEnumerable<Book> generated)
    {
        cblstGeneratedBooks.Items.Clear();
        generatedDictionary.Clear();

        try
        {
            foreach (var book in generated)
            {
                cblstGeneratedBooks.Items.Add(book.Title, false);
                generatedDictionary[book.Title] = book;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    
    
    /// <summary>
    /// Generates a list of books using the Mystery Box feature and loads them for selection.
    /// </summary>
    /// <param name="sender">The control raising the event.</param>
    /// <param name="e">Event arguments.</param>
    private void btnGenerate_Click(object sender, EventArgs e)
    {
        string numberString = txtNumberOfBooks.Text;
        if (numberString == "")
        {
            MessageBox.Show("Please enter the number of books you want to generate.");
            return;
        }

        int number;
        try
        {
            number = Convert.ToInt32(numberString);
        }
        catch (Exception)
        {
            MessageBox.Show("Please enter a valid number.");
            return;
        }

        if (number <= 0)
        {
            MessageBox.Show("Please enter a valid number! (number > 0)");
            return;
        }

        try
        {
            var generatedBooks = _observableService.GenerateBooks(number, _person);
            if (generatedBooks.Count() == 0)
            {
                MessageBox.Show("Looks like all the books have already been borrowed!");
                return;
            }

            if (generatedBooks.Count() < number)
            {
                MessageBox.Show("Here are all the books that haven't been borrowed yet — there aren't enough to match your requested number.");
            }
            pbChest.Image = Image.FromFile("images/openChest.png");
            pbChest.Visible = true;
            gbBookDetails.Visible = false;
            LoadGeneratedBooks(generatedBooks);
        }
        catch (Exception)
        {
            MessageBox.Show("It occurs a problem while generating the Mystery Box.");
        }
        
    }
    
    private void FrmMysteryBox_Load(object sender, EventArgs e)
    {
        gbBookDetails.Visible = false;
    }

    
    
    /// <summary>
    /// Loads book details into the UI controls, including available copies.
    /// </summary>
    /// <param name="book">The book to display details for.</param>
    private void LoadBookData(Book book)
    {
        lblTitle.Text = "Title: " + book.Title;
        lblAuthor.Text = "Author(s): " + book.Author;
        lblGenre.Text = "Genre(s): " + book.Genre;
        int copies = book.Quantity - _observableService.GetNumberOfBorrowedCopies(book.Id);
        lblAvailableCopies.Text = "Available copies: " + copies;
    }
    
    
    
    /// <summary>
    /// Displays the selected book's details from the generated book list.
    /// </summary>
    /// <param name="sender">The control raising the event.</param>
    /// <param name="e">Event arguments.</param>
    private void cblstGeneratedBooks_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cblstGeneratedBooks.SelectedIndex == -1) 
        {
            gbBookDetails.Visible = false;
            return;
        }
        
        string selectedBookTitle = cblstGeneratedBooks.SelectedItem.ToString();

        if (generatedDictionary.ContainsKey(selectedBookTitle))
        {
            var selectedBook = generatedDictionary[selectedBookTitle];

            gbBookDetails.Visible = true;
            pbChest.Visible = false;
            LoadBookData(selectedBook);
        }
        else
        {
            gbBookDetails.Visible = false;
        }
    }

    
    /// <summary>
    /// Adds selected books from the generated list to the user's borrow list via the service.
    /// Removes added books from the list and resets the display.
    /// </summary>
    /// <param name="sender">The control raising the event.</param>
    /// <param name="e">Event arguments.</param>
    private void btnAddSelectedToList_Click(object sender, EventArgs e)
    {
        var checkedBooks = new List<Book>();
        List<int> itemsToRemove = new List<int>();
        
        for (int i = 0; i < cblstGeneratedBooks.Items.Count; i++)
        {
            if (cblstGeneratedBooks.GetItemChecked(i))
            {
                string bookTitle = cblstGeneratedBooks.Items[i].ToString();
                
                if (generatedDictionary.ContainsKey(bookTitle))
                {
                    checkedBooks.Add(generatedDictionary[bookTitle]);
                    itemsToRemove.Add(i);
                }
            }
        }

        if (checkedBooks.Count == 0)
        {
            MessageBox.Show("There are no selected to move.");
            return;
        }

        try
        {
            _observableService.MoveBooks(checkedBooks);
            MessageBox.Show("Books Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            gbBookDetails.Visible = false;
            pbChest.Visible = true;
            pbChest.Image = Image.FromFile("images/closedChest.png");
            foreach (var index in itemsToRemove.OrderByDescending(i => i))
            {
                cblstGeneratedBooks.Items.RemoveAt(index);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
    }
}