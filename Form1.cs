using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Windows.Media;
using System.Windows.Media.Media3D;
using Color = System.Drawing.Color;


namespace Menu
{
    public partial class Form1 : Form
    {
//         "yes.wav"
//         "no.wav"
//         "ho ho ho.wav"
//         "ugh.wav"
//         "na na na.wav"
//         "shh.wav"
//         "ben.wav"
//         "snore.wav"
//         "hm hm hm.wav"
//         "hmm.wav"
//         "burp.wav"
//         "eat.wav"
//         "drink.wav"
//         "start call.wav"
//         "punch.wav"
//         "pet.wav"
//         "open news.wav"
//         "flip news.wav"
//         "flick news.wav"
//         "slap.wav"
//         "end call.wav"

        private bool isdark = false;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Talking Ben Sound Board";
            this.Icon = Properties.Resources.talking_ben;
        }
        protected override void WndProc(ref Message m)//move window
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var p1 = new System.Windows.Media.MediaPlayer();
            p1.Open(new System.Uri(Directory.GetCurrentDirectory() + "//yes.wav"));
            p1.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var p2 = new System.Windows.Media.MediaPlayer();
            p2.Open(new System.Uri(Directory.GetCurrentDirectory() + "/no.wav"));
            p2.Play();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var p3 = new System.Windows.Media.MediaPlayer();
            p3.Open(new System.Uri(Directory.GetCurrentDirectory() + "/ho ho ho.wav"));
            p3.Play();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var p4 = new System.Windows.Media.MediaPlayer();
            p4.Open(new System.Uri(Directory.GetCurrentDirectory() + "/ugh.wav"));
            p4.Play();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var p5 = new System.Windows.Media.MediaPlayer();
            p5.Open(new System.Uri(Directory.GetCurrentDirectory() + "/na na na.wav"));
            p5.Play();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var p6 = new System.Windows.Media.MediaPlayer();
            p6.Open(new System.Uri(Directory.GetCurrentDirectory() + "/shh.wav"));
            p6.Play();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var p7 = new System.Windows.Media.MediaPlayer();
            p7.Open(new System.Uri(Directory.GetCurrentDirectory() + "/ben.wav"));
            p7.Play();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var p8 = new System.Windows.Media.MediaPlayer();
            p8.Open(new System.Uri(Directory.GetCurrentDirectory() + "/snore.wav"));
            p8.Play();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            var p9 = new System.Windows.Media.MediaPlayer();
            p9.Open(new System.Uri(Directory.GetCurrentDirectory() + "/hm hm hm.wav"));
            p9.Play();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            var p10 = new System.Windows.Media.MediaPlayer();
            p10.Open(new System.Uri(Directory.GetCurrentDirectory() + "/hmm.wav"));
            p10.Play();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            var p11 = new System.Windows.Media.MediaPlayer();
            p11.Open(new System.Uri(Directory.GetCurrentDirectory() + "/burp.wav"));
            p11.Play();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var p12 = new System.Windows.Media.MediaPlayer();
            p12.Open(new System.Uri(Directory.GetCurrentDirectory() + "/eat.wav"));
            p12.Play();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            var p13 = new System.Windows.Media.MediaPlayer();
            p13.Open(new System.Uri(Directory.GetCurrentDirectory() + "/drink.wav"));
            p13.Play();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            var p14 = new System.Windows.Media.MediaPlayer();
            p14.Open(new System.Uri(Directory.GetCurrentDirectory() + "/start call.wav"));
            p14.Play();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            var p15 = new System.Windows.Media.MediaPlayer();
            p15.Open(new System.Uri(Directory.GetCurrentDirectory() + "/punch.wav"));
            p15.Play();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            var p16 = new System.Windows.Media.MediaPlayer();
            p16.Open(new System.Uri(Directory.GetCurrentDirectory() + "/pet.wav"));
            p16.Play();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            var p17= new System.Windows.Media.MediaPlayer();
            p17.Open(new System.Uri(Directory.GetCurrentDirectory() + "/open news.wav"));
            p17.Play();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            var p18 = new System.Windows.Media.MediaPlayer();
            p18.Open(new System.Uri(Directory.GetCurrentDirectory() + "/flip news.wav"));
            p18.Play();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            var p19 = new System.Windows.Media.MediaPlayer();
            p19.Open(new System.Uri(Directory.GetCurrentDirectory() + "/flick news.wav"));
            p19.Play();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            var p20 = new System.Windows.Media.MediaPlayer();
            p20.Open(new System.Uri(Directory.GetCurrentDirectory() + "/slap.wav"));
            p20.Play();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            var p21 = new System.Windows.Media.MediaPlayer();
            p21.Open(new System.Uri(Directory.GetCurrentDirectory() + "/end call.wav"));
            p21.Play();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (isdark == false)
            {
                button24.Text = "Light mode";
                BackColor = Color.Black;
                ForeColor = Color.White;
                button1.ForeColor = Color.Black;
                button2.ForeColor = Color.Black;
                isdark = true;
            }
            else
            {
                button24.Text = "Dark mode";
                BackColor = Color.White;
                ForeColor = Color.Black;
                isdark = false;
            }
        }
    }
}
