using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace markoGalavićPolugodišnji
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PrezimetextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OibtextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SpoltextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Unesibutton_Click(object sender, EventArgs e)
        {
            Osoba osoba = new Osoba();

            osoba.setime(ImetextBox1);
            osoba.setprezime(prezime);
            osoba.setoib();
            osoba.setspol();

        }

        private void Ispisibutton_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.Text()
        }

        private void ImetextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
