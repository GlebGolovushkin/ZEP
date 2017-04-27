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
    public partial class Form1 : Form
    {
        private ZepContext db;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                db = new ZepContext();
                Person person = db.Person.FirstOrDefault(p => p.Username == textBox1.Text && p.Password == textBox2.Text);
                if (person == null)
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
                else
                {
                    this.Visible = false;
                    if (person.Role != 1)
                    {
                        Form2 form2 = new Form2(person);
                        form2.ShowDialog();
                    }
                    else
                    {
                        Form3 form3 = new Form3();
                        form3.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }
    }
}
