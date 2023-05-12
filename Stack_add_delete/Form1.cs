using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bahtyyar_yigin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Stack veri = new Stack();

        private void button2_Click(object sender, EventArgs e)
        {
                veri.Push(textBox1.Text);

                textBox1.Clear();

            listBox1.Items.Clear();

                foreach (object obj in veri)

                {

                listBox1.Items.Add(obj);

                }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
         textBox2.Text=veri.Pop().ToString();
        }
    }
}
    

