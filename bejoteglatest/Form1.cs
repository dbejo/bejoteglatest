using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bejoteglatest
{
    public partial class FormTeglatest : Form
    {
        public FormTeglatest()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSzamol_Click(object sender, EventArgs e)
        {
            int a = Decimal.ToInt32(numAoldal.Value);
            int b = Decimal.ToInt32(numBoldal.Value);
            int c = Decimal.ToInt32(numColdal.Value);

            numTestatlo.Value = Convert.ToDecimal(Math.Sqrt(a ^ 2 + b ^ 2 + c ^ 2));
            numFelszin.Value = Convert.ToDecimal(2 * (a * b + b * c + a * c));
            numTerfogat.Value = Convert.ToDecimal(a * b * c);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 myNewForm = new Form2();
            myNewForm.Show();
            this.Hide();
        }
    }
}
