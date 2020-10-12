using System;
using System.Windows.Forms;

namespace TeachFocus
{
    public partial class Challenge1 : Form
    {
        public int Challenge1Grade { get; set; }
        public int NumberOfFeedbackPartners { get; set; }

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
                lblGradeChallenge1.Text = Utils.GetChallenge1Text(ConstantData.CHALLENGE1_TEXT_FILENAME, studentName);
            }
            else
            {
                MessageBox.Show(ConstantData.STUDENTNAME_IS_REQUIRED_FIELD_MESSAGE, ConstantData.VALIDATION_STUDENTNAME_ERROR, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Challenge1_Load(object sender, EventArgs e)
        {
            lblGradeChallenge1.Text = string.Format(ConstantData.BASE_GRADE, "0");
        }

        private void chkForumPostExist_CheckedChanged(object sender, EventArgs e)
        {
            if (chkForumPostExist.Checked)
            {
                Challenge1Grade += 5;
                lblGradeChallenge1.Text = string.Format(ConstantData.BASE_GRADE, Challenge1Grade);
            }
            else
            {
                Challenge1Grade -= 5;
                lblGradeChallenge1.Text = string.Format(ConstantData.BASE_GRADE, Challenge1Grade);
            }
        }

        private void chkAnswersTheQuestions_CheckedChanged(object sender, EventArgs e)
        {
            if (chkForumPostExist.Checked)
            {

            }
        }

        private void chkFeedbackSinglePartner_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFeedbackSinglePartner.Checked)
            {
                chkFeedbackMoreThanOnePartner.Enabled = false;
                numMoreThanOneFeedback.Enabled = false;
            }
            else
            {
                chkFeedbackMoreThanOnePartner.Enabled = true;
                numMoreThanOneFeedback.Enabled = true;
            }
        }

        private void chkFeedbackMoreThanOnePartner_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkIsOnTime_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkSolidFeedbackArgs_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
