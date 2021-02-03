using Question.DAL;
using Question.DAL.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QuestionForm
{
    public partial class RegistrationForm : Form
    {
        MyContext context = new MyContext();
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            context.Users
                .Add(
                new User
                {
                    Surname = tbSurname.Text,
                    Name = tbName.Text,
                    Login = tbLogin.Text,
                    Password = PassHash.HashPassword(tbPassword.Text)
                });
            context.SaveChanges();
            this.Close();
        }
    }
}
