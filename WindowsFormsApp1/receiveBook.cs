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
    public partial class receiveBook : Form
    {
        SqlConnection conn;
        public receiveBook(SqlConnection connection)
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
                string queryFalse = "SELECT * FROM Deliveries WHERE is_returned = 0";
                SqlCommand commandFalse = new SqlCommand(queryFalse, conn);
                SqlDataAdapter adapterFalse = new SqlDataAdapter(commandFalse);
                DataTable dtFalse = new DataTable();
                adapterFalse.Fill(dtFalse);
                dgw_False.DataSource = dtFalse;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void receiveBook_Load(object sender, EventArgs e)
        {
            fill_DGW();
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
        }

        private void b_deliver_Click(object sender, EventArgs e)
        {

            try
            {
                DateTime currentDate = DateTime.Now;

                string updateQuery = "UPDATE Deliveries SET is_returned = 1, return_date = @return_date WHERE delivery_id = @delivery_id";
                SqlCommand updateCommand = new SqlCommand(updateQuery, conn);

                updateCommand.Parameters.AddWithValue("@delivery_id", dgw_False.CurrentRow.Cells["delivery_id"].Value);
                updateCommand.Parameters.AddWithValue("@return_date", currentDate); 
                updateCommand.ExecuteNonQuery();

                string queryToIncreaseBookCount = "UPDATE Books SET book_count = book_count + 1 WHERE barcode_id = @barcode_id";
                SqlCommand commandToIncreaseBookCount = new SqlCommand(queryToIncreaseBookCount, conn);
                commandToIncreaseBookCount.Parameters.AddWithValue("@barcode_id", dgw_False.CurrentRow.Cells["barcode_id"].Value);
                commandToIncreaseBookCount.ExecuteNonQuery();

                fill_DGW(); 

                MessageBox.Show("Kitap Başarıyla Teslim Alındı");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
