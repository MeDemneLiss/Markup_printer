namespace Markup_printer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Row_Add(object sender, DataGridViewRowEventArgs e)
        {
            Height += 25;
            dataGridView1.Height = Height;
        }

        private void Row_Rem(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Height -= 25;
            dataGridView1.Height = Height;
        }

        private void Load_Form(object sender, EventArgs e)
        {
            StreamReader sr = new("date.txt");
            int i = 0;
            while (!sr.EndOfStream)
            {
                dataGridView1.RowCount++;
                dataGridView1[0, i].Value = sr.ReadLine();
                i++;
                Height += 25;
                dataGridView1.Height = Height;
            }
            sr.Close();
        }

        private void The_Close(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Сохранить настройки?", "Закрытие", MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Yes)
            {
                StreamWriter sw = new("date.txt");
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1[0, i].Value != null)
                    {
                        sw.WriteLine(dataGridView1[0, i].Value.ToString());
                    }
                }
                sw.Close();
            }
            else if (res == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
