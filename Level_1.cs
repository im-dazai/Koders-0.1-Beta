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

namespace Koders
{
    public partial class Level_1 : Form
    {
        public Level_1()
        {
            InitializeComponent();
            btn_Next.Enabled = false;
            
        }

        private void Level_1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            

            if (txtBox_x.Text == "int" && txtBox_y.Text == "int" && txtBox_Cx.Text == "x" && txtBox_Cy.Text == "y")
            {
                MessageBox.Show("Correct!");
                btn_Next.Enabled = true;

            }
            else if (txtBox_x.Text == "" || txtBox_y.Text == "" || txtBox_Cx.Text == "" || txtBox_Cy.Text == "")
            {
                MessageBox.Show("Error 100: Tried to submit an empty text box!");
            }
            else
            {
                MessageBox.Show("Wrong Answer! \n Possible Solution: Check letter-case");
            }

           
        }

        private void diff_pClose_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();
            frm.Show();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            this.Hide();

            Level_2 lvl_med = new Level_2();
            lvl_med.Show();
        }
    }
}
