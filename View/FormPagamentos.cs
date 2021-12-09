using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RememberMe.Controller;
using RememberMe.Model;

// *****************************************************************************
// Criador: Maurício Oliveira Monti
// E-mail: mauricioomonti@gmail.com
// GitHub: https://github.com/MauricioOM
// LinkedIn: https://www.linkedin.com/in/maur%C3%ADcio-oliveira-monti-394086205/
// PDF do meu TCC: https://drive.google.com/file/d/184CqhQnRz2EPQod3LUKuYLrjl8NLHogd/view?usp=sharing
// *****************************************************************************

namespace RememberMe.View
{
    public partial class FormPagamentos : Form
    {
        // Armazena a data escolhida
        private DateTime dataEscolhida;

        // Armazena o valor da culture info que é usada na gravação e leitura dos mêses
        private readonly CultureInfo ci = new CultureInfo(ConfigurationManager.AppSettings["culture_info"]);

        public FormPagamentos()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;

            // dataGridView1.ReadOnly = false;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = false;

            dataEscolhida = DateTime.Now;

            inicializarDataGrid(dataEscolhida);
        }

        // Crias os eventos do WF
        private void FormPagamentos_Load(object sender, EventArgs e)
        {
            // Evento para salvar os dados do DataGridView quando o WindowsForm é fechado
            this.FormClosing += new FormClosingEventHandler(FormPagamentos_FormClosing);

            // Eventos para edição de dados no DataGridView
            //this.dataGridView1.CellBeginEdit += new DataGridViewCellCancelEventHandler(dataGridView1_CellBeginEdit);
            this.dataGridView1.CellEndEdit += new DataGridViewCellEventHandler(dataGridView1_CellEndEdit);
      }

        // Se for fechar o WF
        private void FormPagamentos_FormClosing(object sender, FormClosingEventArgs e)
        {
            CRUDPagamentos pagamentos = new CRUDPagamentos(dataEscolhida);
            pagamentos.salvarPagamentosDataGridView(dataGridView1);
        }

        private void FormAdicionarPagamento_UpdateEventHandler(object sender, FormAdicionarPagamento.UpdateEventArgs args)
        {
            CRUDPagamentos crudPagamentos = new CRUDPagamentos(dataEscolhida);

            if (crudPagamentos.arquivoCriado())
            {
                DataSet dataProdutos = new DataSet();

                dataProdutos = crudPagamentos.lerPagamentos();

                dataGridView1.DataSource = dataProdutos.Tables[0];
            }

            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnAdicionarPagamento_Click(object sender, EventArgs e)
        {
            //var adicionarPagamento = new AdicionarPagamento();

           // adicionarPagamento.ShowDialog();

            FormAdicionarPagamento adicionarPagamento = new FormAdicionarPagamento(this, dataEscolhida);
            adicionarPagamento.UpdateEventHandler += FormAdicionarPagamento_UpdateEventHandler;
            adicionarPagamento.ShowDialog();

            // Esse metodo não funciona aqui porque executa no mesmo momento que o adicionarPagamento.Show();
            //carregarDataGridView();

            // Atualizar o Valor da Label Total Faltante e Total Pago
            atualizaLabels();
        }

        private void btnRemoverPagamento_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
            {
                if (oneCell.Selected)
                {
                    int cellSelected = oneCell.RowIndex;

                    DialogResult dialogResult = MessageBox.Show("Deseja Realmente Remover este Pagamento: " + dataGridView1.Rows[cellSelected].Cells[0].Value.ToString() + " ?", "Mensagem de Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        CRUDPagamentos pagamentos = new CRUDPagamentos(dataEscolhida);
                        pagamentos.removerPagamento(dataGridView1.Rows[cellSelected].Cells[0].Value.ToString());
                        dataGridView1.Rows.RemoveAt(cellSelected);

                        // Atualizar o Valor da Label Total Faltante e Total Pago
                        atualizaLabels();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }   
            }
        }

        private string upperCaseFirst(string s)
        {
            // Return char and concat substring.
            return char.ToUpper(s[0]) + s.Substring(1);
        }


        private void atualizaLabels()
        {

            double acumPago = 0;
            double acumFaltante = 0;

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {

                if (dataGridView1.Rows[i].Cells[3].Value.Equals("True"))
                {
                    acumPago += Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                }
                //else if (dataGridView1.Rows[i].Cells[3].Value.Equals("False") || dataGridView1.Rows[i].Cells[3].Value == null)
                else
                {
                    acumFaltante += Convert.ToDouble(dataGridView1.Rows[i].Cells[1].Value);
                }    

            }

            labelValueTotalPago.Text = acumPago.ToString();
            labelValueTotalFaltante.Text = acumFaltante.ToString();

        }


        private void lerArquivo(DateTime dataAlvo)
        {
            CRUDPagamentos crudPagamentos = new CRUDPagamentos(dataAlvo);

            DataSet dataProdutos = new DataSet();

            dataProdutos = crudPagamentos.lerPagamentos();

            // Removo o ponteiro da DataSource (deleto) para poder atribui-lo novamente
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dataProdutos.Tables[0];

            // Deixa os titulos com a primeira letra em maísculo
            dataGridView1.Columns[0].HeaderText = upperCaseFirst(dataGridView1.Columns[0].HeaderText);
            dataGridView1.Columns[1].HeaderText = upperCaseFirst(dataGridView1.Columns[1].HeaderText);
            dataGridView1.Columns[2].HeaderText = upperCaseFirst(dataGridView1.Columns[2].HeaderText);
            dataGridView1.Columns[3].HeaderText = upperCaseFirst(dataGridView1.Columns[3].HeaderText);

            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            // Atualizar o Valor da Label Total Faltante e Total Pago
            atualizaLabels();
        }


        private void inicializarDataGrid(DateTime dataAlvo)
        {
            CRUDPagamentos crudPagamentos = new CRUDPagamentos(dataAlvo);
           
            labelMesAtual.Text = dataAlvo.ToString("MMMM yyyy", ci);
            labelMesAtual.Text = upperCaseFirst(labelMesAtual.Text);

            // Verifica se algum mês já foi criado (diretorio já criado) se não tiver nenhum, cria o DateTime atual
            if (crudPagamentos.diretorioBDCriado() == false)
            {
                // Cria um arquivo com o mês atual
                crudPagamentos.criarArquivo();

                // Le o arquivo arrecem criado para aplicar as formataçoes de leitura
                lerArquivo(dataAlvo);
            }
            else
            {
                // Verifica se o mes atual está criado, se estiver le o arquivo
                if (crudPagamentos.arquivoCriado())
                {
                    lerArquivo(dataAlvo);
                }
                // Se o mes atual não estiver criado pergunta para o usuario se deseja cria-lo
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Deseja Criar o Arquivo do Mês de " + dataAlvo.Month.ToString() + " ?", "Mensagem de Confirmação", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        // Cria um arquivo com o mês atual
                        crudPagamentos.criarArquivo();
                    }
                    // Se o usuário não quiser criar o mes atual volta para o mes do periodo anterior mais próximo
                    else if (dialogResult == DialogResult.No)
                    {
                        int somador = 1;

                        while (crudPagamentos.arquivoCriado() == false)
                        {
                            this.dataEscolhida = this.dataEscolhida.AddMonths(-1);
                            crudPagamentos.subtrairMesArquivo(somador);
                            somador++;
                            
                            //somador++;
                        }
                        lerArquivo(this.dataEscolhida);


                    }
                }
            }
        }

        // Valida as informações editadas pelo usuário
        void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
            {
                if (oneCell.Selected)
                {
                    int cellSelected = oneCell.RowIndex;

                    ExceptionTreatment tratamento = new ExceptionTreatment();

                    // Se os valores não estiverem corretos
                    if (tratamento.valorExceptionTreatment(dataGridView1.Rows[cellSelected].Cells[1].Value.ToString()) <= 0 || tratamento.vencimentoExceptionTreatment(dataGridView1.Rows[cellSelected].Cells[2].Value.ToString()) <= DateTime.MinValue)
                    {
                        MessageBox.Show("Valor Incorreto", "Por favor editar novamente", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        //lerArquivo(this.dataEscolhida);

                        inicializarDataGrid(this.dataEscolhida);
                        //this.dataEscolhida = dataOriginal;
                    }
                }
            }
            //atualizaLabels();
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridView dgv = (DataGridView)sender;
                if (dgv.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
                {
                    e.PaintBackground(e.CellBounds, true);
                    ControlPaint.DrawCheckBox(e.Graphics, e.CellBounds.X + 1, e.CellBounds.Y + 1,
                        e.CellBounds.Width - 2, e.CellBounds.Height - 2,
                        (bool)e.FormattedValue ? ButtonState.Checked : ButtonState.Normal);
                    e.Handled = true;
                }
            }
        }


        private void procurarData(DateTime dataOriginal, DateTime dataAlvo)
        {
            CRUDPagamentos crudPagamentos = new CRUDPagamentos(dataAlvo);

            if (crudPagamentos.arquivoCriado() == false)
            {
                DialogResult dialogResult = MessageBox.Show("Arquivo Não Encontrado, Deseja Criar o Arquivo do Mês de " + dataAlvo.Month.ToString() + " ?", "Mensagem de Confirmação", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Cria um arquivo com o mês atual
                    crudPagamentos.criarArquivo();
                    inicializarDataGrid(dataAlvo);
                    this.dataEscolhida = dataAlvo;
                }
                // Se o usuário não quiser criar o mes inicial
                else if (dialogResult == DialogResult.No)
                {
                    inicializarDataGrid(dataOriginal);
                    this.dataEscolhida = dataOriginal;
                }
            }
            else
            {
                lerArquivo(dataAlvo);
                inicializarDataGrid(dataAlvo);
                this.dataEscolhida = dataAlvo;
            }
        }


        private void btnMesAnterior_Click(object sender, EventArgs e)
        {
            procurarData(dataEscolhida, dataEscolhida.AddMonths(-1));

            // Atualizar o Valor da Label Total Faltante e Total Pago
            atualizaLabels();
        }

        private void btnMesPosterior_Click(object sender, EventArgs e)
        {
            procurarData(dataEscolhida, dataEscolhida.AddMonths(+1));

            // Atualizar o Valor da Label Total Faltante e Total Pago
            atualizaLabels();
        }

        private void btnMesAtual_Click(object sender, EventArgs e)
        {
            DateTime dataAtual = DateTime.Today;
            procurarData(dataEscolhida, dataAtual);

            // Atualizar o Valor da Label Total Faltante e Total Pago
            atualizaLabels();
        }

        private void listaPagamentosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            // Atualiza os valores no arquivo
            CRUDPagamentos pagamentos = new CRUDPagamentos(dataEscolhida);
            pagamentos.salvarPagamentosDataGridView(dataGridView1);

            atualizaLabels();

            // Atualiza o DataGridView
            lerArquivo(dataEscolhida);
            inicializarDataGrid(dataEscolhida);
        }

        private void btnEditarPagamento_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
            {
                if (oneCell.Selected)
                {
                    int cellSelected = oneCell.RowIndex;

                    FormEditarPagamento editarPagamento = new FormEditarPagamento(this, dataEscolhida,
                        dataGridView1.Rows[cellSelected].Cells[0].Value.ToString(),
                        dataGridView1.Rows[cellSelected].Cells[1].Value.ToString(),
                        dataGridView1.Rows[cellSelected].Cells[2].Value.ToString());

                    editarPagamento.ShowDialog();

                    // Atualiza Tudo
                    atualizaLabels();
                    lerArquivo(dataEscolhida);
                    inicializarDataGrid(dataEscolhida);
                }
                else
                {
                    MessageBox.Show("Pagamento Não Selecionado", "Por favor selecione um pagamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Esse metodo não funciona aqui porque executa no mesmo momento que o adicionarPagamento.Show();
            //carregarDataGridView();

            // Atualizar o Valor da Label Total Faltante e Total Pago
            atualizaLabels();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelMesAtual_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
