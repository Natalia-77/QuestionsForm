using Question.DAL;
using QuestionForm.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuestionForm
{
    public partial class ProfileForm : Form
    {
        private readonly MyContext _context;
        public User UserLog { get; set; }       
        public ProfileForm(MenuForm menu)
        {
            InitializeComponent();
            _context = new MyContext();
            UserLog = menu.LogInstancem;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            lblSurname.Text = UserLog.Surname;
            lblName.Text = UserLog.Name;
            var query = _context.Sessions.AsQueryable();
            var res = query.Where(u=>u.UserId==UserLog.Id).Select(x => new ProfileModel
            {               
                Begin = x.Begin,
                End=x.End,
                Len= x.End-x.Begin,               
                Marks =x.Marks             

                
            });
           
            foreach (var item in res)
            {
                
                object[] row =
                     {                      
                       item.Begin,
                       item.End,                    
                       item.Len.ToString(@"hh\:mm\:ss"),
                       item.Marks
                    };

                dataGridView1.Rows.Add(row);
            }


        }
    }
}
