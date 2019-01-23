using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LinguTime.Domain.Dto
{
    public class ExamplesDto
    {
        [Key]
        public int Id { get; set; }
        public int WordId { get; set; }
        public WordsDto Word { get; set; }
        public string Sentence { get; set; }
    }
}
