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

        //Инициализация таблицы
        private void initDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Add(getDataGridViewColumn1());
            dataGridView1.Columns.Add(getDataGridViewColumn2());
            dataGridView1.Columns.Add(getDataGridViewColumn3());
            dataGridView1.AutoResizeColumns();
        }
        //Динамическое создание первой колонки в таблице
        private DataGridViewColumn getDataGridViewColumn1()
        {
            if (dataGridViewColumn1 == null)
            {
                dataGridViewColumn1 = new DataGridViewTextBoxColumn();
                dataGridViewColumn1.Name = "";
                dataGridViewColumn1.HeaderText = "Имя";
                dataGridViewColumn1.ValueType = typeof(int);
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
                dataGridViewColumn2.HeaderText = "Фамилия";
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
                dataGridViewColumn3.HeaderText = "№зачётки";
                dataGridViewColumn3.ValueType = typeof(string);
                dataGridViewColumn3.Width = dataGridView1.Width / 2;
            }
            return dataGridViewColumn3;
        }

        


        //Колекция List
  
        SortedList<int, Student> studentList = new SortedList<int, Student>();
        int k = -1;
        //Добавление студента в колекцию
        private void addStudent(string name, string fio, int n)
        {
            k++;
            Student s = new Student(name, fio, n);
            studentList.Add(k, s);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
           
            showListInGrid();
        }
        //Удаление студента с колекции
        private void deleteStudent(int elementIndex)
        {
            studentList.RemoveAt(elementIndex);
            showListInGrid();
        }
        //Отображение колекции в таблице
        private void showListInGrid()
        {
            ICollection<Student> value = studentList.Values;
            dataGridView1.Rows.Clear();
            foreach (Student s in value)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell cell1 = new  DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell2 = new  DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell3 = new  DataGridViewTextBoxCell();
             
                cell1.ValueType = typeof(string);
                cell1.Value = s.getName();

                cell2.ValueType = typeof(string);
                cell2.Value = s.getFio();

                cell3.ValueType = typeof(int);
                cell3.Value = s.getN();

                
                row.Cells.Add(cell1);
                row.Cells.Add(cell2);
                row.Cells.Add(cell3);
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
            addStudent(textBox1.Text, textBox2.Text, int.Parse(textBox3.Text));
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
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        
    }
}

