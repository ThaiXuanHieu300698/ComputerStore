using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private int imageNumber = 1;

        private void LoadNextImage()
        {
            if(imageNumber == 5)
            {
                imageNumber = 1;
            }
            Slideshow.ImageLocation = string.Format(@"Resources\{0}.jpg", imageNumber);
            imageNumber++;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            LoadNextImage();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            Timer.Start();
        }
    }
}
