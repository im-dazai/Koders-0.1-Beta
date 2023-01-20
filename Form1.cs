using AxWMPLib;
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
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void volume_control_Click(object sender, EventArgs e)
        {
            volume_panel2.Visible = true;
        }

        private void btn_Close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Difficulty_Click(object sender, EventArgs e)
        {
            panel_diff.Visible = true;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            player.URL = "1.mp3";
            player.settings.autoStart = true;
            player.settings.setMode("loop", true);
            volume_panel2.Visible = false;
            panel_diff.Visible = false;
            panel_testStart.Visible = false;
        }


        private void vpanle_close_Click_1(object sender, EventArgs e)
        {
            volume_panel2.Visible = false;
        }

        private void Music_Check_CheckedChanged_1(object sender, EventArgs e)
        {
            if (Music_Check.Checked != true)
            {
                player.controls.stop();
            }
           

            if(Music_Check.Checked == true)
            {

                player.controls.play();


            }
        }
        
        private void volume_Trackbar_Scroll_1(object sender, ScrollEventArgs e)
        {
            player.settings.volume = volume_Trackbar.Value;
        }

        private void diff_pClose_Click(object sender, EventArgs e)
        {
            panel_diff.Visible = false;
        }

        public void btn_Easy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Level_1 lvl_easy = new Level_1();
            player.controls.stop();
            lvl_easy.Show();
            

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            player.controls.stop();
        }

        private void btn_testClose_Click(object sender, EventArgs e)
        {
            panel_testStart.Visible = false;
        }

        private void btn_testPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Form1 frm = new Form1();
            //frm.Hide();
            player.controls.stop();
            Level_1 lvl_easy = new Level_1();
            lvl_easy.Show();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            panel_testStart.Visible = true;
        }


        // For Media Player at end
        //axWindowsMediaPlayer1.URL = "1.mp4";
        //axWindowsMediaPlayer1.uiMode = "none";

    }
}
