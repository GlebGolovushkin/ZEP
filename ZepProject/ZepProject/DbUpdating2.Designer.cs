namespace ZepProject
{
    partial class DbUpdating2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.zEPDataSet4 = new ZepProject.ZEPDataSet4();
            this.objectLibraryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.object_LibraryTableAdapter = new ZepProject.ZEPDataSet4TableAdapters.Object_LibraryTableAdapter();
            this.zEPDataSet5 = new ZepProject.ZEPDataSet5();
            this.specialtyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.specialtyTableAdapter = new ZepProject.ZEPDataSet5TableAdapters.SpecialtyTableAdapter();
            this.zEPDataSet6 = new ZepProject.ZEPDataSet6();
            this.documentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.documentTableAdapter = new ZepProject.ZEPDataSet6TableAdapters.DocumentTableAdapter();
            this.zEPDataSet7 = new ZepProject.ZEPDataSet7();
            this.objectLibraryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.object_LibraryTableAdapter1 = new ZepProject.ZEPDataSet7TableAdapters.Object_LibraryTableAdapter();
            this.zEPDataSet8 = new ZepProject.ZEPDataSet8();
            this.parameterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.parameterTableAdapter = new ZepProject.ZEPDataSet8TableAdapters.ParameterTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zEPDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectLibraryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEPDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEPDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEPDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectLibraryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEPDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.parameterBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберете объект";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.documentBindingSource;
            this.comboBox1.DisplayMember = "Document_Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(35, 65);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "Object_Library_Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Укажите параметр объекта";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Выберете документ";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Укажите тип параметра";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(28, 43);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(70, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Входной ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.objectLibraryBindingSource1;
            this.comboBox2.DisplayMember = "Object_Library_Name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(204, 65);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.ValueMember = "Object_Library_Name";
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.parameterBindingSource;
            this.comboBox3.DisplayMember = "Parameter_Name";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(35, 200);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 4;
            this.comboBox3.ValueMember = "Parameter_Name";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(28, 66);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Рассчётный";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(28, 89);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(75, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Выходной";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(204, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 119);
            this.panel1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Укажите специальность";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.specialtyBindingSource;
            this.comboBox4.DisplayMember = "Specialty_Name";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(35, 131);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 4;
            this.comboBox4.ValueMember = "Specialty_Name";
            // 
            // zEPDataSet4
            // 
            this.zEPDataSet4.DataSetName = "ZEPDataSet4";
            this.zEPDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // objectLibraryBindingSource
            // 
            this.objectLibraryBindingSource.DataMember = "Object_Library";
            this.objectLibraryBindingSource.DataSource = this.zEPDataSet4;
            // 
            // object_LibraryTableAdapter
            // 
            this.object_LibraryTableAdapter.ClearBeforeFill = true;
            // 
            // zEPDataSet5
            // 
            this.zEPDataSet5.DataSetName = "ZEPDataSet5";
            this.zEPDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specialtyBindingSource
            // 
            this.specialtyBindingSource.DataMember = "Specialty";
            this.specialtyBindingSource.DataSource = this.zEPDataSet5;
            // 
            // specialtyTableAdapter
            // 
            this.specialtyTableAdapter.ClearBeforeFill = true;
            // 
            // zEPDataSet6
            // 
            this.zEPDataSet6.DataSetName = "ZEPDataSet6";
            this.zEPDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // documentBindingSource
            // 
            this.documentBindingSource.DataMember = "Document";
            this.documentBindingSource.DataSource = this.zEPDataSet6;
            // 
            // documentTableAdapter
            // 
            this.documentTableAdapter.ClearBeforeFill = true;
            // 
            // zEPDataSet7
            // 
            this.zEPDataSet7.DataSetName = "ZEPDataSet7";
            this.zEPDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // objectLibraryBindingSource1
            // 
            this.objectLibraryBindingSource1.DataMember = "Object_Library";
            this.objectLibraryBindingSource1.DataSource = this.zEPDataSet7;
            // 
            // object_LibraryTableAdapter1
            // 
            this.object_LibraryTableAdapter1.ClearBeforeFill = true;
            // 
            // zEPDataSet8
            // 
            this.zEPDataSet8.DataSetName = "ZEPDataSet8";
            this.zEPDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // parameterBindingSource
            // 
            this.parameterBindingSource.DataMember = "Parameter";
            this.parameterBindingSource.DataSource = this.zEPDataSet8;
            // 
            // parameterTableAdapter
            // 
            this.parameterTableAdapter.ClearBeforeFill = true;
            // 
            // DbUpdating2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 296);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "DbUpdating2";
            this.Text = "Db_update_2";
            this.Load += new System.EventHandler(this.DbUpdating2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.zEPDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectLibraryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEPDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialtyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEPDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEPDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectLibraryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEPDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.parameterBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox4;
        private ZEPDataSet4 zEPDataSet4;
        private System.Windows.Forms.BindingSource objectLibraryBindingSource;
        private ZEPDataSet4TableAdapters.Object_LibraryTableAdapter object_LibraryTableAdapter;
        private ZEPDataSet5 zEPDataSet5;
        private System.Windows.Forms.BindingSource specialtyBindingSource;
        private ZEPDataSet5TableAdapters.SpecialtyTableAdapter specialtyTableAdapter;
        private ZEPDataSet6 zEPDataSet6;
        private System.Windows.Forms.BindingSource documentBindingSource;
        private ZEPDataSet6TableAdapters.DocumentTableAdapter documentTableAdapter;
        private ZEPDataSet7 zEPDataSet7;
        private System.Windows.Forms.BindingSource objectLibraryBindingSource1;
        private ZEPDataSet7TableAdapters.Object_LibraryTableAdapter object_LibraryTableAdapter1;
        private ZEPDataSet8 zEPDataSet8;
        private System.Windows.Forms.BindingSource parameterBindingSource;
        private ZEPDataSet8TableAdapters.ParameterTableAdapter parameterTableAdapter;
    }
}