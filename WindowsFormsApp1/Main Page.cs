using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(this.Main_Paint); // Paint olayını ekliyoruz, çerçeveyi beyaz yapmak için
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

        static string conn_string = "Data Source=DESKTOP-4V8VAGV\\HZM;Initial Catalog=Kutuphane;Integrated Security=True;";
        SqlConnection connection = new SqlConnection(conn_string);

        private void b_add_member_Click(object sender, EventArgs e)
        {
            addMember addMemberForm = new addMember(connection);
            addMemberForm.ShowDialog();
        }

        private void b_list_member_Click(object sender, EventArgs e)
        {
            listMember listMemberForm = new listMember(connection);
            listMemberForm.ShowDialog();
        }

        private void b_delete_member_Click(object sender, EventArgs e)
        {
            deleteMember deleteMemberForm = new deleteMember(connection);
            deleteMemberForm.ShowDialog();
        }

        private void b_add_book_Click(object sender, EventArgs e)
        {
            addBook addBookForm = new addBook(connection);
            addBookForm.ShowDialog();
        }

        private void b_list_book_Click(object sender, EventArgs e)
        {
            listBook listBookForm = new listBook(connection);
            listBookForm.ShowDialog();
        }

        private void b_delete_book_Click(object sender, EventArgs e)
        {
            deleteBook delBookForm = new deleteBook(connection);
            delBookForm.ShowDialog();
        }
    }
}
