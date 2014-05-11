using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3._2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Akceptuj(object sender, EventArgs e)
        {
            string temp = string.Format("{0}\n{1}\n{2}",textBox1.Text, textBox2.Text,comboBox1.Text);
            if (checkBox1.Checked){

                temp = string.Format("{0}\n{1}", temp, checkBox1.Text);
            }
            if (checkBox2.Checked){
                temp = string.Format("{0} {1}", temp, checkBox2.Text);
            }
            MessageBox.Show(temp, "Uczelnia");

        }

        private void exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
