using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Question.DAL
{
    [Table("tblQuestions")]
    public class Question
    {              
            [Key]
            public int Id { get; set; }
        /// <summary>
        /// Text of question
        /// </summary>

            [Required, StringLength(1000)]
            public string Text { get; set; }

        /// <summary>
        /// Image for question
        /// </summary>
            [StringLength(255)]
            public string Image { get; set; }
        /// <summary>
        /// Collection of answers
        /// </summary>
        public virtual ICollection<Answer> Answers { get; set; }

        

    }
}
