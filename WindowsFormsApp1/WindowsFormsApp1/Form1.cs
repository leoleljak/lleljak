using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Govedo> popis = new List<Govedo>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string naziv = textBox1.Text;
            string boja = textBox2.Text;
            char spol = char.Parse(textBox3.Text);

            popis.Add(new Govedo(naziv, boja, spol));

            listBox1.Items.Clear();
            
            foreach (var item in popis)
            {
                listBox1.Items.Add(item.naziv + " " + item.boja + " " + item.spol);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string bojaGoveda = textBox4.Text;

            listBox1.Items.Clear();
            foreach (var item in popis)
            {
                if (item.boja == bojaGoveda)
                {
                    listBox1.Items.Add(item.naziv + " " + item.boja + " " + item.spol);
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string spolGoveda = textBox5.Text;

            listBox1.Items.Clear();
            foreach (var item in popis)
            {
                if (item.spol.ToString() == spolGoveda)
                {
                    listBox1.Items.Add(item.naziv + " " + item.boja + " " + item.spol);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var item in popis)
            {
                if (item.spol.ToString() == "m")
                {
                    listBox1.Items.Add(item.naziv + " " + item.boja + " " + item.spol);
                }
            }
            foreach (var item in popis)
            {
                if (item.spol.ToString() == "ž")
                {
                    listBox1.Items.Add(item.naziv + " " + item.boja + " " + item.spol);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            foreach (var item in popis)
            {
                listBox1.Items.Add(item.naziv + " " + item.boja + " " + item.spol);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var popis2 = popis.OrderBy(x => x.naziv);

            foreach (var item in popis2)
            {
                listBox1.Items.Add(item.naziv + " " + item.boja + " " + item.spol);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

            string bojaGoveda = textBox4.Text;
            string spolGoveda = textBox5.Text;

            listBox1.Items.Clear();
            foreach (var item in popis)
            {
                if (item.boja == bojaGoveda && item.spol.ToString() == spolGoveda)
                {
                    listBox1.Items.Add(item.naziv + " " + item.boja + " " + item.spol);
                }
                
            }

        }
    }
}
