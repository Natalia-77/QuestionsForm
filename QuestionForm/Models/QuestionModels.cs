using System;
using System.Collections.Generic;
using System.Text;

namespace QuestionForm.Models
{
    /// <summary>
    /// Запитання
    /// </summary>
    public class QuestionModel
    {
        public string Text { get; set; }
        public List<QuestionAnswerModel> Answers { get; set; }
        public string Image { get; set; }
    }

    /// <summary>
    /// Варіанти відповіді
    /// </summary>
    public class QuestionAnswerModel
    {
        public string Text { get; set; }
        public bool IsTrue { get; set; }
    }

}
