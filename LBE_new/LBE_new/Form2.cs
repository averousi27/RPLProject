using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LBE_new
{
    public partial class Form2 : Form
    {
        public Form2(string welcomeText)
        {
            InitializeComponent();
            labelWelcome.Text = welcomeText;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5(labelWelcome.Text);
            f5.Show();
        }
    }
}
