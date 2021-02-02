using Question.DAL;
using Question.DAL.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuestionForm
{
    public partial class LoginForm : Form
    {
        private readonly MyContext context;
        public User UserInstance { get; set; }

        public LoginForm()
        {
            context = new MyContext();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = tblogin.Text;
            string pass = tbpassword.Text;

            var user = context.Users.FirstOrDefault(x => x.Login == login);

            if (user != null)
            {
                var passwordHash = user.Password;
                if (PassHash.Verify(pass, passwordHash))
                {
                    UserInstance = user;
                    DialogResult = DialogResult.OK;
                    MessageBox.Show($"Hello,{user.Name}");
                }
            }
            else
            {                
                MessageBox.Show("Try again");
            }
        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            new RegistrationForm().ShowDialog();
        }
    }
}
