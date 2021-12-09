namespace RememberMe.View
{
    partial class FormAdicionarPagamento
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
            this.nomeLabel = new System.Windows.Forms.Label();
            this.valorLabel = new System.Windows.Forms.Label();
            this.dataLabel = new System.Windows.Forms.Label();
            this.salvarBtn = new System.Windows.Forms.Button();
            this.nomeBox = new System.Windows.Forms.TextBox();
            this.valorBox = new System.Windows.Forms.TextBox();
            this.vencimentoBox = new System.Windows.Forms.TextBox();
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(53, 31);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(45, 17);
            this.nomeLabel.TabIndex = 1;
            this.nomeLabel.Text = "Nome";
            this.nomeLabel.Click += new System.EventHandler(this.nomeLabel_Click);
            // 
            // valorLabel
            // 
            this.valorLabel.AutoSize = true;
            this.valorLabel.Location = new System.Drawing.Point(252, 31);
            this.valorLabel.Name = "valorLabel";
            this.valorLabel.Size = new System.Drawing.Size(41, 17);
            this.valorLabel.TabIndex = 3;
            this.valorLabel.Text = "Valor";
            this.valorLabel.Click += new System.EventHandler(this.valorLabel_Click);
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Location = new System.Drawing.Point(410, 31);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(136, 17);
            this.dataLabel.TabIndex = 5;
            this.dataLabel.Text = "Data de Vencimento";
            this.dataLabel.Click += new System.EventHandler(this.dataLabel_Click);
            // 
            // salvarBtn
            // 
            this.salvarBtn.Location = new System.Drawing.Point(121, 109);
            this.salvarBtn.Name = "salvarBtn";
            this.salvarBtn.Size = new System.Drawing.Size(158, 32);
            this.salvarBtn.TabIndex = 6;
            this.salvarBtn.Text = "Salvar";
            this.salvarBtn.UseVisualStyleBackColor = true;
            this.salvarBtn.Click += new System.EventHandler(this.salvarBtn_Click);
            // 
            // nomeBox
            // 
            this.nomeBox.Location = new System.Drawing.Point(9, 57);
            this.nomeBox.Name = "nomeBox";
            this.nomeBox.Size = new System.Drawing.Size(146, 22);
            this.nomeBox.TabIndex = 9;
            this.nomeBox.TextChanged += new System.EventHandler(this.nomeBox_TextChanged);
            // 
            // valorBox
            // 
            this.valorBox.Location = new System.Drawing.Point(196, 57);
            this.valorBox.Name = "valorBox";
            this.valorBox.Size = new System.Drawing.Size(158, 22);
            this.valorBox.TabIndex = 10;
            this.valorBox.TextChanged += new System.EventHandler(this.valorBox_TextChanged);
            // 
            // vencimentoBox
            // 
            this.vencimentoBox.Location = new System.Drawing.Point(393, 57);
            this.vencimentoBox.Name = "vencimentoBox";
            this.vencimentoBox.Size = new System.Drawing.Size(169, 22);
            this.vencimentoBox.TabIndex = 11;
            this.vencimentoBox.TextChanged += new System.EventHandler(this.vencimentoBox_TextChanged);
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(295, 109);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(158, 32);
            this.cancelarBtn.TabIndex = 12;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // FormAdicionarPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 166);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.vencimentoBox);
            this.Controls.Add(this.valorBox);
            this.Controls.Add(this.nomeBox);
            this.Controls.Add(this.salvarBtn);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.valorLabel);
            this.Controls.Add(this.nomeLabel);
            this.Name = "FormAdicionarPagamento";
            this.Text = "Adicionar Pagamento";
            this.Load += new System.EventHandler(this.AdicionarPagamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label valorLabel;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.Button salvarBtn;
        private System.Windows.Forms.TextBox nomeBox;
        private System.Windows.Forms.TextBox valorBox;
        private System.Windows.Forms.TextBox vencimentoBox;
        private System.Windows.Forms.Button cancelarBtn;
    }
}