namespace Markup_printer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Cmb_Date_Load()
        {
            comboBox1.Items.Clear();
            StreamReader sr = new StreamReader("date.txt");
            while (!sr.EndOfStream)
            {
                comboBox1.Items.Add(sr.ReadLine());
            }
            sr.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            Cmb_Date_Load();
            dataGridView1.ColumnCount = 10;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowCount = 10;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            foreach (DataGridViewColumn i in dataGridView1.Columns)
            {
                i.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBox1.Visible = false;
            comboBox1.Text = "";
            if (dataGridView1.CurrentCell.Value == null)
            {
                comboBox1.Visible = true;
                comboBox1.Location = new Point(41 + ((dataGridView1.CurrentCell.ColumnIndex) * 100), 5 + (dataGridView1.CurrentCell.RowIndex + 1) * 25);
            }
        }

        private void OnChange_cmb(object sender, EventArgs e)
        {
            string cmb_txt = comboBox1.Text.Replace(" ", "");
            dataGridView1.CurrentCell.Value = (dataGridView1.CurrentCell.RowIndex + 1).ToString() + cmb_txt;
            comboBox1.Visible = false;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            Save();
        }

        public void Save()
        {
            SaveFileDialog saveFileDialog1 = new()
            {
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 1,
                RestoreDirectory = true
            };
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter mw = new(saveFileDialog1.FileName);
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    if (dataGridView1[0, i].Value != null)
                    {

                        mw.Write(" ");
                        for (int j = 0; j < dataGridView1.ColumnCount; j++)
                        {
                            if (dataGridView1[j, i].Value != null)
                            {

                                if (j != 0)
                                {
                                    mw.Write("      ");
                                }
                                string new_str = dataGridView1[j, i].Value.ToString();
                                mw.Write(new_str);
                            }
                            else
                            {
                                j = dataGridView1.ColumnCount;
                            }
                        }

                        mw.Write("   \n");

                    }

                }
                mw.Close();

            }
        }

        private void Dell_Column_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            if (dataGridView1.ColumnCount > 5)
            {
                dataGridView1.ColumnCount -= 1;
                Width -= 100;
                dataGridView1.Width = Width;
            }
        }

        private void Row_Add(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Height += 25;
            dataGridView1.Height = Height;
        }

        private void Row_Dell(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Height -= 25;
            dataGridView1.Height = Height;
        }

        private void Add_Column_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            if (dataGridView1.ColumnCount < 20)
            {
                Width += 100;
                dataGridView1.Width = Width;
                dataGridView1.ColumnCount += 1;
            }
            dataGridView1.Columns[dataGridView1.ColumnCount - 1].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void New_File_Click(object sender, EventArgs e)
        {
            Clear_DG();
            dataGridView1.ColumnCount = 10;
            dataGridView1.RowCount = 10;
            Correct_Size();
        }

        public void Correct_Size()
        {
            foreach (DataGridViewColumn i in dataGridView1.Columns)
            {
                i.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataGridView1.Width = 44 + 100 * dataGridView1.ColumnCount;
            dataGridView1.Height = 20 + 25 * dataGridView1.RowCount;
            Width = dataGridView1.Width + 15;
            Height = dataGridView1.Height + 65;
        }
        public void Clear_DG()
        {
            comboBox1.Visible = false;
            dataGridView1.ColumnCount = 1;
            dataGridView1.RowCount = 1;
            dataGridView1[0, 0].Value = null;
        }

        private void Open_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog saveFileDialog1 = new()
            {
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 1,
                RestoreDirectory = true
            };
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Clear_DG();
                string fileText = File.ReadAllText(saveFileDialog1.FileName);
                string[] sentence = fileText.Split('\n');
                dataGridView1.RowCount = sentence.Length;
                for (int i = 0; i < sentence.Length; i++)
                {
                    string[] buff = sentence[i].Split(' ');
                    string[] worlds = buff.Where(x => x != "").ToArray();
                    if (dataGridView1.ColumnCount < worlds.Length)
                    {
                        dataGridView1.ColumnCount = worlds.Length;
                    }
                    for (int j = 0; j < worlds.Length; j++)
                    {
                        dataGridView1[j, i].Value = worlds[j];
                    }
                }
            }
            Correct_Size();
        }

        private void Date_Open_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            DialogResult res = frm2.ShowDialog();
            Cmb_Date_Load();
        }

        private void The_Closed(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Сохранить файл преред закрытием?", "Выход", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                Save();
            }
            else if (res == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void InfoMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Руководство по использованию:\n1. В пункте меню 'Файл'\n\t1.1 Сохранитиь - осуществляет выгрузку в формате txt файла с сформированного из значений таблицы в определенном формате\n\tВАЖНО! значения для каждой строки записываются до тех пор пока не встретят пустую ячейку, поэтому в строке пропусков быть не должно\n\t1.2 Открыть - открывает файл txt для дальнейшего редактирования в таблице(для сохранения файла используйте кнопку 'Сохранить'\n\t1.3 Создать новый - создает пустую таблицу 10х10\n2. Столбцы - Добавляет/удаляет столбец в конце таблицы \n3. Изменить данные - открывает форму для добавления/удаления слов в список выбора, чтобы сохранить изменения закройте окно и нажмите 'Да'\n\n\n\n\nПо вопросам и ОС - Asamsakov@mail.ru", "О программе", MessageBoxButtons.OK);
        }
    }
}
