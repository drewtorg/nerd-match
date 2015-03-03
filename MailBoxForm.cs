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
    public partial class MailBoxForm : Form
    {
        List<Tuple<string, string>> Messages;   //ItemOne contains the username of the sender, ItemTwo conatins the message that was sent
        int messageIndex = 0;
        string filepath = "..\\..\\Messages\\";
        string[] delimiters = { "ajsndsads" };  //a delimiter for seperating the current users username and the sender's username

        public MailBoxForm()
        {
            InitializeComponent();

            //check if there are any messages for the user
            GetMessages();

            //disable the button to view mail if there aren't any messages
            if (Messages.Count == 0)
                inboxButton.Enabled = false;
        }

        //populates the Messages List with the messages sent to our user
        public void GetMessages()
        {
            Messages = new List<Tuple<string, string>>();

            if(!Directory.Exists(filepath))
                Directory.CreateDirectory(filepath);

            foreach(var f in Directory.GetFiles(filepath))
            {
                //this shows that the current msg file is for our specific user
                string[] usernames = f.Split(delimiters, 2, StringSplitOptions.RemoveEmptyEntries);
                usernames[0] = usernames[0].Substring(filepath.Length);

                //if the file is meant for the current user, add it to the List
                if(usernames[0] == LoginForm.currentUser.username)
                {
                    StreamReader reader = new StreamReader(f);

                    Messages.Add(new Tuple<string, string>(usernames[1], reader.ReadToEnd()));

                    reader.Close();
                }

            }
        }

        //prints the username of the sender and their message in the textboxes
        public void DisplayMessage(int msgIndex)
        {
            toFromTextBox.Text = Messages[msgIndex].Item1;
            msgTextBox.Text = Messages[msgIndex].Item2;
        }

        //returns whether or not a username can be found in the database
        public bool UserExists(string username)
        {
            foreach(User u in LoginForm.data.Users)
                if (u.username == username)
                    return true;

            return false;
        }

        //writes the message file to the messages folder if the user we are sending to actually exists
        //returns true if the message was sent and false if it wasn't
        public bool TrySendMessage(string msg, string username)
        {
            if (UserExists(username))
            {
                string filename = filepath + username + delimiters[0] + LoginForm.currentUser.username;

                StreamWriter writer = new StreamWriter(filename);
                writer.Write(msg);
                writer.Close();

                return true;
            }

            return false;
        }

        //enables all the textboxes so we can send a message to another user
        //another click will try to send that message
        //a message box will show if the message was successfully sent or not
        private void msgButton_Click(object sender, EventArgs e)
        {
            //when we view inbox again, we'll see them from the beginning
            messageIndex = 0;

            if(msgButton.Text == "Send Message" && UserExists(toFromTextBox.Text))
            {
                //try to send the message to the user
                if (TrySendMessage(msgTextBox.Text, toFromTextBox.Text))
                    MessageBox.Show("Message sent to " + toFromTextBox.Text);   //print the on suceed message

                else
                    MessageBox.Show("Could not send message to " + toFromTextBox.Text); //print the on fail message

                //change the text back the create message and disable the text boxes
                msgButton.Text = "Create Message";
                toFromTextBox.Enabled = false;
                msgTextBox.Enabled = false;
                toFromTextBox.Text = "";
                msgTextBox.Text = "";
            }
            //change the button to say send message and enable all the textboxes
            else if(msgButton.Text == "Create Message")
            {
                msgButton.Text = "Send Message";
                toFromTextBox.Enabled = true;
                msgTextBox.Enabled = true;
                toFromTextBox.Text = "";
                msgTextBox.Text = "";
                toFromLabel.Text = "To:";
            }
        }

        //will change the text to show that we are reading a message
        //prints the contents of a message to the textboxes on the screen
        //another click will print the contents of the next message
        //if there are no messages, disable the button
        private void inboxButton_Click(object sender, EventArgs e)
        {
                msgButton.Text = "Create Message";
                toFromTextBox.Enabled = false;
                msgTextBox.Enabled = false;
                toFromTextBox.Text = "";
                msgTextBox.Text = "";

                toFromLabel.Text = "From:";

                if (messageIndex < Messages.Count)
                    DisplayMessage(messageIndex++);

                if (messageIndex == Messages.Count)
                    inboxButton.Enabled = false;
        }
        
        //close this form
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
