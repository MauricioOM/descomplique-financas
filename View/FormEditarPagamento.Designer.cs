
namespace RememberMe.View
{
    partial class FormEditarPagamento
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
            this.cancelarBtn = new System.Windows.Forms.Button();
            this.vencimentoBox = new System.Windows.Forms.TextBox();
            this.valorBox = new System.Windows.Forms.TextBox();
            this.nomeBox = new System.Windows.Forms.TextBox();
            this.salvarBtn = new System.Windows.Forms.Button();
            this.dataLabel = new System.Windows.Forms.Label();
            this.valorLabel = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelarBtn
            // 
            this.cancelarBtn.Location = new System.Drawing.Point(233, 77);
            this.cancelarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelarBtn.Name = "cancelarBtn";
            this.cancelarBtn.Size = new System.Drawing.Size(118, 26);
            this.cancelarBtn.TabIndex = 20;
            this.cancelarBtn.Text = "Cancelar";
            this.cancelarBtn.UseVisualStyleBackColor = true;
            this.cancelarBtn.Click += new System.EventHandler(this.cancelarBtn_Click);
            // 
            // vencimentoBox
            // 
            this.vencimentoBox.Location = new System.Drawing.Point(307, 34);
            this.vencimentoBox.Margin = new System.Windows.Forms.Padding(2);
            this.vencimentoBox.Name = "vencimentoBox";
            this.vencimentoBox.Size = new System.Drawing.Size(128, 20);
            this.vencimentoBox.TabIndex = 19;
            this.vencimentoBox.TextChanged += new System.EventHandler(this.vencimentoBox_TextChanged);
            // 
            // valorBox
            // 
            this.valorBox.Location = new System.Drawing.Point(159, 34);
            this.valorBox.Margin = new System.Windows.Forms.Padding(2);
            this.valorBox.Name = "valorBox";
            this.valorBox.Size = new System.Drawing.Size(120, 20);
            this.valorBox.TabIndex = 18;
            this.valorBox.TextChanged += new System.EventHandler(this.valorBox_TextChanged);
            // 
            // nomeBox
            // 
            this.nomeBox.Location = new System.Drawing.Point(19, 34);
            this.nomeBox.Margin = new System.Windows.Forms.Padding(2);
            this.nomeBox.Name = "nomeBox";
            this.nomeBox.Size = new System.Drawing.Size(110, 20);
            this.nomeBox.TabIndex = 17;
            this.nomeBox.TextChanged += new System.EventHandler(this.nomeBox_TextChanged);
            // 
            // salvarBtn
            // 
            this.salvarBtn.Location = new System.Drawing.Point(103, 77);
            this.salvarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.salvarBtn.Name = "salvarBtn";
            this.salvarBtn.Size = new System.Drawing.Size(118, 26);
            this.salvarBtn.TabIndex = 16;
            this.salvarBtn.Text = "Salvar";
            this.salvarBtn.UseVisualStyleBackColor = true;
            this.salvarBtn.Click += new System.EventHandler(this.salvarBtn_Click);
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Location = new System.Drawing.Point(320, 13);
            this.dataLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(104, 13);
            this.dataLabel.TabIndex = 15;
            this.dataLabel.Text = "Data de Vencimento";
            // 
            // valorLabel
            // 
            this.valorLabel.AutoSize = true;
            this.valorLabel.Location = new System.Drawing.Point(201, 13);
            this.valorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valorLabel.Name = "valorLabel";
            this.valorLabel.Size = new System.Drawing.Size(31, 13);
            this.valorLabel.TabIndex = 14;
            this.valorLabel.Text = "Valor";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(52, 13);
            this.nomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(35, 13);
            this.nomeLabel.TabIndex = 13;
            this.nomeLabel.Text = "Nome";
            // 
            // FormEditarPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 124);
            this.Controls.Add(this.cancelarBtn);
            this.Controls.Add(this.vencimentoBox);
            this.Controls.Add(this.valorBox);
            this.Controls.Add(this.nomeBox);
            this.Controls.Add(this.salvarBtn);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.valorLabel);
            this.Controls.Add(this.nomeLabel);
            this.Name = "FormEditarPagamento";
            this.Text = "FormEditarPagamento";
            this.Load += new System.EventHandler(this.FormEditarPagamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelarBtn;
        private System.Windows.Forms.TextBox vencimentoBox;
        private System.Windows.Forms.TextBox valorBox;
        private System.Windows.Forms.TextBox nomeBox;
        private System.Windows.Forms.Button salvarBtn;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.Label valorLabel;
        private System.Windows.Forms.Label nomeLabel;
    }
}