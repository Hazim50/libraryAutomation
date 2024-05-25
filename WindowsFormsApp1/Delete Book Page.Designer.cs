namespace WindowsFormsApp1
{
    partial class deleteBook
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
            this.radioButton_name = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.radioButton_author = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_author = new System.Windows.Forms.TextBox();
            this.radioButton_Id = new System.Windows.Forms.RadioButton();
            this.b_delete_book = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton_name
            // 
            this.radioButton_name.AutoSize = true;
            this.radioButton_name.Location = new System.Drawing.Point(896, 285);
            this.radioButton_name.Name = "radioButton_name";
            this.radioButton_name.Size = new System.Drawing.Size(14, 13);
            this.radioButton_name.TabIndex = 35;
            this.radioButton_name.TabStop = true;
            this.radioButton_name.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(711, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Kitap Adına Göre Sil";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(704, 282);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(185, 20);
            this.textBox_name.TabIndex = 33;
            // 
            // radioButton_author
            // 
            this.radioButton_author.AutoSize = true;
            this.radioButton_author.Location = new System.Drawing.Point(896, 179);
            this.radioButton_author.Name = "radioButton_author";
            this.radioButton_author.Size = new System.Drawing.Size(14, 13);
            this.radioButton_author.TabIndex = 32;
            this.radioButton_author.TabStop = true;
            this.radioButton_author.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(733, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Yazara Göre Sil";
            // 
            // textBox_author
            // 
            this.textBox_author.Location = new System.Drawing.Point(704, 176);
            this.textBox_author.Name = "textBox_author";
            this.textBox_author.Size = new System.Drawing.Size(185, 20);
            this.textBox_author.TabIndex = 30;
            // 
            // radioButton_Id
            // 
            this.radioButton_Id.AutoSize = true;
            this.radioButton_Id.Checked = true;
            this.radioButton_Id.Location = new System.Drawing.Point(896, 82);
            this.radioButton_Id.Name = "radioButton_Id";
            this.radioButton_Id.Size = new System.Drawing.Size(14, 13);
            this.radioButton_Id.TabIndex = 29;
            this.radioButton_Id.TabStop = true;
            this.radioButton_Id.UseVisualStyleBackColor = true;
            // 
            // b_delete_book
            // 
            this.b_delete_book.BackColor = System.Drawing.Color.Red;
            this.b_delete_book.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_delete_book.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_delete_book.Location = new System.Drawing.Point(704, 352);
            this.b_delete_book.Name = "b_delete_book";
            this.b_delete_book.Size = new System.Drawing.Size(185, 67);
            this.b_delete_book.TabIndex = 28;
            this.b_delete_book.Text = "Kayıt Sil";
            this.b_delete_book.UseVisualStyleBackColor = false;
            this.b_delete_book.Click += new System.EventHandler(this.b_delete_book_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(733, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "ID\'ye Göre Sil";
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(704, 80);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(185, 20);
            this.textBox_ID.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(253, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Kitap Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Yellow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(31, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(643, 366);
            this.dataGridView1.TabIndex = 24;
            // 
            // deleteBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(931, 450);
            this.Controls.Add(this.radioButton_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.radioButton_author);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_author);
            this.Controls.Add(this.radioButton_Id);
            this.Controls.Add(this.b_delete_book);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "deleteBook";
            this.Text = "Kitap Sil";
            this.Load += new System.EventHandler(this.deleteBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButton_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.RadioButton radioButton_author;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_author;
        private System.Windows.Forms.RadioButton radioButton_Id;
        private System.Windows.Forms.Button b_delete_book;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}