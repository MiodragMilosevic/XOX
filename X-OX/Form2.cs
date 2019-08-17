using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace X_OX
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            if (txtBox.Text.Length <= 9)
                Form3.ChangePlayer1(txtBox.Text);
        }

        private void txtBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            if (txtBox.Text.Length <= 9)
                Form3.ChangePlayer2(txtBox.Text);
        }

        private void radioBtn1_Checked_Changed(object sender, EventArgs e)
        {
            RadioButton radioBtn1 = (RadioButton)sender;
            if (radioBtn1.Checked == true) Form3.ChangedPlayerVsComputer(false);
        }

        private void radioBtn2_Checked_Changed(object sender, EventArgs e)
        {
            RadioButton radioBtn2 = (RadioButton)sender;
            if (radioBtn2.Checked == true) Form3.ChangedPlayerVsComputer(true);
        }

    }
}
