using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace cs2412proj2._1
{
    public class MatchDatabase
    {
        public List<User> Users { get; set; }
        public string filepath;

        //on creation, loads all the users into the database
        public MatchDatabase(string filepath)
        {
            Users = new List<User>();
            this.filepath = filepath;

            if(!Directory.Exists(filepath))
                throw new DirectoryNotFoundException();

            if (!File.Exists(filepath + "MasterList.txt"))
                File.CreateText(filepath + "MasterList.txt");

            foreach (string filename in Directory.GetFiles(filepath))
                Users.Add(GetUserInfo(filename));

            Users.RemoveAll(IsNull);
        }

        //used as the predicate for the Users.RemoveAll function.  if we populate the list with not users, we will get rid of them
        private static bool IsNull(User u)
        {
            if (u == null)
                return true;
            return false;
        }

        public void Add(User newUser)
        {
            Users.Add(newUser);
        }

        //prints the User u's information to a file. Their username is also the name of the file to allow easy access and editing later
        public void SaveUserInfo(User u)
        {
            StreamWriter writer = new StreamWriter(filepath + u.username);
            try
            {
                writer.WriteLine(u.username);
                writer.WriteLine(u.age);
                writer.WriteLine(u.gender);
                writer.WriteLine(u.interest);
                writer.WriteLine(u.vg);
                writer.WriteLine(u.gpa);
                writer.WriteLine(u.console);
                writer.WriteLine(u.os);
                writer.WriteLine(u.weapon);
                writer.WriteLine(u.planet);
                writer.WriteLine(u.anime);

                if (!File.Exists(filepath + u.username + ".jpg"))
                    u.image.Save(filepath + u.username + ".jpg", u.image.RawFormat);

                writer.Close();
            }
            catch(Exception)
            {
                writer.Close();
            }
        }

        //using a filename, will return a User with all the data loaded from the file
        public User GetUserInfo(string filename)
        {
            if (filename != "..\\..\\Users\\MasterList.txt")
            {
                try
                {
                    TextReader reader = File.OpenText(filename);
                    string username = reader.ReadLine();
                    int age = Int32.Parse(reader.ReadLine());
                    string gender = reader.ReadLine();
                    string interest = reader.ReadLine();
                    string vg = reader.ReadLine();
                    double gpa = Double.Parse(reader.ReadLine());
                    string console = reader.ReadLine();
                    string os = reader.ReadLine();
                    string weapon = reader.ReadLine();
                    string planet = reader.ReadLine();
                    string anime = reader.ReadLine();
                    Image img;
                    User newUser;
                    
                    //if the user did attach an image to their account
                    if(!TryGetImage(filename, out img))
                        newUser = new User(username, age, gender, interest, vg, gpa, console, os, weapon, planet, anime);

                    else
                        newUser = new User(username, age, gender, interest, vg, gpa, console, os, weapon, planet, anime, img);

                    reader.Close();
                    return newUser;
                }
                catch (Exception)
                {
                    //don't read in corrupted file
                }
            }

            return null;
        }

        //functions similar to an Int32.TryParse(), returns whether an image exists.
        //the out Image img will be the Image read in by the filename if it exists otherwise it'll be returned as null
        public bool TryGetImage(string filename, out Image img)
        {
            filename += ".jpg";
            img = null;

            if (!File.Exists(filename))
                return false;

            try
            {
                Stream stream = File.OpenRead(filename);
                img = new Bitmap(stream);
                return true;
            }
            catch(Exception)
            {
                //don't read in corrupted data
            }

            return false;
        }
    }
}
