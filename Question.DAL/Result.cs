﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Question.DAL
{
    [Table("tblResult")]
    public class Result
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Session")]
        public int SessionId { get; set; }

        [ForeignKey("Answer")]
        public int AnswerId { get; set; }

        public virtual Session Session { get; set; }

        public virtual Answer Answer { get; set; }
    }
}
