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
    public partial class deleteBook : Form
    {
        SqlConnection conn;
        public deleteBook(SqlConnection connection)
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

        private DataGridView getBooks()
        {
            string query = "Select * from Books";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            return dataGridView1;
        }

        private void deleteBook_Load(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    getBooks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void b_delete_book_Click(object sender, EventArgs e)
        {
            string columnName;
            string text;
            if (radioButton_Id.Checked)
            {
                columnName = "barcode_id";
                text=textBox_ID.Text;
            }
            else if (radioButton_author.Checked)
            {
                columnName= "author";
                text=textBox_author.Text;
            }
            else
            {
                columnName = "book_name";
                text=textBox_name.Text;
            }

            try
            {
                string delQuery = "delete from Books where " + columnName + " = " + "'" + text + "'";
                SqlCommand command = new SqlCommand(delQuery, conn);
                int numberRowAffected = command.ExecuteNonQuery();
                if (numberRowAffected > 0) MessageBox.Show("Üye Silme İşlemi Başarılı. " + numberRowAffected + " adet kullanici silindi!");
                else MessageBox.Show("Silinecek Üye Bulunamadı!");
                getBooks();

                textBox_ID.Text = "";
                textBox_author.Text = "";
                textBox_name.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
