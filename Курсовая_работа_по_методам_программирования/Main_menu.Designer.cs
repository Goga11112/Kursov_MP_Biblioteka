﻿namespace Курсовая_работа_по_методам_программирования
{
    partial class Main_menu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.управлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поКритериямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.общийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.поДатеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Добавить = new System.Windows.Forms.Button();
            this.Удалить = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_writer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Create = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_stel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_shkaf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_polki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.About_book = new System.Windows.Forms.Button();
            this.Recompase = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.управлениеToolStripMenuItem,
            this.отчетToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // управлениеToolStripMenuItem
            // 
            this.управлениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem,
            this.добавитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.поискToolStripMenuItem});
            this.управлениеToolStripMenuItem.Name = "управлениеToolStripMenuItem";
            this.управлениеToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.управлениеToolStripMenuItem.Text = "Управление";
            this.управлениеToolStripMenuItem.Click += new System.EventHandler(this.управлениеToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить всё";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.поискToolStripMenuItem.Text = "Поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // отчетToolStripMenuItem
            // 
            this.отчетToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поКритериямToolStripMenuItem,
            this.общийToolStripMenuItem});
            this.отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            this.отчетToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.отчетToolStripMenuItem.Text = "Отчет";
            // 
            // поКритериямToolStripMenuItem
            // 
            this.поКритериямToolStripMenuItem.Name = "поКритериямToolStripMenuItem";
            this.поКритериямToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.поКритериямToolStripMenuItem.Text = "Выделить по дате";
            this.поКритериямToolStripMenuItem.Click += new System.EventHandler(this.поКритериямToolStripMenuItem_Click);
            // 
            // общийToolStripMenuItem
            // 
            this.общийToolStripMenuItem.Name = "общийToolStripMenuItem";
            this.общийToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.общийToolStripMenuItem.Text = "Общий";
            this.общийToolStripMenuItem.Click += new System.EventHandler(this.общийToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поДатеToolStripMenuItem,
            this.удалитьВсеToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
            this.toolStripMenuItem1.Text = "Удаление";
            // 
            // поДатеToolStripMenuItem
            // 
            this.поДатеToolStripMenuItem.Name = "поДатеToolStripMenuItem";
            this.поДатеToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.поДатеToolStripMenuItem.Text = "По дате";
            this.поДатеToolStripMenuItem.Click += new System.EventHandler(this.поДатеToolStripMenuItem_Click);
            // 
            // удалитьВсеToolStripMenuItem
            // 
            this.удалитьВсеToolStripMenuItem.Name = "удалитьВсеToolStripMenuItem";
            this.удалитьВсеToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.удалитьВсеToolStripMenuItem.Text = "Удалить все";
            this.удалитьВсеToolStripMenuItem.Click += new System.EventHandler(this.удалитьВсеToolStripMenuItem_Click_1);
            // 
            // Добавить
            // 
            this.Добавить.BackColor = System.Drawing.Color.IndianRed;
            this.Добавить.Location = new System.Drawing.Point(12, 51);
            this.Добавить.Name = "Добавить";
            this.Добавить.Size = new System.Drawing.Size(108, 51);
            this.Добавить.TabIndex = 1;
            this.Добавить.Text = "Добавить";
            this.Добавить.UseVisualStyleBackColor = false;
            this.Добавить.Click += new System.EventHandler(this.Добавить_Click);
            // 
            // Удалить
            // 
            this.Удалить.BackColor = System.Drawing.Color.IndianRed;
            this.Удалить.Location = new System.Drawing.Point(126, 51);
            this.Удалить.Name = "Удалить";
            this.Удалить.Size = new System.Drawing.Size(108, 51);
            this.Удалить.TabIndex = 2;
            this.Удалить.Text = "Удалить";
            this.Удалить.UseVisualStyleBackColor = false;
            this.Удалить.Click += new System.EventHandler(this.Удалить_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Salmon;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Name_book,
            this.Name_writer,
            this.Data_Create,
            this.Nom_stel,
            this.Nom_shkaf,
            this.Nom_polki});
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(12, 130);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(742, 295);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1900, 539);
            this.dataGridView1.TabIndex = 5;
            // 
            // ID
            // 
            this.ID.HeaderText = "Id";
            this.ID.Name = "ID";
            // 
            // Name_book
            // 
            this.Name_book.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Name_book.DefaultCellStyle = dataGridViewCellStyle1;
            this.Name_book.HeaderText = "Название книги";
            this.Name_book.Name = "Name_book";
            // 
            // Name_writer
            // 
            this.Name_writer.HeaderText = "Имя автора";
            this.Name_writer.Name = "Name_writer";
            // 
            // Data_Create
            // 
            this.Data_Create.HeaderText = "Дата издания";
            this.Data_Create.Name = "Data_Create";
            // 
            // Nom_stel
            // 
            this.Nom_stel.HeaderText = "Номер стеллажа";
            this.Nom_stel.Name = "Nom_stel";
            // 
            // Nom_shkaf
            // 
            this.Nom_shkaf.HeaderText = "Номер шкафа";
            this.Nom_shkaf.Name = "Nom_shkaf";
            // 
            // Nom_polki
            // 
            this.Nom_polki.HeaderText = "Номер полки";
            this.Nom_polki.Name = "Nom_polki";
            // 
            // About_book
            // 
            this.About_book.BackColor = System.Drawing.Color.IndianRed;
            this.About_book.Location = new System.Drawing.Point(240, 51);
            this.About_book.Name = "About_book";
            this.About_book.Size = new System.Drawing.Size(108, 51);
            this.About_book.TabIndex = 6;
            this.About_book.Text = "Книги автора";
            this.About_book.UseVisualStyleBackColor = false;
            this.About_book.Click += new System.EventHandler(this.About_book_Click);
            // 
            // Recompase
            // 
            this.Recompase.BackColor = System.Drawing.Color.IndianRed;
            this.Recompase.Location = new System.Drawing.Point(354, 51);
            this.Recompase.Name = "Recompase";
            this.Recompase.Size = new System.Drawing.Size(108, 51);
            this.Recompase.TabIndex = 7;
            this.Recompase.Text = "Изменить расположение самой старой книжки\r\n";
            this.Recompase.UseVisualStyleBackColor = false;
            this.Recompase.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1924, 681);
            this.Controls.Add(this.Recompase);
            this.Controls.Add(this.About_book);
            this.Controls.Add(this.Удалить);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Добавить);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(10000000, 123123);
            this.Name = "Main_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программа учёта для читателя";
            this.TransparencyKey = System.Drawing.Color.Coral;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem управлениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem общийToolStripMenuItem;
        private System.Windows.Forms.Button Добавить;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.Button Удалить;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem поДатеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВсеToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_book;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_writer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Create;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_stel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_shkaf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_polki;
        private System.Windows.Forms.ToolStripMenuItem поКритериямToolStripMenuItem;
        private System.Windows.Forms.Button About_book;
        private System.Windows.Forms.Button Recompase;
    }
}