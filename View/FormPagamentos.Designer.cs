namespace RememberMe.View
{
    partial class FormPagamentos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPagamentos));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pagamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnMesAtual = new System.Windows.Forms.Button();
            this.labelMesAtual = new System.Windows.Forms.Label();
            this.labelTextTotalPago = new System.Windows.Forms.Label();
            this.labelValueTotalPago = new System.Windows.Forms.Label();
            this.labelTextTotalFaltante = new System.Windows.Forms.Label();
            this.labelValueTotalFaltante = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnEditarPagamento = new System.Windows.Forms.Button();
            this.btnMesPosterior = new System.Windows.Forms.Button();
            this.btnMesAnterior = new System.Windows.Forms.Button();
            this.btnRemoverPagamento = new System.Windows.Forms.Button();
            this.btnAdicionarPagamento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vencimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pagoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.listaPagamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPagamentosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(137)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.vencimentoDataGridViewTextBoxColumn,
            this.pagoDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.pagamentoBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(322, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(615, 574);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // pagamentoBindingSource
            // 
            this.pagamentoBindingSource.DataMember = "Pagamento";
            this.pagamentoBindingSource.DataSource = this.listaPagamentosBindingSource;
            // 
            // btnMesAtual
            // 
            this.btnMesAtual.BackColor = System.Drawing.SystemColors.Control;
            this.btnMesAtual.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesAtual.ForeColor = System.Drawing.Color.Black;
            this.btnMesAtual.Location = new System.Drawing.Point(16, 79);
            this.btnMesAtual.Margin = new System.Windows.Forms.Padding(2);
            this.btnMesAtual.Name = "btnMesAtual";
            this.btnMesAtual.Size = new System.Drawing.Size(284, 58);
            this.btnMesAtual.TabIndex = 15;
            this.btnMesAtual.Text = "Mês Atual";
            this.btnMesAtual.UseVisualStyleBackColor = false;
            this.btnMesAtual.Click += new System.EventHandler(this.btnMesAtual_Click);
            // 
            // labelMesAtual
            // 
            this.labelMesAtual.AutoSize = true;
            this.labelMesAtual.Font = new System.Drawing.Font("Arial", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMesAtual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(137)))), ((int)(((byte)(161)))));
            this.labelMesAtual.Location = new System.Drawing.Point(14, 10);
            this.labelMesAtual.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMesAtual.Name = "labelMesAtual";
            this.labelMesAtual.Size = new System.Drawing.Size(298, 45);
            this.labelMesAtual.TabIndex = 16;
            this.labelMesAtual.Text = "Dezembro 2020";
            this.labelMesAtual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMesAtual.Click += new System.EventHandler(this.labelMesAtual_Click);
            // 
            // labelTextTotalPago
            // 
            this.labelTextTotalPago.AutoSize = true;
            this.labelTextTotalPago.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextTotalPago.Location = new System.Drawing.Point(19, 464);
            this.labelTextTotalPago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTextTotalPago.Name = "labelTextTotalPago";
            this.labelTextTotalPago.Size = new System.Drawing.Size(110, 23);
            this.labelTextTotalPago.TabIndex = 17;
            this.labelTextTotalPago.Text = "Total Pago:";
            // 
            // labelValueTotalPago
            // 
            this.labelValueTotalPago.AutoSize = true;
            this.labelValueTotalPago.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValueTotalPago.Location = new System.Drawing.Point(167, 464);
            this.labelValueTotalPago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelValueTotalPago.Name = "labelValueTotalPago";
            this.labelValueTotalPago.Size = new System.Drawing.Size(137, 23);
            this.labelValueTotalPago.TabIndex = 18;
            this.labelValueTotalPago.Text = "20000000,000";
            // 
            // labelTextTotalFaltante
            // 
            this.labelTextTotalFaltante.AutoSize = true;
            this.labelTextTotalFaltante.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTextTotalFaltante.Location = new System.Drawing.Point(19, 497);
            this.labelTextTotalFaltante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTextTotalFaltante.Name = "labelTextTotalFaltante";
            this.labelTextTotalFaltante.Size = new System.Drawing.Size(135, 23);
            this.labelTextTotalFaltante.TabIndex = 19;
            this.labelTextTotalFaltante.Text = "Total Faltante:";
            // 
            // labelValueTotalFaltante
            // 
            this.labelValueTotalFaltante.AutoSize = true;
            this.labelValueTotalFaltante.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValueTotalFaltante.Location = new System.Drawing.Point(167, 497);
            this.labelValueTotalFaltante.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelValueTotalFaltante.Name = "labelValueTotalFaltante";
            this.labelValueTotalFaltante.Size = new System.Drawing.Size(137, 23);
            this.labelValueTotalFaltante.TabIndex = 20;
            this.labelValueTotalFaltante.Text = "30000000,548";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(137)))), ((int)(((byte)(161)))));
            this.btnAtualizar.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAtualizar.Location = new System.Drawing.Point(16, 396);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(284, 58);
            this.btnAtualizar.TabIndex = 21;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnEditarPagamento
            // 
            this.btnEditarPagamento.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditarPagamento.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarPagamento.ForeColor = System.Drawing.Color.Black;
            this.btnEditarPagamento.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarPagamento.Image")));
            this.btnEditarPagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarPagamento.Location = new System.Drawing.Point(16, 332);
            this.btnEditarPagamento.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditarPagamento.Name = "btnEditarPagamento";
            this.btnEditarPagamento.Size = new System.Drawing.Size(284, 58);
            this.btnEditarPagamento.TabIndex = 22;
            this.btnEditarPagamento.Text = "Editar Pagamento";
            this.btnEditarPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarPagamento.UseVisualStyleBackColor = false;
            this.btnEditarPagamento.Click += new System.EventHandler(this.btnEditarPagamento_Click);
            // 
            // btnMesPosterior
            // 
            this.btnMesPosterior.BackColor = System.Drawing.SystemColors.Control;
            this.btnMesPosterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMesPosterior.BackgroundImage")));
            this.btnMesPosterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMesPosterior.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesPosterior.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMesPosterior.Location = new System.Drawing.Point(160, 141);
            this.btnMesPosterior.Margin = new System.Windows.Forms.Padding(2);
            this.btnMesPosterior.Name = "btnMesPosterior";
            this.btnMesPosterior.Size = new System.Drawing.Size(140, 58);
            this.btnMesPosterior.TabIndex = 14;
            this.btnMesPosterior.Text = "Mês Posterior";
            this.btnMesPosterior.UseVisualStyleBackColor = false;
            this.btnMesPosterior.Click += new System.EventHandler(this.btnMesPosterior_Click);
            // 
            // btnMesAnterior
            // 
            this.btnMesAnterior.BackColor = System.Drawing.SystemColors.Control;
            this.btnMesAnterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMesAnterior.BackgroundImage")));
            this.btnMesAnterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMesAnterior.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMesAnterior.ForeColor = System.Drawing.SystemColors.Control;
            this.btnMesAnterior.Location = new System.Drawing.Point(16, 141);
            this.btnMesAnterior.Margin = new System.Windows.Forms.Padding(2);
            this.btnMesAnterior.Name = "btnMesAnterior";
            this.btnMesAnterior.Size = new System.Drawing.Size(140, 58);
            this.btnMesAnterior.TabIndex = 13;
            this.btnMesAnterior.Text = "Mês Anterior";
            this.btnMesAnterior.UseVisualStyleBackColor = false;
            this.btnMesAnterior.Click += new System.EventHandler(this.btnMesAnterior_Click);
            // 
            // btnRemoverPagamento
            // 
            this.btnRemoverPagamento.BackColor = System.Drawing.SystemColors.Control;
            this.btnRemoverPagamento.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverPagamento.ForeColor = System.Drawing.Color.Black;
            this.btnRemoverPagamento.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoverPagamento.Image")));
            this.btnRemoverPagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoverPagamento.Location = new System.Drawing.Point(16, 269);
            this.btnRemoverPagamento.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoverPagamento.Name = "btnRemoverPagamento";
            this.btnRemoverPagamento.Size = new System.Drawing.Size(284, 58);
            this.btnRemoverPagamento.TabIndex = 9;
            this.btnRemoverPagamento.Text = "Remover Pagamento";
            this.btnRemoverPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoverPagamento.UseVisualStyleBackColor = false;
            this.btnRemoverPagamento.Click += new System.EventHandler(this.btnRemoverPagamento_Click);
            // 
            // btnAdicionarPagamento
            // 
            this.btnAdicionarPagamento.BackColor = System.Drawing.SystemColors.Control;
            this.btnAdicionarPagamento.Font = new System.Drawing.Font("Constantia", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarPagamento.ForeColor = System.Drawing.Color.Black;
            this.btnAdicionarPagamento.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarPagamento.Image")));
            this.btnAdicionarPagamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdicionarPagamento.Location = new System.Drawing.Point(16, 206);
            this.btnAdicionarPagamento.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdicionarPagamento.Name = "btnAdicionarPagamento";
            this.btnAdicionarPagamento.Size = new System.Drawing.Size(284, 58);
            this.btnAdicionarPagamento.TabIndex = 7;
            this.btnAdicionarPagamento.Text = "Adicionar Pagamento";
            this.btnAdicionarPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdicionarPagamento.UseVisualStyleBackColor = false;
            this.btnAdicionarPagamento.Click += new System.EventHandler(this.btnAdicionarPagamento_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(137)))), ((int)(((byte)(161)))));
            this.label1.Location = new System.Drawing.Point(38, 530);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Desenvolvido por Maurício Oliveira Monti";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(137)))), ((int)(((byte)(161)))));
            this.label2.Location = new System.Drawing.Point(73, 549);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "mauricioomonti@gmail.com";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(137)))), ((int)(((byte)(161)))));
            this.label3.Location = new System.Drawing.Point(82, 569);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "github.com/MauricioOM";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "valor";
            this.valorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            // 
            // vencimentoDataGridViewTextBoxColumn
            // 
            this.vencimentoDataGridViewTextBoxColumn.DataPropertyName = "vencimento";
            this.vencimentoDataGridViewTextBoxColumn.HeaderText = "vencimento";
            this.vencimentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vencimentoDataGridViewTextBoxColumn.Name = "vencimentoDataGridViewTextBoxColumn";
            // 
            // pagoDataGridViewCheckBoxColumn
            // 
            this.pagoDataGridViewCheckBoxColumn.DataPropertyName = "pago";
            this.pagoDataGridViewCheckBoxColumn.HeaderText = "pago";
            this.pagoDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.pagoDataGridViewCheckBoxColumn.Name = "pagoDataGridViewCheckBoxColumn";
            // 
            // listaPagamentosBindingSource
            // 
            this.listaPagamentosBindingSource.DataSource = typeof(RememberMe.Model.ListaPagamentos);
            this.listaPagamentosBindingSource.CurrentChanged += new System.EventHandler(this.listaPagamentosBindingSource_CurrentChanged);
            // 
            // FormPagamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 591);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditarPagamento);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.labelValueTotalFaltante);
            this.Controls.Add(this.labelTextTotalFaltante);
            this.Controls.Add(this.labelValueTotalPago);
            this.Controls.Add(this.labelTextTotalPago);
            this.Controls.Add(this.labelMesAtual);
            this.Controls.Add(this.btnMesAtual);
            this.Controls.Add(this.btnMesPosterior);
            this.Controls.Add(this.btnMesAnterior);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRemoverPagamento);
            this.Controls.Add(this.btnAdicionarPagamento);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormPagamentos";
            this.Text = "FormPagamentos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPagamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pagamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaPagamentosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRemoverPagamento;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vencimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn pagoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource listaPagamentosBindingSource;
        private System.Windows.Forms.Button btnMesAnterior;
        private System.Windows.Forms.Button btnMesPosterior;
        private System.Windows.Forms.Button btnMesAtual;
        private System.Windows.Forms.BindingSource pagamentoBindingSource;
        private System.Windows.Forms.Label labelMesAtual;
        private System.Windows.Forms.Button btnAdicionarPagamento;
        private System.Windows.Forms.Label labelTextTotalPago;
        private System.Windows.Forms.Label labelValueTotalPago;
        private System.Windows.Forms.Label labelTextTotalFaltante;
        private System.Windows.Forms.Label labelValueTotalFaltante;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnEditarPagamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}