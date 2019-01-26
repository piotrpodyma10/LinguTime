using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LinguTime.Domain.Dto
{
    public class WordsDto
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public WordMetadataDto WordsMetadata { get; set; }
        public int WordsMetadataId { get; set; }
        public int LanguageId { get; set; }
        public LanguageDto Language { get; set; }
    }
}
