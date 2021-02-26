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
    public partial class ExamForm : Form
    {
        private readonly MyContext context;
       
        /// <summary>
        /// Користувач,який ввійшов в систему.
        /// </summary>

        public User LogUser { get; set; }

        private readonly int sesmax;
        /// <summary>
        /// Id останньої створеної Сесії користувачем.
        /// </summary>
        public int idsession
        {
            get
            {
                return sesmax;
            }

            set
            {
                value = sesmax;
            }
        }


        // Список питань
        private List<QuestionModel> _listQuestions;

        // Поточне питання
        private int indexQuestion = 0;

        /// <summary>
        /// Кількість питань тесту.
        /// </summary>
        public int listcount
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
        /// Кількість вірних відповідей.Для передачі в форму Результат.
        /// </summary>
        public int right {
            get
            {
                return rightAnswer;
            }
            set
            {
                value = right;
            }
                }

        /// <summary>
        /// Оцінка тесту.
        /// </summary>
        public decimal resmark { get; set; }

        private bool[] result;

        private int rightAnswer ;

        int min = 10;//задаем время старта на таймере

        int sec = 0;

        int conter = 0;//счетчик тиков для досчета времени затраченого на сесию

        public static int count { get; set; }//поле для перекидывания результата 
        //подсчетов тиков в результующую форму.

        /// <summary>
        /// Властивість,що містить дату початку тесту.
        /// </summary>
        public  DateTime start_sess { get; set; }

        /// <summary>
        /// Властивість,що містить дату кінця тесту.
        /// </summary>        
        public DateTime finish_sess { get; set; }

        public ExamForm(MenuForm form)
        {
            context = new MyContext();
            LogUser = form.LogInstancem;
            var sess = new Session
            {
                UserId = LogUser.Id,
                Begin = DateTime.Now
               
                
            };
            
            context.Sessions.Add(sess);
            context.SaveChanges();
            start_sess = sess.Begin;
            var info = context.Sessions.Max(x => x.Id);
            sesmax = info;

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
                        Id=answer.Id,
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
              

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                conter++;
                labelTT.Visible = true;
                
                if (sec > 0)
                {

                    sec--;
                    conter++;
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
                        conter++;
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
                
                //count = conter;
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
            rightAnswer = 0;
            var radioButtons = gbAnswers.Controls.OfType<RadioButton>();
            foreach (RadioButton radioButton in radioButtons)
            {
                if(radioButton.Checked)
                {
                    var answer = radioButton.Tag as QuestionAnswerModel;
                    result[indexQuestion] = answer.IsTrue;
                    indexQuestion++;
                    var infoid = context.Answers.Where(x => x.Id == answer.Id).ToList();
                    foreach (var item in infoid)
                    {
                        context.Results.Add(new Result { SessionId = idsession, AnswerId = item.Id });
                        context.SaveChanges();
                        if (answer.IsTrue)
                        {
                            if (indexQuestion == 1)
                                btnQstNumber1.BackColor = Color.Green;
                            if (indexQuestion == 2)
                                btnQstNumber2.BackColor = Color.Green;
                            if (indexQuestion == 3)
                                btnQstNumber3.BackColor = Color.Green;
                            if (indexQuestion == 4)
                                btnQstNumber4.BackColor = Color.Green;
                            if (indexQuestion == 5)
                                btnQstNumber5.BackColor = Color.Green;
                            if (indexQuestion == 6)
                                btnQstNumber6.BackColor = Color.Green;
                            if (indexQuestion == 7)
                                btnQstNumber7.BackColor = Color.Green;
                            if (indexQuestion == 8)
                                btnQstNumber8.BackColor = Color.Green;
                            if (indexQuestion == 9)
                                btnQstNumber9.BackColor = Color.Green;
                            if (indexQuestion == 10)
                                btnQstNumber10.BackColor = Color.Green;                      

                        }
                        else
                        {
                            if(indexQuestion==1)
                                btnQstNumber1.BackColor = Color.Red;
                            if (indexQuestion == 2)
                                btnQstNumber2.BackColor = Color.Red;
                            if (indexQuestion == 3)
                                btnQstNumber3.BackColor = Color.Red;
                            if (indexQuestion == 4)
                                btnQstNumber4.BackColor = Color.Red;
                            if (indexQuestion == 5)
                                btnQstNumber5.BackColor = Color.Red;
                            if (indexQuestion == 6)
                                btnQstNumber6.BackColor = Color.Red;
                            if (indexQuestion == 7)
                                btnQstNumber7.BackColor = Color.Red;
                            if (indexQuestion == 8)
                                btnQstNumber8.BackColor = Color.Red;
                            if (indexQuestion == 9)
                                btnQstNumber9.BackColor = Color.Red;
                            if (indexQuestion == 10)
                                btnQstNumber10.BackColor = Color.Red;
                        }
                    }                

                }             
                            }
            foreach (var item in result)
            {
                if(item==true)
                {
                    rightAnswer++;
                    
                }
            }         
          
            //indexQuestion++;

            if(indexQuestion<_listQuestions.Count)
            {
                LoadQuestion();
            }
            else
            {
                var total = context.Sessions.Where(x => x.Id == sesmax).ToList();

                //Додала в таблицю Сесія,скільки часу було потрачено на тест та оцінку, записала в базу.
                foreach (var item in total)
                {
                    item.End = DateTime.Now.AddSeconds(-count);
                    item.Marks = (decimal)(rightAnswer*100) / result.Count();                      
                    context.SaveChanges();
                    finish_sess = item.End;
                    resmark=item.Marks;
                }
                count = conter;
                Close();
                timer1.Enabled = false;
                new RezaltFormTraining(this).ShowDialog();
            }

        }
    }
}
