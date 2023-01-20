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
    public partial class Level_2 : Form
    {
        public Level_2()
        {
            InitializeComponent();
            btn_Next.Enabled = false;
        }

        private void btn_Check_Click(object sender, EventArgs e)
        {
            if (txtBox_int.Text == "" && txtBox_string.Text == "" && txtBox_float.Text == "" && txtBox_double.Text == "" && txtBox_char.Text == "" && txtBox_bool.Text == "")
            {
                MessageBox.Show("Error 100: Tried to sumbit an Empty Text Box");
            }
            else if (txtBox_int.Text == "int" && txtBox_string.Text == "string" && txtBox_float.Text == "float" && txtBox_double.Text == "double" && txtBox_char.Text == "char" && txtBox_bool.Text == "bool")
            {
                btn_Next.Enabled = true;
                MessageBox.Show("Correct!");
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
    }
}
