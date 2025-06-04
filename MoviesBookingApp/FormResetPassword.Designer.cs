namespace MoviesBookingApp
{
    partial class FormResetPassword
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
            this.Email1 = new System.Windows.Forms.TextBox();
            this.NewPass = new System.Windows.Forms.TextBox();
            this.ConfirmPass = new System.Windows.Forms.TextBox();
            this.Resetbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Email1
            // 
            this.Email1.Location = new System.Drawing.Point(502, 105);
            this.Email1.Name = "Email1";
            this.Email1.Size = new System.Drawing.Size(317, 26);
            this.Email1.TabIndex = 0;
            // 
            // NewPass
            // 
            this.NewPass.Location = new System.Drawing.Point(510, 172);
            this.NewPass.Name = "NewPass";
            this.NewPass.Size = new System.Drawing.Size(308, 26);
            this.NewPass.TabIndex = 1;
            // 
            // ConfirmPass
            // 
            this.ConfirmPass.Location = new System.Drawing.Point(574, 238);
            this.ConfirmPass.Name = "ConfirmPass";
            this.ConfirmPass.Size = new System.Drawing.Size(308, 26);
            this.ConfirmPass.TabIndex = 2;
            // 
            // Resetbtn
            // 
            this.Resetbtn.Location = new System.Drawing.Point(539, 311);
            this.Resetbtn.Name = "Resetbtn";
            this.Resetbtn.Size = new System.Drawing.Size(224, 42);
            this.Resetbtn.TabIndex = 3;
            this.Resetbtn.Text = "Reset Password";
            this.Resetbtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(385, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirm New Password";
            // 
            // FormResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 968);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Resetbtn);
            this.Controls.Add(this.ConfirmPass);
            this.Controls.Add(this.NewPass);
            this.Controls.Add(this.Email1);
            this.Name = "FormResetPassword";
            this.Text = "FormResetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Email1;
        private System.Windows.Forms.TextBox NewPass;
        private System.Windows.Forms.TextBox ConfirmPass;
        private System.Windows.Forms.Button Resetbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}