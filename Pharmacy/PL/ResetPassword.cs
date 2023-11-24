using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Pharmacy.PL
{
    public partial class ResetPassword : MetroFramework.Forms.MetroForm
    {
       Verify frm;
        public ResetPassword()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var newPassword = textNewPassword.Text;
            var confirmPassword = textConfirmPassword.Text;

            // Check if the new password and confirm password are empty or not the same
            if (string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmPassword) || newPassword != confirmPassword)
            {
                MessageBox.Show("Please enter a valid new password and confirm it.");
                return;
            }

            try
            {
                // Reset the user's password using the provided new password
                frm=new Verify();
                frm.ResetPassword(newPassword);
                MessageBox.Show("Your password has been reset successfully.");
                this.Hide();
                frm.Show();

                // Close the form and redirect the user to the login page
                this.Hide();
                //frm.Show();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error resetting password: " + ex.Message);
            }
        }
    }
}
