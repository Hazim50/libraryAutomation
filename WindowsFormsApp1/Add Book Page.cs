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
                String checkQuery = "SELECT COUNT(*) FROM Books WHERE author = @author AND book_name = @book_name";
                SqlCommand checkCommand = new SqlCommand(checkQuery, conn);
                checkCommand.Parameters.AddWithValue("@author", textBox_author.Text);
                checkCommand.Parameters.AddWithValue("@book_name", textBox_name.Text);

                int count = (int)checkCommand.ExecuteScalar();

                if (textBox_bookCount.Text != null)
                {
                    if (count > 0)
                    {
                        String updateQuery = "UPDATE Books SET book_count = book_count + @book_count WHERE author = @author AND book_name = @book_name";
                        SqlCommand updateCommand = new SqlCommand(updateQuery, conn);
                        updateCommand.Parameters.AddWithValue("@book_count", int.Parse(textBox_bookCount.Text));
                        updateCommand.Parameters.AddWithValue("@author", textBox_author.Text);
                        updateCommand.Parameters.AddWithValue("@book_name", textBox_name.Text);

                        updateCommand.ExecuteNonQuery();
                        MessageBox.Show("Kitap sayısı güncellendi.");
                    }
                    else
                    {
                        String query = "INSERT INTO Books (author, book_name, page_count, shelf_no, book_count) VALUES (@author, @book_name, @page_count, @shelf_no, @book_count)";
                        SqlCommand command = new SqlCommand(query, conn);
                        command.Parameters.AddWithValue("@author", textBox_author.Text);
                        command.Parameters.AddWithValue("@book_name", textBox_name.Text);
                        command.Parameters.AddWithValue("@page_count", textBox_pageCount.Text);
                        command.Parameters.AddWithValue("@shelf_no", textBox_shelfNo.Text);
                        command.Parameters.AddWithValue("@book_count", int.Parse(textBox_bookCount.Text));

                        command.ExecuteNonQuery();
                        MessageBox.Show("Kitap Ekleme İşlemi Başarılı.");
                    }
                }
                else MessageBox.Show("Kitap Sayısı Boş Olamaz!");

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
