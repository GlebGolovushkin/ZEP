using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZEP
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "objectZEPDataSet.Person". При необходимости она может быть перемещена или удалена.
            this.personTableAdapter.Fill(this.objectZEPDataSet.Person);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ZepContext db = new ZepContext();
            var pr = db.Person.FirstOrDefault(p => p.Username == comboBox1.SelectedValue.ToString());
            if (textBox1.Text != "")
            {
                pr.Password = textBox1.Text;
                db.Entry(pr).State = EntityState.Modified;
                db.SaveChanges();
                MessageBox.Show("Пароль успешно изменён");
            }
            else
            {
                MessageBox.Show("Введите пароль");
            }

        }
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
