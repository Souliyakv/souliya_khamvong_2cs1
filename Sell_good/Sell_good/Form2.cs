using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sell_good
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 _form1 = new Form1();
            _form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 _form3 = new Form3();
            _form3.Show();


        }
    }
}
