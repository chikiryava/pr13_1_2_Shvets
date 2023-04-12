using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pract13._2
{
    public partial class Form1 : Form
    {
        private DataGridViewColumn dataGridViewColumn1 = null;
        private DataGridViewColumn dataGridViewColumn2 = null;
        private DataGridViewColumn dataGridViewColumn3 = null;
        private DataGridViewColumn dataGridViewColumn4 = null;
        private DataGridViewColumn dataGridViewColumn5 = null;
        private DataGridViewColumn dataGridViewColumn6 = null;
        private DataGridViewColumn dataGridViewColumn7 = null;
        private SortedDictionary<string,Computer> computersList = new SortedDictionary<string,Computer>();
        static Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            initDataGridView();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void number_of_pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void surname_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
        private void initDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Add(getDataGridViewColumn1());
            dataGridView1.Columns.Add(getDataGridViewColumn2());
            dataGridView1.Columns.Add(getDataGridViewColumn3());
            dataGridView1.Columns.Add(getDataGridViewColumn4());
            dataGridView1.Columns.Add(getDataGridViewColumn5());
            dataGridView1.Columns.Add(getDataGridViewColumn6());
            dataGridView1.Columns.Add(getDataGridViewColumn7());
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
                dataGridViewColumn1.Width = dataGridView1.Width / 7;
            }
            return dataGridViewColumn1;
        }
        //Динамическое создание второй колонки в таблице
        private DataGridViewColumn getDataGridViewColumn2()
        {
            if (dataGridViewColumn2 == null)
            {
                dataGridViewColumn2 = new DataGridViewTextBoxColumn();
                dataGridViewColumn2.Name = "" ;
                dataGridViewColumn2.HeaderText = "Материнская плата" ;
                dataGridViewColumn2.ValueType = typeof(string);
                dataGridViewColumn2.Width = dataGridView1.Width / 7;
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
                dataGridViewColumn3.HeaderText = "Оперативная память" ;
                dataGridViewColumn3.ValueType = typeof(string);
                dataGridViewColumn3.Width = dataGridView1.Width / 7;
            }
            return dataGridViewColumn3;
        }
        private DataGridViewColumn getDataGridViewColumn4()
        {
            if (dataGridViewColumn4 == null)
            {
                dataGridViewColumn4 = new DataGridViewTextBoxColumn();
                dataGridViewColumn4.Name = "";
                dataGridViewColumn4.HeaderText = "Видеокарта";
                dataGridViewColumn4.ValueType = typeof(string);
                dataGridViewColumn4.Width = dataGridView1.Width / 7;
            }
            return dataGridViewColumn4;
        }
        private DataGridViewColumn getDataGridViewColumn5()
        {
            if (dataGridViewColumn5 == null)
            {
                dataGridViewColumn5 = new DataGridViewTextBoxColumn();
                dataGridViewColumn5.Name = "";
                dataGridViewColumn5.HeaderText = "Блок питания";
                dataGridViewColumn5.ValueType = typeof(string);
                dataGridViewColumn5.Width = dataGridView1.Width / 7;
            }
            return dataGridViewColumn5;
        }
        private DataGridViewColumn getDataGridViewColumn6()
        {
            if (dataGridViewColumn6 == null)
            {
                dataGridViewColumn6 = new DataGridViewTextBoxColumn();
                dataGridViewColumn6.Name = "";
                dataGridViewColumn6.HeaderText = "Индекс";
                dataGridViewColumn6.ValueType = typeof(string);
                dataGridViewColumn6.Width = dataGridView1.Width / 7;
            }
            return dataGridViewColumn6;
        }
        private DataGridViewColumn getDataGridViewColumn7()
        {
            if (dataGridViewColumn7 == null)
            {
                dataGridViewColumn7 = new DataGridViewTextBoxColumn();
                dataGridViewColumn7.Name = "";
                dataGridViewColumn7.HeaderText = "Цена";
                dataGridViewColumn7.ValueType = typeof(string);
                dataGridViewColumn7.Width = dataGridView1.Width / 7;
            }
            return dataGridViewColumn7;
        }
            private void addComputer(string processor, string motherboard, string RAM, string video_card, string power_unit,int price)
        {
            Computer s = new Computer(processor,motherboard,RAM,video_card,power_unit,price);
            computersList.Add($"computer{rnd.Next()}",s);
            this.processor.Text = "" ;
            videocard.Text = "" ;
            ram.Text = "" ;
            showListInGrid();
        }
        //Отображение колекции в таблице
        private void showListInGrid()
        {
            dataGridView1.Rows.Clear();
            int id = 0;
            foreach (KeyValuePair<string, Computer> item in computersList)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell cell1 = new
                DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell2 = new
                DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell3 = new
                DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell4 = new
               DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell5 = new
               DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell6 = new
              DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell7 = new
             DataGridViewTextBoxCell();
                cell1.ValueType = typeof(string);
                cell1.Value = item.Value.GetProcessor;
                cell2.ValueType = typeof(string);
                cell2.Value = item.Value.GetMotherboard;
                cell3.ValueType = typeof(string);
                cell3.Value = item.Value.GetRAM;
                cell4.ValueType = typeof(string);
                cell4.Value = item.Value.GetVideoCard;
                cell5.ValueType = typeof(string);
                cell5.Value = item.Value.GetPowerUnit;
                cell6.ValueType = typeof(string);
                cell6.Value = id.ToString();
                cell7.ValueType = typeof(string);
                cell7.Value = item.Value.GetPriceAndConvertToString;
                row.Cells.Add(cell1);
                row.Cells.Add(cell2);
                row.Cells.Add(cell3);
                row.Cells.Add(cell4);
                row.Cells.Add(cell5);
                row.Cells.Add(cell6);
                row.Cells.Add(cell7);
                id++;
                dataGridView1.Rows.Add(row);
            }
            dataGridView1.Sort(dataGridView1.Columns[6], ListSortDirection.Ascending);
            numericUpDown1.Maximum = dataGridView1.Rows.Count - 1;
        }
        private void Delete(int index)
        {
            int i = 0;
            foreach (KeyValuePair<string, Computer> item in computersList)
            {
                if (index == i)
                {
                    string key = item.Key;
                    computersList.Remove(key);
                    break;
                }
                i++;
            }
        }
        private bool CheckPrice(string price)
        {
            if(!int.TryParse(price, out int result))
            {
                MessageBox.Show("Поле цена может содержать только число");
                return false;
            }
            if (result <= 0)
            {
                MessageBox.Show("Цена не может быть меньше или равна 0");
                return false;
            }
            else
                return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(Check(processor.Text,"Процессор")&& Check(videocard.Text, "Видеокарта") && Check(ram.Text, "Оперативная память") && Check(powerunit.Text, "Блок питания") && Check(motherBoard1.Text,"Материнская плата") && CheckPrice(Price.Text))
            addComputer(processor.Text, motherBoard1.Text, ram.Text,videocard.Text,powerunit.Text,int.Parse(Price.Text));
        }
        private bool Check(string value,string partofcomputer)
        {
            if (value.Length == 0)
            {
                MessageBox.Show($"Строка {partofcomputer} не может быть пустой");
                return false;
            }
            else
                return true;
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            Delete(Convert.ToInt32(numericUpDown1.Value));
            showListInGrid();
        }

        private void searchTextBox_Click(object sender, EventArgs e)
        {
            bool stringFound = false;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString()== searchItem.Text)
                        {
                            dataGridView1.Rows[i].Cells[j].Selected = true;
                            stringFound = true;
                            break;
                        }
            }
            if (stringFound == false)
                MessageBox.Show("Совпадений с заданной вами строкой не обнаружено");
        }

        private void searchItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void powerunit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
