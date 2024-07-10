using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_ni_Caseoh
{
    public partial class image : Form
    {
        public image()
        {
            InitializeComponent();
            string imagePath = @"C:\Users\novakami\source\repos\Calculator ni Caseoh\Calculator ni Caseoh\res\monkey-meme.gif";
            if (File.Exists(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show("Image file not found: " + imagePath);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
