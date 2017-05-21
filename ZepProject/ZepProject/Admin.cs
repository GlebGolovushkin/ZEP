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
    public partial class Admin : Form
    {
        ZEPEntities db = new ZEPEntities();

        private int count = 0;

        public Admin()
        {
            InitializeComponent();
            dataGridView1.RowCount = 100;
            radioButton1.Checked = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.Login = textBox1.Text;
            u.Password = textBox2.Text;
            if (radioButton1.Checked)
                u.Type = 4;
            else if (radioButton3.Checked)
                u.Type = 3;
            else if (radioButton2.Checked)
                u.Type = 2;
            else u.Type = 1;
            db.User.Add(u);
            Department_User d = new Department_User();
            d.User_Id = u.User_Id;
            d.Deprtment_Id = db.Department.FirstOrDefault(de => de.Department_Name == comboBox1.SelectedValue)
                .Department_Id;
            db.Department_User.Add(d);
            for(int i=0;i<count;i++)
            {
                Station_User su = new Station_User();
                string s = dataGridView1.Rows[i].Cells[0].Value.ToString();
                su.Station_id = db.Station
                    .FirstOrDefault(st => st.Station_Name == s).Station_Id;
                su.User_Id = u.User_Id;
                db.Station_User.Add(su);
            }
            db.SaveChanges();
            MessageBox.Show("Добавлено");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows[count].Cells[0].Value = comboBox5.Text;
            count++;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zEPDataSet13.Department". При необходимости она может быть перемещена или удалена.
            this.departmentTableAdapter.Fill(this.zEPDataSet13.Department);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zEPDataSet12.Station". При необходимости она может быть перемещена или удалена.
            this.stationTableAdapter.Fill(this.zEPDataSet12.Station);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
