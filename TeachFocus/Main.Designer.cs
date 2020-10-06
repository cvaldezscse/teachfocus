namespace TeachFocus
{
    partial class Main
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
            this.btnChallenge1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChallenge2 = new System.Windows.Forms.Button();
            this.btnChallenge3 = new System.Windows.Forms.Button();
            this.btnChallenge5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAdminEmailText = new System.Windows.Forms.Button();
            this.btnAdminNumbers = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChallenge1
            // 
            this.btnChallenge1.Location = new System.Drawing.Point(6, 19);
            this.btnChallenge1.Name = "btnChallenge1";
            this.btnChallenge1.Size = new System.Drawing.Size(359, 23);
            this.btnChallenge1.TabIndex = 0;
            this.btnChallenge1.Text = "Reto 1: Foro";
            this.btnChallenge1.UseVisualStyleBackColor = true;
            this.btnChallenge1.Click += new System.EventHandler(this.btnChallenge1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChallenge5);
            this.groupBox1.Controls.Add(this.btnChallenge3);
            this.groupBox1.Controls.Add(this.btnChallenge2);
            this.groupBox1.Controls.Add(this.btnChallenge1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 161);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // btnChallenge2
            // 
            this.btnChallenge2.Location = new System.Drawing.Point(6, 48);
            this.btnChallenge2.Name = "btnChallenge2";
            this.btnChallenge2.Size = new System.Drawing.Size(359, 23);
            this.btnChallenge2.TabIndex = 1;
            this.btnChallenge2.Text = "Reto 2: Evolucion de los Sistemas Operativos (Cuadro Comparativo)";
            this.btnChallenge2.UseVisualStyleBackColor = true;
            this.btnChallenge2.Click += new System.EventHandler(this.btnChallenge2_Click);
            // 
            // btnChallenge3
            // 
            this.btnChallenge3.Location = new System.Drawing.Point(7, 78);
            this.btnChallenge3.Name = "btnChallenge3";
            this.btnChallenge3.Size = new System.Drawing.Size(358, 23);
            this.btnChallenge3.TabIndex = 2;
            this.btnChallenge3.Text = "Reto 3: Procesos e Hilos (Diferencias y Similitudes)";
            this.btnChallenge3.UseVisualStyleBackColor = true;
            this.btnChallenge3.Click += new System.EventHandler(this.btnChallenge3_Click);
            // 
            // btnChallenge5
            // 
            this.btnChallenge5.Location = new System.Drawing.Point(7, 108);
            this.btnChallenge5.Name = "btnChallenge5";
            this.btnChallenge5.Size = new System.Drawing.Size(358, 23);
            this.btnChallenge5.TabIndex = 3;
            this.btnChallenge5.Text = "Reto 5: Procedimientos (Diagramas de flujo)";
            this.btnChallenge5.UseVisualStyleBackColor = true;
            this.btnChallenge5.Click += new System.EventHandler(this.btnChallenge5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAdminNumbers);
            this.groupBox2.Controls.Add(this.btnAdminEmailText);
            this.groupBox2.Location = new System.Drawing.Point(12, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 88);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Administrativo";
            // 
            // btnAdminEmailText
            // 
            this.btnAdminEmailText.Location = new System.Drawing.Point(7, 19);
            this.btnAdminEmailText.Name = "btnAdminEmailText";
            this.btnAdminEmailText.Size = new System.Drawing.Size(358, 23);
            this.btnAdminEmailText.TabIndex = 0;
            this.btnAdminEmailText.Text = "Generar textos para Mensajes de Correo/Plataforma";
            this.btnAdminEmailText.UseVisualStyleBackColor = true;
            this.btnAdminEmailText.Click += new System.EventHandler(this.btnAdminEmailText_Click);
            // 
            // btnAdminNumbers
            // 
            this.btnAdminNumbers.Location = new System.Drawing.Point(7, 48);
            this.btnAdminNumbers.Name = "btnAdminNumbers";
            this.btnAdminNumbers.Size = new System.Drawing.Size(358, 23);
            this.btnAdminNumbers.TabIndex = 1;
            this.btnAdminNumbers.Text = "Informe de Numeros";
            this.btnAdminNumbers.UseVisualStyleBackColor = true;
            this.btnAdminNumbers.Click += new System.EventHandler(this.btnAdminNumbers_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 309);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(411, 348);
            this.MinimumSize = new System.Drawing.Size(411, 348);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistemas Operativos v1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChallenge1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChallenge5;
        private System.Windows.Forms.Button btnChallenge3;
        private System.Windows.Forms.Button btnChallenge2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdminEmailText;
        private System.Windows.Forms.Button btnAdminNumbers;
    }
}