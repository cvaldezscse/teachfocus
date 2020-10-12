namespace TeachFocus
{
    partial class Challenge1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkAnswersTheQuestions = new System.Windows.Forms.CheckBox();
            this.chkForumPostExist = new System.Windows.Forms.CheckBox();
            this.chkFeedbackSinglePartner = new System.Windows.Forms.CheckBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResultTextChallenge1 = new System.Windows.Forms.TextBox();
            this.lblGradeChallenge1 = new System.Windows.Forms.Label();
            this.btnGenerateText = new System.Windows.Forms.Button();
            this.chkFeedbackMoreThanOnePartner = new System.Windows.Forms.CheckBox();
            this.numMoreThanOneFeedback = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.chkIsOnTime = new System.Windows.Forms.CheckBox();
            this.chkSolidFeedbackArgs = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numMoreThanOneFeedback)).BeginInit();
            this.SuspendLayout();
            // 
            // chkAnswersTheQuestions
            // 
            this.chkAnswersTheQuestions.AutoSize = true;
            this.chkAnswersTheQuestions.Location = new System.Drawing.Point(24, 103);
            this.chkAnswersTheQuestions.Name = "chkAnswersTheQuestions";
            this.chkAnswersTheQuestions.Size = new System.Drawing.Size(279, 17);
            this.chkAnswersTheQuestions.TabIndex = 0;
            this.chkAnswersTheQuestions.Text = "¿Contesta las Preguntas Requeridas por la actividad?";
            this.chkAnswersTheQuestions.UseVisualStyleBackColor = true;
            this.chkAnswersTheQuestions.CheckedChanged += new System.EventHandler(this.chkAnswersTheQuestions_CheckedChanged);
            // 
            // chkForumPostExist
            // 
            this.chkForumPostExist.AutoSize = true;
            this.chkForumPostExist.Location = new System.Drawing.Point(24, 80);
            this.chkForumPostExist.Name = "chkForumPostExist";
            this.chkForumPostExist.Size = new System.Drawing.Size(184, 17);
            this.chkForumPostExist.TabIndex = 1;
            this.chkForumPostExist.Text = "¿Existe su publicación en el foro?";
            this.chkForumPostExist.UseVisualStyleBackColor = true;
            this.chkForumPostExist.CheckedChanged += new System.EventHandler(this.chkForumPostExist_CheckedChanged);
            // 
            // chkFeedbackSinglePartner
            // 
            this.chkFeedbackSinglePartner.AutoSize = true;
            this.chkFeedbackSinglePartner.Location = new System.Drawing.Point(24, 126);
            this.chkFeedbackSinglePartner.Name = "chkFeedbackSinglePartner";
            this.chkFeedbackSinglePartner.Size = new System.Drawing.Size(178, 17);
            this.chkFeedbackSinglePartner.TabIndex = 2;
            this.chkFeedbackSinglePartner.Text = "¿Retroalimenta a 1 Compañero?";
            this.chkFeedbackSinglePartner.UseVisualStyleBackColor = true;
            this.chkFeedbackSinglePartner.CheckedChanged += new System.EventHandler(this.chkFeedbackSinglePartner_CheckedChanged);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(77, 22);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(220, 20);
            this.txtStudentName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mensaje:";
            // 
            // txtResultTextChallenge1
            // 
            this.txtResultTextChallenge1.Location = new System.Drawing.Point(24, 271);
            this.txtResultTextChallenge1.Multiline = true;
            this.txtResultTextChallenge1.Name = "txtResultTextChallenge1";
            this.txtResultTextChallenge1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultTextChallenge1.Size = new System.Drawing.Size(273, 107);
            this.txtResultTextChallenge1.TabIndex = 5;
            // 
            // lblGradeChallenge1
            // 
            this.lblGradeChallenge1.AutoSize = true;
            this.lblGradeChallenge1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeChallenge1.Location = new System.Drawing.Point(68, 230);
            this.lblGradeChallenge1.Name = "lblGradeChallenge1";
            this.lblGradeChallenge1.Size = new System.Drawing.Size(171, 25);
            this.lblGradeChallenge1.TabIndex = 4;
            this.lblGradeChallenge1.Text = "Calificación: 100";
            // 
            // btnGenerateText
            // 
            this.btnGenerateText.Location = new System.Drawing.Point(24, 204);
            this.btnGenerateText.Name = "btnGenerateText";
            this.btnGenerateText.Size = new System.Drawing.Size(273, 23);
            this.btnGenerateText.TabIndex = 6;
            this.btnGenerateText.Text = "Generar";
            this.btnGenerateText.UseVisualStyleBackColor = true;
            this.btnGenerateText.Click += new System.EventHandler(this.btnGenerateText_Click);
            // 
            // chkFeedbackMoreThanOnePartner
            // 
            this.chkFeedbackMoreThanOnePartner.AutoSize = true;
            this.chkFeedbackMoreThanOnePartner.Location = new System.Drawing.Point(24, 149);
            this.chkFeedbackMoreThanOnePartner.Name = "chkFeedbackMoreThanOnePartner";
            this.chkFeedbackMoreThanOnePartner.Size = new System.Drawing.Size(215, 17);
            this.chkFeedbackMoreThanOnePartner.TabIndex = 2;
            this.chkFeedbackMoreThanOnePartner.Text = "¿Retroalimenta a más de 1 Compañero?";
            this.chkFeedbackMoreThanOnePartner.UseVisualStyleBackColor = true;
            this.chkFeedbackMoreThanOnePartner.CheckedChanged += new System.EventHandler(this.chkFeedbackMoreThanOnePartner_CheckedChanged);
            // 
            // numMoreThanOneFeedback
            // 
            this.numMoreThanOneFeedback.Location = new System.Drawing.Point(245, 148);
            this.numMoreThanOneFeedback.Name = "numMoreThanOneFeedback";
            this.numMoreThanOneFeedback.Size = new System.Drawing.Size(52, 20);
            this.numMoreThanOneFeedback.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre:";
            // 
            // chkIsOnTime
            // 
            this.chkIsOnTime.AutoSize = true;
            this.chkIsOnTime.Location = new System.Drawing.Point(24, 57);
            this.chkIsOnTime.Name = "chkIsOnTime";
            this.chkIsOnTime.Size = new System.Drawing.Size(156, 17);
            this.chkIsOnTime.TabIndex = 1;
            this.chkIsOnTime.Text = "¿Enregó su tarea a tiempo?";
            this.chkIsOnTime.UseVisualStyleBackColor = true;
            this.chkIsOnTime.CheckedChanged += new System.EventHandler(this.chkIsOnTime_CheckedChanged);
            // 
            // chkSolidFeedbackArgs
            // 
            this.chkSolidFeedbackArgs.AutoSize = true;
            this.chkSolidFeedbackArgs.Location = new System.Drawing.Point(24, 171);
            this.chkSolidFeedbackArgs.Name = "chkSolidFeedbackArgs";
            this.chkSolidFeedbackArgs.Size = new System.Drawing.Size(296, 17);
            this.chkSolidFeedbackArgs.TabIndex = 9;
            this.chkSolidFeedbackArgs.Text = "¿Sus argumentos para su o sus compañeros son sólidos?";
            this.chkSolidFeedbackArgs.UseVisualStyleBackColor = true;
            this.chkSolidFeedbackArgs.CheckedChanged += new System.EventHandler(this.chkSolidFeedbackArgs_CheckedChanged);
            // 
            // Challenge1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 390);
            this.Controls.Add(this.chkSolidFeedbackArgs);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numMoreThanOneFeedback);
            this.Controls.Add(this.btnGenerateText);
            this.Controls.Add(this.txtResultTextChallenge1);
            this.Controls.Add(this.lblGradeChallenge1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.chkFeedbackMoreThanOnePartner);
            this.Controls.Add(this.chkFeedbackSinglePartner);
            this.Controls.Add(this.chkIsOnTime);
            this.Controls.Add(this.chkForumPostExist);
            this.Controls.Add(this.chkAnswersTheQuestions);
            this.Name = "Challenge1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reto 1: Foro Sistemas Operativos";
            this.Load += new System.EventHandler(this.Challenge1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numMoreThanOneFeedback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkAnswersTheQuestions;
        private System.Windows.Forms.CheckBox chkForumPostExist;
        private System.Windows.Forms.CheckBox chkFeedbackSinglePartner;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResultTextChallenge1;
        private System.Windows.Forms.Label lblGradeChallenge1;
        private System.Windows.Forms.Button btnGenerateText;
        private System.Windows.Forms.CheckBox chkFeedbackMoreThanOnePartner;
        private System.Windows.Forms.NumericUpDown numMoreThanOneFeedback;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkIsOnTime;
        private System.Windows.Forms.CheckBox chkSolidFeedbackArgs;
    }
}