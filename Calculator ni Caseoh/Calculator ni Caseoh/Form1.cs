using System.Windows.Forms;

namespace Calculator_ni_Caseoh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CalTotal;
        double num1;
        double num2;
        string option;
        double result;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + btn0.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "3";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = double.Parse(txtTotal.Text);


            txtTotal.Text += " / ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "1";
        }
        private void btn2_Click_1(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "2";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + "9";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = double.Parse(txtTotal.Text);


            txtTotal.Text += " + ";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = double.Parse(txtTotal.Text);


            txtTotal.Text += " - ";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = double.Parse(txtTotal.Text);


            txtTotal.Text += " * ";
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            string[] parts = txtTotal.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            if (parts.Length == 3)
            {
                try
                {
                    num1 = double.Parse(parts[0]);
                    option = parts[1];
                    num2 = double.Parse(parts[2]);

                    switch (option)
                    {
                        case "+":
                            result = num1 + num2;
                            break;
                        case "-":
                            result = num1 - num2;
                            break;
                        case "*":
                            result = num1 * num2;
                            break;
                        case "/":
                            result = num1 / num2;
                            break;
                    }

                    txtTotal.Text = result.ToString();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Input string was not in a correct format. Please enter a valid expression.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid expression in the format 'num1 operator num2'.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + ".";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("What up.");
        }


        private void button18_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text.Length > 0)
            {
                txtTotal.Text = txtTotal.Text.Substring(0, txtTotal.Text.Length - 1);
            }
        }
    }
}
