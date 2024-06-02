using System.Collections.Generic;
using System.Drawing;

namespace Markup_printer
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            создатьНовыйToolStripMenuItem = new ToolStripMenuItem();
            столбцыToolStripMenuItem = new ToolStripMenuItem();
            добавитьСтолбецToolStripMenuItem = new ToolStripMenuItem();
            удалитьСтолбецToolStripMenuItem = new ToolStripMenuItem();
            изменитьДанныеToolStripMenuItem = new ToolStripMenuItem();
            info = new ToolStripMenuItem();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlDarkDark;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.MenuText;
            dataGridView1.Location = new Point(1, 27);
            dataGridView1.MaximumSize = new Size(2000, 500);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.ScrollBars = ScrollBars.Horizontal;
            dataGridView1.Size = new Size(1044, 191);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.RowsAdded += Row_Add;
            dataGridView1.RowsRemoved += Row_Dell;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, столбцыToolStripMenuItem, изменитьДанныеToolStripMenuItem, info });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1057, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { сохранитьToolStripMenuItem, открытьToolStripMenuItem, создатьНовыйToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(156, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += Save_Click;
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(156, 22);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += Open_File_Click;
            // 
            // создатьНовыйToolStripMenuItem
            // 
            создатьНовыйToolStripMenuItem.Name = "создатьНовыйToolStripMenuItem";
            создатьНовыйToolStripMenuItem.Size = new Size(156, 22);
            создатьНовыйToolStripMenuItem.Text = "Создать новый";
            создатьНовыйToolStripMenuItem.Click += New_File_Click;
            // 
            // столбцыToolStripMenuItem
            // 
            столбцыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { добавитьСтолбецToolStripMenuItem, удалитьСтолбецToolStripMenuItem });
            столбцыToolStripMenuItem.Name = "столбцыToolStripMenuItem";
            столбцыToolStripMenuItem.Size = new Size(69, 20);
            столбцыToolStripMenuItem.Text = "Столбцы";
            // 
            // добавитьСтолбецToolStripMenuItem
            // 
            добавитьСтолбецToolStripMenuItem.Name = "добавитьСтолбецToolStripMenuItem";
            добавитьСтолбецToolStripMenuItem.Size = new Size(174, 22);
            добавитьСтолбецToolStripMenuItem.Text = "Добавить столбец";
            добавитьСтолбецToolStripMenuItem.Click += Add_Column_Click;
            // 
            // удалитьСтолбецToolStripMenuItem
            // 
            удалитьСтолбецToolStripMenuItem.Name = "удалитьСтолбецToolStripMenuItem";
            удалитьСтолбецToolStripMenuItem.Size = new Size(174, 22);
            удалитьСтолбецToolStripMenuItem.Text = "Удалить столбец";
            удалитьСтолбецToolStripMenuItem.Click += Dell_Column_Click;
            // 
            // изменитьДанныеToolStripMenuItem
            // 
            изменитьДанныеToolStripMenuItem.Name = "изменитьДанныеToolStripMenuItem";
            изменитьДанныеToolStripMenuItem.Size = new Size(117, 20);
            изменитьДанныеToolStripMenuItem.Text = "Изменить данные";
            изменитьДанныеToolStripMenuItem.Click += Date_Open_Click;
            // 
            // info
            // 
            info.Name = "info";
            info.Size = new Size(93, 20);
            info.Text = "Информация";
            info.Click += InfoMenuItem_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1075, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(100, 23);
            comboBox1.TabIndex = 2;
            comboBox1.Visible = false;
            comboBox1.SelectedIndexChanged += OnChange_cmb;
            comboBox1.SelectedValueChanged += OnChange_cmb;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1057, 243);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.AppWorkspace;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximumSize = new Size(2020, 550);
            MinimumSize = new Size(30, 25);
            Name = "Form1";
            Text = "Markup_printer";
            FormClosing += The_Closed;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem создатьНовыйToolStripMenuItem;
        private ToolStripMenuItem столбцыToolStripMenuItem;
        private ToolStripMenuItem добавитьСтолбецToolStripMenuItem;
        private ToolStripMenuItem удалитьСтолбецToolStripMenuItem;
        private ToolStripMenuItem изменитьДанныеToolStripMenuItem;
        public ComboBox comboBox1;
        private ToolStripMenuItem info;
    }
}