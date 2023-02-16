
namespace Boleto
{
    partial class form
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txtmulta = new System.Windows.Forms.TextBox();
            this.txtjuros = new System.Windows.Forms.TextBox();
            this.txtdesconto = new System.Windows.Forms.TextBox();
            this.txtatrasado = new System.Windows.Forms.TextBox();
            this.txtvmulta = new System.Windows.Forms.TextBox();
            this.txtvjuros = new System.Windows.Forms.TextBox();
            this.txtvdesconto = new System.Windows.Forms.TextBox();
            this.txtacrescimos = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.txtvencimento = new System.Windows.Forms.MaskedTextBox();
            this.txtpagamento = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.calcular = new System.Windows.Forms.Button();
            this.apagar = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(49, 75);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(100, 20);
            this.txtvalor.TabIndex = 0;
            // 
            // txtmulta
            // 
            this.txtmulta.Location = new System.Drawing.Point(49, 223);
            this.txtmulta.Name = "txtmulta";
            this.txtmulta.Size = new System.Drawing.Size(100, 20);
            this.txtmulta.TabIndex = 1;
            // 
            // txtjuros
            // 
            this.txtjuros.Location = new System.Drawing.Point(49, 274);
            this.txtjuros.Name = "txtjuros";
            this.txtjuros.Size = new System.Drawing.Size(100, 20);
            this.txtjuros.TabIndex = 2;
            // 
            // txtdesconto
            // 
            this.txtdesconto.Location = new System.Drawing.Point(49, 328);
            this.txtdesconto.Name = "txtdesconto";
            this.txtdesconto.Size = new System.Drawing.Size(100, 20);
            this.txtdesconto.TabIndex = 3;
            // 
            // txtatrasado
            // 
            this.txtatrasado.Location = new System.Drawing.Point(566, 75);
            this.txtatrasado.Name = "txtatrasado";
            this.txtatrasado.Size = new System.Drawing.Size(100, 20);
            this.txtatrasado.TabIndex = 4;
            // 
            // txtvmulta
            // 
            this.txtvmulta.Location = new System.Drawing.Point(566, 126);
            this.txtvmulta.Name = "txtvmulta";
            this.txtvmulta.Size = new System.Drawing.Size(100, 20);
            this.txtvmulta.TabIndex = 6;
            // 
            // txtvjuros
            // 
            this.txtvjuros.Location = new System.Drawing.Point(566, 174);
            this.txtvjuros.Name = "txtvjuros";
            this.txtvjuros.Size = new System.Drawing.Size(100, 20);
            this.txtvjuros.TabIndex = 8;
            // 
            // txtvdesconto
            // 
            this.txtvdesconto.Location = new System.Drawing.Point(566, 223);
            this.txtvdesconto.Name = "txtvdesconto";
            this.txtvdesconto.Size = new System.Drawing.Size(100, 20);
            this.txtvdesconto.TabIndex = 10;
            // 
            // txtacrescimos
            // 
            this.txtacrescimos.Location = new System.Drawing.Point(566, 274);
            this.txtacrescimos.Name = "txtacrescimos";
            this.txtacrescimos.Size = new System.Drawing.Size(100, 20);
            this.txtacrescimos.TabIndex = 12;
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(566, 328);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(100, 20);
            this.total.TabIndex = 14;
            // 
            // txtvencimento
            // 
            this.txtvencimento.Location = new System.Drawing.Point(49, 126);
            this.txtvencimento.Mask = "00/00/0000";
            this.txtvencimento.Name = "txtvencimento";
            this.txtvencimento.Size = new System.Drawing.Size(100, 20);
            this.txtvencimento.TabIndex = 15;
            this.txtvencimento.ValidatingType = typeof(System.DateTime);
            // 
            // txtpagamento
            // 
            this.txtpagamento.Location = new System.Drawing.Point(49, 174);
            this.txtpagamento.Mask = "00/00/0000";
            this.txtpagamento.Name = "txtpagamento";
            this.txtpagamento.Size = new System.Drawing.Size(100, 20);
            this.txtpagamento.TabIndex = 16;
            this.txtpagamento.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Vencimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Pagamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Multa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Juros";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Desconto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(563, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Dias atrasados";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(563, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Valor de multa";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(563, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Valor dos juros";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(563, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Valor dos descontos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(563, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Acrescimos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(563, 312);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Total";
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(333, 75);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(75, 23);
            this.calcular.TabIndex = 29;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // apagar
            // 
            this.apagar.Location = new System.Drawing.Point(333, 126);
            this.apagar.Name = "apagar";
            this.apagar.Size = new System.Drawing.Size(75, 23);
            this.apagar.TabIndex = 30;
            this.apagar.Text = "Apagar";
            this.apagar.UseVisualStyleBackColor = true;
            this.apagar.Click += new System.EventHandler(this.apagar_Click);
            // 
            // sair
            // 
            this.sair.Location = new System.Drawing.Point(333, 171);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(75, 23);
            this.sair.TabIndex = 31;
            this.sair.Text = "Sair";
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.apagar);
            this.Controls.Add(this.calcular);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpagamento);
            this.Controls.Add(this.txtvencimento);
            this.Controls.Add(this.total);
            this.Controls.Add(this.txtacrescimos);
            this.Controls.Add(this.txtvdesconto);
            this.Controls.Add(this.txtvjuros);
            this.Controls.Add(this.txtvmulta);
            this.Controls.Add(this.txtatrasado);
            this.Controls.Add(this.txtdesconto);
            this.Controls.Add(this.txtjuros);
            this.Controls.Add(this.txtmulta);
            this.Controls.Add(this.txtvalor);
            this.Name = "form";
            this.Text = "Desconto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txtmulta;
        private System.Windows.Forms.TextBox txtjuros;
        private System.Windows.Forms.TextBox txtdesconto;
        private System.Windows.Forms.TextBox txtatrasado;
        private System.Windows.Forms.TextBox txtvmulta;
        private System.Windows.Forms.TextBox txtvjuros;
        private System.Windows.Forms.TextBox txtvdesconto;
        private System.Windows.Forms.TextBox txtacrescimos;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.MaskedTextBox txtvencimento;
        private System.Windows.Forms.MaskedTextBox txtpagamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button calcular;
        private System.Windows.Forms.Button apagar;
        private System.Windows.Forms.Button sair;
    }
}

