using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZEP
{
    public partial class Form3 : Form
    {
        private ZepContext db = new ZepContext();
        public Form3()
        {
            InitializeComponent();
        }
        

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 frm4 = new Form5();
            frm4.ShowDialog();
        }
        

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form6 frm4 = new Form6();
            frm4.ShowDialog();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
