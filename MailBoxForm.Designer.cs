namespace cs2412proj2._1
{
    partial class MailBoxForm
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
            this.inboxButton = new System.Windows.Forms.Button();
            this.msgButton = new System.Windows.Forms.Button();
            this.toFromLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toFromTextBox = new System.Windows.Forms.TextBox();
            this.msgTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inboxButton
            // 
            this.inboxButton.Location = new System.Drawing.Point(97, 350);
            this.inboxButton.Name = "inboxButton";
            this.inboxButton.Size = new System.Drawing.Size(75, 23);
            this.inboxButton.TabIndex = 2;
            this.inboxButton.Text = "View Inbox";
            this.inboxButton.UseVisualStyleBackColor = true;
            this.inboxButton.Click += new System.EventHandler(this.inboxButton_Click);
            // 
            // msgButton
            // 
            this.msgButton.Location = new System.Drawing.Point(195, 350);
            this.msgButton.Name = "msgButton";
            this.msgButton.Size = new System.Drawing.Size(93, 23);
            this.msgButton.TabIndex = 3;
            this.msgButton.Text = "Create Message";
            this.msgButton.UseVisualStyleBackColor = true;
            this.msgButton.Click += new System.EventHandler(this.msgButton_Click);
            // 
            // toFromLabel
            // 
            this.toFromLabel.AutoSize = true;
            this.toFromLabel.Location = new System.Drawing.Point(133, 18);
            this.toFromLabel.Name = "toFromLabel";
            this.toFromLabel.Size = new System.Drawing.Size(23, 13);
            this.toFromLabel.TabIndex = 3;
            this.toFromLabel.Text = "To:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.msgTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(464, 299);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Message";
            // 
            // toFromTextBox
            // 
            this.toFromTextBox.Enabled = false;
            this.toFromTextBox.Location = new System.Drawing.Point(174, 15);
            this.toFromTextBox.Name = "toFromTextBox";
            this.toFromTextBox.Size = new System.Drawing.Size(116, 20);
            this.toFromTextBox.TabIndex = 0;
            // 
            // msgTextBox
            // 
            this.msgTextBox.Enabled = false;
            this.msgTextBox.Location = new System.Drawing.Point(7, 19);
            this.msgTextBox.Multiline = true;
            this.msgTextBox.Name = "msgTextBox";
            this.msgTextBox.Size = new System.Drawing.Size(451, 274);
            this.msgTextBox.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(311, 350);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MailBoxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 378);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.toFromTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toFromLabel);
            this.Controls.Add(this.msgButton);
            this.Controls.Add(this.inboxButton);
            this.Name = "MailBoxForm";
            this.Text = "Mailbox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inboxButton;
        private System.Windows.Forms.Button msgButton;
        private System.Windows.Forms.Label toFromLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox msgTextBox;
        private System.Windows.Forms.TextBox toFromTextBox;
        private System.Windows.Forms.Button exitButton;
    }
}