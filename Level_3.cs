using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koders
{
    public partial class Level_3 : Form
    {
        public Level_3()
        {
            InitializeComponent();
            btn_Next.Enabled = false;
            lbl_ans.Enabled = false;
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            if (txtBox_Plus.Text == "" && txtBox_FullName.Text == "")
            {
                MessageBox.Show("Error 100: Tried to Submit an Empty Text Box");
            }
            else if (txtBox_Plus.Text == "+" && txtBox_FullName.Text == "full_name")
            {
                btn_Next.Enabled = true;
                MessageBox.Show("Correct!");
                lbl_ans.Enabled = true;
            }
            else
                MessageBox.Show("Wrong Answer! \n Possible Solution: Check letter-case");
        }
    }
}
