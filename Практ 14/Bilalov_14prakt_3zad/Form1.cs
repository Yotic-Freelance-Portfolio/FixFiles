using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilalov_14prakt_2zad
{
    //размер, цвет, модель, рисунок, посадка 
    public partial class Form1 : Form
    {
        private DataGridViewColumn dataGridViewColumn1 = null;
        private DataGridViewColumn dataGridViewColumn2 = null;
        private DataGridViewColumn dataGridViewColumn3 = null;
        private DataGridViewColumn dataGridViewColumn4 = null;

        private DataGridViewColumn dataGridViewColumn5 = null;

        private DataGridViewColumn dataGridViewColumn6 = null;


        //Инициализация таблицы
        private void initDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Add(getDataGridViewColumn1());
            dataGridView1.Columns.Add(getDataGridViewColumn2());
            dataGridView1.Columns.Add(getDataGridViewColumn3());
            dataGridView1.Columns.Add(getDataGridViewColumn4());
            dataGridView1.Columns.Add(getDataGridViewColumn5());
            dataGridView1.Columns.Add(getDataGridViewColumn6());
            dataGridView1.AutoResizeColumns();
        }
        //Динамическое создание первой колонки в таблице
        private DataGridViewColumn getDataGridViewColumn1()
        {
            if (dataGridViewColumn1 == null)
            {
                dataGridViewColumn1 = new DataGridViewTextBoxColumn();
                dataGridViewColumn1.Name = "";
                dataGridViewColumn1.HeaderText = "Процессор";
                dataGridViewColumn1.ValueType = typeof(string);
                dataGridViewColumn1.Width = dataGridView1.Width / 4;
            }
            return dataGridViewColumn1;
        }
        //Динамическое создание второй колонки в таблице
        private DataGridViewColumn getDataGridViewColumn2()
        {
            if (dataGridViewColumn2 == null)
            {
                dataGridViewColumn2 = new DataGridViewTextBoxColumn();
                dataGridViewColumn2.Name = "";
                dataGridViewColumn2.HeaderText = "Видеокарта";
                dataGridViewColumn2.ValueType = typeof(string);
                dataGridViewColumn2.Width = dataGridView1.Width / 3;
            }
            return dataGridViewColumn2;
        }
        //Динамическое создание третей колонки в таблице
        private DataGridViewColumn getDataGridViewColumn3()
        {
            if (dataGridViewColumn3 == null)
            {
                dataGridViewColumn3 = new DataGridViewTextBoxColumn();
                dataGridViewColumn3.Name = "";
                dataGridViewColumn3.HeaderText = "Мышь";
                dataGridViewColumn3.ValueType = typeof(string);
                dataGridViewColumn3.Width = dataGridView1.Width / 2;
            }
            return dataGridViewColumn3;
        }
        private DataGridViewColumn getDataGridViewColumn4()
        {
            if (dataGridViewColumn4 == null)
            {
                dataGridViewColumn4 = new DataGridViewTextBoxColumn();
                dataGridViewColumn4.Name = "";
                dataGridViewColumn4.HeaderText = "Монитор";
                dataGridViewColumn4.ValueType = typeof(string);
                dataGridViewColumn4.Width = dataGridView1.Width / 2;
            }
            return dataGridViewColumn4;
        }
        private DataGridViewColumn getDataGridViewColumn5()
        {
            if (dataGridViewColumn5 == null)
            {
                dataGridViewColumn5 = new DataGridViewTextBoxColumn();
                dataGridViewColumn5.Name = "";
                dataGridViewColumn5.HeaderText = "Кол. Ядр";
                dataGridViewColumn5.ValueType = typeof(int);
                dataGridViewColumn5.Width = dataGridView1.Width / 2;
            }
            return dataGridViewColumn5;
        }
        private DataGridViewColumn getDataGridViewColumn6()
        {
            if (dataGridViewColumn6 == null)
            {
                dataGridViewColumn6 = new DataGridViewTextBoxColumn();
                dataGridViewColumn6.Name = "";
                dataGridViewColumn6.HeaderText = "ОЗУ";
                dataGridViewColumn6.ValueType = typeof(int);
                dataGridViewColumn6.Width = dataGridView1.Width / 2;
            }
            return dataGridViewColumn6;
        }




        //Колекция List

        SortedList<int, Computer> ComputerList = new SortedList<int, Computer>();
        int k = -1;
        //Добавление компа в колекцию
        private void addStudent(string procesor, string videokarte, string mush, string monitor, string kolider, string OZY)
        {
            k++;
            Computer s = new Computer (procesor, videokarte, mush, monitor,kolider,OZY);
            ComputerList.Add(k, s);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

            showListInGrid();
        }
        //Удаление студента с колекции
        private void deleteStudent(int elementIndex)
        {
            ComputerList.RemoveAt(elementIndex);
            showListInGrid();
        }
        //Отображение колекции в таблице
        private void showListInGrid()
        {
            ICollection<Computer> value = ComputerList.Values;
            dataGridView1.Rows.Clear();
            foreach (Computer s in value)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell cell1 = new  DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell2 = new  DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell3 = new  DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell4 = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell5 = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell6 = new DataGridViewTextBoxCell();

                cell1.ValueType = typeof(string);
                cell1.Value = s.getName();

                cell2.ValueType = typeof(string);
                cell2.Value = s.getFio();

                cell3.ValueType = typeof(string);
                cell3.Value = s.getMush();

                cell4.ValueType = typeof(string);
                cell4.Value = s.getMon();

                cell5.ValueType = typeof(string);
                cell5.Value = s.getKI();

                cell6.ValueType = typeof(string);
                cell6.Value = s.getOZY();

               


                row.Cells.Add(cell1);
                row.Cells.Add(cell2);
                row.Cells.Add(cell3);
                row.Cells.Add(cell4);
                row.Cells.Add(cell5);
                row.Cells.Add(cell6);
                dataGridView1.Rows.Add(row);
            }
        }

        public Form1()
        {
            InitializeComponent();
            initDataGridView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addStudent(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text,textBox5.Text, textBox6.Text) ;
        }
       
        
        //Обработчик нажатия на удалить      
        private void удалитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int selectedRow = dataGridView1.SelectedCells[0].RowIndex;
            DialogResult dr = MessageBox.Show("Удалить номер?", "",
            MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    deleteStudent(selectedRow);
                }
                catch (Exception)
                {
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }




        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBox2_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBox3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

