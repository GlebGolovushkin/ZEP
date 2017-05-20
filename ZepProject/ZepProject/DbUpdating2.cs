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
        public DbUpdating2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void DbUpdating2_Load(object sender, EventArgs e)
        {
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
    }
}
