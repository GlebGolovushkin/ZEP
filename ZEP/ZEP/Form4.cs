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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            comboBox1.SelectedItem = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ZepContext db = new ZepContext();
            Person pr = new Person();
            pr.Username = textBox1.Text;
            pr.Password = textBox2.Text;
            try
            {
                pr.Role = Convert.ToInt32(comboBox1.SelectedIndex + 2);
                db.Person.Add(pr);
                db.SaveChanges();
                MessageBox.Show("Добавлен");
            }
            catch(Exception)
            {
                MessageBox.Show("Накосячил");
            }

        }
    }
}
