namespace WindowsFormsApp1
{
    partial class addBook
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
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_add_member = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_shelfNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_pageCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_author = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_bookCount = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(136, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kitap Ekleme Sayfası";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_bookCount);
            this.panel1.Controls.Add(this.b_add_member);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox_name);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_shelfNo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_pageCount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox_author);
            this.panel1.Location = new System.Drawing.Point(51, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 381);
            this.panel1.TabIndex = 13;
            // 
            // b_add_member
            // 
            this.b_add_member.BackColor = System.Drawing.Color.LimeGreen;
            this.b_add_member.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_add_member.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_add_member.Location = new System.Drawing.Point(78, 302);
            this.b_add_member.Name = "b_add_member";
            this.b_add_member.Size = new System.Drawing.Size(199, 57);
            this.b_add_member.TabIndex = 12;
            this.b_add_member.Text = "Kitap Ekle";
            this.b_add_member.UseVisualStyleBackColor = false;
            this.b_add_member.Click += new System.EventHandler(this.b_add_member_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(24, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Kitap Yazarı:";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(147, 90);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(170, 20);
            this.textBox_name.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Raf Numarası:";
            // 
            // textBox_shelfNo
            // 
            this.textBox_shelfNo.Location = new System.Drawing.Point(147, 197);
            this.textBox_shelfNo.Name = "textBox_shelfNo";
            this.textBox_shelfNo.Size = new System.Drawing.Size(170, 20);
            this.textBox_shelfNo.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sayfa Sayısı:";
            // 
            // textBox_pageCount
            // 
            this.textBox_pageCount.Location = new System.Drawing.Point(147, 144);
            this.textBox_pageCount.Name = "textBox_pageCount";
            this.textBox_pageCount.Size = new System.Drawing.Size(170, 20);
            this.textBox_pageCount.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kitap Adı:";
            // 
            // textBox_author
            // 
            this.textBox_author.Location = new System.Drawing.Point(147, 37);
            this.textBox_author.Name = "textBox_author";
            this.textBox_author.Size = new System.Drawing.Size(170, 20);
            this.textBox_author.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Adet Sayısı:";
            // 
            // textBox_bookCount
            // 
            this.textBox_bookCount.Location = new System.Drawing.Point(147, 251);
            this.textBox_bookCount.Name = "textBox_bookCount";
            this.textBox_bookCount.Size = new System.Drawing.Size(170, 20);
            this.textBox_bookCount.TabIndex = 13;
            // 
            // addBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(468, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Name = "addBook";
            this.Text = "Kitap Ekle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_add_member;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_shelfNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_pageCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_author;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_bookCount;
    }
}