using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatchTimerProject
{
    public partial class Timer_form : Form
    {
        //inisialisasi jam, menit, dan detik
        int jam;
        int menit;
        int detik;
        public Timer_form()
        {
            InitializeComponent();
        }


        private void btnAturWaktu_Click(object sender, EventArgs e)
        {
            
            if (aturWaktuGroup.Visible == false)
            {
                aturWaktuGroup.Visible = true;
            }
            //jika sudah muncul, dan user sudah mengatur waktu, maka valuenya akan dimasukkan ke timerlabel
            else if (aturWaktuGroup.Visible == true)
            {
                //ambil value pada jamCount dan masukkan ke variabel jam
                jam = int.Parse(jamCount.Text);
                menit = int.Parse(menitCount.Text);
                detik = int.Parse(detikCount.Text);
                //masukkan value jam,menit,dan detik ke labelstopwatch
                labelTimerJam.Text = jam.ToString("D2");
                labelTimerMenit.Text = menit.ToString("D2");
                labelTimerDetik.Text = detik.ToString("D2");

                aturWaktuGroup.Visible = false;
            }
        }

        private void btnMulai_Click(object sender, EventArgs e)
        {

            if (timerCountDown.Enabled)
            {
                timerCountDown.Stop();
                btnMulai.Text = "Mulai";
            }
            else
            //kondisi agar menghindari error ketika tombol klik ditekan
            {
                //jika waktu masih 0, maka akan muncul perintah untuk mengatur waktunya
                if (jam == 0 && menit == 0 && detik == 0 || aturWaktuGroup.Visible == true)
                {
                        MessageBox.Show("Atur Waktu terlebih dahulu");
                   
                }
                //jika waktu sudah diatur maka timer dimulai dan tulisan tombol mulai akan berubah menjadi berhenti
                else if (aturWaktuGroup.Visible == false)
                {
                timerCountDown.Start();
                btnMulai.Text = "Berhenti";
                }
            }
        }

        private void timerCountDown_Tick(object sender, EventArgs e)
        {
            if (timerCountDown.Enabled)
            {
                //jika detik sama dengan 0, maka menit berkurang, tapi menit, detik, jam tidak boleh sampai negatif
                if (jam == 0 && menit == 0 && detik == 0)
                {
                    timerCountDown.Stop();
                    MessageBox.Show("Waktu Habis");
                    btnMulai.Text = "Mulai";
                    jam = 0;
                    menit = 0;
                    detik = 0;
                }
                if (detik > 0)
                {
                    detik--;
                }
                
                else{
                    if (menit > 0) {
                        menit--;
                        detik = 59;
                    }
                   else if (jam > 0){
                        jam--;
                        menit = 59;
                        detik = 59;
                    }
                }
                labelTimerDetik.Text = detik.ToString("D2");
                labelTimerMenit.Text = menit.ToString("D2");
                labelTimerJam.Text = jam.ToString("D2");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (!timerCountDown.Enabled)
            {
                detik = 0;
                menit = 0;
                jam = 0;
                labelTimerDetik.Text = "00";
                labelTimerMenit.Text = "00";
                labelTimerJam.Text = "00";
                jamCount.Text = "0";
                menitCount.Text = "0";
                detikCount.Text = "0";
            }
        }
    }
}
