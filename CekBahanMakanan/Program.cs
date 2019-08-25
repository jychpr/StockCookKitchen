using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CekBahanMakanan
{
    static class Program //class Program adalah class pertama yang diakses ketika program dijalankan karena ada Main()
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() //method yang pertama dijalankan ketika program berjalan
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm()); //aplikasi menjalankan MainForm()
        }
    }
}
