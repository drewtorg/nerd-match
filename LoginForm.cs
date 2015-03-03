using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace cs2412proj2._1
{
    public partial class LoginForm : Form
    {
        public static MatchDatabase data;
        public static User currentUser;
        public const string filepath = @"..\..\Users\";

        //create the database and store it in the login form
        public LoginForm()
        {
            InitializeComponent();

            data = new MatchDatabase(filepath);
        }

        //open a create account form
        private void newAccountButton_Click(object sender, EventArgs e)
        {
            var form = new CreateAccountForm();
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }

        //close this form and thus the entire program
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //check if the username/password combination exists, if so, opens a main menu form, otherwise, states that an error has occurred
        private void loginButton_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;

            if(File.Exists(filepath + "MasterList.txt"))
            {
                StreamReader reader = File.OpenText(filepath + "MasterList.txt");
                while(!reader.EndOfStream)
                {
                    string username = reader.ReadLine();
                    string password = reader.ReadLine();
                    //test if the usernames and passwords match
                    if(username == usernameTextBox.Text && password == passwordTextBox.Text)
                    {
                        currentUser = data.GetUserInfo(filepath + username);
                        var form = new MainMenuForm();
                        form.Location = this.Location;
                        form.StartPosition = FormStartPosition.Manual;
                        form.FormClosing += delegate { this.Show(); };
                        form.Show();
                        this.Hide();
                        return;
                    }
                }

                errorLabel.Text = "Username/Password combination doesn't exist.";
                errorLabel.Visible = true;
            }
            else
            {
                errorLabel.Text = "Cannot find master list.";
                errorLabel.Visible = true;
            }
        }
    }
}
