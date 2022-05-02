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
            int god_zadan = int.Parse(textBox1.Text.Split('.')[2]);
            List<DataGridViewRow> list = new List<DataGridViewRow>();
            foreach (DataGridViewRow i in Main_menu.dataGridView1.Rows)
            {
                if (int.Parse(i.Cells["Data_create"].Value.ToString().Split('.')[2]) <= god_zadan)
                    Main_menu.dataGridView1.Rows[i.Index].DefaultCellStyle.BackColor = Color.Red;
            }
        }
    }
}
