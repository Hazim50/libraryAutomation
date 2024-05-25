namespace WindowsFormsApp1
{
    partial class deleteMember
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.b_delete_member = new System.Windows.Forms.Button();
            this.radioButton_Id = new System.Windows.Forms.RadioButton();
            this.radioButton_name = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.radioButton_surname = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.radioButton_mail = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_tel = new System.Windows.Forms.TextBox();
            this.radioButton_tel = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(259, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Üye Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Yellow;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(37, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 366);
            this.dataGridView1.TabIndex = 6;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(615, 42);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(185, 20);
            this.textBox_ID.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(650, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID\'ye Göre Sil";
            // 
            // b_delete_member
            // 
            this.b_delete_member.BackColor = System.Drawing.Color.Red;
            this.b_delete_member.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_delete_member.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_delete_member.Location = new System.Drawing.Point(615, 344);
            this.b_delete_member.Name = "b_delete_member";
            this.b_delete_member.Size = new System.Drawing.Size(185, 67);
            this.b_delete_member.TabIndex = 10;
            this.b_delete_member.Text = "Üye Sil";
            this.b_delete_member.UseVisualStyleBackColor = false;
            this.b_delete_member.Click += new System.EventHandler(this.b_delete_member_Click);
            // 
            // radioButton_Id
            // 
            this.radioButton_Id.AutoSize = true;
            this.radioButton_Id.Checked = true;
            this.radioButton_Id.Location = new System.Drawing.Point(807, 44);
            this.radioButton_Id.Name = "radioButton_Id";
            this.radioButton_Id.Size = new System.Drawing.Size(14, 13);
            this.radioButton_Id.TabIndex = 11;
            this.radioButton_Id.TabStop = true;
            this.radioButton_Id.UseVisualStyleBackColor = true;
            // 
            // radioButton_name
            // 
            this.radioButton_name.AutoSize = true;
            this.radioButton_name.Location = new System.Drawing.Point(807, 100);
            this.radioButton_name.Name = "radioButton_name";
            this.radioButton_name.Size = new System.Drawing.Size(14, 13);
            this.radioButton_name.TabIndex = 14;
            this.radioButton_name.TabStop = true;
            this.radioButton_name.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(650, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "İsme Göre Sil";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(615, 98);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(185, 20);
            this.textBox_name.TabIndex = 12;
            // 
            // radioButton_surname
            // 
            this.radioButton_surname.AutoSize = true;
            this.radioButton_surname.Location = new System.Drawing.Point(807, 163);
            this.radioButton_surname.Name = "radioButton_surname";
            this.radioButton_surname.Size = new System.Drawing.Size(14, 13);
            this.radioButton_surname.TabIndex = 17;
            this.radioButton_surname.TabStop = true;
            this.radioButton_surname.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(635, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Soyisime Göre Sil";
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(615, 161);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(185, 20);
            this.textBox_surname.TabIndex = 15;
            // 
            // radioButton_mail
            // 
            this.radioButton_mail.AutoSize = true;
            this.radioButton_mail.Location = new System.Drawing.Point(807, 228);
            this.radioButton_mail.Name = "radioButton_mail";
            this.radioButton_mail.Size = new System.Drawing.Size(14, 13);
            this.radioButton_mail.TabIndex = 20;
            this.radioButton_mail.TabStop = true;
            this.radioButton_mail.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(647, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Maile Göre Sil";
            // 
            // textBox_mail
            // 
            this.textBox_mail.Location = new System.Drawing.Point(615, 226);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(185, 20);
            this.textBox_mail.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(605, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Tel Numarasına Göre Sil";
            // 
            // textBox_tel
            // 
            this.textBox_tel.Location = new System.Drawing.Point(615, 293);
            this.textBox_tel.Name = "textBox_tel";
            this.textBox_tel.Size = new System.Drawing.Size(185, 20);
            this.textBox_tel.TabIndex = 21;
            // 
            // radioButton_tel
            // 
            this.radioButton_tel.AutoSize = true;
            this.radioButton_tel.Location = new System.Drawing.Point(807, 296);
            this.radioButton_tel.Name = "radioButton_tel";
            this.radioButton_tel.Size = new System.Drawing.Size(14, 13);
            this.radioButton_tel.TabIndex = 23;
            this.radioButton_tel.TabStop = true;
            this.radioButton_tel.UseVisualStyleBackColor = true;
            // 
            // deleteMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(868, 450);
            this.Controls.Add(this.radioButton_tel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_tel);
            this.Controls.Add(this.radioButton_mail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_mail);
            this.Controls.Add(this.radioButton_surname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_surname);
            this.Controls.Add(this.radioButton_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.radioButton_Id);
            this.Controls.Add(this.b_delete_member);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "deleteMember";
            this.Text = "Delete_Member_Page";
            this.Load += new System.EventHandler(this.deleteMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_delete_member;
        private System.Windows.Forms.RadioButton radioButton_Id;
        private System.Windows.Forms.RadioButton radioButton_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.RadioButton radioButton_surname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.RadioButton radioButton_mail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_tel;
        private System.Windows.Forms.RadioButton radioButton_tel;
    }
}