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
    public partial class data_search : Form
    {
        public Main_menu Main_menu;
        public data_search(Main_menu form)
        {
            InitializeComponent();
            Main_menu = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int god_zadan = int.Parse(textBox1.Text.Split('.')[2]);
                List<DataGridViewRow> list = new List<DataGridViewRow>();
                foreach (DataGridViewRow i in Main_menu.dataGridView1.Rows)
                {
                    if (int.Parse(i.Cells["Data_create"].Value.ToString().Split('.')[2]) == god_zadan)
                        list.Add(i);
                }
                MessageBox.Show("Колличество книг с данной датой издания: " + list.Count);
            }
            catch {
                MessageBox.Show("Неправильный формат даты!");

            }
        }
    }
}
