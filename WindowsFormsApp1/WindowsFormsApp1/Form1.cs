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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            personal prs42 = new personal(AdTxt.Text, AdresTxt.Text, Convert.ToInt32(YasTxt.Text), Convert.ToInt32(MesaıTxt.Text), comboBox1.Text);
            if(comboBox1.Text =="İşçi")


            {
                MessageBox.Show(prs42.ucrethesapla().ToString());

            }
            else
            {
                prs42.ucrethesapla(1000);
            }

        }
    }
}
