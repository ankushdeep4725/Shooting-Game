using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Shooting_zombie
{
    public partial class first : Form
    {
        private SoundPlayer _soundplayer;

        private SoundPlayer _soundplayer1;

        public first()
        {
            InitializeComponent();
            _soundplayer = new SoundPlayer(@"C:\Users\Armangill\Documents\Gun+Reload.wav");
            _soundplayer1 = new SoundPlayer(@"C:\Users\Armangill\Documents\Revolver Chamber Spin Sound Effect.wav ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 display = new Form1();
            display.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _soundplayer.Play();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _soundplayer1.Play();
        }
    }
}
