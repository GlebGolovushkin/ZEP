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
                UserData.type = (int) user.Type;
                UserData.departments.Clear();
                UserData.stations.Clear();
                foreach (var du in db.Department_User)
                {
                    if (du.User_Id == user.User_Id)
                    {
                        UserData.departments.Add(db.Department.FirstOrDefault(d => d.Department_Id == du.Deprtment_Id)
                            .Department_Name);
                        UserData.department = du.Deprtment_Id;
                    }
                }
                foreach (var su in db.Station_User)
                {
                    if (su.User_Id == user.User_Id)
                    {
                        UserData.stations.Add(
                            db.Station.FirstOrDefault(d => d.Station_Id == su.Station_id).Station_Name);
                        UserData.station = su.Station_id;
                    }
                }
                this.Visible = false;
                Main window = new Main();
                window.ShowDialog();
            }
        }
    }
}
