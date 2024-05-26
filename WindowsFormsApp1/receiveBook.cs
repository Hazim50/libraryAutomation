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
    public partial class receiveBook : Form
    {
        OleDbConnection conn;
        public receiveBook(OleDbConnection connection)
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
                string queryFalse = "SELECT * FROM Deliveries WHERE is_returned = 0"; // ekranda sadece teslim edilmeyenleri göstermek için
                OleDbCommand commandFalse = new OleDbCommand(queryFalse, conn);
                OleDbDataAdapter adapterFalse = new OleDbDataAdapter(commandFalse);
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


        private void b_receive_Click_1(object sender, EventArgs e)
        {
            try
            {
                string updateQuery = "UPDATE Deliveries SET is_returned = true WHERE delivery_id = @delivery_id"; //teslim edilen kitabın is_returned değişkenini True yapmak için
                OleDbCommand updateCommand = new OleDbCommand(updateQuery, conn);
                updateCommand.Parameters.AddWithValue("@delivery_id", dgw_False.CurrentRow.Cells["delivery_id"].Value);
                updateCommand.ExecuteNonQuery();

                string queryToIncreaseBookCount = "UPDATE Books SET book_count = book_count + 1 WHERE barcode_id = @barcode_id"; //teslim edilen kitabın book_count değişkenini 1 artırıyoruz
                OleDbCommand commandToIncreaseBookCount = new OleDbCommand(queryToIncreaseBookCount, conn);
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
