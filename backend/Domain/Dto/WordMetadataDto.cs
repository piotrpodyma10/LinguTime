using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LinguTime.Domain.Dto
{
    public class WordMetadataDto
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int CategoryId { get; set; }
        public CategoryDto Category { get; set; }
    }
}
