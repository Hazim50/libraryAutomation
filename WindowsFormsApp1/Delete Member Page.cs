using System;
using System.Collections;
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
    public partial class deleteMember : Form
    {
        SqlConnection conn;
        public deleteMember(SqlConnection connection)
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
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
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
                    getMembers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void b_delete_member_Click(object sender, EventArgs e)
        {
            string columnName;
            string text;
            if (radioButton_Id.Checked)
            {
                columnName = "member_id";
                text=textBox_ID.Text;
            }
            else if (radioButton_name.Checked)
            {
                columnName= "name";
                text=textBox_name.Text;
            }
            else if (radioButton_surname.Checked)
            {
                columnName = "surname";
                text=textBox_surname.Text;
            }
            else if (radioButton_tel.Checked)
            {
                columnName = "tel";
                text=textBox_tel.Text;
            }
            else
            {
                columnName = "email";
                text = textBox_mail.Text;
            }

            try
            {
                string delQuery = "delete from Members where " + columnName + " = " + "'" + text + "'";
                SqlCommand command = new SqlCommand(delQuery, conn);
                int numberRowAffected = command.ExecuteNonQuery();
                if (numberRowAffected > 0) MessageBox.Show("Üye Silme İşlemi Başarılı. " + numberRowAffected + " adet kullanici silindi!");
                else MessageBox.Show("Silinecek Üye Bulunamadı!");
                getMembers();

                textBox_ID.Text = "";
                textBox_name.Text = "";
                textBox_surname.Text = "";
                textBox_mail.Text = "";
                textBox_tel.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
