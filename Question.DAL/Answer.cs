using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Question.DAL
{
    [Table("tblAnswers")]
    public class Answer
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(500)]
        public string Text { get; set; }

        /// <summary>
        /// Right answer or wrong
        /// </summary>
        public bool IsTrue { get; set; }

        [ForeignKey("Question")]
        public int QuestionId { get; set; }

        public virtual Question Questions { get; set; }

    }
}
