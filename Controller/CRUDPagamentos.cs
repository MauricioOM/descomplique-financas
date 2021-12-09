using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RememberMe.Model;
using System.Configuration;
using System.Xml;
using System.Xml.Linq;
using System.Data;
using RememberMe.View;
using System.Windows.Forms;
using System.Globalization;

// *****************************************************************************
// Criador: Maurício Oliveira Monti
// E-mail: mauricioomonti@gmail.com
// GitHub: https://github.com/MauricioOM
// LinkedIn: https://www.linkedin.com/in/maur%C3%ADcio-oliveira-monti-394086205/
// PDF do meu TCC: https://drive.google.com/file/d/184CqhQnRz2EPQod3LUKuYLrjl8NLHogd/view?usp=sharing
// *****************************************************************************

namespace RememberMe.Controller
{
    class CRUDPagamentos
    {
        //static String caminho = ConfigurationManager.AppSettings["caminho_BD"] + "\\teste.xml";
        
        private string diretorio = ConfigurationManager.AppSettings["caminho_BD"]; 
        private string caminhoArquivo = ConfigurationManager.AppSettings["caminho_BD"];

        // Armazena o valor da culture info que é usada na gravação e leitura dos mêses
        private readonly CultureInfo ci = new CultureInfo(ConfigurationManager.AppSettings["culture_info"]);

        public CRUDPagamentos(DateTime dataEscolhida)
        {
            this.diretorio = diretorio + "\\" + dataEscolhida.Year.ToString();

            this.caminhoArquivo = diretorio + "\\" + dataEscolhida.ToString("MMMM", ci) + ".xml";
            
        }

        public void atualizarMesArquivo(DateTime dataEscolhida)
        {
            this.diretorio = ConfigurationManager.AppSettings["caminho_BD"] + "\\" + dataEscolhida.Year.ToString();

            this.caminhoArquivo = diretorio + "\\" + dataEscolhida.ToString("MMMM", ci) + ".xml";
        }

        public void subtrairMesArquivo(int somador)
        {
            var today = DateTime.Today;
            var result = today.AddMonths(-somador);
            this.caminhoArquivo = ConfigurationManager.AppSettings["caminho_BD"] + "\\" + result.Year.ToString() + "\\" + result.ToString("MMMM", ci) + ".xml";
        }

        public bool diretorioBDCriado()
        {
            if (Directory.Exists(diretorio))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool arquivoCriado()
        {
            if (File.Exists(caminhoArquivo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Cria o primeiro pagamento do arquivo    
        public void adicionarPrimeiroPagamento(string pgtNome, string pgtValor, string pgtVencimento, string pgtPago)
        {
            // Try to create the directory.
            DirectoryInfo di = Directory.CreateDirectory(diretorio);

            // Create the file, or overwrite if the file exists.
            using (FileStream fs = File.Create(caminhoArquivo))
            {
                byte[] info = new UTF8Encoding(true).GetBytes("");
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }

            // Create a new file in C:\\ dir  
            //XmlTextWriter textWriter = new XmlTextWriter(caminho, Encoding.UTF8);

            XmlWriter textWriter = XmlWriter.Create(caminhoArquivo);

            //XmlWriter writer = XmlWriter.Create("books.xml")
            // Opens the document  
            textWriter.WriteStartDocument(true);
            //textWriter.Formatting = Formatting.Indented;
            //textWriter.Indentation = 2;
            textWriter.WriteStartElement("Mês");
            textWriter.WriteStartElement("Pagamento");
            textWriter.WriteStartElement("Nome");
            textWriter.WriteString(pgtNome);
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("Valor");
            textWriter.WriteString(pgtValor);
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("Vencimento");
            textWriter.WriteString(pgtVencimento);
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("Pago");
            textWriter.WriteString(pgtPago);
            textWriter.WriteEndElement();
            textWriter.WriteEndElement();
            textWriter.WriteEndElement();
            textWriter.WriteEndDocument();
            textWriter.Close();
        }

        public void adicionarPrimeiroPagamento(Pagamento pagamento)
        {
            // Try to create the directory.
            DirectoryInfo di = Directory.CreateDirectory(diretorio);

            // Create the file, or overwrite if the file exists.
            using (FileStream fs = File.Create(caminhoArquivo))
            {
                byte[] info = new UTF8Encoding(true).GetBytes("");
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }

            // Create a new file in C:\\ dir  
            //XmlTextWriter textWriter = new XmlTextWriter(caminho, Encoding.UTF8);

            XmlWriter textWriter = XmlWriter.Create(caminhoArquivo);

            //XmlWriter writer = XmlWriter.Create("books.xml")
            // Opens the document  
            textWriter.WriteStartDocument(true);
            //textWriter.Formatting = Formatting.Indented;
            //textWriter.Indentation = 2;
            textWriter.WriteStartElement("Mês");
            textWriter.WriteStartElement("Pagamento");
            textWriter.WriteStartElement("Nome");
            textWriter.WriteString(pagamento.nome);
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("Valor");
            textWriter.WriteString(pagamento.valor.ToString());
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("Vencimento");
            textWriter.WriteString(pagamento.vencimento.ToString("dd/MM/yyyy"));
            textWriter.WriteEndElement();
            textWriter.WriteStartElement("Pago");
            textWriter.WriteString(pagamento.pago.ToString());
            textWriter.WriteEndElement();
            textWriter.WriteEndElement();
            textWriter.WriteEndElement();
            textWriter.WriteEndDocument();
            textWriter.Close();
        }


        public void criarArquivo()
        {
            // Try to create the directory.
            DirectoryInfo di = Directory.CreateDirectory(diretorio);

            // Create the file, or overwrite if the file exists.
            using (FileStream fs = File.Create(caminhoArquivo))
            {
                byte[] info = new UTF8Encoding(true).GetBytes("");
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }

            // Create a new file in C:\\ dir  
            //XmlTextWriter textWriter = new XmlTextWriter(caminho, Encoding.UTF8);

            XmlWriter textWriter = XmlWriter.Create(caminhoArquivo);

            //XmlWriter writer = XmlWriter.Create("books.xml")
            // Opens the document  
            //textWriter.WriteStartDocument(true);
            //textWriter.Formatting = Formatting.Indented;
            //textWriter.Indentation = 2;
            textWriter.Close();
        }

        public void adicionarPagamento(Pagamento pagamento)
        {
            try
            {
                using (DataSet dsWriter = new DataSet())
                {
                    dsWriter.ReadXml(caminhoArquivo);
                    //inclui os dados no DataSet
                    dsWriter.Tables[0].Rows.Add(dsWriter.Tables[0].NewRow());
                    dsWriter.Tables[0].Rows[dsWriter.Tables[0].Rows.Count - 1]["Nome"] = pagamento.nome;
                    dsWriter.Tables[0].Rows[dsWriter.Tables[0].Rows.Count - 1]["Valor"] = pagamento.valor.ToString();
                    dsWriter.Tables[0].Rows[dsWriter.Tables[0].Rows.Count - 1]["Vencimento"] = pagamento.vencimento.ToString("dd/MM/yyyy");
                    dsWriter.Tables[0].Rows[dsWriter.Tables[0].Rows.Count - 1]["Pago"] = pagamento.pago.ToString();
                    dsWriter.AcceptChanges();
                    //--  Escreve para o arquivo XML final usando o método Write
                    dsWriter.WriteXml(caminhoArquivo, XmlWriteMode.IgnoreSchema);
                }
            }
            // Se o arquivo estiver zerado usa outro metodo para adicionar o primeiro pagemento
            catch (Exception)
            {
                adicionarPrimeiroPagamento(pagamento);
                //MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        public void editarPagamento(Pagamento pagamento, String nomeAntigoPgto)
        {
            removerPagamento(nomeAntigoPgto);
            adicionarPagamento(pagamento);
        }

        public DataSet lerPagamentos()
        {
            DataSet dsRead = new DataSet();
            try
            {
                if (File.Exists(caminhoArquivo))
                {
                    dsRead.ReadXml(caminhoArquivo);
                }
                //return dsRead;
            }
            catch (Exception)
            {
                // Adiciona uma tabela vazia
                dsRead.Tables.Add();
                //throw;
            }
            return dsRead;
        }

        public void removerPagamento(string nomePagamento)
        {
            // Se o arquivo estiver criado
            if (arquivoCriado())
            {
                // create the XML, load the contents
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(caminhoArquivo);

                foreach (XmlNode xNode in xDoc.SelectNodes("Mês/Pagamento"))
                {
                    if (xNode.SelectSingleNode("Nome").InnerText == nomePagamento)
                    {
                        //Gets all the nodes with name submenuid
                        XmlNodeList nodeList = xDoc.GetElementsByTagName("Nome");
                        //Here is the count that you need
                        int countNode = nodeList.Count;
                        // Se estiver sobrando apenas 1 elemento exclui o arquivo
                        if (countNode <= 1)
                        {
                            // Assim deleta o arquivo existente também
                            criarArquivo();
                            return;
                        }

                        // Remove apenas 1 elemento
                        xNode.ParentNode.RemoveChild(xNode);
                    }
                }
                xDoc.Save(caminhoArquivo);

            }
        }

        public void salvarPagamentosDataGridView(DataGridView dataGrid)
        {
            if (arquivoCriado() && dataGrid.RowCount > 0)
            {
                // Se for em branco significa que é false o vencimento
                if (dataGrid.Rows[0].Cells[3].Value.ToString() == "")
                {
                    dataGrid.Rows[0].Cells[3].Value = false;
                }

                // Cria o primeiro valor no arquivo para Zerar ele e assim poder gravar os próximo dados do dataGrid se tiver
                adicionarPrimeiroPagamento(dataGrid.Rows[0].Cells[0].Value.ToString(), dataGrid.Rows[0].Cells[1].Value.ToString(), 
                    dataGrid.Rows[0].Cells[2].Value.ToString(), dataGrid.Rows[0].Cells[3].Value.ToString());

                // Se tiver mais de um elemento no dataGrid
                if (dataGrid.RowCount > 1)
                {
                    DataSet dsWriter = new DataSet();
                    dsWriter.ReadXml(caminhoArquivo);

                    for (int i = 1; i < dataGrid.RowCount; i++)
                    {
                        // Se chegar a null significa que terminou de varrer a dataGridView
                        if (dataGrid.Rows[i].Cells[0].Value == null)
                        {
                            break;
                        }

                        //inclui os dados no DataSet
                        dsWriter.Tables[0].Rows.Add(dsWriter.Tables[0].NewRow());
                        dsWriter.Tables[0].Rows[dsWriter.Tables[0].Rows.Count - 1]["Nome"] = dataGrid.Rows[i].Cells[0].Value.ToString();
                        dsWriter.Tables[0].Rows[dsWriter.Tables[0].Rows.Count - 1]["Valor"] = dataGrid.Rows[i].Cells[1].Value.ToString();
                        dsWriter.Tables[0].Rows[dsWriter.Tables[0].Rows.Count - 1]["Vencimento"] = dataGrid.Rows[i].Cells[2].Value.ToString();

                        // Se for em branco significa que é false o vencimento
                        if (dataGrid.Rows[i].Cells[3].Value.ToString() == "")
                        {
                            dataGrid.Rows[i].Cells[3].Value = false;
                        }

                        dsWriter.Tables[0].Rows[dsWriter.Tables[0].Rows.Count - 1]["Pago"] = dataGrid.Rows[i].Cells[3].Value.ToString();
                        
                        //Console.WriteLine(dataGrid.Rows[i].Cells[j].Value.ToString());
                    }
                    //--  Escreve para o arquivo XML final usando o método Write
                    dsWriter.AcceptChanges();
                    dsWriter.WriteXml(caminhoArquivo, XmlWriteMode.IgnoreSchema);
                }
            }
        }

        // Verifica se o nome do pagamento já existe
        public bool verificarPagamento(String nome)
        {
            // Verifica se existe o arquivo primeiro
            if (arquivoCriado())
            {
                DataSet dsRead = new DataSet();

                dsRead = lerPagamentos();

                for (int i = 0; i < dsRead.Tables[0].Rows.Count; i++)
                {
                    //Console.WriteLine(dsRead.Tables[0].Rows[i]["Nome"].ToString());
                    if (dsRead.Tables[0].Rows[i]["Nome"].ToString() == nome)
                    {
                        return true;
                    }
                }
            }

            return false;
        }


        // Verifica se o nome do pagamento já existe excluindo o já existente (acontece na etapa de editar pagamento)
        public bool verificarPagamento(String nome, String nomeAntigoPgto)
        {
            // Verifica se existe o arquivo primeiro
            if (arquivoCriado())
            {
                DataSet dsRead = new DataSet();

                dsRead = lerPagamentos();

                for (int i = 0; i < dsRead.Tables[0].Rows.Count; i++)
                {
                    //Console.WriteLine(dsRead.Tables[0].Rows[i]["Nome"].ToString());
                    if (dsRead.Tables[0].Rows[i]["Nome"].ToString() == nome && nome != nomeAntigoPgto)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
