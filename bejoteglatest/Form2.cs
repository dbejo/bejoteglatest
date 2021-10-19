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
    public partial class Form2 : Form
    {
        int osszeg = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTeglatest myNewForm = new FormTeglatest();
            myNewForm.Show();
            this.Hide();
        }

        private void buttonSzamol_Click(object sender, EventArgs e)
        {
            if(textBxNszam.Text != String.Empty)
            {
                if (int.TryParse(textBxNszam.Text, out int n))
                {
                    if (n >= 1)
                    {
                        n = Convert.ToInt32(textBxNszam.Text);
                        for (int i = 1; i <= n; i++)
                        {
                            osszeg += i;
                            txtBxOsszeg.Text = osszeg.ToString();
                            lblNszamOsszeg.Text = "1-től " + n.ToString() + "-ig a számok összege";

                        }
                    }
                    else
                    {
                        MessageBox.Show("1-nél nagyobb számot adj meg!");
                    }
                }
                else
                {
                    MessageBox.Show("Egy számot írj be!");
                }
            }
            else
            {
                MessageBox.Show("Írj be egy számot!");
            }
            osszeg = 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
