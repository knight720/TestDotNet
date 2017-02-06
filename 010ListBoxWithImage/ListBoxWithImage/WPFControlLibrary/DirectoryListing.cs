using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace WPFControlLibrary
{
    public class DirectoryListing
    {
        public string path { get; set; }
        public Image image { get; set; }
        public DirectoryListing(Image imgage, String path)
        {
            this.image = image;
            this.path = path;
        }
    }
}
