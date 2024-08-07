using System.Windows.Forms;

namespace Client
{
    partial class ChatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userNamelabel = new System.Windows.Forms.Label();
            this.ipLabel = new System.Windows.Forms.Label();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.sendBox = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 160);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // userNamelabel
            // 
            this.userNamelabel.AutoSize = true;
            this.userNamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNamelabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.userNamelabel.Location = new System.Drawing.Point(12, 338);
            this.userNamelabel.Name = "userNamelabel";
            this.userNamelabel.Size = new System.Drawing.Size(144, 29);
            this.userNamelabel.TabIndex = 1;
            this.userNamelabel.Text = "User Name";
            // 
            // ipLabel
            // 
            this.ipLabel.AutoSize = true;
            this.ipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipLabel.Location = new System.Drawing.Point(12, 432);
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Size = new System.Drawing.Size(37, 29);
            this.ipLabel.TabIndex = 3;
            this.ipLabel.Text = "IP";
            // 
            // messageBox
            // 
            this.messageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageBox.Location = new System.Drawing.Point(327, 1);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.ReadOnly = true;
            this.messageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.messageBox.Size = new System.Drawing.Size(677, 397);
            this.messageBox.TabIndex = 4;
            // 
            // sendBox
            // 
            this.sendBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sendBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBox.Location = new System.Drawing.Point(327, 404);
            this.sendBox.Multiline = true;
            this.sendBox.Name = "sendBox";
            this.sendBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sendBox.Size = new System.Drawing.Size(521, 86);
            this.sendBox.TabIndex = 5;
            this.sendBox.TextChanged += new System.EventHandler(this.sendBox_TextChanged);
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.sendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sendBtn.Location = new System.Drawing.Point(867, 404);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(118, 86);
            this.sendBtn.TabIndex = 6;
            this.sendBtn.Text = "GỬI";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(12, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Người dùng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 393);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Địa chỉ IP Server:";
            // 
            // ChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 497);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendBtn);
            this.Controls.Add(this.sendBox);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.userNamelabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userNamelabel;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.TextBox sendBox;
        private System.Windows.Forms.Button sendBtn;
        private Label label1;
        private Label label2;
    }
}