using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ああ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dtToday = DateTime.Today;
            MessageBox.Show(dtToday.ToString());

            DateTime dtNow = DateTime.Now;
            MessageBox.Show(dtNow.ToString());

            DateTime dtUtcNow = DateTime.UtcNow;
            MessageBox.Show(dtUtcNow.ToString());

            string stPrompt1 = dtNow.ToString();

            //int num, sum = 0, r;
            //Console.WriteLine("Enter a Number:");

            //while (num != 0)
            //{

            //    r = num % 10;
            //    num = num / 10;
            //    sum = sum + r;
            //}
            //Console.WriteLine("Sum of Digits of the Number;" + sum);
            //Console.ReadLine();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime sd = new DateTime(2010, 10, 12);
            Console.WriteLine("Starting Date:{0}", sd);
            DateTime ed = sd.AddDays(10);
            Console.WriteLine("Ending Date:{1}", sd, ed);
            if(sd < ed)
            {
                Console.WriteLine("{0} Occurs Befor{1}", sd, ed);
   
            }
            Console.Read();
            Console.Read();
            Console.Read();




        }

        private void button3_Click(object sender, EventArgs e)
        {

            string[] arr = {"aaa.txt","bbb.txt","xyz.abc.pdf","aaaa.PDF",
                                "abc.xml","ccc.txt","zzz.txt"};

            var egrp = arr.Select(file => Path.GetExtention(file).TrimStart('.').ToLower().GroupBy(x => x, (ext, extCnt))=>new
            {
                Extension = ext,
                Count = extCnt.Count()
            });

            foreatch(var v in egrp)


        }
    }
}
