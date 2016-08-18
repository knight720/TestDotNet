using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            listView1.Items[0].Selected = true;
            listView1.Focus();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text = listView1.FocusedItem.Index.ToString();
        }
    }
}
