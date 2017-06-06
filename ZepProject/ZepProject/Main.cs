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
            SetObjects();
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
                                    dataGridView1.Rows[i].Cells[3].Value = odp.Type == 0? "Входной" : odp.Type==1? "Рассчётный" : "Выходной";
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
                    string path = treeView1.SelectedNode.FullPath;
                    string[] nodes = path.Split((char)92);
                    string nam = treeView1.SelectedNode.Text;
                    label4.Text = "";
                    string q = nodes[0].ToString();
                    if (UserData.station != db.Station.FirstOrDefault(s => s.Station_Name == q).Station_Id)
                    {
                        UserData.station = db.Station.FirstOrDefault(s => s.Station_Name == q).Station_Id;
                        SetObjects();
                        foreach (TreeNode node in treeView1.Nodes)
                        {
                            TreeColor(node, q);
                        }
                    }
                    try
                    {

                        label4.Text += db.Station.FirstOrDefault(s => s.Station_Id == UserData.station).Station_KKS.ToString().Substring(0, db.Station.FirstOrDefault(s => s.Station_Id == UserData.station).Station_KKS.ToString().IndexOf(' '));
                        label4.Text += " ";
                        label4.Text+=db.Object.FirstOrDefault(o => o.Object_Library_Id == db.Object_Library.FirstOrDefault(ol => ol.Object_Library_Name == nam).Object_Library_Id && db.Station_Object.Any(so => so.Object_Id==o.Object_Id && so.Station_Id == UserData.station)).Amount;
                    }
                    catch(Exception ew)
                    { }
                    string name;
                    for (int j = 1; j < nodes.Length; j++)
                    {
                        name = nodes[j].ToString();
                        label4.Text += db.Object_Library.FirstOrDefault(o => o.Object_Library_Name == name)
                            .Object_KKS[0];
                    }
                }
                catch (Exception exception)
                {
                }
            }
            
        }

        private void SetObjects()
        {
            for (int j = 0; j < dataGridView2.RowCount; j++)
            {
                for (int k = 0; k < dataGridView2.ColumnCount; k++)
                {
                    dataGridView2.Rows[j].Cells[k].Value = "";
                }
            }
            int i = 0;
            foreach (var odp1 in db.Object_Document_Parameter)
            {
                foreach (var odp2 in db.Object_Document_Parameter)
                {
                    if (odp2.Parameter_Id == odp1.Parameter_Id)
                    {
                        string first = db.Object_Library
                            .First(ol => ol.Object_Library_Id ==
                                         db.Object.FirstOrDefault(o => o.Object_Id == db.Object_Document
                                                                           .FirstOrDefault(
                                                                               od => od.Object_Document_Id == odp1
                                                                                         .Object_Document_Id).Object_Id)
                                             .Object_Library_Id).Object_Library_Name;
                        string second = db.Object_Library
                            .First(ol => ol.Object_Library_Id ==
                                         db.Object.FirstOrDefault(o => o.Object_Id == db.Object_Document
                                                                           .FirstOrDefault(
                                                                               od => od.Object_Document_Id == odp2
                                                                                         .Object_Document_Id).Object_Id)
                                             .Object_Library_Id).Object_Library_Name;
                        
                        if (db.Station_Object.FirstOrDefault(so => so.Station_Id == UserData.station && so.Object_Id == odp1.Object_Document.Object.Object_Id)!=null && db.Station_Object.FirstOrDefault(so => so.Station_Id == UserData.station && so.Object_Id == odp2.Object_Document.Object.Object_Id)!=null)
                        { 
                            if (odp1.Type == 0 && odp2.Type == 2 && second != first)
                        {
                            for (int j = 0; j <= i; j++)
                            {
                                if ((string) dataGridView2.Rows[j].Cells[0].Value == second &&
                                    (string) dataGridView2.Rows[j].Cells[1].Value == first)
                                {
                                    break;
                                }
                                if (j == i)
                                {
                                    dataGridView2.Rows[i].Cells[0].Value = second;
                                    dataGridView2.Rows[i].Cells[1].Value = first;
                                    i++;
                                    break;
                                }
                            }
                        }
                            if (odp1.Type == 2 && odp2.Type == 0)
                            {
                                for (int j = 0; j <= i; j++)
                                {
                                    if ((string) dataGridView2.Rows[j].Cells[0].Value == first &&
                                        (string) dataGridView2.Rows[j].Cells[1].Value == second)
                                    {
                                        break;
                                    }
                                    if (j == i)
                                    {
                                        dataGridView2.Rows[i].Cells[0].Value = first;
                                        dataGridView2.Rows[i].Cells[1].Value = second;
                                        i++;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
                try
                {
                }
                catch (Exception e)
                { }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void TreeColor(TreeNode node, string q)
        {
            if (node.Nodes.Count > 0)
            {
                foreach (TreeNode nod in node.Nodes)
                {
                    TreeColor(nod,q);
                }
            }
            if (node.FullPath.Split((char)92)[0] == q)
            {
                bool exis = false;
                for (int j = 0; j < dataGridView2.RowCount; j++)
                {
                    for (int k = 0; k < dataGridView2.ColumnCount; k++)
                    {
                        if (dataGridView2.Rows[j].Cells[k].Value == node.Text)
                        {
                            exis = true;
                        }
                    }
                }
                if (!exis)
                {
                    node.ForeColor = Color.DarkOrange;
                }
                else
                {
                    bool gj = false;
                    foreach (var odp in db.Object_Document_Parameter)
                    {
                        if (odp.Type == 0 && odp.Object_Document.Object.Object_Library.Object_Library_Name == node.Text && db.Station_Object.FirstOrDefault(so => so.Station_Id == UserData.station && so.Object_Id == odp.Object_Document.Object.Object_Id) != null)
                        {
                            gj = false;
                            foreach (var odp2 in db.Object_Document_Parameter)
                            {
                                if (odp.Parameter_Id == odp2.Parameter_Id && odp2.Type == 2 && db.Station_Object.FirstOrDefault(so => so.Station_Id == UserData.station && so.Object_Id == odp2.Object_Document.Object.Object_Id) != null)
                                {
                                    gj = true;
                                    break;
                                }
                            }
                            if (!gj)
                            {
                                node.ForeColor = Color.Brown;
                                break;
                            }
                            gj = false;
                        }
                    }
                }
            }
        }

        private void выгрузкаВФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File file = new File();
            file.ShowDialog();
        }
    }
}
