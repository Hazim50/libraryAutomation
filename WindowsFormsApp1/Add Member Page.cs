using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class addMember : Form
    {
        OleDbConnection conn;
        public addMember(OleDbConnection connection)
        {
            InitializeComponent();
            this.conn=connection;
            this.Paint += new PaintEventHandler(this.Main_Paint);
        }

        private void Main_Paint(object sender, PaintEventArgs e)
        {
            Color borderColor = Color.White;
            int borderWidth = 2;

            int width = this.ClientSize.Width;
            int height = this.ClientSize.Height;

            using (Pen pen = new Pen(borderColor, borderWidth))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, width - 1, height - 1);
            }
        }

        private void b_add_member_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            try //yeni kayıt oluştur
            {
                String query = "insert into Members (name,surname,email,tel) values (@name,@surname,@email,@tel)";
                OleDbCommand command = new OleDbCommand(query, conn);
                command.Parameters.AddWithValue("@name", textBox_member_name.Text);
                command.Parameters.AddWithValue("@surname", textBox_member_surname.Text);
                command.Parameters.AddWithValue("@email", textBox_member_mail.Text);
                command.Parameters.AddWithValue("@tel", textBox_member_tel.Text);

                command.ExecuteNonQuery();
                MessageBox.Show("Üye Ekleme İşlemi Başarılı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
