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
    public partial class Search : Form
    {
        public Main_menu Main_menu;
        public Search(Main_menu form)
        {
            InitializeComponent();
            Main_menu = form;
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int j = 0;
            List<DataGridViewRow> list = new List<DataGridViewRow>();
            foreach (DataGridViewRow i in Main_menu.dataGridView1.Rows)
            {
                if ((i.Cells["Name_book"].Value.ToString() == Name_book.Text) && (i.Cells["Name_writer"].Value.ToString() == Name_writer.Text))
                {
                    MessageBox.Show("Книга находится на " + i.Cells["Nom_stel"].Value.ToString() + " стеллаже, в " + i.Cells["Nom_shkaf"].Value.ToString() + " шкафу, на " + i.Cells["Nom_polki"].Value.ToString() + " полке");
                    j++;
                }
            }
            if (j == 0) 
            {
                MessageBox.Show("Данной книги не найдено");
            }
            j = 0;
        }
    }
}
