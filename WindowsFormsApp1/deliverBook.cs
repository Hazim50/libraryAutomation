using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class deliverBook : Form
    {
        OleDbConnection conn;
        public deliverBook(OleDbConnection connection)
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

        private void fill_DGW()
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
                string query1 = "Select * from Books"; //kitaplar tablosunu doldurmak için
                OleDbCommand command = new OleDbCommand(query1, conn);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgw_Books.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                string query2 = "Select * from Members"; //üyeler tablosunu doldurmak için
                OleDbCommand command2 = new OleDbCommand(query2, conn);
                OleDbDataAdapter adapter2 = new OleDbDataAdapter(command2);
                DataTable dt2 = new DataTable();
                adapter2.Fill(dt2);
                dgw_Members.DataSource = dt2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deliverBook_Load(object sender, EventArgs e)
        {
            fill_DGW();
        }

        private void b_deliver_Click(object sender, EventArgs e)
        {
            try
            {
                int bookCount = Convert.ToInt32(dgw_Books.CurrentRow.Cells["book_count"].Value); // kitap sayısını alıyoruz

                if (bookCount > 0) 
                {
                    String query = "INSERT INTO Deliveries (member_id, member_name, member_tel, barcode_id, book_author, book_name, delivery_date, return_date, is_returned)" +
                        " VALUES (@member_id, @member_name, @member_tel, @barcode_id, @book_author, @book_name, @delivery_date, @return_date, @is_returned)";
                    OleDbCommand command = new OleDbCommand(query, conn); // dataGridView kullanarak hücrelerdeki bilgileri çekiyoruz

                    command.Parameters.AddWithValue("@member_id", dgw_Members.CurrentRow.Cells["member_id"].Value);
                    command.Parameters.AddWithValue("@member_name", dgw_Members.CurrentRow.Cells["name"].Value.ToString());
                    command.Parameters.AddWithValue("@member_tel", dgw_Members.CurrentRow.Cells["tel"].Value);
                    command.Parameters.AddWithValue("@barcode_id", dgw_Books.CurrentRow.Cells["barcode_id"].Value);
                    command.Parameters.AddWithValue("@book_author", dgw_Books.CurrentRow.Cells["author"].Value.ToString());
                    command.Parameters.AddWithValue("@book_name", dgw_Books.CurrentRow.Cells["book_name"].Value.ToString());
                    command.Parameters.AddWithValue("@delivery_date", dtp_Deliver.Value.ToString());
                    command.Parameters.AddWithValue("@return_date", dtp_Return.Value.ToString());
                    command.Parameters.AddWithValue("@is_returned", "0");

                    command.ExecuteNonQuery();

                    string queryToDecreaseBookCount = "UPDATE Books SET book_count = book_count - 1 WHERE barcode_id = @barcode_id"; // book_count değişkenini (kitap adeti) 1 azaltıyoruz
                    OleDbCommand commandToDecreaseBookCount = new OleDbCommand(queryToDecreaseBookCount, conn);
                    commandToDecreaseBookCount.Parameters.AddWithValue("@barcode_id", dgw_Books.CurrentRow.Cells["barcode_id"].Value);
                    commandToDecreaseBookCount.ExecuteNonQuery();
                    fill_DGW();

                    MessageBox.Show("Kitap Başarıyla Teslim Edildi");
                }
                else
                {
                    MessageBox.Show("Bu kitaptan stokta kalmadı. Teslim işlemi gerçekleştirilemez.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
