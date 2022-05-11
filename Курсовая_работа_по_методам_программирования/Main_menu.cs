using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using ExcelDataReader;
using Microsoft.Win32;
using System.Data.OleDb;

namespace Курсовая_работа_по_методам_программирования
{

    public partial class Main_menu : Form
    {
        public int count;
        public int count_ID=1;
        DataGridViewCell Kod_book1 = new DataGridViewTextBoxCell();
        DataGridViewCell Name_book1 = new DataGridViewTextBoxCell();
        DataGridViewCell Name_writer1 = new DataGridViewTextBoxCell();
        public DataGridViewCell Data_create1 = new DataGridViewTextBoxCell();
        DataGridViewCell Nom_stellach1 = new DataGridViewTextBoxCell();
        DataGridViewCell Nom_shkaf1 = new DataGridViewTextBoxCell();
        DataGridViewCell Nom_polki1 = new DataGridViewTextBoxCell();
        public int flag;

        public Main_menu()
        {
            InitializeComponent();

            
                dataGridView1.Rows.Add(1,"Зелёная миля", "Стивен Кинг","11.12.1996",111,23,10);
                dataGridView1.Rows.Add(2, "Абли-баба", "Стивен Кинг", "11.12.2000", 11, 13, 10);
                dataGridView1.Rows.Add(3, "Черный клевер", "Стивен Кинг", "11.12.1999", 1, 1, 10);
                dataGridView1.Rows.Add(4, "Черная рука", "Стивен Кинг", "11.12.1980", 110, 13, 10);
                dataGridView1.Rows.Add(5, "Заводной механизм", "Стивен Кинг", "11.12.1970", 100, 23, 10);
                dataGridView1.Rows.Add(6, "Как долго летала пчела", "Стивен Кинг", "11.12.1976", 101, 23, 10);
                dataGridView1.Rows.Add(7, "Почему упал самолет", "Стивен Кинг", "11.12.1989", 200, 12, 10);

        }
        private void Добавить_Click(object sender, EventArgs e)
        {
            Addendum Addendum = new Addendum(this);
            Addendum.ShowDialog();
            
            dataGridView1.Rows.Add(Addendum.row); 
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Addendum Addendum = new Addendum(this);
            Addendum.ShowDialog();
            
            dataGridView1.Rows.Add(Addendum.row); 

        }

        private void удалитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void Удалить_Click(object sender, EventArgs e)
        {
            try
            {
                int ind = dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.Rows.RemoveAt(ind);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Editing form4 = new Editing();
                int flag = dataGridView1.SelectedCells[0].RowIndex;
                form4.Kod_book_rep.Text = dataGridView1.Rows[flag].Cells[0].Value.ToString();
                form4.Name_book_rep.Text = dataGridView1.Rows[flag].Cells[1].Value.ToString();
                form4.Name_writer_rep.Text = dataGridView1.Rows[flag].Cells[2].Value.ToString();
                form4.Data_create_rep.Text = dataGridView1.Rows[flag].Cells[3].Value.ToString();
                form4.Nom_stellach_rep.Text = dataGridView1.Rows[flag].Cells[4].Value.ToString();
                form4.Nom_shkaf_rep.Text = dataGridView1.Rows[flag].Cells[5].Value.ToString();
                form4.Nom_polka_rep.Text = dataGridView1.Rows[flag].Cells[6].Value.ToString();
                form4.ShowDialog();
                dataGridView1.Rows.RemoveAt(flag);
                dataGridView1.Rows.Add(form4.row);
            }
            catch (Exception ex)
            { 
            MessageBox.Show(ex.Message);
            }
        }


        private void удалитьВсеToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        public void поДатеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            count = dataGridView1.Rows.Count;
            Deletion_date Deletion_date = new Deletion_date(this);
            Deletion_date.ShowDialog();
        }

        private void Main_menu_Load(object sender, EventArgs e)
        {
        }
        public void Delete(string parts)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[3].Value != null)
                {
                    var parts2 = dataGridView1.Rows[i].Cells[3].Value.ToString().Split('.');
                    if (int.Parse(parts) >= int.Parse(parts2[2])) {
                        count--;
                        dataGridView1.Rows.RemoveAt(i);
                }
                }
            }
            
        }

        private void общийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int k = dataGridView1.Rows.Count;
            MessageBox.Show("Колличество книг в библиотеке: " + k);
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search Search = new Search(this);
            Search.ShowDialog();
        }

        private void поКритериямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            data_search form2 = new data_search(this);
            form2.ShowDialog();
        }

        private void About_book_Click(object sender, EventArgs e)
        {   
            Form2 form = new Form2(this);
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int flag = 0;
                int min = 10000;
                List<DataGridViewRow> list = new List<DataGridViewRow>();
                Random random = new Random();
                foreach (DataGridViewRow i in dataGridView1.Rows)
                {
                    if (i.Cells["Data_create"].Value != null)
                    {
                        if (int.Parse(i.Cells["Data_create"].Value.ToString().Split('.')[2]) < min)
                        {
                            min = int.Parse(i.Cells["Data_create"].Value.ToString().Split('.')[2]);
                            flag = i.Index;
                        }
                    }
                    else 
                        dataGridView1.Rows.RemoveAt(i.Index);
                }
                dataGridView1.Rows[flag].Cells["Nom_stel"].Value = random.Next(1, 100);
                dataGridView1.Rows[flag].Cells["Nom_shkaf"].Value = random.Next(1, 10);
                dataGridView1.Rows[flag].Cells["Nom_polki"].Value = random.Next(1, 10);
            }
            catch
            {
                MessageBox.Show("Данные не найдены");
            }
        }

        private void управлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
   
}
