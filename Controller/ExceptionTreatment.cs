using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// *****************************************************************************
// Criador: Maurício Oliveira Monti
// E-mail: mauricioomonti@gmail.com
// GitHub: https://github.com/MauricioOM
// LinkedIn: https://www.linkedin.com/in/maur%C3%ADcio-oliveira-monti-394086205/
// PDF do meu TCC: https://drive.google.com/file/d/184CqhQnRz2EPQod3LUKuYLrjl8NLHogd/view?usp=sharing
// *****************************************************************************

namespace RememberMe.Controller
{
    class ExceptionTreatment
    {

        // Armazena o valor da culture info que é usada na gravação e leitura dos mêses
        private readonly CultureInfo ci = new CultureInfo(ConfigurationManager.AppSettings["culture_info"]);


        // Tratamento de exceções para os valores da conta
        // Se o valor for invalido retorna 0
        public double valorExceptionTreatment(String valor)
        {
            valor = valor.Replace('.', ',').Trim();
            double valor2;

            // Se não der para converter retorna 0
            try
            {
                valor2 = Convert.ToDouble(valor);
            }
            catch (Exception)
            {
                valor2 = 0;
            }

            // Se for negativo retorna 0
            if (valor2 < 0)
            {
                return 0;
            }
            else
            {
                return valor2;
            }
        }

        // Tratamento de exceções para as datas de vencimento
        // Se o valor for invalido retorna DateTime.MinValue
        public DateTime vencimentoExceptionTreatment(String vencimento)
        {
            vencimento = vencimento.Replace('.', '/').Trim();
            vencimento = vencimento.Replace('-', '/');

            DateTime vencimento2;

            if (DateTime.TryParseExact(vencimento, "dd/MM/yyyy", ci, DateTimeStyles.None, out vencimento2))
            {

                return vencimento2;

            }
            else
            {
                return DateTime.MinValue;
            }
        }













    }
}
