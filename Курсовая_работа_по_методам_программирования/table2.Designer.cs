namespace Курсовая_работа_по_методам_программирования
{
    partial class table2
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
            this.Table222 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_writer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_create = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_stel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_skaf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_polki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Table222)).BeginInit();
            this.SuspendLayout();
            // 
            // Table222
            // 
            this.Table222.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Table222.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table222.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name_book,
            this.Name_writer,
            this.Data_create,
            this.Nom_stel,
            this.Nom_skaf,
            this.Nom_polki});
            this.Table222.Location = new System.Drawing.Point(12, 120);
            this.Table222.Name = "Table222";
            this.Table222.Size = new System.Drawing.Size(776, 318);
            this.Table222.TabIndex = 0;
            this.Table222.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            // 
            // Name_book
            // 
            this.Name_book.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name_book.HeaderText = "Название книги";
            this.Name_book.Name = "Name_book";
            // 
            // Name_writer
            // 
            this.Name_writer.HeaderText = "Имя автора";
            this.Name_writer.Name = "Name_writer";
            // 
            // Data_create
            // 
            this.Data_create.HeaderText = "Дата издания";
            this.Data_create.Name = "Data_create";
            // 
            // Nom_stel
            // 
            this.Nom_stel.HeaderText = "Номер стеллажа";
            this.Nom_stel.Name = "Nom_stel";
            // 
            // Nom_skaf
            // 
            this.Nom_skaf.HeaderText = "Номер шкафа";
            this.Nom_skaf.Name = "Nom_skaf";
            // 
            // Nom_polki
            // 
            this.Nom_polki.HeaderText = "Номер полки";
            this.Nom_polki.Name = "Nom_polki";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 69);
            this.button2.TabIndex = 2;
            this.button2.Text = "Изменить расположение самой старой книги";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // table2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Table222);
            this.Name = "table2";
            this.Text = "Книги с данной датой создания";
            ((System.ComponentModel.ISupportInitialize)(this.Table222)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView Table222;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_book;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_writer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_create;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_stel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_skaf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_polki;
        private System.Windows.Forms.Button button2;
    }
}