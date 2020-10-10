using System;
using System.Windows.Forms;

namespace TeachFocus
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnChallenge1_Click(object sender, EventArgs e)
        {
            var challenge1Form = new Challenge1();
            challenge1Form.Show();
        }

        private void btnChallenge2_Click(object sender, EventArgs e)
        {
            var challenge2Form = new Challenge2();
            challenge2Form.Show();
        }

        private void btnChallenge3_Click(object sender, EventArgs e)
        {
            var challenge3Form = new Challenge3();
            challenge3Form.Show();
        }

        private void btnChallenge5_Click(object sender, EventArgs e)
        {
            var challenge5 = new Challenge5();
            challenge5.Show();
        }

        private void btnAdminEmailText_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ConstantData.COMING_SOON_MESSAGE);
        }

        private void btnAdminNumbers_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ConstantData.COMING_SOON_MESSAGE);
        }
    }
}
