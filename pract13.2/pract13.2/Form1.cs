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
        private SortedDictionary<string,Computer> computersList = new SortedDictionary<string,Computer>();
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
                dataGridViewColumn1.Width = dataGridView1.Width / 5;
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
                dataGridViewColumn2.Width = dataGridView1.Width / 5;
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
                dataGridViewColumn3.Width = dataGridView1.Width / 5;
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
                dataGridViewColumn4.Width = dataGridView1.Width / 5;
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
                dataGridViewColumn5.Width = dataGridView1.Width / 5;
            }
            return dataGridViewColumn5;
        }
        private void addComputer(string processor, string motherboard, string RAM, string video_card, string power_unit)
        {
            Computer s = new Computer(processor,motherboard,RAM,video_card,power_unit);
            computersList.Add("computer",s);
            this.processor.Text = "" ;
            videocard.Text = "" ;
            ram.Text = "" ;
            showListInGrid();
        }
        //Удаление студента с колекции
        //Отображение колекции в таблице
        private void showListInGrid()
        {
            dataGridView1.Rows.Clear();
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

                row.Cells.Add(cell1);
                row.Cells.Add(cell2);
                row.Cells.Add(cell3);
                row.Cells.Add(cell4);
                row.Cells.Add(cell5);
                dataGridView1.Rows.Add(row);
            }
        }
        private void Delete(int index)
        {
            dataGridView1.Rows.C();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addComputer(processor.Text, motherboard.Text, ram.Text,videocard.Text,powerunit.Text);
        }
      
    }
}
