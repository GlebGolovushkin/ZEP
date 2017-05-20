namespace ZepProject
{
    partial class DbUpdating3
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.zEPDataSet9 = new ZepProject.ZEPDataSet9();
            this.objectLibraryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.object_LibraryTableAdapter = new ZepProject.ZEPDataSet9TableAdapters.Object_LibraryTableAdapter();
            this.zEPDataSet10 = new ZepProject.ZEPDataSet10();
            this.variationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.variationTableAdapter = new ZepProject.ZEPDataSet10TableAdapters.VariationTableAdapter();
            this.zEPDataSet11 = new ZepProject.ZEPDataSet11();
            this.placeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.placeTableAdapter = new ZepProject.ZEPDataSet11TableAdapters.PlaceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.zEPDataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectLibraryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEPDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.variationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEPDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить объект";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберете объект из списка";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.objectLibraryBindingSource;
            this.comboBox1.DisplayMember = "Object_Library_Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "Object_Library_Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Укажите вариацию объекта";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(25, 141);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(147, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Укажите местоположение объекта";
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.placeBindingSource;
            this.comboBox4.DisplayMember = "Place_Name";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(232, 141);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 2;
            this.comboBox4.ValueMember = "Place_Name";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(232, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Количество объектов";
            // 
            // zEPDataSet9
            // 
            this.zEPDataSet9.DataSetName = "ZEPDataSet9";
            this.zEPDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // objectLibraryBindingSource
            // 
            this.objectLibraryBindingSource.DataMember = "Object_Library";
            this.objectLibraryBindingSource.DataSource = this.zEPDataSet9;
            // 
            // object_LibraryTableAdapter
            // 
            this.object_LibraryTableAdapter.ClearBeforeFill = true;
            // 
            // zEPDataSet10
            // 
            this.zEPDataSet10.DataSetName = "ZEPDataSet10";
            this.zEPDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // variationBindingSource
            // 
            this.variationBindingSource.DataMember = "Variation";
            this.variationBindingSource.DataSource = this.zEPDataSet10;
            // 
            // variationTableAdapter
            // 
            this.variationTableAdapter.ClearBeforeFill = true;
            // 
            // zEPDataSet11
            // 
            this.zEPDataSet11.DataSetName = "ZEPDataSet11";
            this.zEPDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // placeBindingSource
            // 
            this.placeBindingSource.DataMember = "Place";
            this.placeBindingSource.DataSource = this.zEPDataSet11;
            // 
            // placeTableAdapter
            // 
            this.placeTableAdapter.ClearBeforeFill = true;
            // 
            // DbUpdating3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 231);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "DbUpdating3";
            this.Text = "Объект";
            this.Load += new System.EventHandler(this.DbUpdating3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.zEPDataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectLibraryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEPDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.variationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEPDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private ZEPDataSet9 zEPDataSet9;
        private System.Windows.Forms.BindingSource objectLibraryBindingSource;
        private ZEPDataSet9TableAdapters.Object_LibraryTableAdapter object_LibraryTableAdapter;
        private ZEPDataSet10 zEPDataSet10;
        private System.Windows.Forms.BindingSource variationBindingSource;
        private ZEPDataSet10TableAdapters.VariationTableAdapter variationTableAdapter;
        private ZEPDataSet11 zEPDataSet11;
        private System.Windows.Forms.BindingSource placeBindingSource;
        private ZEPDataSet11TableAdapters.PlaceTableAdapter placeTableAdapter;
    }
}