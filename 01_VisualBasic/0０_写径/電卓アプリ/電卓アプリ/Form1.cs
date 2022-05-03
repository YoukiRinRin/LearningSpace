using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 電卓アプリ
{
    public partial class Form1 : Form
    {
        int Num1;
        int Num2;

        int Result;
        int Symbol;


        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Num_7_Click(object sender, EventArgs e)
        {
            Num1 = Num1 * 10;
            Num1 = Num1 + 7:

        }
    }
}
