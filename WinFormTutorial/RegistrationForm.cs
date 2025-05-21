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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SchoolDbEntities context = new SchoolDbEntities();
            Signup model = new Signup();
            model.UserName = Usertxt.Text;
            model.Password = Passtxt.Text;
            model.Email = Emailtxt.Text;
            model.Contact = Contxt.Text;
            context.Signups.Add(model);
            context.SaveChanges();
            MessageBox.Show("Registration Successful");

        }
    }
}
