using MyBank.User_View;
using System;
using System.Windows.Forms;

namespace MyBank
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm.GetInstance();
            LoginForm.GetInstance();
            MainForm mainForm = MainForm.Instance;
            LoginForm loginForm = LoginForm.GetInstance();
            mainForm.SetContent(loginForm);
            Application.Run(mainForm);

        }

    }
}