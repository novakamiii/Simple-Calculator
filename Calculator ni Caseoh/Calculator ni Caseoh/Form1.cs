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
            try
            {
                option = "/";
                num1 = double.Parse(txtTotal.Text);


                txtTotal.Text += " / ";
            }
            catch (FormatException)
            {
                MessageBox.Show("Input a number first!/Only use two variables!", "Division", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            try
            {
                option = "+";
                num1 = double.Parse(txtTotal.Text);


                txtTotal.Text += " + ";
            }
            catch (FormatException)
            {
                MessageBox.Show("Input a number first!/Only use two variables!", "Addition", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            try
            {
                option = "-";
                num1 = double.Parse(txtTotal.Text);


                txtTotal.Text += " - ";
            }
            catch (FormatException)
            {
                MessageBox.Show("Input a number first!/Only use two variables!", "Subtraction", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                option = "*";
                num1 = double.Parse(txtTotal.Text);


                txtTotal.Text += " * ";
            }
            catch (FormatException)
            {
                MessageBox.Show("Input a number first!/Only use two variables!", "Multiplication", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = double.Parse(txtTotal.Text);
                option = "sqrt";
                txtTotal.Text = "sqrt " + num1.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Input a number first!/Only use one variable!", "Square Root", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnEquals_Click(object sender, EventArgs e)
        {
            string input = txtTotal.Text.Trim();
            string[] parts = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            try
            {
                if (parts.Length == 3)
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
                            if (num2 != 0)
                            {
                                result = num1 / num2;
                            }
                            else
                            {
                                MessageBox.Show("Cannot Divide by Zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            break;
                        default:
                            MessageBox.Show("Invalid operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }
                }
                else if (parts.Length == 2)
                {
                    // square root
                    option = parts[0];
                    num1 = double.Parse(parts[1]);

                    switch (option.ToLower())
                    {
                        case "sqrt":
                            result = Math.Sqrt(num1);
                            break;
                        case "square":
                            result = num1 * num1;
                            break;
                        default:
                            MessageBox.Show("Invalid operation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid expression.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                txtTotal.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtTotal.Text = txtTotal.Text + ".";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("aye", "Members", MessageBoxButtons.OK, MessageBoxIcon.Question);

            //sound
            string soundFilePath = @"C:\Users\novakami\source\repos\Calculator ni Caseoh\Calculator ni Caseoh\res\monkey.wav";
            using (var soundPlayer = new System.Media.SoundPlayer(soundFilePath))
            {
                soundPlayer.Play();
            }

            //image
            image pictureForm = new image();
            pictureForm.Show();
        }


        private void button18_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text.Length > 0)
            {
                txtTotal.Text = txtTotal.Text.Substring(0, txtTotal.Text.Length - 1);
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
