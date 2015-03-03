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
    public partial class MainMenuForm : Form
    {
        List<User> Matches { get; set; }
        ToolTip t = new ToolTip();
        private int matchIndex = 0;

        public MainMenuForm()
        {
            InitializeComponent();

            //populate our matches list
            UpdateMatches();

            DisplayUser(LoginForm.currentUser);

            //make sure to disable the button on start up if there are no matches
            if (matchIndex >= Matches.Count)
                matchButton.Enabled = false;

            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }


        //prints a User u to the textboxes on the screen
        public void DisplayUser(User u)
        {
            nameTextBox.Text = u.username;
            ageTextBox.Text = u.age.ToString();
            vgTextBox.Text = u.vg;
            gpaTextBox.Text = u.gpa.ToString();
            consoleTextBox.Text = u.console;
            osTextBox.Text = u.os;
            weaponTextBox.Text = u.weapon;
            planetTextBox.Text = u.planet;
            animeTextBox.Text = u.anime;


            if (u.gender == "Male")
                maleGenderButton.Checked = true;
            else
                femaleGenderButton.Checked = true;

            if (u.interest == "Male")
                maleInterestButton.Checked = true;
            else if (u.interest == "Female")
                femaleInterestButton.Checked = true;
            else
                bothInterestButton.Checked = true;

            pictureBox.Image = u.image;
        }

        //populates the Matches List with all the matches in the database.  Matches are ordered based off the fancy matching algorithm I made up
        public void UpdateMatches()
        {
            SortedDictionary<int, User> matchesDict = new SortedDictionary<int, User>();
            Matches = new List<User>();

            //fill a sorted dictionary with all the users you match with
            foreach(User u in LoginForm.data.Users)
            {
                bool youRightGender = (u.interest == LoginForm.currentUser.gender || u.interest == "Both");
                bool theyRightGender = (LoginForm.currentUser.interest == u.gender || LoginForm.currentUser.interest == "Both");

                //Don't match with youself and only match with the sex you are interested and vice versa
                if(u.username != LoginForm.currentUser.username && youRightGender && theyRightGender)
                {
                    int matches = 0;
                    matches += MatchAmount(u.username, LoginForm.currentUser.username);
                    matches += MatchAmount(u.vg, LoginForm.currentUser.vg);
                    matches += MatchAmount(u.weapon, LoginForm.currentUser.weapon);
                    matches += MatchAmount(u.planet, LoginForm.currentUser.planet);
                    matches += MatchAmount(u.os, LoginForm.currentUser.os);
                    matches += MatchAmount(u.gpa.ToString(), LoginForm.currentUser.gpa.ToString());
                    matches += MatchAmount(u.console, LoginForm.currentUser.console);
                    matches += MatchAmount(u.anime, LoginForm.currentUser.anime);
                    matches += MatchAmount(u.age.ToString(), LoginForm.currentUser.age.ToString());

                    //if the dictionary contains someone you matched with the same amount of times, change the key by one until they ift into the dictionary
                    while(matchesDict.ContainsKey(matches))
                        matches++;

                    matchesDict.Add(matches, u);
                }
            }
            
            //add them in order to the Matches List for further use
            foreach(var pair in matchesDict)
                Matches.Add(pair.Value);
        }

        //returns how much of a match two strings are
        public int MatchAmount(string s1, string s2)
        {
            s1 = s1.ToLower().Replace(" ", "");
            s2 = s2.ToLower().Replace(" ", "");

            //same word grants 2 matches
            if (s1 == s2)
                return 2;

            //same first letter grants 1 match
            if (s1[0] == s2[0])
                return 1;

            return 0;
        }

        //allows the user to change their own profile info as well as save that info
        private void editProfileButton_Click(object sender, EventArgs e)
        {
            //open the textboxes for editing
            if (editProfileButton.Text == "Edit Profile")
            {
                foreach (Control c in this.Controls)
                    c.Enabled = true;
                foreach (Control c in this.panel1.Controls)
                    c.Enabled = true;
                foreach (Control c in this.panel2.Controls)
                    c.Enabled = true;
                

                nameTextBox.Enabled = false;
                matchButton.Enabled = false;
                logoutButton.Enabled = false;
                mailboxButton.Enabled = false;
                editProfileButton.Text = "Save Profile";

                DisplayUser(LoginForm.currentUser);
            }
            //disbale all the textboxes and save the new information
            else
            {
                errorLabel.Visible = false;

                int age;
                if (!Int32.TryParse(ageTextBox.Text, out age))
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

                LoginForm.currentUser.age = age;
                LoginForm.currentUser.anime = anime;
                LoginForm.currentUser.console = console;
                LoginForm.currentUser.gender = gender;
                LoginForm.currentUser.gpa = gpa;
                LoginForm.currentUser.interest = interest;
                LoginForm.currentUser.os = os;
                LoginForm.currentUser.planet = planet;
                LoginForm.currentUser.vg = vg;
                LoginForm.currentUser.weapon = weapon;

                //save your user
                LoginForm.data.SaveUserInfo(LoginForm.currentUser);

                //disable all the textboxes

                editProfileButton.Text = "Edit Profile";
                
                foreach (Control c in this.Controls)
                    c.Enabled = false;
                foreach (Control c in this.panel1.Controls)
                    c.Enabled = false;
                foreach (Control c in this.panel2.Controls)
                    c.Enabled = false;

                matchButton.Enabled = true;
                logoutButton.Enabled = true;
                mailboxButton.Enabled = true;
                editProfileButton.Enabled = true;
                pictureBox.Enabled = true;

                //be sure to update the matches again so we cna see what might've changed
                matchIndex = 0;
                UpdateMatches();
            }
        }

        //display the next match in the list, if there are no more matches, disable the button
        private void matchButton_Click(object sender, EventArgs e)
        {
            if (matchIndex < Matches.Count)
                DisplayUser(Matches[matchIndex++]);

            if (matchIndex == Matches.Count)
                matchButton.Enabled = false;
        }

        //closes the form
        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //on a double click, the img is opened in a new form in its full size
        private void pictureBox_Click(object sender, EventArgs e)
        {
            var form = new PictureForm(pictureBox.Image);
            form.Location = this.Location;
            form.StartPosition = FormStartPosition.Manual;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }

        //shows a tooltip explaining the double click feature
        private void pictureBox_MouseHover(object sender, EventArgs e)
        {
            Point p = pictureBox.Location;
            t.Show("Double Click to show the full image", this, p.X, p.Y + pictureBox.Size.Height);
        }

        //hides the tooltip when they stop hovering
        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            t.Hide(this);
        }

        //open the mailbox form
        private void mailboxButton_Click(object sender, EventArgs e)
        {
            var form = new MailBoxForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.FormClosing += delegate { this.Show(); };
            form.Show();
        }
    }
}
