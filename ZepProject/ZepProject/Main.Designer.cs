namespace ZepProject
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.элементыВСправочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.объектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыДляОбъектаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выгрузкаВФайлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Доккумент = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Специализация = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Параметр = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Тип = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.objectLibraryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zEPDataSet18 = new ZepProject.ZEPDataSet18();
            this.object_LibraryTableAdapter = new ZepProject.ZEPDataSet18TableAdapters.Object_LibraryTableAdapter();
            this.objectLibraryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.zEPDataSet19 = new ZepProject.ZEPDataSet19();
            this.object_LibraryTableAdapter1 = new ZepProject.ZEPDataSet19TableAdapters.Object_LibraryTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectLibraryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEPDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectLibraryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEPDataSet19)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1596, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.выгрузкаВФайлToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.элементыВСправочникиToolStripMenuItem,
            this.объектToolStripMenuItem,
            this.параметрыДляОбъектаToolStripMenuItem,
            this.пользователейToolStripMenuItem});
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // элементыВСправочникиToolStripMenuItem
            // 
            this.элементыВСправочникиToolStripMenuItem.Name = "элементыВСправочникиToolStripMenuItem";
            this.элементыВСправочникиToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.элементыВСправочникиToolStripMenuItem.Text = "Элементы в справочники";
            this.элементыВСправочникиToolStripMenuItem.Click += new System.EventHandler(this.элементыВСправочникиToolStripMenuItem_Click);
            // 
            // объектToolStripMenuItem
            // 
            this.объектToolStripMenuItem.Name = "объектToolStripMenuItem";
            this.объектToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.объектToolStripMenuItem.Text = "Объект";
            this.объектToolStripMenuItem.Click += new System.EventHandler(this.объектToolStripMenuItem_Click);
            // 
            // параметрыДляОбъектаToolStripMenuItem
            // 
            this.параметрыДляОбъектаToolStripMenuItem.Name = "параметрыДляОбъектаToolStripMenuItem";
            this.параметрыДляОбъектаToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.параметрыДляОбъектаToolStripMenuItem.Text = "Параметры для объекта";
            this.параметрыДляОбъектаToolStripMenuItem.Click += new System.EventHandler(this.параметрыДляОбъектаToolStripMenuItem_Click);
            // 
            // пользователейToolStripMenuItem
            // 
            this.пользователейToolStripMenuItem.Name = "пользователейToolStripMenuItem";
            this.пользователейToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.пользователейToolStripMenuItem.Text = "Пользователей";
            this.пользователейToolStripMenuItem.Click += new System.EventHandler(this.пользователейToolStripMenuItem_Click);
            // 
            // выгрузкаВФайлToolStripMenuItem
            // 
            this.выгрузкаВФайлToolStripMenuItem.Name = "выгрузкаВФайлToolStripMenuItem";
            this.выгрузкаВФайлToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.выгрузкаВФайлToolStripMenuItem.Text = "Выгрузка в файл";
            this.выгрузкаВФайлToolStripMenuItem.Click += new System.EventHandler(this.выгрузкаВФайлToolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(39, 54);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(606, 807);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Доккумент,
            this.Специализация,
            this.Параметр,
            this.Тип});
            this.dataGridView1.Location = new System.Drawing.Point(655, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(933, 394);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Доккумент
            // 
            this.Доккумент.HeaderText = "Документ";
            this.Доккумент.Name = "Доккумент";
            this.Доккумент.Width = 232;
            // 
            // Специализация
            // 
            this.Специализация.HeaderText = "Специализация";
            this.Специализация.Name = "Специализация";
            this.Специализация.Width = 233;
            // 
            // Параметр
            // 
            this.Параметр.HeaderText = "Параметр";
            this.Параметр.Name = "Параметр";
            this.Параметр.Width = 234;
            // 
            // Тип
            // 
            this.Тип.HeaderText = "Тип";
            this.Тип.Name = "Тип";
            this.Тип.Width = 210;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView2.Location = new System.Drawing.Point(655, 427);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(933, 302);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Выдающий объект";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 450;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Получающий объект";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 450;
            // 
            // objectLibraryBindingSource
            // 
            this.objectLibraryBindingSource.DataMember = "Object_Library";
            this.objectLibraryBindingSource.DataSource = this.zEPDataSet18;
            // 
            // zEPDataSet18
            // 
            this.zEPDataSet18.DataSetName = "ZEPDataSet18";
            this.zEPDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // object_LibraryTableAdapter
            // 
            this.object_LibraryTableAdapter.ClearBeforeFill = true;
            // 
            // objectLibraryBindingSource1
            // 
            this.objectLibraryBindingSource1.DataMember = "Object_Library";
            this.objectLibraryBindingSource1.DataSource = this.zEPDataSet19;
            // 
            // zEPDataSet19
            // 
            this.zEPDataSet19.DataSetName = "ZEPDataSet19";
            this.zEPDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // object_LibraryTableAdapter1
            // 
            this.object_LibraryTableAdapter1.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "ККС:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 10;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 741);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Главная";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectLibraryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEPDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objectLibraryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zEPDataSet19)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem элементыВСправочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem объектToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыДляОбъектаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователейToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private ZEPDataSet18 zEPDataSet18;
        private System.Windows.Forms.BindingSource objectLibraryBindingSource;
        private ZEPDataSet18TableAdapters.Object_LibraryTableAdapter object_LibraryTableAdapter;
        private ZEPDataSet19 zEPDataSet19;
        private System.Windows.Forms.BindingSource objectLibraryBindingSource1;
        private ZEPDataSet19TableAdapters.Object_LibraryTableAdapter object_LibraryTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Доккумент;
        private System.Windows.Forms.DataGridViewTextBoxColumn Специализация;
        private System.Windows.Forms.DataGridViewTextBoxColumn Параметр;
        private System.Windows.Forms.DataGridViewTextBoxColumn Тип;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem выгрузкаВФайлToolStripMenuItem;
    }
}