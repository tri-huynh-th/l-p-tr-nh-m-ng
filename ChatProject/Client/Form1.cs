using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            // lấy thông tin từ textBox
            string userName = nameBox.Text;
            string severIp = ipBox.Text;

            // Kiểm tra nếu thông tin không trống
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(severIp))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            // Tạo và hiển thị FormChat
            ChatForm chatForm = new ChatForm(userName, severIp);
            chatForm.Show();

            // Ẩn FormLogin
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
