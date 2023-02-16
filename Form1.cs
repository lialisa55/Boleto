using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boleto
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = double.Parse(txtvalor.Text);
                DateTime vencimento = Convert.ToDateTime(txtvencimento.Text);
                DateTime pagamento = Convert.ToDateTime(txtpagamento.Text);
                double multa = double.Parse(txtmulta.Text);
                double juros = double.Parse(txtjuros.Text);
                double desconto = double.Parse(txtdesconto.Text);
                int dias;
                double vmulta, vjuros, acrescimos, vdesconto, ftotal;

                if (pagamento > vencimento)
                {
                    dias = (pagamento - vencimento).Days;
                }
                else
                {
                    dias = 0;
                }
                txtatrasado.Text = dias.ToString();

                if (pagamento > vencimento)
                {
                    vmulta = (multa / 100) * valor;
                }
                else
                {
                    vmulta = 0;
                }
                txtvmulta.Text = vmulta.ToString("C");

                if (pagamento > vencimento)
                {
                    vjuros = (juros / 100) * valor * dias;
                }
                else
                {
                    vjuros = 0;
                }
                txtvjuros.Text = vjuros.ToString("C");

                acrescimos = vjuros + vmulta;
                txtacrescimos.Text = acrescimos.ToString("C");

                if (pagamento < vencimento)
                {
                    vdesconto = (desconto / 100) * valor * desconto;
                }
                else
                {
                    vdesconto = 0;
                }
                txtvdesconto.Text = vdesconto.ToString("C");

                ftotal = valor + acrescimos + vdesconto;
                total.Text = ftotal.ToString("C");
            }
            catch
            {
                MessageBox.Show("Informações incompletas ou em formato incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void apagar_Click(object sender, EventArgs e)
        {
            txtdesconto.Clear();
            txtatrasado.Clear();
            txtacrescimos.Clear();
            txtjuros.Clear();
            txtmulta.Clear();
            txtpagamento.Clear();
            txtvalor.Clear();
            txtvdesconto.Clear();
            txtvencimento.Clear();
            txtvjuros.Clear();
            txtvmulta.Clear();
            total.Clear();
            txtvalor.Focus();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
