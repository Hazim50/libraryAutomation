namespace WindowsFormsApp1
{
    partial class Main
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.b_list_member = new System.Windows.Forms.Button();
            this.b_delete_member = new System.Windows.Forms.Button();
            this.b_add_member = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.b_list_book = new System.Windows.Forms.Button();
            this.b_delete_book = new System.Windows.Forms.Button();
            this.b_add_book = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.b_list_delivery = new System.Windows.Forms.Button();
            this.b_receive = new System.Windows.Forms.Button();
            this.b_deliver = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.b_list_member);
            this.panel1.Controls.Add(this.b_delete_member);
            this.panel1.Controls.Add(this.b_add_member);
            this.panel1.Location = new System.Drawing.Point(88, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 326);
            this.panel1.TabIndex = 0;
            // 
            // b_list_member
            // 
            this.b_list_member.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_list_member.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_list_member.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_list_member.Location = new System.Drawing.Point(44, 245);
            this.b_list_member.Name = "b_list_member";
            this.b_list_member.Size = new System.Drawing.Size(113, 57);
            this.b_list_member.TabIndex = 2;
            this.b_list_member.Text = "Üye Listele";
            this.b_list_member.UseVisualStyleBackColor = false;
            this.b_list_member.Click += new System.EventHandler(this.b_list_member_Click);
            // 
            // b_delete_member
            // 
            this.b_delete_member.BackColor = System.Drawing.Color.Red;
            this.b_delete_member.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_delete_member.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_delete_member.Location = new System.Drawing.Point(44, 135);
            this.b_delete_member.Name = "b_delete_member";
            this.b_delete_member.Size = new System.Drawing.Size(113, 57);
            this.b_delete_member.TabIndex = 1;
            this.b_delete_member.Text = "Üye Sil";
            this.b_delete_member.UseVisualStyleBackColor = false;
            this.b_delete_member.Click += new System.EventHandler(this.b_delete_member_Click);
            // 
            // b_add_member
            // 
            this.b_add_member.BackColor = System.Drawing.Color.LimeGreen;
            this.b_add_member.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_add_member.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_add_member.Location = new System.Drawing.Point(44, 29);
            this.b_add_member.Name = "b_add_member";
            this.b_add_member.Size = new System.Drawing.Size(113, 57);
            this.b_add_member.TabIndex = 0;
            this.b_add_member.Text = "Üye Ekle";
            this.b_add_member.UseVisualStyleBackColor = false;
            this.b_add_member.Click += new System.EventHandler(this.b_add_member_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(133, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Üye İşlemleri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(404, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kitap İşlemleri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(674, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Teslim İşlemleri";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Yellow;
            this.panel4.Controls.Add(this.b_list_book);
            this.panel4.Controls.Add(this.b_delete_book);
            this.panel4.Controls.Add(this.b_add_book);
            this.panel4.Location = new System.Drawing.Point(364, 56);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 326);
            this.panel4.TabIndex = 3;
            // 
            // b_list_book
            // 
            this.b_list_book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_list_book.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_list_book.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_list_book.Location = new System.Drawing.Point(44, 245);
            this.b_list_book.Name = "b_list_book";
            this.b_list_book.Size = new System.Drawing.Size(113, 57);
            this.b_list_book.TabIndex = 2;
            this.b_list_book.Text = "Kitap Listele";
            this.b_list_book.UseVisualStyleBackColor = false;
            // 
            // b_delete_book
            // 
            this.b_delete_book.BackColor = System.Drawing.Color.Red;
            this.b_delete_book.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_delete_book.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_delete_book.Location = new System.Drawing.Point(44, 135);
            this.b_delete_book.Name = "b_delete_book";
            this.b_delete_book.Size = new System.Drawing.Size(113, 57);
            this.b_delete_book.TabIndex = 1;
            this.b_delete_book.Text = "Kitap Sil";
            this.b_delete_book.UseVisualStyleBackColor = false;
            // 
            // b_add_book
            // 
            this.b_add_book.BackColor = System.Drawing.Color.LimeGreen;
            this.b_add_book.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_add_book.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_add_book.Location = new System.Drawing.Point(44, 29);
            this.b_add_book.Name = "b_add_book";
            this.b_add_book.Size = new System.Drawing.Size(113, 57);
            this.b_add_book.TabIndex = 0;
            this.b_add_book.Text = "Kitap Ekle";
            this.b_add_book.UseVisualStyleBackColor = false;
            this.b_add_book.Click += new System.EventHandler(this.b_add_book_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Controls.Add(this.b_list_delivery);
            this.panel2.Controls.Add(this.b_receive);
            this.panel2.Controls.Add(this.b_deliver);
            this.panel2.Location = new System.Drawing.Point(638, 56);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 326);
            this.panel2.TabIndex = 3;
            // 
            // b_list_delivery
            // 
            this.b_list_delivery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.b_list_delivery.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_list_delivery.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_list_delivery.Location = new System.Drawing.Point(44, 245);
            this.b_list_delivery.Name = "b_list_delivery";
            this.b_list_delivery.Size = new System.Drawing.Size(113, 57);
            this.b_list_delivery.TabIndex = 2;
            this.b_list_delivery.Text = "Teslim Listele";
            this.b_list_delivery.UseVisualStyleBackColor = false;
            // 
            // b_receive
            // 
            this.b_receive.BackColor = System.Drawing.Color.Red;
            this.b_receive.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_receive.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_receive.Location = new System.Drawing.Point(44, 135);
            this.b_receive.Name = "b_receive";
            this.b_receive.Size = new System.Drawing.Size(113, 57);
            this.b_receive.TabIndex = 1;
            this.b_receive.Text = "Teslim Al";
            this.b_receive.UseVisualStyleBackColor = false;
            // 
            // b_deliver
            // 
            this.b_deliver.BackColor = System.Drawing.Color.LimeGreen;
            this.b_deliver.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_deliver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_deliver.Location = new System.Drawing.Point(44, 29);
            this.b_deliver.Name = "b_deliver";
            this.b_deliver.Size = new System.Drawing.Size(113, 57);
            this.b_deliver.TabIndex = 0;
            this.b_deliver.Text = "Teslim Et";
            this.b_deliver.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(934, 480);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.Text = "Kütüphane Otomasyonu";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_list_member;
        private System.Windows.Forms.Button b_delete_member;
        private System.Windows.Forms.Button b_add_member;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button b_list_book;
        private System.Windows.Forms.Button b_delete_book;
        private System.Windows.Forms.Button b_add_book;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button b_list_delivery;
        private System.Windows.Forms.Button b_receive;
        private System.Windows.Forms.Button b_deliver;
    }
}

