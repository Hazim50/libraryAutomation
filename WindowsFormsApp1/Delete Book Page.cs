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
    public partial class deleteBook : Form
    {
        OleDbConnection conn;
        public deleteBook(OleDbConnection connection)
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
            OleDbCommand command = new OleDbCommand(query, conn);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            getBooks(); // sayfa açılırken listenin gelmesi için
        }

        private void b_delete_book_Click(object sender, EventArgs e)
        {
            try //kitap sil
            {
                if (dataGridView1.Rows.Count > 1) // >0 denmesinin sebebi ekrandaki 1 tane boş satırı da sayıyor
                {
                    string deleteQuery = "DELETE FROM Books WHERE barcode_id = @barcode_id";
                    OleDbCommand deleteCommand = new OleDbCommand(deleteQuery, conn);
                    deleteCommand.Parameters.AddWithValue("@barcode_id", dataGridView1.CurrentRow.Cells["barcode_id"].Value);
                    deleteCommand.ExecuteNonQuery();
                    getBooks(); //silindikten sonra listenin güncellenmesi için
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
