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

        private void Form1_Load(object sender, EventArgs e)
        {
            string fieldName = "Time";
            string format = "yyyy/MM/dd HH:mm:ss";

            DataTable dt = new DataTable();
            dt.Columns.Add(fieldName);
            DataRow dr = dt.NewRow();
            dr[fieldName] = DateTime.Now;
            dt.Rows.Add(dr);

            dataGridView1.DefaultCellStyle.Format = format;

            dataGridView1.DataSource = dt;

            dataGridView1.DefaultCellStyle.Format = format;

            dataGridView1.Columns[fieldName].DefaultCellStyle.Format = format;

            DataGridViewCellStyle cs = new DataGridViewCellStyle();
            cs.Format = format;

            dataGridView1.Columns[fieldName].DefaultCellStyle = cs;
        }
    }
}
