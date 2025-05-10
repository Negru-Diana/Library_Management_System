using System;
using System.Windows.Forms;
using Library_Management_System.service;
using Library_Management_System.ui;

public class Program
{
    /// <summary>
    /// Starts the application, initializes the observable service, sets up Windows Forms rendering, and launches the main form.
    /// </summary>
    /// <param name="args">Command-line arguments passed to the application (not used).</param>
    [STAThread]
    public static void Main(string[] args)
    {
        ObservableService observableService = ServiceFactory.GetObservableService();
        
        
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new FrmMain(observableService));
    }
}