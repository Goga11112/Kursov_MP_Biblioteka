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
    public partial class Form2 : Form
    {
        public Main_menu Main_menu;
        public Form2(Main_menu form)
        {
            InitializeComponent();
            Main_menu = form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            table2 table = new table2();

            List<DataGridViewRow> list = new List<DataGridViewRow>();
            foreach (DataGridViewRow i in Main_menu.dataGridView1.Rows)
            {
                if (i.Cells["Name_writer"].Value.ToString() == Name_writer.Text)
                {
                    list.Add(i);
                    table.Table222.Rows.Add(i.Cells["ID"].Value.ToString(), i.Cells["Name_book"].Value.ToString(), i.Cells["Name_writer"].Value.ToString(), i.Cells["Data_create"].Value.ToString(), i.Cells["Nom_stel"].Value.ToString(), i.Cells["Nom_shkaf"].Value.ToString(), i.Cells["Nom_polki"].Value.ToString());
                }
                
            }
          
            if (list.Count == 0)
            {
                MessageBox.Show("Такого автора нет в библиотеке");
                return;
            }
            else
            {
                table.ShowDialog();
            }
        }


    }

    
}
