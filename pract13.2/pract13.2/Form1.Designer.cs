
namespace pract13._2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.searchItem = new System.Windows.Forms.TextBox();
            this.searchTextBox = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.motherboard = new System.Windows.Forms.Label();
            this.motherBoard1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.powerunit = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ram = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.videocard = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.processor = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1327, 620);
            this.splitContainer1.SplitterDistance = 441;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Price);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.searchItem);
            this.panel1.Controls.Add(this.searchTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.motherboard);
            this.panel1.Controls.Add(this.motherBoard1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.powerunit);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ram);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.videocard);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.processor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 620);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Цена";
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(143, 288);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(100, 20);
            this.Price.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 463);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Введите строку для поиска";
            // 
            // searchItem
            // 
            this.searchItem.Location = new System.Drawing.Point(154, 479);
            this.searchItem.Name = "searchItem";
            this.searchItem.Size = new System.Drawing.Size(100, 20);
            this.searchItem.TabIndex = 15;
            this.searchItem.TextChanged += new System.EventHandler(this.searchItem_TextChanged);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(145, 505);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(120, 23);
            this.searchTextBox.TabIndex = 14;
            this.searchTextBox.Text = "Найти";
            this.searchTextBox.UseVisualStyleBackColor = true;
            this.searchTextBox.Click += new System.EventHandler(this.searchTextBox_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(256, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Укажите индекс строки, которую хотите удалить";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(134, 381);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Удалить из таблицы";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // motherboard
            // 
            this.motherboard.AutoSize = true;
            this.motherboard.Location = new System.Drawing.Point(140, 227);
            this.motherboard.Name = "motherboard";
            this.motherboard.Size = new System.Drawing.Size(107, 13);
            this.motherboard.TabIndex = 10;
            this.motherboard.Text = "Материнская плата";
            // 
            // motherBoard1
            // 
            this.motherBoard1.Location = new System.Drawing.Point(143, 243);
            this.motherBoard1.Name = "motherBoard1";
            this.motherBoard1.Size = new System.Drawing.Size(100, 20);
            this.motherBoard1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Блок питания";
            // 
            // powerunit
            // 
            this.powerunit.Location = new System.Drawing.Point(143, 193);
            this.powerunit.Name = "powerunit";
            this.powerunit.Size = new System.Drawing.Size(100, 20);
            this.powerunit.TabIndex = 7;
            this.powerunit.TextChanged += new System.EventHandler(this.powerunit_TextChanged);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(134, 314);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(120, 23);
            this.Add.TabIndex = 6;
            this.Add.Text = "Добавить в таблицу";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Оперативная память";
            // 
            // ram
            // 
            this.ram.Location = new System.Drawing.Point(143, 141);
            this.ram.Name = "ram";
            this.ram.Size = new System.Drawing.Size(100, 20);
            this.ram.TabIndex = 4;
            this.ram.TextChanged += new System.EventHandler(this.number_of_pass_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Видеокарта";
            // 
            // videocard
            // 
            this.videocard.Location = new System.Drawing.Point(143, 86);
            this.videocard.Name = "videocard";
            this.videocard.Size = new System.Drawing.Size(100, 20);
            this.videocard.TabIndex = 2;
            this.videocard.TextChanged += new System.EventHandler(this.surname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Процессор";
            // 
            // processor
            // 
            this.processor.Location = new System.Drawing.Point(143, 29);
            this.processor.Name = "processor";
            this.processor.Size = new System.Drawing.Size(100, 20);
            this.processor.TabIndex = 0;
            this.processor.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 620);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(882, 590);
            this.dataGridView1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 26);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1327, 620);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "pract 13.2";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ram;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox videocard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox processor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label motherboard;
        private System.Windows.Forms.TextBox motherBoard1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox powerunit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox searchItem;
        private System.Windows.Forms.Button searchTextBox;
    }
}

