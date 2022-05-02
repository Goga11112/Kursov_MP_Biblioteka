namespace Курсовая_работа_по_методам_программирования
{
    partial class Addendum
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Name_book = new System.Windows.Forms.TextBox();
            this.Name_writer = new System.Windows.Forms.TextBox();
            this.Data_create = new System.Windows.Forms.TextBox();
            this.Nom_stellach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nom_polki = new System.Windows.Forms.TextBox();
            this.Nom_shkaf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Сохранить = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название книги";
            // 
            // Name_book
            // 
            this.Name_book.Location = new System.Drawing.Point(148, 42);
            this.Name_book.Name = "Name_book";
            this.Name_book.Size = new System.Drawing.Size(284, 20);
            this.Name_book.TabIndex = 2;
            // 
            // Name_writer
            // 
            this.Name_writer.Location = new System.Drawing.Point(148, 71);
            this.Name_writer.Name = "Name_writer";
            this.Name_writer.Size = new System.Drawing.Size(284, 20);
            this.Name_writer.TabIndex = 3;
            // 
            // Data_create
            // 
            this.Data_create.Location = new System.Drawing.Point(148, 100);
            this.Data_create.Name = "Data_create";
            this.Data_create.Size = new System.Drawing.Size(129, 20);
            this.Data_create.TabIndex = 4;
            this.Data_create.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Nom_stellach
            // 
            this.Nom_stellach.Location = new System.Drawing.Point(148, 130);
            this.Nom_stellach.Name = "Nom_stellach";
            this.Nom_stellach.Size = new System.Drawing.Size(100, 20);
            this.Nom_stellach.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Имя автора";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Год издания(дд.мм.гггг)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Номер стеллажа";
            // 
            // Nom_polki
            // 
            this.Nom_polki.Location = new System.Drawing.Point(148, 188);
            this.Nom_polki.Name = "Nom_polki";
            this.Nom_polki.Size = new System.Drawing.Size(100, 20);
            this.Nom_polki.TabIndex = 11;
            // 
            // Nom_shkaf
            // 
            this.Nom_shkaf.Location = new System.Drawing.Point(148, 159);
            this.Nom_shkaf.Name = "Nom_shkaf";
            this.Nom_shkaf.Size = new System.Drawing.Size(100, 20);
            this.Nom_shkaf.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Номер шкафа";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Номер полки";
            // 
            // Сохранить
            // 
            this.Сохранить.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Сохранить.BackColor = System.Drawing.Color.Transparent;
            this.Сохранить.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Сохранить.Location = new System.Drawing.Point(325, 201);
            this.Сохранить.Name = "Сохранить";
            this.Сохранить.Size = new System.Drawing.Size(107, 33);
            this.Сохранить.TabIndex = 0;
            this.Сохранить.Text = "Сохранить";
            this.Сохранить.UseVisualStyleBackColor = false;
            this.Сохранить.Click += new System.EventHandler(this.Сохранить_Click);
            // 
            // Addendum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 272);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Nom_shkaf);
            this.Controls.Add(this.Nom_polki);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nom_stellach);
            this.Controls.Add(this.Data_create);
            this.Controls.Add(this.Name_writer);
            this.Controls.Add(this.Name_book);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Сохранить);
            this.Name = "Addendum";
            this.Text = "Добавление новой книги";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox Name_book;
        public System.Windows.Forms.TextBox Name_writer;
        public System.Windows.Forms.TextBox Data_create;
        public System.Windows.Forms.TextBox Nom_stellach;
        public System.Windows.Forms.TextBox Nom_polki;
        public System.Windows.Forms.TextBox Nom_shkaf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Сохранить;
    }
}