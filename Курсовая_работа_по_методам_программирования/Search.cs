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
                for (int i = 0; i < Main_menu.dataGridView1.RowCount; i++)
                {
                    Main_menu.dataGridView1.Rows[i].Selected = false;
                        if (Main_menu.dataGridView1.Rows[i].Cells[2].Value != null)
                            if (Main_menu.dataGridView1.Rows[i].Cells[2].Value.ToString().Contains(textBox1.Text))
                            {
                                Main_menu.dataGridView1.Rows[i].Selected = true;
                                break;
                            }
                }
        }
    }
}
