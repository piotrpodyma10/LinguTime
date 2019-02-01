using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinguTime.Domain.ViewModel
{
    public class FlashCardsViewModel
    {
        public string WordInMainLanguage { get; set; }
        public List<FlashCardsWordsViewModel> Words { get; set; }
    }
}