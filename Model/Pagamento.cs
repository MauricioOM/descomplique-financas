using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// *****************************************************************************
// Criador: Maurício Oliveira Monti
// E-mail: mauricioomonti@gmail.com
// GitHub: https://github.com/MauricioOM
// LinkedIn: https://www.linkedin.com/in/maur%C3%ADcio-oliveira-monti-394086205/
// PDF do meu TCC: https://drive.google.com/file/d/184CqhQnRz2EPQod3LUKuYLrjl8NLHogd/view?usp=sharing
// *****************************************************************************

namespace RememberMe.Model
{
    class Pagamento
    {
        public String nome { get; set; }

        public double valor { get; set; }

        public DateTime vencimento { get; set; }

        //public int identificador { get; set; }

        public bool pago { get; set; }

        public Pagamento()
        {
            //nome = "";
            //valor = 0;
            //vencimento = 00 / 00 / 00;
            pago = false;
        }
    }
}
