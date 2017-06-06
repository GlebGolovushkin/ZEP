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
    public partial class DbUpdating2 : Form
    {
        ZEPEntities db = new ZEPEntities();

        public DbUpdating2()
        {
            InitializeComponent();
            //foreach (var obj in db.Object)
            //{

            //    string name = obj.Variaton_Id != null
            //        ? db.Object_Library.FirstOrDefault(o => o.Object_Library_Id == obj.Object_Library_Id).Object_Library_Name : db.Variation.FirstOrDefault(o => o.Variation_Id == obj.Variaton_Id).Variation_Name;
            //    comboBox2.Items.Add(name);
            //}

            dataGridView1.RowCount = 100;
            dataGridView4.RowCount = 100;
            foreach (var sta in UserData.stations)
            {
                comboBox7.Items.Add(sta);
            }
            SetObjects();
            FillParams();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Object_Document od = new Object_Document();
            od.Document_Specialty_Id = db.Document_Specialty
                .FirstOrDefault(
                    ds => ds.Specialty_Id == db.Specialty
                              .FirstOrDefault(s => s.Specialty_Name == comboBox4.SelectedItem.ToString())
                              .Specialty_Id && ds.Document_Id ==
                          db.Document.FirstOrDefault(d => d.Document_Name == comboBox1.SelectedValue.ToString())
                              .Document_Id).Document_Specialty_Id;
            od.Object_Id = db.Object.FirstOrDefault(o => o.Variaton_Id == null
                ? db.Object_Library.FirstOrDefault(ol => ol.Object_Library_Name == comboBox2.SelectedItem.ToString())
                      .Object_Library_Id == o.Object_Library_Id
                : db.Variation.FirstOrDefault(ol => ol.Variation_Name == comboBox2.SelectedItem.ToString())
                      .Variation_Id == o.Variaton_Id).Object_Id;
            Object_Document_Parameter odp = new Object_Document_Parameter();
            odp.Object_Document_Id = od.Object_Document_Id;
            odp.Parameter_Id = db.Parameter.FirstOrDefault(p => p.Parameter_Name == comboBox3.SelectedValue.ToString())
                .Parameter_Id;
            odp.Type = radioButton1.Checked ? 0 : radioButton2.Checked ? 1 : 2;
            db.Object_Document_Parameter.Add(odp);
            db.Object_Document.Add(od);
            db.SaveChanges();
            MessageBox.Show("Добавлено");
        }

        private void DbUpdating2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zEPDataSet25.Parameter". При необходимости она может быть перемещена или удалена.
            this.parameterTableAdapter2.Fill(this.zEPDataSet25.Parameter);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zEPDataSet24.Parameter". При необходимости она может быть перемещена или удалена.
            this.parameterTableAdapter1.Fill(this.zEPDataSet24.Parameter);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zEPDataSet17.Document". При необходимости она может быть перемещена или удалена.
            this.documentTableAdapter2.Fill(this.zEPDataSet17.Document);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zEPDataSet16.Specialty". При необходимости она может быть перемещена или удалена.
            this.specialtyTableAdapter2.Fill(this.zEPDataSet16.Specialty);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zEPDataSet15.Specialty". При необходимости она может быть перемещена или удалена.
            this.specialtyTableAdapter1.Fill(this.zEPDataSet15.Specialty);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zEPDataSet14.Document". При необходимости она может быть перемещена или удалена.
            this.documentTableAdapter1.Fill(this.zEPDataSet14.Document);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zEPDataSet8.Parameter". При необходимости она может быть перемещена или удалена.
            this.parameterTableAdapter.Fill(this.zEPDataSet8.Parameter);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zEPDataSet7.Object_Library". При необходимости она может быть перемещена или удалена.
            this.object_LibraryTableAdapter1.Fill(this.zEPDataSet7.Object_Library);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zEPDataSet6.Document". При необходимости она может быть перемещена или удалена.
            this.documentTableAdapter.Fill(this.zEPDataSet6.Document);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zEPDataSet5.Specialty". При необходимости она может быть перемещена или удалена.
            this.specialtyTableAdapter.Fill(this.zEPDataSet5.Specialty);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zEPDataSet4.Object_Library". При необходимости она может быть перемещена или удалена.
            this.object_LibraryTableAdapter.Fill(this.zEPDataSet4.Object_Library);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Document_Specialty ds = new Document_Specialty();
            ds.Document_Id = db.Document.FirstOrDefault(d => d.Document_Name == comboBox6.SelectedValue)
                .Document_Id;
            ds.Specialty_Id = db.Specialty.FirstOrDefault(d => d.Specialty_Name == comboBox5.SelectedValue)
                .Specialty_Id;
            db.Document_Specialty.Add(ds);
            db.SaveChanges();
            MessageBox.Show("Добавлено");
            SetData(sender, e);
        }

        private void SetData2(object sender, EventArgs e)
        {
            comboBox4.Items.Clear();
            int count = 0;
            foreach (var ds in db.Document_Specialty)
            {
                if (ds.Document_Id == db.Document.FirstOrDefault(d => d.Document_Name == comboBox1.SelectedValue).Document_Id)
                {
                    comboBox4.Items.Add(ds.Specialty.Specialty_Name);
                }
            }
        }

        private void SetData(object sender, EventArgs e)
        {
            if (comboBox6.SelectedValue.ToString().Length > 0)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = "";
                }
                int count = 0;
                foreach (var ds in db.Document_Specialty)
                {
                    if (ds.Document_Id == db.Document.FirstOrDefault(d => d.Document_Name == comboBox6.SelectedValue)
                            .Document_Id)
                    {
                        dataGridView1.Rows[count].Cells[0].Value = db.Specialty.FirstOrDefault(s => s.Specialty_Id == ds.Specialty_Id).Specialty_Name;
                        count++;
                    }
                }
            }
        }

        private void SetObjects()
        {
            comboBox2.Items.Clear();
            foreach (var obj in db.Object)
            {
                foreach (var dob in db.Department_Object)
                {
                    if (dob.Object_Id == obj.Object_Id && dob.Department_Id == UserData.department)
                        foreach (var so in db.Station_Object)
                        {
                            if (so.Object_Id == obj.Object_Id && so.Station_Id == UserData.station)
                            {
                                if (!(obj.Variaton_Id>0))
                                {
                                    comboBox2.Items.Add(db.Object_Library
                                        .FirstOrDefault(ol => ol.Object_Library_Id == obj.Object_Library_Id)
                                        .Object_Library_Name);
                                }
                                else
                                    comboBox2.Items.Add(db.Variation
                                   .FirstOrDefault(ol => ol.Variation_Id == obj.Variaton_Id)
                                   .Variation_Name);
                            }
                        }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string par;
            par = dataGridView2.SelectedCells[0].Value.ToString();
            Parameter_Parameter pp = new Parameter_Parameter();
            pp.Parameter_First = db.Parameter.FirstOrDefault(p => p.Parameter_Name == par).Parameter_Id;
            par = dataGridView3.SelectedCells[0].Value.ToString();
            pp.Parameter_Second = db.Parameter.FirstOrDefault(p => p.Parameter_Name == par).Parameter_Id;
            db.Parameter_Parameter.Add(pp);
            db.SaveChanges();
            MessageBox.Show("Добавлено");
            FillParams();
        }

        private void FillParams()
        {
            int i = 0;
            foreach (var pp in db.Parameter_Parameter)
            {
                dataGridView4.Rows[i].Cells[1].Value = db.Parameter
                    .FirstOrDefault(p => p.Parameter_Id == pp.Parameter_First).Parameter_Name;
                dataGridView4.Rows[i].Cells[0].Value = db.Parameter
                    .FirstOrDefault(p => p.Parameter_Id == pp.Parameter_Second).Parameter_Name;
                i++;
            }
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserData.station = db.Station.FirstOrDefault(s => s.Station_Name == comboBox7.SelectedItem.ToString())
                .Station_Id;
            SetObjects();
        }
    }
}
