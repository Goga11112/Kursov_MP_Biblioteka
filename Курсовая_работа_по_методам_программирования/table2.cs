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
    public partial class table2 : Form
    {
        public table2()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int flag = 0;
                int min = 10000;
                Random random = new Random();
                foreach (DataGridViewRow i in Table222.Rows)
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
                        continue;
                }
                Table222.Rows[flag].Cells["Nom_stel"].Value = random.Next(1, 100);
                Table222.Rows[flag].Cells["Nom_skaf"].Value = random.Next(1, 10);
                Table222.Rows[flag].Cells["Nom_polki"].Value = random.Next(1, 10);
            }
            catch
            {
                MessageBox.Show("Данные не найдены");
            }
        }

       
    }
}
