using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RememberMe.View;

// *****************************************************************************
// Criador: Maurício Oliveira Monti
// E-mail: mauricioomonti@gmail.com
// GitHub: https://github.com/MauricioOM
// LinkedIn: https://www.linkedin.com/in/maur%C3%ADcio-oliveira-monti-394086205/
// PDF do meu TCC: https://drive.google.com/file/d/184CqhQnRz2EPQod3LUKuYLrjl8NLHogd/view?usp=sharing
// *****************************************************************************

namespace RememberMe
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
            Application.Run(new FormPagamentos());
        }
    }
}
