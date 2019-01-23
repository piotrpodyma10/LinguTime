using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LinguTime.Domain.Dto
{
    public class CustomWordsDto
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int CustomWordsMetadataId { get; set; }
        public CustomWordMetadataDto CustomWordsMetadata { get; set; }
        public int LanguageId { get; set; }
        public LanguageDto Language { get; set; }
    }
}
