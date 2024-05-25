namespace WindowsFormsApp1
{
    partial class deliverBook
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
            this.dgw_Books = new System.Windows.Forms.DataGridView();
            this.dgw_Members = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_Deliver = new System.Windows.Forms.DateTimePicker();
            this.dtp_Return = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.b_deliver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Members)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_Books
            // 
            this.dgw_Books.BackgroundColor = System.Drawing.Color.Yellow;
            this.dgw_Books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Books.GridColor = System.Drawing.Color.Black;
            this.dgw_Books.Location = new System.Drawing.Point(63, 41);
            this.dgw_Books.Name = "dgw_Books";
            this.dgw_Books.RowTemplate.ReadOnly = true;
            this.dgw_Books.Size = new System.Drawing.Size(643, 282);
            this.dgw_Books.TabIndex = 26;
            // 
            // dgw_Members
            // 
            this.dgw_Members.BackgroundColor = System.Drawing.Color.Yellow;
            this.dgw_Members.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Members.GridColor = System.Drawing.Color.Black;
            this.dgw_Members.Location = new System.Drawing.Point(114, 374);
            this.dgw_Members.Name = "dgw_Members";
            this.dgw_Members.RowTemplate.ReadOnly = true;
            this.dgw_Members.Size = new System.Drawing.Size(543, 262);
            this.dgw_Members.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(328, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Kitap Listesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(328, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Üye Listesi";
            // 
            // dtp_Deliver
            // 
            this.dtp_Deliver.Location = new System.Drawing.Point(736, 113);
            this.dtp_Deliver.Name = "dtp_Deliver";
            this.dtp_Deliver.Size = new System.Drawing.Size(200, 20);
            this.dtp_Deliver.TabIndex = 30;
            // 
            // dtp_Return
            // 
            this.dtp_Return.Location = new System.Drawing.Point(736, 251);
            this.dtp_Return.Name = "dtp_Return";
            this.dtp_Return.Size = new System.Drawing.Size(200, 20);
            this.dtp_Return.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(758, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Teslim Alma Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(758, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Teslim Etme Tarihi";
            // 
            // b_deliver
            // 
            this.b_deliver.BackColor = System.Drawing.Color.LimeGreen;
            this.b_deliver.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_deliver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_deliver.Location = new System.Drawing.Point(736, 374);
            this.b_deliver.Name = "b_deliver";
            this.b_deliver.Size = new System.Drawing.Size(200, 77);
            this.b_deliver.TabIndex = 34;
            this.b_deliver.Text = "Teslim Et";
            this.b_deliver.UseVisualStyleBackColor = false;
            this.b_deliver.Click += new System.EventHandler(this.b_deliver_Click);
            // 
            // deliverBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(975, 648);
            this.Controls.Add(this.b_deliver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_Return);
            this.Controls.Add(this.dtp_Deliver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgw_Members);
            this.Controls.Add(this.dgw_Books);
            this.Name = "deliverBook";
            this.Text = "Teslim Et";
            this.Load += new System.EventHandler(this.deliverBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Members)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_Books;
        private System.Windows.Forms.DataGridView dgw_Members;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_Deliver;
        private System.Windows.Forms.DateTimePicker dtp_Return;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button b_deliver;
    }
}