using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0426
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            int a = 0;
            a = 5 / a;
            */

            aisatu.Text = "こんにちは";
            aisatu.Left = 0;
            aisatu.Visible = false;


            //あいさつ
            MessageBox. Show("こんにちは");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
