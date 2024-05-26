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
    public partial class listDeliveredBooks : Form
    {
        OleDbConnection conn;
        public listDeliveredBooks(OleDbConnection connection)
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

        private void listDeliveredBooks_Load(object sender, EventArgs e)
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
                string queryFalse = "SELECT * FROM Deliveries WHERE is_returned = false"; //teslim edilmeyenleri üstteki tabloda göstermek için
                OleDbCommand commandFalse = new OleDbCommand(queryFalse, conn);
                OleDbDataAdapter adapterFalse = new OleDbDataAdapter(commandFalse);
                DataTable dtFalse = new DataTable();
                adapterFalse.Fill(dtFalse);
                dgw_False.DataSource = dtFalse;

                string queryTrue = "SELECT * FROM Deliveries WHERE is_returned = true"; // teslim edilenleri alttaki tabloda göstermek için
                OleDbCommand commandTrue = new OleDbCommand(queryTrue, conn);
                OleDbDataAdapter adapterTrue = new OleDbDataAdapter(commandTrue);
                DataTable dtTrue = new DataTable();
                adapterTrue.Fill(dtTrue);
                dgw_True.DataSource = dtTrue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
