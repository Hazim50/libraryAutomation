using System;
using System.Collections;
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
    public partial class deleteMember : Form
    {
        OleDbConnection conn;
        public deleteMember(OleDbConnection connection)
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

        private DataGridView getMembers()
        {
            string query = "Select * from Members";
            OleDbCommand command = new OleDbCommand(query, conn);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            return dataGridView1;
        } 

        private void deleteMember_Load(object sender, EventArgs e)
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
            getMembers();
        }
        private void b_delete_member_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 1)
                {
                    string deleteQuery = "DELETE FROM Members WHERE member_id = @member_id";
                    OleDbCommand deleteCommand = new OleDbCommand(deleteQuery, conn);
                    deleteCommand.Parameters.AddWithValue("@member_id", dataGridView1.CurrentRow.Cells["member_id"].Value);
                    deleteCommand.ExecuteNonQuery();
                    getMembers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
