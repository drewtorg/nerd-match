namespace cs2412proj2._1
{
    partial class MainMenuForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.editProfileButton = new System.Windows.Forms.Button();
            this.matchButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bothInterestButton = new System.Windows.Forms.RadioButton();
            this.femaleInterestButton = new System.Windows.Forms.RadioButton();
            this.maleInterestButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.femaleGenderButton = new System.Windows.Forms.RadioButton();
            this.maleGenderButton = new System.Windows.Forms.RadioButton();
            this.animeTextBox = new System.Windows.Forms.TextBox();
            this.planetTextBox = new System.Windows.Forms.TextBox();
            this.weaponTextBox = new System.Windows.Forms.TextBox();
            this.osTextBox = new System.Windows.Forms.TextBox();
            this.consoleTextBox = new System.Windows.Forms.TextBox();
            this.gpaTextBox = new System.Windows.Forms.TextBox();
            this.vgTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mailboxButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // editProfileButton
            // 
            this.editProfileButton.Location = new System.Drawing.Point(16, 443);
            this.editProfileButton.Name = "editProfileButton";
            this.editProfileButton.Size = new System.Drawing.Size(75, 23);
            this.editProfileButton.TabIndex = 1;
            this.editProfileButton.Text = "Edit Profile";
            this.editProfileButton.UseVisualStyleBackColor = true;
            this.editProfileButton.Click += new System.EventHandler(this.editProfileButton_Click);
            // 
            // matchButton
            // 
            this.matchButton.Location = new System.Drawing.Point(97, 443);
            this.matchButton.Name = "matchButton";
            this.matchButton.Size = new System.Drawing.Size(102, 23);
            this.matchButton.TabIndex = 2;
            this.matchButton.Text = "Show Next Match";
            this.matchButton.UseVisualStyleBackColor = true;
            this.matchButton.Click += new System.EventHandler(this.matchButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(332, 443);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 3;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(22, 251);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(385, 150);
            this.pictureBox.TabIndex = 60;
            this.pictureBox.TabStop = false;
            this.pictureBox.DoubleClick += new System.EventHandler(this.pictureBox_Click);
            this.pictureBox.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            this.pictureBox.MouseHover += new System.EventHandler(this.pictureBox_MouseHover);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.errorLabel.Location = new System.Drawing.Point(143, 414);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(50, 13);
            this.errorLabel.TabIndex = 57;
            this.errorLabel.Text = "errorlabel";
            this.errorLabel.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bothInterestButton);
            this.panel2.Controls.Add(this.femaleInterestButton);
            this.panel2.Controls.Add(this.maleInterestButton);
            this.panel2.Location = new System.Drawing.Point(301, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(73, 83);
            this.panel2.TabIndex = 56;
            // 
            // bothInterestButton
            // 
            this.bothInterestButton.AutoSize = true;
            this.bothInterestButton.Enabled = false;
            this.bothInterestButton.Location = new System.Drawing.Point(9, 61);
            this.bothInterestButton.Name = "bothInterestButton";
            this.bothInterestButton.Size = new System.Drawing.Size(47, 17);
            this.bothInterestButton.TabIndex = 2;
            this.bothInterestButton.Text = "Both";
            this.bothInterestButton.UseVisualStyleBackColor = true;
            // 
            // femaleInterestButton
            // 
            this.femaleInterestButton.AutoSize = true;
            this.femaleInterestButton.Checked = true;
            this.femaleInterestButton.Enabled = false;
            this.femaleInterestButton.Location = new System.Drawing.Point(9, 34);
            this.femaleInterestButton.Name = "femaleInterestButton";
            this.femaleInterestButton.Size = new System.Drawing.Size(59, 17);
            this.femaleInterestButton.TabIndex = 1;
            this.femaleInterestButton.TabStop = true;
            this.femaleInterestButton.Text = "Female";
            this.femaleInterestButton.UseVisualStyleBackColor = true;
            // 
            // maleInterestButton
            // 
            this.maleInterestButton.AutoSize = true;
            this.maleInterestButton.Enabled = false;
            this.maleInterestButton.Location = new System.Drawing.Point(9, 4);
            this.maleInterestButton.Name = "maleInterestButton";
            this.maleInterestButton.Size = new System.Drawing.Size(48, 17);
            this.maleInterestButton.TabIndex = 0;
            this.maleInterestButton.Text = "Male";
            this.maleInterestButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.femaleGenderButton);
            this.panel1.Controls.Add(this.maleGenderButton);
            this.panel1.Location = new System.Drawing.Point(301, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(73, 61);
            this.panel1.TabIndex = 54;
            // 
            // femaleGenderButton
            // 
            this.femaleGenderButton.AutoSize = true;
            this.femaleGenderButton.Enabled = false;
            this.femaleGenderButton.Location = new System.Drawing.Point(9, 32);
            this.femaleGenderButton.Name = "femaleGenderButton";
            this.femaleGenderButton.Size = new System.Drawing.Size(59, 17);
            this.femaleGenderButton.TabIndex = 1;
            this.femaleGenderButton.Text = "Female";
            this.femaleGenderButton.UseVisualStyleBackColor = true;
            // 
            // maleGenderButton
            // 
            this.maleGenderButton.AutoSize = true;
            this.maleGenderButton.Checked = true;
            this.maleGenderButton.Enabled = false;
            this.maleGenderButton.Location = new System.Drawing.Point(9, 4);
            this.maleGenderButton.Name = "maleGenderButton";
            this.maleGenderButton.Size = new System.Drawing.Size(48, 17);
            this.maleGenderButton.TabIndex = 0;
            this.maleGenderButton.TabStop = true;
            this.maleGenderButton.Text = "Male";
            this.maleGenderButton.UseVisualStyleBackColor = true;
            // 
            // animeTextBox
            // 
            this.animeTextBox.Enabled = false;
            this.animeTextBox.Location = new System.Drawing.Point(275, 218);
            this.animeTextBox.Name = "animeTextBox";
            this.animeTextBox.Size = new System.Drawing.Size(117, 20);
            this.animeTextBox.TabIndex = 53;
            // 
            // planetTextBox
            // 
            this.planetTextBox.Enabled = false;
            this.planetTextBox.Location = new System.Drawing.Point(275, 187);
            this.planetTextBox.Name = "planetTextBox";
            this.planetTextBox.Size = new System.Drawing.Size(117, 20);
            this.planetTextBox.TabIndex = 52;
            // 
            // weaponTextBox
            // 
            this.weaponTextBox.Enabled = false;
            this.weaponTextBox.Location = new System.Drawing.Point(90, 218);
            this.weaponTextBox.Name = "weaponTextBox";
            this.weaponTextBox.Size = new System.Drawing.Size(117, 20);
            this.weaponTextBox.TabIndex = 51;
            // 
            // osTextBox
            // 
            this.osTextBox.Enabled = false;
            this.osTextBox.Location = new System.Drawing.Point(90, 187);
            this.osTextBox.Name = "osTextBox";
            this.osTextBox.Size = new System.Drawing.Size(117, 20);
            this.osTextBox.TabIndex = 50;
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.Enabled = false;
            this.consoleTextBox.Location = new System.Drawing.Point(90, 154);
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.Size = new System.Drawing.Size(117, 20);
            this.consoleTextBox.TabIndex = 49;
            // 
            // gpaTextBox
            // 
            this.gpaTextBox.Enabled = false;
            this.gpaTextBox.Location = new System.Drawing.Point(90, 119);
            this.gpaTextBox.Name = "gpaTextBox";
            this.gpaTextBox.Size = new System.Drawing.Size(117, 20);
            this.gpaTextBox.TabIndex = 48;
            // 
            // vgTextBox
            // 
            this.vgTextBox.Enabled = false;
            this.vgTextBox.Location = new System.Drawing.Point(90, 85);
            this.vgTextBox.Name = "vgTextBox";
            this.vgTextBox.Size = new System.Drawing.Size(117, 20);
            this.vgTextBox.TabIndex = 47;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Enabled = false;
            this.ageTextBox.Location = new System.Drawing.Point(90, 50);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(117, 20);
            this.ageTextBox.TabIndex = 46;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Enabled = false;
            this.nameTextBox.Location = new System.Drawing.Point(90, 16);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(117, 20);
            this.nameTextBox.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(60, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Age:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(237, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Gender:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(55, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "GPA:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 40;
            this.label8.Text = "Console:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Planet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Anime:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "Weapon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "OS:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Video Game:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Interested In:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Username:";
            // 
            // mailboxButton
            // 
            this.mailboxButton.Location = new System.Drawing.Point(205, 443);
            this.mailboxButton.Name = "mailboxButton";
            this.mailboxButton.Size = new System.Drawing.Size(121, 23);
            this.mailboxButton.TabIndex = 61;
            this.mailboxButton.Text = "Send/View Messages";
            this.mailboxButton.UseVisualStyleBackColor = true;
            this.mailboxButton.Click += new System.EventHandler(this.mailboxButton_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 493);
            this.Controls.Add(this.mailboxButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.animeTextBox);
            this.Controls.Add(this.planetTextBox);
            this.Controls.Add(this.weaponTextBox);
            this.Controls.Add(this.osTextBox);
            this.Controls.Add(this.consoleTextBox);
            this.Controls.Add(this.gpaTextBox);
            this.Controls.Add(this.vgTextBox);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.matchButton);
            this.Controls.Add(this.editProfileButton);
            this.Name = "MainMenuForm";
            this.Text = "Nerd Match";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button editProfileButton;
        private System.Windows.Forms.Button matchButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton bothInterestButton;
        private System.Windows.Forms.RadioButton femaleInterestButton;
        private System.Windows.Forms.RadioButton maleInterestButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton femaleGenderButton;
        private System.Windows.Forms.RadioButton maleGenderButton;
        private System.Windows.Forms.TextBox animeTextBox;
        private System.Windows.Forms.TextBox planetTextBox;
        private System.Windows.Forms.TextBox weaponTextBox;
        private System.Windows.Forms.TextBox osTextBox;
        private System.Windows.Forms.TextBox consoleTextBox;
        private System.Windows.Forms.TextBox gpaTextBox;
        private System.Windows.Forms.TextBox vgTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button mailboxButton;

    }
}