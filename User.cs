using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace cs2412proj2._1
{
    //A simple class which holds all the information for a single user in the system
    public class User
    {
        public string username;
        public int age;
        public string gender;
        public string interest;
        public string vg;
        public double gpa;
        public string console;
        public string os;
        public string weapon;
        public string planet;
        public string anime;
        public Image image;

        public User(string username, int age, string gender, string interest, string vg, double gpa, string console, string os, string weapon, string planet, string anime, Image image)
        {
            this.username = username;
            this.age = age;
            this.gender = gender;
            this.interest = interest;
            this.vg = vg;
            this.gpa = gpa;
            this.console = console;
            this.os = os;
            this.weapon = weapon;
            this.planet = planet;
            this.anime = anime;
            this.image = image;
        }

        public User(string username, int age, string gender, string interest, string vg, double gpa, string console, string os, string weapon, string planet, string anime)
        {
            this.username = username;
            this.age = age;
            this.gender = gender;
            this.interest = interest;
            this.vg = vg;
            this.gpa = gpa;
            this.console = console;
            this.os = os;
            this.weapon = weapon;
            this.planet = planet;
            this.anime = anime;
            this.image = null;
        }
    }
}
