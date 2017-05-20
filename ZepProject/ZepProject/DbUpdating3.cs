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
            //if (comboBox1.SelectedValue!="")
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Object_Library obj =
                db.Object_Library.FirstOrDefault(o => o.Object_Library_Name == comboBox1.SelectedValue);
            
            MessageBox.Show("Добавленно");

        }
    }
}
