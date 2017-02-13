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

            string path = @"C:\Test\TestDotNet\010ListBoxWithImage\ListBoxWithImage\Resource\images (3).jpg";

            List<ImageItem> items = new List<ImageItem>();
            items.Add(new ImageItem() { Name = "abc", Image = path });
            items.Add(new ImageItem() { Name = "def C#", Image = path });
            items.Add(new ImageItem() { Name = "ghi the car", Image = path });
            items.Add(new ImageItem() { Name = "ghi the car", Image = path });
            items.Add(new ImageItem() { Name = "ghi the car", Image = path });
            items.Add(new ImageItem() { Name = "ghi the car", Image = path });

            ilb.ItemsSource = items;
            
        }
    }
}
