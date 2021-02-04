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
        private int rightAnswer = 0;
        MyContext context = new MyContext();
        
        DateTime finish=DateTime.Now.ToUniversalTime();
        
        public RezaltFormTraining(bool[] result)
        {
            
        InitializeComponent();
            var user = context.Users.SingleOrDefault(x => x.Login == LoginForm.log);
            {
                //var user = context.Users.SingleOrDefault(x => x.Login == LoginForm.log);
                lblName.Text = $"{user.Surname} {user.Name}";
                
            }
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i])
                {
                    rightAnswer++;
                }
                
            }
            DateTime begin = finish.AddSeconds(-ExamForm.count);
            decimal mark = (decimal)rightAnswer / result.Length;
            
            lblCountQuestions.Text = $"Всього пройдено запитань: {result.Length}";
            lblRightAnswers.Text = $"Кількість правильних відповідей: {rightAnswer}";
            lblWrongAnswers.Text = $"Кількість неправильних відповідей: {result.Length- rightAnswer}";
            lblMark.Text = $"Пройдено тест на: {mark*100} %";
            lblStartDateTime.Text = $"Початок проходження тесту: {begin}";
            lblEndDateTime.Text = $"Закінчення проходження тесту: {finish}";


            var session = new List<Session>
                {
                    new Session{UserId=user.Id,Begin=begin,End=finish,Marks=mark*100}

                };
            context.Sessions.AddRange(session);
            context.SaveChanges();

        }

        
    }
}
