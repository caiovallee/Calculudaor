using System.Globalization;

namespace Calculudaor
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0;
        string operecao = " ";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operecao = "subtracao";
            labelOperecao.Text = "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operecao = "multiplicacao";
            labelOperecao.Text = "*";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operecao = "soma";
            labelOperecao.Text = "+";
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {

            txtResultado.Text = txtResultado.Text + "0";


        }

        private void button10_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

            if (operecao == "soma")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operecao == "subtracao")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operecao == "multiplicacao")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);

            }
            else if (operecao == "divisao")
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }

        }

        private void button20_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operecao = "divisao";
            labelOperecao.Text = "/";
        }
    }
}