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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.элементыВСправочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.объектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыДляОбъектаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem});
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
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}