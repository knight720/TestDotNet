using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TestWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            string path = @"C:\Test\TestDotNet\010ListBoxWithImage\ListBoxWithImage\Resource\images (3).jpg";

            List<TodoItem> items = new List<TodoItem>();
            items.Add(new TodoItem() { Name = "abc", Image = path });
            items.Add(new TodoItem() { Name = "def C#", Image = path });
            items.Add(new TodoItem() { Name = "ghi the car", Image = path });

            lstDirecotryListing.ItemsSource = items;
        }

        public class TodoItem
        {
            public string Name { get; set; }
            public string Image { get; set; }
        }
    }
}
