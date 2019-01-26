using System;
using System.Collections.Generic;
using System.Text;

namespace LinguTime.Domain.ViewModel
{
    public class CustomWordViewModel
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public int CustomWordsMetadataId { get; set; }
        public int LanguageId { get; set; }
    }
}
