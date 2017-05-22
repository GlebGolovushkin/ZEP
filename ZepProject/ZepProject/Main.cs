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
    public partial class Main : Form
    {

        ZEPEntities db = new ZEPEntities();

        public Main()
        {
            InitializeComponent();
            dataGridView1.RowCount = 100;
            dataGridView2.RowCount = 100;
        }

        private void элементыВСправочникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DbUpdating window = new DbUpdating();
            window.ShowDialog();

        }

        private void объектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DbUpdating3 window = new DbUpdating3();
            window.ShowDialog();

        }

        private void параметрыДляОбъектаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DbUpdating2 window = new DbUpdating2();
            window.ShowDialog();

        }

        private void пользователейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin window = new Admin();
            window.ShowDialog();

        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zEPDataSet19.Object_Library". При необходимости она может быть перемещена или удалена.
            this.object_LibraryTableAdapter1.Fill(this.zEPDataSet19.Object_Library);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "zEPDataSet18.Object_Library". При необходимости она может быть перемещена или удалена.
            this.object_LibraryTableAdapter.Fill(this.zEPDataSet18.Object_Library);
            foreach (var station in UserData.stations)
            {
                Station s = db.Station.FirstOrDefault(sta => sta.Station_Name == station);
                TreeNode st = new TreeNode(station);
                treeView1.Nodes.Add(st);
                foreach (var so in db.Station_Object)
                {
                    if (so.Station_Id == s.Station_Id)
                    {
                        if (!(db.Object_Library
                                  .FirstOrDefault(ol => ol.Object_Library_Id ==
                                                        db.Object.FirstOrDefault(o => o.Object_Id == so.Object_Id)
                                                            .Object_Library_Id).Parent_Object_Id > 0))
                        {
                            TreeNode t = new TreeNode(db.Object_Library
                                .FirstOrDefault(ol => ol.Object_Library_Id ==
                                                      db.Object.FirstOrDefault(o => o.Object_Id == so.Object_Id)
                                                          .Object_Library_Id).Object_Library_Name);
                            st.Nodes.Add(t);
                            SetTree(t);
                            DeleteTree(t, station);
                        }
                    }
                }
            }
        }

        private void SetTree(TreeNode t)
        {
            foreach (var o in db.Object_Library)
            {
                if (o.Parent_Object_Id > 0)
                {
                    if (o.Parent_Object_Id == db.Object_Library.FirstOrDefault(ol => ol.Object_Library_Name == t.Text)
                            .Object_Library_Id)
                    {
                        TreeNode tr = new TreeNode(o.Object_Library_Name);
                        t.Nodes.Add(tr);
                        SetTree(tr);
                    }
                }
            }
        }

        private void DeleteTree(TreeNode t, string stationName)
        {
            if (t.Nodes.Count > 0)
            {
                for (int i = 0; i < t.Nodes.Count; i++)
                {
                    DeleteTree(t.Nodes[i], stationName);
                }
            }
            if (t.Nodes.Count > 0)
                return;
            else
            {
                foreach (var so in db.Station_Object)
                {
                    if (so.Station_Id == db.Station.FirstOrDefault(st => st.Station_Name == stationName).Station_Id)
                    {
                        if (db.Object_Library
                                .FirstOrDefault(ol => ol.Object_Library_Id ==
                                                      db.Object.FirstOrDefault(o => o.Object_Id == so.Object_Id)
                                                          .Object_Library_Id).Object_Library_Name == t.Text)
                        {
                            return;
                        }
                    }
                }
                t.Remove();
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            for (int j = 0; j < dataGridView1.RowCount; j++)
            {
                for (int k = 0; k < dataGridView1.ColumnCount; k++)
                {
                    dataGridView1.Rows[j].Cells[k].Value = "";
                }
            }
            for (int j = 0; j < dataGridView2.RowCount; j++)
            {
                for (int k = 0; k < dataGridView2.ColumnCount; k++)
                {
                    dataGridView2.Rows[j].Cells[k].Value = "";
                }
            }
            SetObjects();
            int i = 0;
            foreach (var station in UserData.stations)
            {
                try
                {
                    Object obj =  db.Object.FirstOrDefault(o => o.Object_Library_Id == db.Object_Library.FirstOrDefault(ol => ol.Object_Library_Name == treeView1.SelectedNode.Text).Object_Library_Id && db.Station_Object.Any(s => s.Station_Id == db.Station.FirstOrDefault(st => st.Station_Name == station).Station_Id && s.Object_Id == o.Object_Id));

                    foreach (var od in db.Object_Document)
                    {
                        if (od.Object_Id == obj.Object_Id)
                        {
                            foreach (var odp in db.Object_Document_Parameter)
                            {
                                if (odp.Object_Document_Id == od.Object_Document_Id)
                                {
                                    dataGridView1.Rows[i].Cells[2].Value =
                                        db.Parameter.FirstOrDefault(p => p.Parameter_Id == odp.Parameter_Id)
                                            .Parameter_Name;
                                    dataGridView1.Rows[i].Cells[3].Value = odp.Type;
                                    dataGridView1.Rows[i].Cells[1].Value =
                                        db.Specialty
                                            .FirstOrDefault(
                                                s => s.Specialty_Id ==
                                                     db.Document_Specialty
                                                         .FirstOrDefault(
                                                             ds => ds.Document_Specialty_Id == od.Document_Specialty_Id)
                                                         .Specialty_Id).Specialty_Name;
                                    dataGridView1.Rows[i].Cells[0].Value =
                                        db.Document
                                            .FirstOrDefault(
                                                s => s.Document_Id ==
                                                     db.Document_Specialty
                                                         .FirstOrDefault(
                                                             ds => ds.Document_Specialty_Id == od.Document_Specialty_Id)
                                                         .Document_Id).Document_Name;
                                    i++;
                                }
                            }
                        }
                    }
                }
                catch (Exception exception)
                {
                }
            }
        }

        private void SetObjects()
        {
            string stat;
            try
            {
                stat = treeView1.SelectedNode.FullPath.Substring(0, treeView1.SelectedNode.FullPath.IndexOf(@"\"));
            }
            catch (Exception e)
            {
                stat = treeView1.SelectedNode.Text;
            }

            int i = 0;
            foreach (var oo in db.Object_Object)
            {
                try
                {
                    dataGridView2.Rows[i].Cells[0].Value = db.Object_Library
                        .FirstOrDefault(
                            ol => db.Object.FirstOrDefault(
                                          o => oo.Out_Object_Id == o.Object_Id &&
                                               db.Station_Object.Any(so => so.Station_Id == db.Station.FirstOrDefault(st => st.Station_Name == stat).Station_Id &&
                                                                           so.Object_Id == o.Object_Id))
                                      .Object_Library_Id ==
                                  ol.Object_Library_Id).Object_Library_Name;
                    dataGridView2.Rows[i].Cells[1].Value = db.Object_Library
                        .FirstOrDefault(
                            ol => db.Object.FirstOrDefault(
                                          o => oo.In_Object_Id == o.Object_Id &&
                                               db.Station_Object.Any(so => so.Station_Id == db.Station.FirstOrDefault(st => st.Station_Name == stat).Station_Id &&
                                                                           so.Object_Id == o.Object_Id))
                                      .Object_Library_Id ==
                                  ol.Object_Library_Id).Object_Library_Name;
                    i++;
                }
                catch (Exception e)
                { }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stat;
            try
            {
                stat = treeView1.SelectedNode.FullPath.Substring(0, treeView1.SelectedNode.FullPath.IndexOf(@"\"));
            }
            catch (Exception ex)
            {
                stat = treeView1.SelectedNode.Text;
            }
            try
            {
                Object_Object oo = new Object_Object();
                oo.Out_Object_Id = db.Object.FirstOrDefault(o => o.Object_Library_Id == db.Object_Library
                                                                     .FirstOrDefault(ol => ol.Object_Library_Name == comboBox1.SelectedValue.ToString()).Object_Library_Id && db.Station_Object.Any(so => so.Station_Id == db.Station.FirstOrDefault(st => st.Station_Name == stat).Station_Id &&
                                                                                                                                                                                                          so.Object_Id == o.Object_Id)).Object_Id;
                oo.In_Object_Id = db.Object.FirstOrDefault(o => o.Object_Library_Id == db.Object_Library
                                                                     .FirstOrDefault(ol => ol.Object_Library_Name == comboBox2.SelectedValue.ToString()).Object_Library_Id && db.Station_Object.Any(so => so.Station_Id == db.Station.FirstOrDefault(st => st.Station_Name == stat).Station_Id &&
                                                                                                                                                                                                          so.Object_Id == o.Object_Id)).Object_Id;
                db.Object_Object.Add((oo));
                db.SaveChanges();
                MessageBox.Show("Добавлено");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Ошибка");
            }
        }
    }
}
