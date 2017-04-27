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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "objectZEPDataSet1.Person". При необходимости она может быть перемещена или удалена.
            this.personTableAdapter.Fill(this.objectZEPDataSet1.Person);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ZepContext db = new ZepContext();
            var pr = db.Person.FirstOrDefault(p => p.Username == comboBox1.SelectedValue.ToString());
            db.Entry(pr).State=EntityState.Deleted;
            db.SaveChanges();
            MessageBox.Show("Пользователь удалён");
        }
    }
}
