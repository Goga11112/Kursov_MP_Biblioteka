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
    public partial class Editing : Form
    {
        public DataGridViewRow row = new DataGridViewRow();
        DataGridViewCell Kod_book_rep1 = new DataGridViewTextBoxCell();
        DataGridViewCell Name_book_rep1 = new DataGridViewTextBoxCell();
        DataGridViewCell Name_writer_rep1 = new DataGridViewTextBoxCell();
        DataGridViewCell Data_create_rep1 = new DataGridViewTextBoxCell();
        DataGridViewCell Nom_stellach_rep1 = new DataGridViewTextBoxCell(); 
        DataGridViewCell Nom_shkaf_rep1 = new DataGridViewTextBoxCell(); 
        DataGridViewCell Nom_polka_rep1 = new DataGridViewTextBoxCell();
        public Editing()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)  
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kod_book_rep1.Value = Kod_book_rep.Text;
            Name_book_rep1.Value = Name_book_rep.Text;
            Name_writer_rep1.Value = Name_writer_rep.Text;
            Data_create_rep1.Value = Data_create_rep.Text;
            Nom_stellach_rep1.Value = Nom_stellach_rep.Text;
            Nom_shkaf_rep1.Value = Nom_shkaf_rep.Text;
            Nom_polka_rep1.Value = Nom_polka_rep.Text;

            try
            {

                string Text = Name_book_rep.Text;
                string Text2 = Name_writer_rep.Text;
                int kod = int.Parse(Kod_book_rep.Text);
                int kod1 = int.Parse(Nom_shkaf_rep.Text);
                int kod2 = int.Parse(Nom_stellach_rep.Text);
                int kod3 = int.Parse(Nom_polka_rep.Text);
                var parts = Data_create_rep.Text.Split('.');
                if ((int.Parse(parts[0]) >= 1) && (int.Parse(parts[0]) <= 31) && (int.Parse(parts[1]) >= 1) && (int.Parse(parts[1]) <= 12) && (int.Parse(parts[2]) >= 0001) && (int.Parse(parts[0]) <= 9999))
                {

                }
                else MessageBox.Show("Не правильно введена дата!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Введите полную информацию или проверьте всё ли верно введено"); //либо показывать свою строку
                return;
            }
            //MessageBox.Show(ex.Message); //либо показывать свою строку

            // добавление в строку элементов

            Add(Kod_book_rep1, Name_book_rep1, Name_writer_rep1, Data_create_rep1, Nom_stellach_rep1, Nom_shkaf_rep1, Nom_polka_rep1);
            Kod_book_rep.Clear();
            Name_book_rep.Clear();
            Name_writer_rep.Clear();
            Data_create_rep.Clear();
            Nom_stellach_rep.Clear();
            Nom_shkaf_rep.Clear();
            Nom_polka_rep.Clear();
            this.Close();
        }
        public void Add(DataGridViewCell Kod_book1, DataGridViewCell Name_book1, DataGridViewCell Name_writer1, DataGridViewCell Data_create1, DataGridViewCell Nom_stellach1, DataGridViewCell Nom_shkaf1, DataGridViewCell Nom_polki1)
        {
            row = new DataGridViewRow();
            row.Cells.AddRange(Kod_book1, Name_book1, Name_writer1, Data_create1, Nom_stellach1, Nom_shkaf1, Nom_polki1);
        }
    }
}
