using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 勉強
{
    public partial class Form1 : Form
    {

        int count = 0;
        public Form1()
        {
            InitializeComponent();

            this.Width = 200;
            this.Height = 80;
            this.Text = "サンプルプログラム";

            this.button1 = new Button();

            this.button1.Location = new Point(10, 10);
            this.button1.Size = new Size(170, 30);
            this.button1.Text = "ここを推して";

            this.Controls.Add(this.button1);



        }

        private void button1_Click(object sender, EventArgs e)
        {

            //this.count++;
            //this.button1.Text = this.count.ToString();

            //string fileName = System.IO.Path.GetFileName(@"W:\01_Youki\Desktop\講座.txt");
            //string folderPath = System.IO.Path.GetDirectoryName(@"W:\01_Youki\Desktop\講座.txt");
            //string folderName = System.IO.Path.GetFileName(folderPath);
            //string fileName2 = System.IO.Path.GetFileNameWithoutExtension(@"W:\01_Youki\Desktop\講座.txt");
            //string extension = System.IO.Path.GetExtension(@"W:\01_Youki\Desktop\講座.txt");


            //MessageBox.Show(folderPath+fileName);
            //MessageBox.Show(fileName);
            //MessageBox.Show(folderName);
            //MessageBox.Show(fileName2);
            //MessageBox.Show(extension);

            //System.IO.Directory.CreateDirectory(@"W:\01_Youki\Desktop\勉強用");


            Form2 cForm2 = new Form2();
            cForm2.ShowDialog();

            cForm2.Dispose();

            

        }
    }
}
