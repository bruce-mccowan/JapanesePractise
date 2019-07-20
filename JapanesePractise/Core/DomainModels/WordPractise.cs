using JapanesePractise.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JapanesePractise.Core.DomainModels
{
    public class WordPractise
    {
        public Word Word { get; set; }
        public DateTime LastPractised { get; set; }
        public PractiseDifficulty Difficulty { get; set; }

        public string GitTest { get; set; }

    }
}
