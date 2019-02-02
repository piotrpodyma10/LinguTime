using System;
using System.Collections.Generic;
using System.Text;

namespace LinguTime.Domain.ViewModel
{
    public class FlashCardsContainerViewModel
    {
        public string CategoryName { get; set; }
        public int NumberOfWords { get; set; }
        public List<FlashCardsViewModel> FlashCards { get; set; }
    }
}
