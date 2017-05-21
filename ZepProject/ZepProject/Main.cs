using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZepProject
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void элементыВСправочникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DbUpdating window = new DbUpdating();
            window.ShowDialog();

        }

        private void объектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DbUpdating3 window = new DbUpdating3();
            window.ShowDialog();

        }

        private void параметрыДляОбъектаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DbUpdating2 window = new DbUpdating2();
            window.ShowDialog();

        }

        private void пользователейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin window = new Admin();
            window.ShowDialog();

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
