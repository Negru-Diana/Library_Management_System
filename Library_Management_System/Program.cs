using System;
using System.Windows.Forms;
using Library_Management_System.service;
using Library_Management_System.ui;

public class Program
{
    [STAThread]
    public static void Main(string[] args)
    {
        ObservableService observableService = ServiceFactory.GetObservableService();
        
        
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new FrmMain(observableService));
    }
}