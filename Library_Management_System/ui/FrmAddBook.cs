using Library_Management_System.service;

namespace Library_Management_System.ui;

public partial class FrmAddBook : Form
{
    private ObservableService _observableService;
    public FrmAddBook(ObservableService observableService)
    {
        this._observableService = observableService;
        
        InitializeComponent();
        this.StartPosition = FormStartPosition.CenterScreen;
        this.Size = new Size(355, 380);
    }


    private void btnAddBook_Click(object sender, EventArgs e)
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
            _observableService.AddBook(title, author, genre, quantity);
            MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
        {
            e.Handled = true;
            txtQuantity.Focus();
        }
    }
}