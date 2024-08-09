using System;
using System.Windows.Forms;

namespace ChatApplication
{
    public partial class ChatForm : Form
    {
        public ChatForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text;
            if (!string.IsNullOrWhiteSpace(message))
            {
                lstMessages.Items.Add("Bạn: " + message);
                txtMessage.Clear();
            }
        }
    }
}
