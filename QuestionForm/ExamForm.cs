using Question.DAL;
using QuestionForm.Models;
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
    public partial class ExamForm : Form
    {
        // Список питань
        private List<QuestionModel> _listQuestions;
        // Поточне питання
        private int indexQuestion = 0;
        private bool[] result;

        public ExamForm(MyContext context)
        {
            Random rnd = new Random();
            
            // Створюємо список для запитань на іспит
            _listQuestions = new List<QuestionModel>();

            // Створюємо тимчасовий список, в який завантажимо всі запитання з БД
            List<QuestionModel> newList = new List<QuestionModel>();

            foreach (var item in context.Questions.ToList())
            {
                // запитання
                QuestionModel question = new QuestionModel
                {
                    Text = item.Text,
                    Image = item.Image,
                    Answers = new List<QuestionAnswerModel>()
                };
                foreach (var answer in context.Answers
                    .Where(x=>x.QuestionId==item.Id))
                {
                    // відповіді
                    var answerModel = new QuestionAnswerModel
                    {
                        Text = answer.Text,
                        IsTrue = answer.IsTrue
                    };
                    question.Answers.Add(answerModel);
                }
                // Заповнюємо тимчасовий список всіма запитаннями і відповідями
                newList.Add(question);
                
                // Випадковим чином вибираємо тільки 10 запитань для іспиту
                _listQuestions = newList.OrderBy(x => rnd.Next()).Take(10).ToList();
            }
           
            InitializeComponent();

            // Заповнюємо масив правильних відповідей
            result = new bool[_listQuestions.Count];
        }
        
        int min = 10;//задаем время старта на таймере
        int sec = 0;
        int conter = 0;//счетчик тиков для досчета времени затраченого на сесию
        public static int count { get; set; }//поле для перекидывания результата подсчетов тиков в результующую форму
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                conter++;
                labelTT.Visible = true;

                if (sec > 0)
                {

                    sec--;

                    if (sec < 10)
                        labelSec.Text = "0" + sec.ToString();
                    else
                        labelSec.Text = sec.ToString();

                }
                else
                {
                    if (min > 0)
                    {
                        min--;
                        if (min < 10)
                            labelMin.Text = "0" + min.ToString();
                        else
                            labelMin.Text = min.ToString();
                        sec = 59;
                        labelSec.Text = "59";
                    }
                    else
                    {
                        min = 0;
                        labelMin.Text = "00";

                    }

                }
                count = conter;
            }

            if (min == 0 && sec == 0)
            {
                timer1.Enabled = false;
                if (MessageBox.Show("Відведений час вичерпано.\n Спробуйте наступного разу.") == DialogResult.OK)
                    Application.Exit();
            }
        
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
            lblNumberQuestion.Text = $"Питання {indexQuestion + 1} з {_listQuestions.Count}";

        }

        private void ExamForm_Load(object sender, EventArgs e)
        {
            LoadQuestion();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var radioButtons = gbAnswers.Controls.OfType<RadioButton>();
            foreach (RadioButton radioButton in radioButtons)
            {
                if(radioButton.Checked)
                {
                    var answer = radioButton.Tag as QuestionAnswerModel;
                    result[indexQuestion] = answer.IsTrue;
                }
            }
            indexQuestion++;

            if(indexQuestion<_listQuestions.Count)
            {
                LoadQuestion();
            }
            else
            {
                this.Close();
                timer1.Enabled = false;
               
                    new RezaltFormTraining( result).ShowDialog();
            }

        }
    }
}
