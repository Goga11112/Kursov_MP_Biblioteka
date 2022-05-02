using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая_работа_по_методам_программирования
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet();
        DataGridViewRow row = new DataGridViewRow();
        DataGridViewCell Kod_book = new DataGridViewTextBoxCell();
        DataGridViewCell Name_book = new DataGridViewTextBoxCell();
        DataGridViewCell Name_writer = new DataGridViewTextBoxCell();
        DataGridViewCell Data_create = new DataGridViewTextBoxCell();
        DataGridViewCell GPS_book = new DataGridViewTextBoxCell();
        Form2 newForm = new Form2();
        public Form1()
        {
            
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            newForm.ShowDialog();
            row.Cells.Add(Name_book);
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
          DataGridView1.Rows.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridView1.Rows.RemoveAt(int.Parse(textBox1.Text));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
