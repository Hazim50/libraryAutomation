﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(this.Main_Paint); // Paint olayını ekliyoruz, çerçeveyi beyaz yapmak için
        }

        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=my_library.mdb"); // accdb ile baglanti kur
        
        private void Main_Paint(object sender, PaintEventArgs e) //çerçeveyi beyaz yapan kod
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
        private void b_add_member_Click(object sender, EventArgs e) //butona tıklayınca kendi penceresini açan kısımlar
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

        private void b_deliver_Click(object sender, EventArgs e)
        {
            deliverBook deliverBookForm = new deliverBook(connection);
            deliverBookForm.ShowDialog();
        }

        private void b_list_delivery_Click(object sender, EventArgs e)
        {
            listDeliveredBooks listDeliveredBooks = new listDeliveredBooks(connection);
            listDeliveredBooks.ShowDialog();
        }

        private void b_receive_Click(object sender, EventArgs e)
        {
            receiveBook receiveBookForm = new receiveBook(connection);
            receiveBookForm.ShowDialog();
        }
    }
}
