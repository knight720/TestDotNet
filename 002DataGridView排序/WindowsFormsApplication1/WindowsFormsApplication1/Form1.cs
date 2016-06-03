using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            DataTable dt = new DataTable();
            dt.Columns.Add("c1");
            dt.Columns.Add("c2");
            dt.Columns.Add("c3");
            dt.Columns.Add("c4");
            dt.Columns.Add("c5");

            dt.Rows.Add(new object[] {1,2,3,4,5});
            dt.Rows.Add(new object[] { 2, 2, 2, 2, 2 });
            dt.Rows.Add(new object[] { 3, 3, 3, 3, 3 });
            dt.Rows.Add(new object[] { DateTime.Now, DateTime.Now, DateTime.Now, 3, 3 });

            dataGridView1.DataSource = dt;

        }
    }
}
