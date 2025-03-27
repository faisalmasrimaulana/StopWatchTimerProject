using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatchC_
{
    public partial class MenuUtama : Form
    {
        //1. Membuat objek stopwatch dan timer
        StopWatch_form stopwatch;
        Timer_form timer;

        //2. buat prosedur closed stopWatch dan closed timer
        void closedStopwatch(object sender, FormClosedEventArgs e)
        {
            stopwatch = null;
        }

        void closedTimer(object sender, FormClosedEventArgs e)
        {
            timer = null;
        }
        public MenuUtama()
        {
            InitializeComponent();

        }

        private void subMenu_stopwatch_Click(object sender, EventArgs e)
        {
            if (stopwatch == null)
            {
                stopwatch = new StopWatch_form();
                stopwatch.MdiParent = this;
                //panggil prosedur closed stopwatch
                stopwatch.FormClosed += new FormClosedEventHandler(closedStopwatch);
                stopwatch.Show();
            }
            else
            {
                stopwatch.Activate();
            }
        }

        private void subMenu_timer_Click(object sender, EventArgs e)
        {
            if (timer == null)
            {
                timer = new Timer_form();
                timer.MdiParent = this;
                //panggil prosedur closed timer
                timer.FormClosed += new FormClosedEventHandler(closedTimer);
                timer.Show();
            }
            else
            {
                timer.Activate();
            }
        }
    }
}
