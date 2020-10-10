using System;
using System.Windows.Forms;

namespace TeachFocus
{
    public partial class Challenge1 : Form
    {
        public Challenge1()
        {
            InitializeComponent();
        }

        private void btnGenerateText_Click(object sender, EventArgs e)
        {
            string studentName = string.Empty;
            if (txtStudentName.Text != string.Empty)
            {
                studentName = txtStudentName.Text;
            }
            else
            {
                MessageBox.Show(ConstantData.STUDENTNAME_IS_REQUIRED_FIELD_MESSAGE, ConstantData.VALIDATION_STUDENTNAME_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Challenge1_Load(object sender, EventArgs e)
        {
            lblGradeChallenge1.Text = ConstantData.BASE_GRADE;
        }
    }
}
