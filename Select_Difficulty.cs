using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koders
{
    public partial class Select_Difficulty : Form
    {
        public Select_Difficulty()
        {
            InitializeComponent();
            
        }
        
        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_Hard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon!\n The Beta version is limited for now.");
        }

        private void btn_Medium_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coming Soon!\n The Beta version is limited for now.");
        }

        public void btn_Easy_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Level_1 lvl_easy = new Level_1();
            //lvl_easy.Show();
            //Form1 main = new Form1();
            //main.WindowState = FormWindowState.Minimized;

        }
    }
}
