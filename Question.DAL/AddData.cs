using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Question.DAL
{
   public class AddData
    {
        //testing
        public static void Add(MyContext context)
        {
            AddQuestion(context);            
        }
        private static void AddQuestion(MyContext context)
        {
            if (context.Questions.Count() == 0)
            {
                var question = new Question
                {
                    Text = "З якого боку дозволено виконати" +
                           "випередження на проїзній частині?",
                    Image = @"Images\0.jpg"
                };

                context.Questions.Add(question);
                context.SaveChanges();
                var answers = new List<Answer>
                {
                    new Answer {Text="тільки з лівого боку",IsTrue=false,QuestionId=question.Id},
                    new Answer {Text="тільки з правого боку",IsTrue=false,QuestionId=question.Id},
                    new Answer {Text="з будь-якого боку по суміжній смузі",IsTrue=true,QuestionId=question.Id}
                    

                };
                context.Answers.AddRange(answers);
                context.SaveChanges();

                question = new Question
                {
                    Text = "Які фактори можуть призвести до засліплення водія?",
                    Image = @"Images\0.jpg"
                };

                context.Questions.Add(question);
                context.SaveChanges();
                answers = new List<Answer>
                {
                    new Answer {Text="мокрий сніг",IsTrue=false,QuestionId=question.Id},
                    new Answer {Text="сильна злива",IsTrue=false,QuestionId=question.Id},
                    new Answer {Text="інтенсивний снігопад",IsTrue=false,QuestionId=question.Id},
                    new Answer {Text="світло",IsTrue=true,QuestionId=question.Id}

                };
                context.Answers.AddRange(answers);
                context.SaveChanges();
                question = new Question
                {
                    Text = "Для чого призначений тротуар?",
                    Image = @"Images\0.jpg"
                };

                context.Questions.Add(question);
                context.SaveChanges();
                answers = new List<Answer>
                {
                    new Answer {Text="для велосипедистів з 5-річного віку",IsTrue=false,QuestionId=question.Id},
                    new Answer {Text="для руху пішоходів",IsTrue=true,QuestionId=question.Id},
                    new Answer {Text="усі перелічені варіанти",IsTrue=false,QuestionId=question.Id}
                    

                };
                context.Answers.AddRange(answers);
                context.SaveChanges();
                question = new Question
                {
                    Text = "Учасник дорожнього руху-це:",
                    Image = @"Images\0.jpg"
                };

                context.Questions.Add(question);
                context.SaveChanges();
                answers = new List<Answer>
                {
                    new Answer {Text="регулювальник",IsTrue=false,QuestionId=question.Id},
                    new Answer {Text="пішоходи,водії,пасажири",IsTrue=true,QuestionId=question.Id},
                    new Answer {Text="усі перелічені вище",IsTrue=false,QuestionId=question.Id}
                    
                };
                context.Answers.AddRange(answers);
                context.SaveChanges();
                question = new Question
                {
                    Text = "Скільки перехресть зображено на малюнку?",
                    Image = @"Images\5.jpg"
                };

                context.Questions.Add(question);
                context.SaveChanges();
                answers = new List<Answer>
                {
                    new Answer {Text="одне",IsTrue=true,QuestionId=question.Id},
                    new Answer {Text="два",IsTrue=false,QuestionId=question.Id},
                    new Answer {Text="чотири",IsTrue=false,QuestionId=question.Id}

                };
                context.Answers.AddRange(answers);
                context.SaveChanges();
                question = new Question
                {
                    Text = "Скільки проїзних частин має дана дорога?",
                    Image = @"Images\6.jpg"
                };

                context.Questions.Add(question);
                context.SaveChanges();
                answers = new List<Answer>
                {
                    new Answer {Text="одну",IsTrue=false,QuestionId=question.Id},
                    new Answer {Text="дві",IsTrue=true,QuestionId=question.Id},
                    new Answer {Text="чотири",IsTrue=false,QuestionId=question.Id}

                };
                context.Answers.AddRange(answers);
                context.SaveChanges();
                question = new Question
                {
                    Text = "Чи є тротуари і узбіччя частиною дороги?",
                    Image = @"Images\0.jpg"
                };

                context.Questions.Add(question);
                context.SaveChanges();
                answers = new List<Answer>
                {
                    new Answer {Text="так",IsTrue=false,QuestionId=question.Id},
                    new Answer {Text="ні",IsTrue=true,QuestionId=question.Id},
                    new Answer {Text="тільки узбіччя",IsTrue=false,QuestionId=question.Id}

                };
                context.Answers.AddRange(answers);
                context.SaveChanges();
                question = new Question
                {
                    Text = "Ви водій синього автомобіля"+
                           "і виконаєте розворот",
                    Image = @"Images\8.jpg"
                };

                context.Questions.Add(question);
                context.SaveChanges();
                answers = new List<Answer>
                {
                    new Answer {Text="перед залізничним переїздом",IsTrue=false,QuestionId=question.Id},
                    new Answer {Text="після залізничного переїзду",IsTrue=true,QuestionId=question.Id},
                    new Answer {Text="на залізничному переїзді",IsTrue=false,QuestionId=question.Id}

                };
                context.Answers.AddRange(answers);
                context.SaveChanges();
                question = new Question
                {
                    Text = "Для регулювання руху яких транспортних" +
                           "засобів застосовується даний світлофор?",
                    Image = @"Images\9.jpg"
                };

                context.Questions.Add(question);
                context.SaveChanges();
                answers = new List<Answer>
                {
                    new Answer {Text="маршрутних транспортних засобів",IsTrue=false,QuestionId=question.Id},
                    new Answer {Text="трамваїв",IsTrue=true,QuestionId=question.Id},
                    new Answer {Text="тролейбусів",IsTrue=false,QuestionId=question.Id}

                };
                context.Answers.AddRange(answers);
                context.SaveChanges();
                question = new Question
                {
                    Text = "Кому заборонено рух у даній ситуації?",
                    Image = @"Images\10.jpg"

                };

                context.Questions.Add(question);
                context.SaveChanges();
                answers = new List<Answer>
                {
                    new Answer {Text="велосипедисту",IsTrue=false,QuestionId=question.Id},
                    new Answer {Text="водію мопеда і велосипедисту",IsTrue=true,QuestionId=question.Id},
                    new Answer {Text="нікому",IsTrue=false,QuestionId=question.Id}

                };
                context.Answers.AddRange(answers);
                context.SaveChanges();
                question = new Question
                {
                    Text = "Зображений дорожній знак інформує про"+
                           "місце розташування",
                    Image = @"Images\11.jpg"
                };

                context.Questions.Add(question);
                context.SaveChanges();
                answers = new List<Answer>
                {
                    new Answer {Text="телефону громадського харчування",IsTrue=false,QuestionId=question.Id},
                    new Answer {Text="телефону для виклику аварійних служб",IsTrue=true,QuestionId=question.Id},
                    new Answer {Text="відділення зв'язку",IsTrue=false,QuestionId=question.Id}

                };
                context.Answers.AddRange(answers);
                context.SaveChanges();
                question = new Question
                {
                    Text = "Зображений дорожній знак інформує" +
                           "про місце розташування:",
                    Image = @"Images\12.jpg"
                };

                context.Questions.Add(question);
                context.SaveChanges();
                answers = new List<Answer>
                {
                    new Answer {Text="газозаправної станції",IsTrue=true,QuestionId=question.Id},
                    new Answer {Text="автозаправної станції",IsTrue=false,QuestionId=question.Id},
                    new Answer {Text="гральних автоматів",IsTrue=false,QuestionId=question.Id}

                };
                context.Answers.AddRange(answers);
                context.SaveChanges();
                question = new Question
                {
                    Text = "На які транспортні засоби "+
                           "не поширюється дія знаку?",
                    Image = @"Images\13.jpg"
                };

                context.Questions.Add(question);
                context.SaveChanges();
                answers = new List<Answer>
                {
                    new Answer {Text="мопеди",IsTrue=false,QuestionId=question.Id},
                    new Answer {Text="велосипеди",IsTrue=true,QuestionId=question.Id},
                    new Answer {Text="мотоцикли",IsTrue=false,QuestionId=question.Id}

                };
                context.Answers.AddRange(answers);
                context.SaveChanges();
                question = new Question
                {
                    Text = "Зображений дорожній знак забороняє рух: ",
                    Image = @"Images\14.jpg"
                };

                context.Questions.Add(question);
                context.SaveChanges();
                answers = new List<Answer>
                {
                    new Answer {Text="тракторів",IsTrue=false,QuestionId=question.Id},
                    new Answer {Text="самохідних машин і механізмів",IsTrue=false,QuestionId=question.Id},
                    new Answer {Text="всього переліченого вище",IsTrue=true,QuestionId=question.Id}

                };
                context.Answers.AddRange(answers);
                context.SaveChanges();
                question = new Question
                {
                    Text = "Дія зображеного дорожнього знака поширюється на:",
                    Image = @"Images\15.jpg"
                };

                context.Questions.Add(question);
                context.SaveChanges();
                answers = new List<Answer>
                {
                    new Answer {Text="мотоцикли і мопеди",IsTrue=false,QuestionId=question.Id},
                    new Answer {Text="мопеди",IsTrue=false,QuestionId=question.Id},
                    new Answer {Text="мопеди і велосипеди з підвісними двигунами",IsTrue=true,QuestionId=question.Id}

                };
                context.Answers.AddRange(answers);
                context.SaveChanges();
                question = new Question
                {
                    Text = "Зображений дорожній знак забороняє рух:",
                    Image = @"Images\16.jpg"
                };

                context.Questions.Add(question);
                context.SaveChanges();
                answers = new List<Answer>
                {
                    new Answer {Text="велосипедів і мопедів",IsTrue=false,QuestionId=question.Id},
                    new Answer {Text="велосипедів",IsTrue=true,QuestionId=question.Id},
                    new Answer {Text="мотоциклів",IsTrue=false,QuestionId=question.Id}

                };
                context.Answers.AddRange(answers);
                context.SaveChanges();
            }

        }




    }
}
