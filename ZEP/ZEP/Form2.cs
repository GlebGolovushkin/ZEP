using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ZEP
{
    public partial class Form2 : Form
    {
        private ZepContext db = new ZepContext();
        private Person pr;
        public Form2(Person person)
        {
            InitializeComponent();
            checkBox1.Checked = true;
            radioButton1.Checked = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Model md = new Model();
                md.Name = textBox2.Text;
                db.Model.Add(md);
                db.SaveChanges();
                MessageBox.Show("Добавленно успешно");
                Form2_Load(null, null);

            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

                Model md = db.Model.FirstOrDefault(p => p.Name == comboBox2.Text);
                Model_Classificator mc = db.Model_Classificator.FirstOrDefault(p => p.Name == comboBox1.Text);
                Model_Classified cl = new Model_Classified();
                cl.Model = md.ID;
                cl.Model_Code_1 = mc.ID;
                db.Model_Classified.Add(cl);
                db.SaveChanges();
                MessageBox.Show("Добавленно успешно");
                Form2_Load(null, null);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var parentlc = db.Location.FirstOrDefault(p => p.Name == comboBox3.SelectedValue.ToString());
                Location lc = new Location();
                lc.Name = textBox3.Text;
                lc.HierLevel = parentlc.HierLevel + 1;
                lc.Parent = parentlc.ID;
                db.Location.Add(lc);
                db.SaveChanges();
                MessageBox.Show("Добавленно успешно");
                Form2_Load(null, null);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "objectZEPDataSet18.Data". При необходимости она может быть перемещена или удалена.
            this.dataTableAdapter.Fill(this.objectZEPDataSet18.Data);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "objectZEPDataSet17.Task_Classified". При необходимости она может быть перемещена или удалена.
            this.task_ClassifiedTableAdapter.Fill(this.objectZEPDataSet17.Task_Classified);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "objectZEPDataSet16.Object_Classified". При необходимости она может быть перемещена или удалена.
            this.object_ClassifiedTableAdapter.Fill(this.objectZEPDataSet16.Object_Classified);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "objectZEPDataSet15.Model_Classified". При необходимости она может быть перемещена или удалена.
            this.model_ClassifiedTableAdapter.Fill(this.objectZEPDataSet15.Model_Classified);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "objectZEPDataSet14.Object_Classificator". При необходимости она может быть перемещена или удалена.
            this.object_ClassificatorTableAdapter2.Fill(this.objectZEPDataSet14.Object_Classificator);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "objectZEPDataSet13.Object". При необходимости она может быть перемещена или удалена.
            this.objectTableAdapter1.Fill(this.objectZEPDataSet13.Object);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "objectZEPDataSet12.Object_Classificator". При необходимости она может быть перемещена или удалена.
            this.object_ClassificatorTableAdapter1.Fill(this.objectZEPDataSet12.Object_Classificator);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "objectZEPDataSet11.Object_Classificator". При необходимости она может быть перемещена или удалена.
            this.object_ClassificatorTableAdapter.Fill(this.objectZEPDataSet11.Object_Classificator);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "objectZEPDataSet10.Location". При необходимости она может быть перемещена или удалена.
            this.locationTableAdapter1.Fill(this.objectZEPDataSet10.Location);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "objectZEPDataSet9.Function". При необходимости она может быть перемещена или удалена.
            this.functionTableAdapter1.Fill(this.objectZEPDataSet9.Function);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "objectZEPDataSet8.Object". При необходимости она может быть перемещена или удалена.
            this.objectTableAdapter.Fill(this.objectZEPDataSet8.Object);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "objectZEPDataSet7.Function". При необходимости она может быть перемещена или удалена.
            this.functionTableAdapter.Fill(this.objectZEPDataSet7.Function);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "objectZEPDataSet6.Task_Classificator". При необходимости она может быть перемещена или удалена.
            this.task_ClassificatorTableAdapter.Fill(this.objectZEPDataSet6.Task_Classificator);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "objectZEPDataSet5.Task". При необходимости она может быть перемещена или удалена.
            this.taskTableAdapter.Fill(this.objectZEPDataSet5.Task);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "objectZEPDataSet4.Location". При необходимости она может быть перемещена или удалена.
            this.locationTableAdapter.Fill(this.objectZEPDataSet4.Location);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "objectZEPDataSet3.Model". При необходимости она может быть перемещена или удалена.
            this.modelTableAdapter.Fill(this.objectZEPDataSet3.Model);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "objectZEPDataSet2.Model_Classificator". При необходимости она может быть перемещена или удалена.
            this.model_ClassificatorTableAdapter.Fill(this.objectZEPDataSet2.Model_Classificator);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState == CheckState.Checked)
            {
                checkBox2.Checked = false;
            }
            else
            {
                if (checkBox2.CheckState!=CheckState.Checked)
                checkBox2.CheckState = CheckState.Checked;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                checkBox1.Checked = false;
            }
            else
            {
                if (checkBox1.CheckState != CheckState.Checked)
                    checkBox1.CheckState = CheckState.Checked;
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Model_Classificator mc = new Model_Classificator();
            mc.Graphical = checkBox1.Checked ? true : false;
            mc.Textual= checkBox1.Checked ? false : true;
            mc.Name = textBox1.Text;
            mc.Code = textBox4.Text;
            db.Model_Classificator.Add(mc);
            db.SaveChanges();
            MessageBox.Show("Добавленно успешно");
            Form2_Load(null, null);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Task mc = new Task();
            mc.Name = textBox5.Text;
            db.Task.Add(mc);
            db.SaveChanges();
            MessageBox.Show("Добавленно успешно");
            Form2_Load(null, null);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Task_Classificator mc = new Task_Classificator();
            mc.TaskGroup = radioButton1.Checked ? "Технологическая" : "Организационная";
            mc.Group_Code = radioButton1.Checked ? "Т" : "О";
            mc.Name = textBox6.Text;
            db.Task_Classificator.Add(mc);
            db.SaveChanges();
            MessageBox.Show("Добавленно успешно");
            Form2_Load(null, null);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var task = db.Task.FirstOrDefault(p => p.Name == comboBox5.SelectedValue.ToString());
            var clas = db.Task_Classificator.FirstOrDefault(p => p.Name == comboBox4.SelectedValue.ToString());
            Task_Classified tc = new Task_Classified();
            tc.Task = task.ID;
            tc.Task_Code_1 = clas.ID;
            db.Task_Classified.Add(tc);
            db.SaveChanges();
            MessageBox.Show("Добавленно успешно");
            Form2_Load(null, null);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            var funk = db.Function.FirstOrDefault(p => p.Name == comboBox6.SelectedValue.ToString());
            Function fc = new Function();
            fc.HierLevel = funk.HierLevel + 1;
            fc.Name = textBox7.Text;
            fc.Parent = funk.ID;
            fc.Specialization = textBox9.Text;
            fc.FunctionGroup = textBox8.Text;
            db.Function.Add(fc);
            db.SaveChanges();
            MessageBox.Show("Добавленно успешно");
            Form2_Load(null, null);
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            var parObj = db.Object.FirstOrDefault(p => p.Name == comboBox7.SelectedValue.ToString());
            var fuc = db.Function.FirstOrDefault(p => p.Name == comboBox8.SelectedValue.ToString());
            var loc = db.Location.FirstOrDefault(p => p.Name == comboBox9.SelectedValue.ToString());
            Object obj = new Object();
            obj.FunctionID = fuc.ID;
            obj.HierLevel = parObj.HierLevel + 1;
            obj.Location = loc.ID;
            obj.Parent = parObj.ID;
            obj.Name = textBox11.Text;

            db.Object.Add(obj);
            db.SaveChanges();
            MessageBox.Show("Добавленно успешно");
            Form2_Load(null, null);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Object_Classificator oc = new Object_Classificator();
            var parOc = db.Object_Classificator.FirstOrDefault(p => p.Name == comboBox10.SelectedValue.ToString());
            oc.Name = textBox12.Text;
            oc.Code = textBox13.Text;
            oc.ParentCode = parOc.ID;
            db.Object_Classificator.Add(oc);
            db.SaveChanges();
            MessageBox.Show("Добавленно успешно");
            Form2_Load(null, null);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var obj = db.Object.FirstOrDefault(p => p.Name == comboBox11.SelectedValue.ToString());
            var Oc = db.Object_Classificator.FirstOrDefault(p => p.Name == comboBox12.SelectedValue.ToString());
            Object_Classified ocl = new Object_Classified();
            ocl.Object = obj.ID;
            ocl.Object_Code_1 = Oc.ID;
            db.Object_Classified.Add(ocl);
            db.SaveChanges();
            MessageBox.Show("Добавленно успешно");
            Form2_Load(null, null);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int o = Convert.ToInt32(comboBox14.SelectedValue.ToString());
            int t = Convert.ToInt32(comboBox15.SelectedValue.ToString());
            int m = Convert.ToInt32(comboBox13.SelectedValue.ToString());
            var obj = db.Object_Classified.FirstOrDefault(p => p.ID == o);
            var task = db.Task_Classified.FirstOrDefault(p => p.ID == t);
            var model = db.Model_Classified.FirstOrDefault(p => p.ID == m);
            Model_Object_Task mot = new Model_Object_Task();
            mot.Model = model.ID;
            mot.Object = obj.ID;
            mot.Task = task.ID;
            db.Model_Object_Task.Add(mot);
            db.SaveChanges();
            MessageBox.Show("Добавленно успешно");
            Form2_Load(null, null);
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }
    }
}
