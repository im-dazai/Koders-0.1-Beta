using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Koders
{
    public partial class VolumeMessage : Form
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        public VolumeMessage()
        {
            InitializeComponent();
            player.URL = "1.mp3";
            player.settings.autoStart = true;
            player.settings.setMode("loop", true);
        }

        private void volume_Trackbar_Scroll(object sender, ScrollEventArgs e)
        {
            player.settings.volume = volume_Trackbar.Value;
        }

        private void Music_Check_CheckedChanged(object sender, EventArgs e)
        {
            if (Music_Check.Checked != true)
            {
                player.controls.stop();
            }
            else
            {
               
                player.controls.play();
                
               
            }
            
        }

        private void btn_Close_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
