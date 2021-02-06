using Question.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionForm
{
    public partial class MenuForm : Form
    {
        private readonly MyContext _context;

        /// <summary>
        /// Властивість,де містяться дані про конкретного користувача.
        /// </summary>
        public User LogInstancem { get; set; }
     
        public MenuForm()
        {
           _context = new MyContext();
            AddData.Add(_context);
            LoginForm log = new LoginForm();
            if (log.ShowDialog() == DialogResult.OK)
            {
                LogInstancem = log.UserInstance;                
                InitializeComponent();
            }
           
        }

        private void btnTraining_Click(object sender, EventArgs e)
        {
            new TrainingForm(this).ShowDialog();
        }

        private void btnExam_Click(object sender, EventArgs e)
        {
            new ExamForm(this).ShowDialog();
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
