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
    public partial class TrainingForm : Form
    {
        // Список питань
        private List<QuestionModel> _listQuestions;
        // Поточне питання
        private int indexQuestion = 0;
        private bool[] result;

        public TrainingForm(MyContext context)
        {
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
            new RezaltFormTraining(result).ShowDialog();
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            var radioButtons = gbAnswers.Controls.OfType<RadioButton>();
            foreach (RadioButton radioButton in radioButtons)
            {
                if (radioButton.Checked)
                {
                    var answer = radioButton.Tag as QuestionAnswerModel;
                    result[indexQuestion] = answer.IsTrue;
                }
            }
            indexQuestion++;

            if (indexQuestion < _listQuestions.Count)
            {
                LoadQuestion();
            }
            else
            {
                this.Close();

                new RezaltFormTraining(result).ShowDialog();
            }
        }

        private void TrainingForm_Load(object sender, EventArgs e)
        {
            LoadQuestion();
        }
    }
}
