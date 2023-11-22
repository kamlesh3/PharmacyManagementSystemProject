using System;

namespace Pharmacy.PL
{
    partial class Verify
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
            this.textEmail = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.otp = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textOtp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(154, 40);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(271, 22);
            this.textEmail.TabIndex = 0;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(67, 40);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(41, 16);
            this.email.TabIndex = 1;
            this.email.Text = "Email";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(67, 92);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(67, 16);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(154, 92);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(271, 22);
            this.textPassword.TabIndex = 3;
            // 
            // otp
            // 
            this.otp.AutoSize = true;
            this.otp.Location = new System.Drawing.Point(70, 140);
            this.otp.Name = "otp";
            this.otp.Size = new System.Drawing.Size(35, 16);
            this.otp.TabIndex = 5;
            this.otp.Text = "OTP";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(238, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(594, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Verify OTP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(479, 140);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Send OTP";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textOtp
            // 
            this.textOtp.Location = new System.Drawing.Point(154, 141);
            this.textOtp.Name = "textOtp";
            this.textOtp.Size = new System.Drawing.Size(271, 22);
            this.textOtp.TabIndex = 9;
            // 
            // Verify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textOtp);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.otp);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.textEmail);
            this.Name = "Verify";
            this.Load += new System.EventHandler(this.Verify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        

        #endregion

        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label otp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label wrong;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textOtp;
    }
}