using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class addBook : Form
    {
        SqlConnection conn;
        public addBook(SqlConnection connection)
        {
            InitializeComponent();
            this.conn = connection;
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

            try
            {
                String query = "insert into Books (author,book_name,page_count,shelf_no,book_count) values (@author,@book_name,@page_count,@shelf_no,@book_count)";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@author", textBox_author.Text);
                command.Parameters.AddWithValue("@book_name", textBox_name.Text);
                command.Parameters.AddWithValue("@page_count", textBox_pageCount.Text);
                command.Parameters.AddWithValue("@shelf_no", textBox_shelfNo.Text);
                command.Parameters.AddWithValue("@book_count", textBox_bookCount.Text);

                command.ExecuteNonQuery();
                MessageBox.Show("Kitap Ekleme İşlemi Başarılı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
