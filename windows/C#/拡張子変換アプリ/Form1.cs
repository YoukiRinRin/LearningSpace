using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 拡張子変換アプリ
{
    public partial class 拡張子変換アプリ : Form
    {
        public 拡張子変換アプリ()
        {
            InitializeComponent();
        }

        private void 拡張子変換アプリ_Load(object sender, EventArgs e)
        {
            dGV_except.RowCount = 20;
            dGV_Object.RowCount = 20;


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int[] path_henkou;
            int[] path_except;

            string bf_ex = tx_bf_ex.Text;
            string af_bf = tx_af_ex.Text;

            foreach(int row in dGV_Object.Rows)
            {
                path_Object[] = 
            }

            
            







        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
