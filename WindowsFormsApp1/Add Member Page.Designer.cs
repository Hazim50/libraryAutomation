namespace WindowsFormsApp1
{
    partial class addMember
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
            this.b_add_member = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_member_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_member_mail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_member_surname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_member_tel = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_member_tel);
            this.panel1.Controls.Add(this.b_add_member);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox_member_name);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_member_mail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox_member_surname);
            this.panel1.Location = new System.Drawing.Point(56, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 381);
            this.panel1.TabIndex = 2;
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
            this.b_add_member.Text = "Üye Ekle";
            this.b_add_member.UseVisualStyleBackColor = false;
            this.b_add_member.Click += new System.EventHandler(this.b_add_member_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(24, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Üye İsim:";
            // 
            // textBox_member_name
            // 
            this.textBox_member_name.Location = new System.Drawing.Point(149, 33);
            this.textBox_member_name.Name = "textBox_member_name";
            this.textBox_member_name.Size = new System.Drawing.Size(170, 20);
            this.textBox_member_name.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(26, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Üye Mail:";
            // 
            // textBox_member_mail
            // 
            this.textBox_member_mail.Location = new System.Drawing.Point(149, 184);
            this.textBox_member_mail.Name = "textBox_member_mail";
            this.textBox_member_mail.Size = new System.Drawing.Size(170, 20);
            this.textBox_member_mail.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(26, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Üye Soyisim:";
            // 
            // textBox_member_surname
            // 
            this.textBox_member_surname.Location = new System.Drawing.Point(149, 109);
            this.textBox_member_surname.Name = "textBox_member_surname";
            this.textBox_member_surname.Size = new System.Drawing.Size(170, 20);
            this.textBox_member_surname.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(141, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Üye Ekleme Sayfası";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Üye Tel:";
            // 
            // textBox_member_tel
            // 
            this.textBox_member_tel.Location = new System.Drawing.Point(149, 256);
            this.textBox_member_tel.Name = "textBox_member_tel";
            this.textBox_member_tel.Size = new System.Drawing.Size(170, 20);
            this.textBox_member_tel.TabIndex = 13;
            // 
            // addMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(464, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Name = "addMember";
            this.Text = "Üye Ekle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_member_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_member_mail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_member_surname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button b_add_member;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_member_tel;
    }
}