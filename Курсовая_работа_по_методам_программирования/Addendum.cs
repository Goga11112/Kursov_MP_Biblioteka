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
    public partial class Addendum : Form
    {
        public DataGridViewRow row = new DataGridViewRow();
        DataGridViewCell Name_book1 = new DataGridViewTextBoxCell();
        DataGridViewCell Name_writer1 = new DataGridViewTextBoxCell();
        DataGridViewCell Data_create1 = new DataGridViewTextBoxCell();
        DataGridViewCell Nom_stellach1 = new DataGridViewTextBoxCell();
        DataGridViewCell Nom_shkaf1 = new DataGridViewTextBoxCell(); 
        DataGridViewCell Nom_polki1 = new DataGridViewTextBoxCell();
        DataGridViewCell Kod_book1 = new DataGridViewTextBoxCell();
        public Main_menu Main_menu;
        public Addendum(Main_menu form)
        {
            InitializeComponent();
            Main_menu = form;
        }
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void Сохранить_Click(object sender, EventArgs e)
        { 
            
            
            Name_book1.Value = Name_book.Text;
            Name_writer1.Value = Name_writer.Text;
            Data_create1.Value = Data_create.Text;
            Nom_stellach1.Value = Nom_stellach.Text;
            Nom_shkaf1.Value = Nom_shkaf.Text;
            Nom_polki1.Value = Nom_polki.Text;
            Kod_book1.Value = Kod_book.Text;
            try
            {

                string Text = Name_book.Text;
                string Text2 = Name_writer.Text;
                int kod = int.Parse(Kod_book.Text);

                int kod1 = int.Parse(Nom_shkaf.Text);
                int kod2 = int.Parse(Nom_stellach.Text);
                int kod3 = int.Parse(Nom_polki.Text);
                var parts = Data_create.Text.Split('.');
                if ((int.Parse(parts[0]) >= 1) && (int.Parse(parts[0]) <= 31) && (int.Parse(parts[1]) >= 1) && (int.Parse(parts[1]) <= 12) && (int.Parse(parts[2]) >= 0001) && (int.Parse(parts[0]) <= 9999))
                {
                    // добавление в строку элементов
                    Add(Kod_book1, Name_book1, Name_writer1, Data_create1, Nom_stellach1, Nom_shkaf1, Nom_polki1);
                    Kod_book.Clear();
                    Name_book.Clear();
                    Name_writer.Clear();
                    Data_create.Clear();
                    Nom_stellach.Clear();
                    Nom_shkaf.Clear();
                    Nom_polki.Clear();
                    this.Close();
                }
                else MessageBox.Show("Не правильно введена дата!!!");
            }
            catch
            {
                MessageBox.Show("Введите полную информацию или проверьте всё ли верно введено "); //либо показывать свою строку
                return;
            }
            //MessageBox.Show(ex.Message); //либо показывать свою строку

          
        }
        public void Add(DataGridViewCell Kod_book1, DataGridViewCell Name_book1, DataGridViewCell Name_writer1, DataGridViewCell Data_create1, DataGridViewCell Nom_stellach1, DataGridViewCell Nom_shkaf1, DataGridViewCell Nom_polki1)
        {
            row.Cells.AddRange(Kod_book1, Name_book1, Name_writer1, Data_create1, Nom_stellach1, Nom_shkaf1, Nom_polki1);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
    
    
}
