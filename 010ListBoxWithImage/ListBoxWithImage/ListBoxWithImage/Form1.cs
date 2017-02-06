using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using WPFControlLibrary;

namespace ListBoxWithImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Image image = new Image();
            //BitmapImage bi = new BitmapImage(new Uri(@"C:\Users\Public\Pictures\crown_density_scale.bmp"));
            //image.Source = bi;
            ImageListBox ilb = (ImageListBox)elementHost1.Child;
            //ilb.Items.Add(new DirectoryListing(image, "hello"));
            
        }
    }
}
