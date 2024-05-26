namespace WindowsFormsApp1
{
    partial class receiveBook
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
            this.dgw_False = new System.Windows.Forms.DataGridView();
            this.b_receive = new System.Windows.Forms.Button();
            this.dtp_return = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_False)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(458, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Teslim Edilmemiş Kitaplar";
            // 
            // dgw_False
            // 
            this.dgw_False.BackgroundColor = System.Drawing.Color.Yellow;
            this.dgw_False.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_False.GridColor = System.Drawing.Color.Black;
            this.dgw_False.Location = new System.Drawing.Point(35, 33);
            this.dgw_False.Name = "dgw_False";
            this.dgw_False.RowTemplate.ReadOnly = true;
            this.dgw_False.Size = new System.Drawing.Size(1043, 250);
            this.dgw_False.TabIndex = 30;
            // 
            // b_receive
            // 
            this.b_receive.BackColor = System.Drawing.Color.LimeGreen;
            this.b_receive.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_receive.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_receive.Location = new System.Drawing.Point(462, 299);
            this.b_receive.Name = "b_receive";
            this.b_receive.Size = new System.Drawing.Size(212, 57);
            this.b_receive.TabIndex = 32;
            this.b_receive.Text = "Teslim Al";
            this.b_receive.UseVisualStyleBackColor = false;
            this.b_receive.Click += new System.EventHandler(this.b_receive_Click_1);
            // 
            // dtp_return
            // 
            this.dtp_return.Location = new System.Drawing.Point(799, 328);
            this.dtp_return.Name = "dtp_return";
            this.dtp_return.Size = new System.Drawing.Size(200, 20);
            this.dtp_return.TabIndex = 33;
            // 
            // receiveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1112, 409);
            this.Controls.Add(this.dtp_return);
            this.Controls.Add(this.b_receive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgw_False);
            this.Name = "receiveBook";
            this.Text = "Kitap Teslim Alma";
            this.Load += new System.EventHandler(this.receiveBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_False)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgw_False;
        private System.Windows.Forms.Button b_receive;
        private System.Windows.Forms.DateTimePicker dtp_return;
    }
}