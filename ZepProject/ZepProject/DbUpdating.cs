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
            MessageBox.Show("Добавлено");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Specialty spec = new Specialty();
            spec.Specialty_Name = textBox9.Text;
            spec.Specialty_Code = textBox7.Text;
            db.Specialty.Add(spec);
            db.SaveChanges();
            MessageBox.Show("Добавлено");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Parameter par = new Parameter();
            par.Parameter_Name = textBox8.Text;
            db.Parameter.Add(par);
            db.SaveChanges();
            MessageBox.Show("Добавлено");

        }

        private void DbUpdating_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zEPDataSet3.Object_Library". При необходимости она может быть перемещена или удалена.
            this.object_LibraryTableAdapter2.Fill(this.zEPDataSet3.Object_Library);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zEPDataSet2.Place". При необходимости она может быть перемещена или удалена.
            this.placeTableAdapter.Fill(this.zEPDataSet2.Place);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zEPDataSet1.Object_Library". При необходимости она может быть перемещена или удалена.
            this.object_LibraryTableAdapter1.Fill(this.zEPDataSet1.Object_Library);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zEPDataSet.Object_Library". При необходимости она может быть перемещена или удалена.
            this.object_LibraryTableAdapter.Fill(this.zEPDataSet.Object_Library);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Object_Library obj = new Object_Library();
            obj.Object_Library_Name= textBox6.Text;
            obj.Object_KKS= textBox5.Text;
            try
            {
                obj.Parent_Object_Id = db.Object_Library
                    .FirstOrDefault(o => o.Object_Library_Name == comboBox2.SelectedValue.ToString()).Object_Library_Id;
            }
            catch (Exception)
            { }
            db.Object_Library.Add(obj);
            db.SaveChanges();
            MessageBox.Show("Добавлено");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Place place = new Place();
            place.Place_Name = textBox2.Text;
            place.Place_KKS = textBox3.Text;
            try
            {
                place.Parent_Place_Id = db.Place
                    .FirstOrDefault(o => o.Place_Name == comboBox2.SelectedValue.ToString()).Place_Id;
            }
            catch(Exception)
            { }
            db.Place.Add(place);
            db.SaveChanges();
            MessageBox.Show("Добавлено");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Variation var = new Variation();
            var.Variation_Name = textBox4.Text;
            Variation_Object vo = new Variation_Object();
                vo.Object_Id = db.Object_Library
                    .FirstOrDefault(o => o.Object_Library_Name == comboBox4.SelectedValue.ToString()).Object_Library_Id;
            vo.Variation_Id = var.Variation_Id;
            db.Variation.Add(var);
            db.Variation_Object.Add(vo);
            db.SaveChanges();
            MessageBox.Show("Добавлено");

        }
    }
}
