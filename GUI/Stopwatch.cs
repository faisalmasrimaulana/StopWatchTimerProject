using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatchTimerProject
{
    public partial class StopWatch_form: Form
    {

        //inisialisasi detik, menit, dan jam
        int detik = 0;
        int menit = 0;
        int jam = 0;
      
        public StopWatch_form()
        {
            InitializeComponent();
        }

        private void btnMulai_Click(object sender, EventArgs e)
        {
            //Ketika tombol di klik, angka di labelStopWatch bertambah
            //Ketika tombol di stop, maka angka di labelStopWatch berhenti
            if (timerStopWatch.Enabled)
            {
                timerStopWatch.Stop();
                btnMulai.Text = "Mulai";
            }
            else
            {
                timerStopWatch.Start();
                btnMulai.Text = "Berhenti";
            }
        }

        private void timerStopwatch_Tick(object sender, EventArgs e)
        {
            if (timerStopWatch.Enabled)
            {
                    detik++;
                    labelStopWatchDetik.Text = detik.ToString("D2");
                    if(detik == 60)
                    {
                        menit++;
                        labelStopWatchMenit.Text = menit.ToString("D2");
                        detik = 0;
                        if(menit == 60)
                        {
                            jam++;
                            labelStopWatchJam.Text = jam.ToString("D2");
                            menit = 0;
                        }
                    }
                }
            }
            //Angka berubah setiap satu detik

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (!timerStopWatch.Enabled)
            {
                detik = 0;
                menit = 0;
                jam = 0;
                labelStopWatchDetik.Text = "00";
                labelStopWatchMenit.Text = "00";
                labelStopWatchJam.Text = "00";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String waktu = labelStopWatchJam.Text + ":" + labelStopWatchMenit.Text + ":" + labelStopWatchDetik.Text;
            if (timerStopWatch.Enabled)
            {
                listBoxStopWatch.Items.Add(waktu);
                if(listBoxStopWatch.Items.Count > 3)
                {
                    listBoxStopWatch.Items.RemoveAt(0);
                }
            }
        }

        private void btnResetSave_Click(object sender, EventArgs e)
        {
            listBoxStopWatch.Items.Clear();
        }

    }
}
