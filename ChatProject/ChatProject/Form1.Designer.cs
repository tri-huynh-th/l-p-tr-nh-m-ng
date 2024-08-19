namespace ChatProject
{
    partial class Form1
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
            this.messageBox = new System.Windows.Forms.TextBox();
            this.sendBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.connectTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // messageBox
            // 
            this.messageBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageBox.HideSelection = false;
            this.messageBox.Location = new System.Drawing.Point(288, 12);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.ReadOnly = true;
            this.messageBox.Size = new System.Drawing.Size(530, 317);
            this.messageBox.TabIndex = 0;
            // 
            // sendBox
            // 
            this.sendBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sendBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBox.Location = new System.Drawing.Point(288, 335);
            this.sendBox.Multiline = true;
            this.sendBox.Name = "sendBox";
            this.sendBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sendBox.Size = new System.Drawing.Size(407, 109);
            this.sendBox.TabIndex = 1;
            // 
            // sendButton
            // 
            this.sendButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sendButton.Location = new System.Drawing.Point(701, 335);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(117, 109);
            this.sendButton.TabIndex = 2;
            this.sendButton.Text = "GỬI";
            this.sendButton.UseVisualStyleBackColor = false;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Người dùng đã kết nối:";
            // 
            // connectTextBox
            // 
            this.connectTextBox.BackColor = System.Drawing.Color.LightSalmon;
            this.connectTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.connectTextBox.Location = new System.Drawing.Point(5, 42);
            this.connectTextBox.Multiline = true;
            this.connectTextBox.Name = "connectTextBox";
            this.connectTextBox.ReadOnly = true;
            this.connectTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.connectTextBox.Size = new System.Drawing.Size(217, 287);
            this.connectTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Địa chỉ IP của sever:";
            // 
            // ipTextBox
            // 
            this.ipTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ipTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipTextBox.Location = new System.Drawing.Point(5, 390);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.ReadOnly = true;
            this.ipTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ipTextBox.Size = new System.Drawing.Size(246, 30);
            this.ipTextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 450);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.connectTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.sendBox);
            this.Controls.Add(this.messageBox);
            this.Name = "Form1";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Form_load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.TextBox sendBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox connectTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ipTextBox;
    }
}

