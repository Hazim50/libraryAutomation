namespace WindowsFormsApp1
{
    partial class listDeliveredBooks
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
            this.dgw_False = new System.Windows.Forms.DataGridView();
            this.dgw_True = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_False)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_True)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_False
            // 
            this.dgw_False.BackgroundColor = System.Drawing.Color.Yellow;
            this.dgw_False.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_False.GridColor = System.Drawing.Color.Black;
            this.dgw_False.Location = new System.Drawing.Point(58, 41);
            this.dgw_False.Name = "dgw_False";
            this.dgw_False.RowTemplate.ReadOnly = true;
            this.dgw_False.Size = new System.Drawing.Size(1043, 250);
            this.dgw_False.TabIndex = 27;
            // 
            // dgw_True
            // 
            this.dgw_True.BackgroundColor = System.Drawing.Color.Yellow;
            this.dgw_True.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_True.GridColor = System.Drawing.Color.Black;
            this.dgw_True.Location = new System.Drawing.Point(58, 341);
            this.dgw_True.Name = "dgw_True";
            this.dgw_True.RowTemplate.ReadOnly = true;
            this.dgw_True.Size = new System.Drawing.Size(1043, 252);
            this.dgw_True.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(503, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 20);
            this.label1.TabIndex = 29;
            this.label1.Text = "Teslim Edilmemiş Kitaplar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(513, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Teslim Edilmiş Kitaplar";
            // 
            // listDeliveredBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1170, 626);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgw_True);
            this.Controls.Add(this.dgw_False);
            this.Name = "listDeliveredBooks";
            this.Text = "Teslim Durumlarını Listele";
            this.Load += new System.EventHandler(this.listDeliveredBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgw_False)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_True)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_False;
        private System.Windows.Forms.DataGridView dgw_True;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}