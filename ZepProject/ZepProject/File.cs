using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;


namespace ZepProject
{
    public partial class File : Form
    {

        ZEPEntities db = new ZEPEntities();

        public File()
        {
            InitializeComponent();
            dataGridView1.RowCount = UserData.stations.Count;
            for (int i = 0; i < UserData.stations.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = UserData.stations[i];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ObjExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ObjWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ObjWorkSheet;
            //Книга.
            ObjWorkBook = ObjExcel.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1];
            ObjWorkSheet.Cells[1, 1] = "Название объекта";
            ObjWorkSheet.Cells[1, 2] = "Код";
            int n = 2;
            List<string> nodes = new List<string>();
            foreach (var obje in db.Object)
            {
                if (db.Station_Object.Any(so => so.Station_Id == UserData.station && so.Object_Id == obje.Object_Id))
                {
                    string objName = db.Object_Library
                        .FirstOrDefault(o => o.Object_Library_Id == obje.Object_Library_Id)
                        .Object_Library_Name;
                    try
                    {
                        string kks = "";
                        string curName = objName;
                        while (true)
                        {
                            Object_Library ol = db.Object_Library.FirstOrDefault(o => o.Object_Library_Name == curName);
                            nodes.Add(curName);
                            if (ol.Parent_Object_Id != null)
                            {
                                curName = db.Object_Library
                                    .FirstOrDefault(o => o.Object_Library_Id == ol.Parent_Object_Id)
                                    .Object_Library_Name;

                                continue;
                            }
                            break;
                        }
                        string nam = objName;
                        kks = "";
                        try
                        {

                            kks += db.Station.FirstOrDefault(s => s.Station_Id == UserData.station).Station_KKS
                                .ToString().Substring(0,
                                    db.Station.FirstOrDefault(s => s.Station_Id == UserData.station).Station_KKS
                                        .ToString()
                                        .IndexOf(' '));
                            kks += " ";
                            kks += db.Object
                                .FirstOrDefault(
                                    o => o.Object_Library_Id ==
                                         db.Object_Library.FirstOrDefault(ol => ol.Object_Library_Name == nam)
                                             .Object_Library_Id &&
                                         db.Station_Object.Any(
                                             so => so.Object_Id == o.Object_Id && so.Station_Id == UserData.station))
                                .Amount;
                        }
                        catch (Exception ew)
                        {
                        }
                        string name;
                        for (int j = nodes.Count - 1; j >= 0; j--)
                        {
                            name = nodes[j].ToString();
                            kks += db.Object_Library.FirstOrDefault(o => o.Object_Library_Name == name)
                                .Object_KKS[0];
                        }

                        ObjWorkSheet.Cells[n, 1] = objName;
                        ObjWorkSheet.Cells[n, 2] = kks;
                        n++;
                        kks = "";
                        nodes.Clear();

                    }
                    catch (Exception exception)
                    {
                    }
                }
            }

            ObjExcel.Visible = true;
            ObjExcel.UserControl = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string st = dataGridView1.SelectedCells[0].Value.ToString();
            UserData.station = db.Station
                .FirstOrDefault(s => s.Station_Name == st).Station_Id;
        }
    }
}
