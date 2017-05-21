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
    public partial class DbUpdating3 : Form
    {

        ZEPEntities db = new ZEPEntities();

        public DbUpdating3()
        {
            InitializeComponent();
        }

        private void DbUpdating3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zEPDataSet11.Place". При необходимости она может быть перемещена или удалена.
            this.placeTableAdapter.Fill(this.zEPDataSet11.Place);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zEPDataSet10.Variation". При необходимости она может быть перемещена или удалена.
            this.variationTableAdapter.Fill(this.zEPDataSet10.Variation);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zEPDataSet9.Object_Library". При необходимости она может быть перемещена или удалена.
            this.object_LibraryTableAdapter.Fill(this.zEPDataSet9.Object_Library);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Object obj = new Object();
            obj.Object_Library_Id = db.Object_Library
                .FirstOrDefault(o => o.Object_Library_Name == comboBox1.SelectedValue).Object_Library_Id;
            obj.Place_Id = db.Place
                .FirstOrDefault(o => o.Place_Name == comboBox4.SelectedValue).Place_Id;
            obj.Amount = Convert.ToInt32(textBox1.Text);
            try
            {
                obj.Variaton_Id = db.Variation
                    .FirstOrDefault(o => o.Variation_Name == comboBox2.SelectedItem.ToString()).Variation_Id;
            }
            catch(Exception)
            { }

            Station_Object so = new Station_Object();
            so.Object_Id = obj.Object_Id;
            so.Station_Id = UserData.station;
            
            Department_Object dob = new Department_Object();
            dob.Department_Id = UserData.department;
            dob.Object_Id = obj.Object_Id;

            db.Department_Object.Add(dob);
            db.Station_Object.Add(so);
            db.Object.Add(obj);
            db.SaveChanges();

            MessageBox.Show("Добавлено");

        }

        private void SetVariations(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.SelectedValue != "")
            {
                foreach (var varObj in db.Variation_Object)
                {
                    try
                    {
                        if (varObj.Object_Id == db.Object_Library
                                .FirstOrDefault(o => o.Object_Library_Name == comboBox1.SelectedValue).Object_Library_Id)
                        {
                            comboBox2.Items.Add(db.Variation.FirstOrDefault(v => v.Variation_Id == varObj.Variation_Id).Variation_Name);
                        }
                    }
                    catch (Exception exception)
                    {
                    }
                }
            }

        }
    }
}
