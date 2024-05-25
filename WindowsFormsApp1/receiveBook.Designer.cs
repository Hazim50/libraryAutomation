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
            this.b_deliver = new System.Windows.Forms.Button();
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
            // b_deliver
            // 
            this.b_deliver.BackColor = System.Drawing.Color.LimeGreen;
            this.b_deliver.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.b_deliver.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.b_deliver.Location = new System.Drawing.Point(462, 299);
            this.b_deliver.Name = "b_deliver";
            this.b_deliver.Size = new System.Drawing.Size(212, 57);
            this.b_deliver.TabIndex = 32;
            this.b_deliver.Text = "Teslim Al";
            this.b_deliver.UseVisualStyleBackColor = false;
            this.b_deliver.Click += new System.EventHandler(this.b_deliver_Click);
            // 
            // receiveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1112, 409);
            this.Controls.Add(this.b_deliver);
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
        private System.Windows.Forms.Button b_deliver;
    }
}