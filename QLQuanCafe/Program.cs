using System;
using System.Windows.Forms;
using QLQuanCafe.GUI;
using QLQuanCafe.GUI.Form;

namespace QLQuanCafe
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
