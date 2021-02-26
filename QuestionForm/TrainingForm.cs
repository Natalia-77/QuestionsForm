using Question.DAL;
using QuestionForm.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QuestionForm
{
    public partial class TrainingForm : Form
    {
        private readonly MyContext context;

        public User ResUser { get; set; }
        // Список питань
        private List<QuestionModel> _listQuestions;

        // Поточне питання
        private int indexQuestion = 0;
       
        /// <summary>
        /// Кількість питань в тесті.
        /// </summary>
        public int newlistcount
        {
            get
            {
                return _listQuestions.Count();
            }
            set
            {
                value = _listQuestions.Count();
            }
        }


        /// <summary>
        /// Лічильник правильних відповідей.
        /// </summary>
        int right_answer;


        public int rightans
        {
            get
            {
                return right_answer;
            }
            set
            {
                value = right_answer;
            }
        }

        /// <summary>
        /// Масив відповідей на питання,які дав користувач.
        /// </summary>
        private bool[] result;

        /// <summary>
        /// Властивість,містить підсумкову оцінку користувача.
        /// </summary>
        public decimal resmark { get; set; }

        /// <summary>
        /// Айді поточної сесії.
        /// </summary>
        private readonly int sess_begin;

        public DateTime finish { get; set; }
        public DateTime begin { get; set; }

        /// <summary>
        /// Властивість,повертає айді поточної сесії.
        /// </summary>
        public int idsesstrain
        {
            get
            {
                return sess_begin;
            }

            set
            {
                value = sess_begin;
            }
        }

        /// <summary>
        /// Відлік секунд таймера.
        /// </summary>
        private int _tick;

        /// <summary>
        /// Лічильник тіків.
        /// </summary>
        private int count = 0;

        public TrainingForm(MenuForm form)
        {
            context = new MyContext();
            ResUser = form.LogInstancem;
            var sess = new Session
            {
                UserId = ResUser.Id,
                Begin = DateTime.Now               

            };

            context.Sessions.Add(sess);
            context.SaveChanges();
            begin = sess.Begin;
            var infoid = context.Sessions.Max(x => x.Id);
            sess_begin = infoid;

            _listQuestions = new List<QuestionModel>();
            foreach (var item in context.Questions.ToList())
            {
                QuestionModel question = new QuestionModel
                {
                    Text = item.Text,
                    Image = item.Image,
                    Answers = new List<QuestionAnswerModel>()
                };
                foreach (var answer in context.Answers
                    .Where(x => x.QuestionId == item.Id))
                {
                    var answerModel = new QuestionAnswerModel
                    {
                        Id = answer.Id,
                        Text = answer.Text,
                        IsTrue = answer.IsTrue
                    };
                    question.Answers.Add(answerModel);
                }
                _listQuestions.Add(question);
            }

            InitializeComponent();
            result = new bool[_listQuestions.Count];
        }

        private void LoadQuestion()
        {
            pBoxImage.Image = Image.FromFile(_listQuestions[indexQuestion].Image);
            lblQuestion.Text = _listQuestions[indexQuestion].Text;
            var answers = _listQuestions[indexQuestion].Answers;
            int dy = 25;
            int startPosition = 30;
            gbAnswers.Controls.Clear();
            for (int i = 0; i < answers.Count; i++)
            {
                RadioButton gbOneItem;
                gbOneItem = new System.Windows.Forms.RadioButton();
                gbOneItem.AutoSize = true;
                gbOneItem.Location = new System.Drawing.Point(25, startPosition);
                gbOneItem.Name = $"gbItem{i}";
                gbOneItem.Tag = answers[i];
                gbOneItem.Size = new System.Drawing.Size(67, 19);
                gbOneItem.TabIndex = 1;
                gbOneItem.TabStop = true;
                gbOneItem.Text = answers[i].Text;
                gbOneItem.UseVisualStyleBackColor = true;
                gbAnswers.Controls.Add(gbOneItem);
                startPosition += dy;
            }
            lblNumberQuestion.Text = $"Питання {indexQuestion + 1}";

        }
        private void btnFinishTraining_Click(object sender, EventArgs e)
        {            
            Close();
            new RezaltTrain(this).ShowDialog();
          
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            right_answer = 0;
            var radioButtons = gbAnswers.Controls.OfType<RadioButton>();
            foreach (RadioButton radioButton in radioButtons)
            {
                if (radioButton.Checked)
                {
                    var answer = radioButton.Tag as QuestionAnswerModel;
                    result[indexQuestion] = answer.IsTrue;
                    indexQuestion++;

                    var idsess = context.Answers.Where(x => x.Id == answer.Id).ToList();
                    foreach (var item in idsess)
                    {
                        context.Results.Add(new Result { SessionId = idsesstrain, AnswerId = item.Id });
                        context.SaveChanges();
                    }

                }
            }
            foreach (var item in result)
            {
                if (item == true)
                {
                    right_answer++;
                }
            }
            //indexQuestion++;

            if (indexQuestion < _listQuestions.Count)
            {
                LoadQuestion();
            }
            else
            {
                var idmaxsess = context.Sessions.Where(x => x.Id == sess_begin).ToList();

                //Додала в таблицю Сесія,скільки часу було потрачено на тест та оцінку, записала в базу.
                foreach (var item in idmaxsess)
                {
                    item.End = DateTime.Now.AddSeconds(count);
                    item.Marks = (decimal)(right_answer*100) / result.Count();
                    context.SaveChanges();
                    finish = item.End;
                    resmark = item.Marks;
                }
               
                Close();
                timer1.Enabled = false;
                new RezaltTrain(this).ShowDialog();      
                
            }
        }

        private void TrainingForm_Load(object sender, EventArgs e)
        {
            LoadQuestion();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _tick++;           
            count++;
        }
    }
}
