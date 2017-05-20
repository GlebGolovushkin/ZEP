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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ZEPEntities db = new ZEPEntities();
            User user = db.User.FirstOrDefault(u => u.Login == textBox1.Text && u.Password == textBox2.Text);
            if (user != null)
            {
                DbUpdating window = new DbUpdating();
                window.ShowDialog();
            }
        }
    }
}
