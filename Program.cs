using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;

namespace A21_Ex03_Dana_208992321_Aileen_205834161
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            eFormType formType = eFormType.FormLogin;
            FormFactory.Create(formType, new ArrayList());
            Application.Run(FormFactory.FormLogin);
        }
    }
}