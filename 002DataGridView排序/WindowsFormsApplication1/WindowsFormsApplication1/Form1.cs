using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.CellValuePushed += dataGridView1_CellValuePushed;
            dataGridView1.CurrentCellDirtyStateChanged += dataGridView1_CurrentCellDirtyStateChanged;
        }

        void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            Debug.WriteLine("CurrentCellDirtyStateChanged");
            if (dataGridView1.IsCurrentCellDirty )
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        void dataGridView1_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
            Debug.WriteLine("CellValuePushed");
        }

        void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Debug.WriteLine(string.Format("CellValueChanged Column{0}, Row{1}",e.ColumnIndex,e.RowIndex));
        }

        void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            Debug.WriteLine("CellContentClick");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("c1");
            dt.Columns.Add("c2");
            dt.Columns.Add("c3");
            dt.Columns.Add("c4");
            dt.Columns.Add("c5");

            dt.Rows.Add(new object[] {1,2,3,true,5});
            dt.Rows.Add(new object[] { 2, 2, 2, false, 2 });
            dt.Rows.Add(new object[] { 3, 3, 3, false, 3 });
            dt.Rows.Add(new object[] { DateTime.Now, DateTime.Now, DateTime.Now, false, 3 });

            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns["c4"].ReadOnly = true;
        }
    }
}
