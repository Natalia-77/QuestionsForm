using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionForm.Models
{
    public class Questiontest
    {
        public string Text { get; set; }
        public List<QuestionAnswerModel> Answers { get; set; }
    }

    public class QuestionAnswerModel
    {
        public string Text { get; set; }
        public bool IsTrue { get; set; }
    }
}
