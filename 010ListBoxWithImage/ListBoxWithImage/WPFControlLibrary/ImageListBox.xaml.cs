﻿using System;
using System.Collections;
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

namespace WPFControlLibrary
{
    /// <summary>
    /// Interaction logic for ImageListBox.xaml
    /// </summary>
    public partial class ImageListBox : UserControl
    {
        public ImageListBox()
        {
            InitializeComponent();
        }

        public IEnumerable ItemsSource
        {
            set { listBox.ItemsSource = value; }
        }
    }
}
