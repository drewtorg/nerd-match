using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cs2412proj2._1
{
    public partial class PictureForm : Form
    {
        //A form used to show a full image file
        //the form is the size of the image file so big images will be massive on the form
        public PictureForm(Image img)
        {
            InitializeComponent();

            this.Size = img.Size;
            this.BackgroundImage = img;
        }
    }
}
