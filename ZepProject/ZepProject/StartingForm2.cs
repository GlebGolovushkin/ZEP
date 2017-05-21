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
    public partial class StartingForm2 : Form
    {
        public StartingForm2()
        {
            InitializeComponent();
            foreach (var st in UserData.stations)
            {
                comboBox1.Items.Add(st);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //UserData.station = comboBox1.SelectedItem;
            var s = UserData.type;
            var ss = UserData.departments;
            Admin window = new Admin();
            window.ShowDialog();
        }
    }
}
