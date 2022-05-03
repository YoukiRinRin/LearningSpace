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
            label1.Text = "入力された文字は"+textBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("りんご");
            listBox1.Items.Add("バナナ");
            listBox1.Items.Add("いちご");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked){
                label1.Text = "チェックボックスがチェックされました";
                }
            else
            {
                label1.Text = "チェックボックスからチェックが外れました";
            }

        }
    }
}
