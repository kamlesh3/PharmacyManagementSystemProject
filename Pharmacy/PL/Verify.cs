using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Pharmacy.BL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.ComponentModel.DataAnnotations;

namespace Pharmacy.PL
{
    public partial class Verify : MetroFramework.Forms.MetroForm
    {
        FRM_MAIN frm = new FRM_MAIN();
        FRM_Cashier Cashier = new FRM_Cashier();
        ResetPassword resetpassword = new ResetPassword();  
        string randomCode;
        public static string resetEmail {  get; set; }
        bool flag=false;
        bool flag1=false;
        public Verify()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textEmail.Text == string.Empty)
            {
                textEmail.Focus();
                return;
            }
            if (textPassword.Text == string.Empty)
            {
                textPassword.Focus();
                return;
            }
            DataTable dt = Login.login(textEmail.Text, textPassword.Text);
            if (dt.Rows.Count > 0)
            {
                
               
                Program.UserFullName = dt.Rows[0]["U_Full_Name"].ToString();
                Program.Permision = dt.Rows[0]["Per_ID"].ToString();
                
                BL.Logs.Logs_Add(Program.UserFullName, DateTime.Now.ToString(), "Login");

                this.Hide();
                if(flag == true)
                {
                    if (dt.Rows[0]["Per_ID"].ToString() == "3")
                    {
                        Cashier.Show();
                    }
                    else
                    {
                        frm.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Code");
                }
               
            }
            else
            {
                wrong.Text = "invalid password or name";
                textEmail.Clear();
                textPassword.Clear();
                textOtp.Clear();
                textEmail.Focus();
            }



        }

        private void emailSend(string toemail)
        {
            var fromMail = "pharmacysystemautomail@gmail.com";
            var fromPwd = "tfoulgaxgkpzrnbw";

            Random rand = new Random();
            randomCode = (rand.Next(999999)).ToString();

            MailMessage message = new MailMessage();
            message.From = new MailAddress(fromMail);
            message.Subject = "User Verification Mail";
            message.To.Add(new MailAddress(toemail));
            message.Body = "Your OTP: " + randomCode;
            message.IsBodyHtml = true;
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential(fromMail, fromPwd),
                EnableSsl = true,
            };

            try
            {
                smtpClient.Send(message);
                MessageBox.Show("Email sent successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void verifyOtp()
        {
            
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textPassword.Text))
            {
                e.Cancel = true;
                textEmail.Focus();
                errorProvider1.SetError(textPassword, "Please enter your name!");
                errorProvider1.SetIconPadding(textPassword, -20);
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textPassword, null);
            }
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textEmail.Text))
            {
                e.Cancel = true;
                textEmail.Focus();
                errorProvider1.SetError(textEmail, "Please enter your name!");
                errorProvider1.SetIconPadding(textEmail, -20);
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textEmail, null);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string otp=textOtp.Text.Trim().ToString();
            if (randomCode==otp)
            {
                flag = true;
                MessageBox.Show("OTP verified successfully");
            }
            else
            {
                MessageBox.Show("OPT not verified " + randomCode + " "+ otp +" " + (randomCode==otp));
            }

            if(flag==true && flag1==true)
            {
                this.Hide();
                resetpassword.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Email="";
            string pass="";
            if (textEmail.Text == string.Empty)
            {
                textEmail.Focus();
                return;
            }
            if (textPassword.Text == string.Empty)
            {
                textPassword.Focus();
                return;
            }
            try
            {
                DataTable dt = Login.login(textEmail.Text, textPassword.Text);
                Email = dt.Rows[0]["U_Name"].ToString();
                pass = dt.Rows[0]["U_Pass"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Email or Password is not correct");
            }


            if (Email==textEmail.Text.ToString())
            {
                emailSend(textEmail.Text.ToString());
            }
        }
        private void Verify_Load(object sender, EventArgs e)
        {

        }

       
        public void ResetPassword(string password)
        {
            Login.updatePass(resetEmail, password);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (textEmail.Text == string.Empty)
            {
                textEmail.Focus();
                return;
            }
            
            try
            {
                DataTable dt = Login.emailCheck(textEmail.Text);
                resetEmail = dt.Rows[0]["U_Name"].ToString();
                emailSend(textEmail.Text.ToString());
                MessageBox.Show("Please enter OTP to verify you as a authentic User");
                flag1 = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(textEmail.Text.ToString() + " is not registered email. "+"Plaese enter correct email to reset password");
            }
        }
        private void otpVerify()
        {
            string otp = textOtp.Text.Trim().ToString();
            if (randomCode == otp)
            {
                flag = true;
                MessageBox.Show("OTP verified successfully");
            }
            else
            {
                MessageBox.Show("OPT not verified " + randomCode + " " + otp + " " + (randomCode == otp));
            }
        }
    }
}
