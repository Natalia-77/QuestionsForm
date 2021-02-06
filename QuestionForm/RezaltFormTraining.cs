using Question.DAL;
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
    public partial class RezaltFormTraining : Form
    {
       // private int rightAnswer = 0;
        MyContext context = new MyContext();
        public User UserResult { get; set; }

        // DateTime finish=DateTime.Now.ToUniversalTime();

        public RezaltFormTraining(ExamForm exam)
        {

            InitializeComponent();
            UserResult = exam.LogUser;
            // var user = context.Users.SingleOrDefault(x => x.Login == LoginForm.log);
            var user = context.Users.SingleOrDefault(x => x.Id == UserResult.Id);
            //{
                //var user = context.Users.SingleOrDefault(x => x.Login == LoginForm.log);
                lblName.Text = $"{user.Surname} {user.Name}";
            
            //}
            // DateTime begin = finish.AddSeconds(-ExamForm.count);
            //decimal mark = (decimal)rightAnswer / result.Length;
            
            lblCountQuestions.Text = $"Всього пройдено запитань: {exam.listcount}";
            lblRightAnswers.Text = $"Кількість правильних відповідей: {exam.right}";
            lblWrongAnswers.Text = $"Кількість неправильних відповідей: {exam.listcount-exam.right}";
            lblMark.Text = $"Пройдено тест на: {(exam.right*100)/exam.listcount} %";
            lblStartDateTime.Text = $"Початок проходження тесту: {exam.start_sess}";
            lblEndDateTime.Text = $"Закінчення проходження тесту: {exam.finish_sess}";


            //var session = new List<Session>
            //    {
            //        new Session{UserId=user.Id,Begin=begin,End=finish,Marks=mark*100}

            //    };
            //context.Sessions.AddRange(session);
            //context.SaveChanges();

        }

        
    }
}
