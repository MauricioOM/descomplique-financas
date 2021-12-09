using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RememberMe.Model;
using RememberMe.Controller;
using System.Globalization;
using System.Configuration;

// *****************************************************************************
// Criador: Maurício Oliveira Monti
// E-mail: mauricioomonti@gmail.com
// GitHub: https://github.com/MauricioOM
// LinkedIn: https://www.linkedin.com/in/maur%C3%ADcio-oliveira-monti-394086205/
// PDF do meu TCC: https://drive.google.com/file/d/184CqhQnRz2EPQod3LUKuYLrjl8NLHogd/view?usp=sharing
// *****************************************************************************

namespace RememberMe.View
{
    public partial class FormEditarPagamento : Form
    {
        // Armazena o valor da culture info que é usada na gravação e leitura dos mêses
        private readonly CultureInfo ci = new CultureInfo(ConfigurationManager.AppSettings["culture_info"]);

        // Armazena a data escolhida que não é modificada depois ta inicialização
        private DateTime dataEscolhida;

        // Armazena o nome antigo para que se o usuario modificar o nome consiga procuralo no arquivo
        private String nomeAntigoPgto;
        private DateTime dataAntigaPgto;

        public FormEditarPagamento(FormPagamentos f1, DateTime dataEscolhida,
            String nome, String valor, String data)
        {
            InitializeComponent();
            formPagamentos = f1;
            this.dataEscolhida = dataEscolhida;
            this.dataAntigaPgto = dataEscolhida;

            this.nomeBox.Text = nome;
            nomeAntigoPgto = nome;

            this.valorBox.Text = valor;
            this.vencimentoBox.Text = data;
        }

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;
        FormPagamentos formPagamentos;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void updateDataGrid()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler?.Invoke(this, args);
        }

        private void nomeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void valorBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void vencimentoBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void salvarBtn_Click(object sender, EventArgs e)
        {
            Boolean verificarNomeAntigo = false;

            Pagamento pagamento = new Pagamento();
            pagamento.nome = nomeBox.Text;

            // Avalia os dados preenchidos (obriga a serem preenchidos corretamente)
            ExceptionTreatment tratamento = new ExceptionTreatment();
            pagamento.valor = tratamento.valorExceptionTreatment(valorBox.Text);
            pagamento.vencimento = tratamento.vencimentoExceptionTreatment(vencimentoBox.Text);

            CRUDPagamentos crudPagamentos = new CRUDPagamentos(dataEscolhida);

            // Se os valores não estiverem corretos abre outra janela para o preenchimento de novo
            if (pagamento.vencimento <= DateTime.MinValue || pagamento.valor <= 0)
            {
                vencimentoBox.ResetText();
                valorBox.ResetText();
                MessageBox.Show("Por Favor Preencha os Dados Corretamente", "Valor Incorreto ou Não Preenchido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //-----------------------------------------------------------------------------------------------------

            // Se a data de vencimento for do próximo mes ou ano
            if (pagamento.vencimento.Month > dataEscolhida.Month || pagamento.vencimento.Year > dataEscolhida.Year) //.AddMonths(1).Month)
            {
                DialogResult dialogResult = MessageBox.Show("Data do Vencimento Não Pertence ao Mês Atual (" + DateTime.Now.ToString("MMMM", ci) + ") " + "Deseja Gravar Assim Mesmo ?", "Mensagem de Confirmação", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    vencimentoBox.ResetText();
                    return;
                }
            }

            // Se a data de vencimento for anterior ao mês atual (vencida) ou ano
            else if (pagamento.vencimento < dataEscolhida.AddDays(-1) || pagamento.vencimento.Year < dataEscolhida.Year)
            {
                DialogResult dialogResult1 = MessageBox.Show("Data do Vencimento é Anterior a Data Atual (Pagamento Vencido), Deseja Gravar Assim Mesmo ?", "Mensagem de Confirmação", MessageBoxButtons.YesNo);
                if (dialogResult1 == DialogResult.No)
                {
                    vencimentoBox.ResetText();
                    return;
                }
            }

            // Se o nome do pagamento já existir no arquivo ATUAL
            if (crudPagamentos.verificarPagamento(nomeBox.Text.Trim(), nomeAntigoPgto))
            {
                nomeBox.ResetText();
                MessageBox.Show("Por Favor Digite um Nome Diferente", "Nome do Pagamento Já Existente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Se passar por tudo adicionar o pagamento
            crudPagamentos.editarPagamento(pagamento, nomeAntigoPgto);
            updateDataGrid();
            this.Close();
        }

        private void cancelarBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditarPagamento_Load(object sender, EventArgs e)
        {

        }
    }
}
