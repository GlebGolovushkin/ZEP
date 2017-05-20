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
    public partial class DbUpdating : Form
    {
        ZEPEntities db = new ZEPEntities();

        public DbUpdating()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Document doc = new Document();
            doc.Document_Name = textBox1.Text;
            doc.Type = radioButton2.Checked ? 1 : 0;
            db.Document.Add(doc);
            db.SaveChanges();
            MessageBox.Show("Добавленно");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
