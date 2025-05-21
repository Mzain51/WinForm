using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormTutorial
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(UserTxt.Text) || string.IsNullOrEmpty(PassTxt.Text))
                {
                    MessageBox.Show("Please fill all fields");
                }
                else
                {
                    SchoolDbEntities context = new SchoolDbEntities();
                    {
                        var User = context.Signups.Where(x => x.UserName == UserTxt.Text).FirstOrDefault();
                        if (User != null)
                        {
                            if (User.Password == PassTxt.Text)
                            {
                                MessageBox.Show("Login Successful");
                            }
                            else
                            {
                                MessageBox.Show("Invalid Password");
                            }
                        }
                        else
                        {
                            MessageBox.Show("User not found");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}