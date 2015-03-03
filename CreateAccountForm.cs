using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace cs2412proj2._1
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }
        
        //close this form
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //creates a new user based on all the information input by the user.  that user is then saved into the database.
        private void createButton_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;

            //check to make sure they at least put a username and password
            if(nameTextBox.Text.Replace(" ", "") == "" && passwordTextBox.Text.Replace(" ", "") == "")
            {
                errorLabel.Text = "Username and password are required.";
                errorLabel.Visible = true;
                return;
            }

            //it doesn't matter if they don't put something into a textbox, it's only their loss, but gpa's and age's must exist and be in the right format
            string username = nameTextBox.Text;
            string password = passwordTextBox.Text;
            int age;
            if(!Int32.TryParse(ageTextBox.Text, out age))
            {
                errorLabel.Text = "Age must be an integer value";
                errorLabel.Visible = true;
                return;
            }
            string gender = femaleGenderButton.Checked ? "Female" : "Male";
            string interest = femaleInterestButton.Checked ? "Female" : maleInterestButton.Checked ? "Male" : "Both";
            string vg = vgTextBox.Text;
            double gpa;
            if (!Double.TryParse(gpaTextBox.Text, out gpa))
            {
                errorLabel.Text = "GPA must be a number";
                errorLabel.Visible = true;
                return;
            }
            string console = consoleTextBox.Text;
            string os = osTextBox.Text;
            string weapon = weaponTextBox.Text;
            string planet = planetTextBox.Text;
            string anime = animeTextBox.Text;

            //create a user with an image is one was uploaded otherwise make an user without an image
            User newUser;
            if(picPathTextBox.Text != "")
                newUser = new User(username, age, gender, interest, vg, gpa, console, os, weapon, planet, anime, pictureBox.Image);
            else
                newUser = new User(username, age, gender, interest, vg, gpa, console, os, weapon, planet, anime);

            if (!Directory.Exists(LoginForm.filepath))
            {
                throw new DirectoryNotFoundException();
            }

            //write the username and password to the MasterList of usernames and passwords
            StreamWriter writer = new StreamWriter(LoginForm.filepath + "\\MasterList.txt", true);
            writer.WriteLine(username);
            writer.WriteLine(password);
            writer.Close();

            //save user into the database and create a file for them
            LoginForm.data.Add(newUser);
            LoginForm.data.SaveUserInfo(newUser);

            this.Close();
        }

        //opens and displays an account picture for the user, this is optional but awesome
        //not sure if more than .jpg works, but that's what I have it set as
        private void uploadButton_Click(object sender, EventArgs e)
        {
            //create the dialog to search for a picture
            openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Image Files(*.JPG)|*.JPG";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Stream stream = openFileDialog1.OpenFile();
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                    //print out just the file's name in the textbox
                    String[] filenameSplit = openFileDialog1.FileName.Split('\\');
                    string filename = filenameSplit[filenameSplit.Length - 1];

                    //Dispose of an older image if you already uploaded another one, just in case
                    var oldImage = pictureBox.Image;
                    pictureBox.Image = new Bitmap(stream);
                    picPathTextBox.Text = filename;

                    if (oldImage != null)
                        oldImage.Dispose();
                }
                catch(Exception)
                {
                    //do nothing if their image doesn't work
                }
            }
        }
    }
}
