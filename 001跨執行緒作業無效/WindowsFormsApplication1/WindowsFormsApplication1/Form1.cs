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
        private System.Timers.Timer _Timer;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _Timer = new System.Timers.Timer(1000);
            //_Timer.Elapsed += _Timer_ElapsedThreadUnsafe;
            _Timer.Elapsed += _Timer_ElapsedThreadSafe;
            _Timer.Start();
        }

        #region Method0

        void _Timer_ElapsedThreadUnsafe(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.Text = DateTime.Now.ToShortTimeString();
        }

        #endregion Method

        #region Method1

        delegate void SetTextCallback(string text);

        void SetTime(string time)
        {
            this.Text = time;
        }

        void _Timer_ElapsedThreadSafe(object sender, System.Timers.ElapsedEventArgs e)
        {
            string time = DateTime.Now.Millisecond.ToString();
            if (this.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetTime);
                this.Invoke(d, new object[] { time });
            }
            else
            {
                this.Text = time;
            }
        }

        #endregion Mehtod1

        #region Method2



        #endregion Method2
    }
}
