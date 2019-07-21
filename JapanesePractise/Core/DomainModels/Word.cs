using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace JapanesePractise.Core.DomainModels
{
    public class Word
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdWord { get; set; }
        public string English { get; set; }
        public string Romanji { get; set; }
        public string HiraganaKatakana { get; set; }
        public string Kanji { get; set; }
    }

    public class Noun : Word
    {
        public bool CanBeTopic { get; set; }
        public bool CanBeSubject { get; set; }
        public bool CanBeLocation { get; set; }
    }

    public class Verb : Word
    {
        public string PoliteFormAffirmative { get; set; }
        public string PoliteFormNegative { get; set; }
        public string PoliteFormQuestionDo { get; set; }
        public string PoliteFormQuestionWill { get; set; }
        public string CasualFormAffirmative { get; set; }
        public string CasualFormNegative { get; set; }
    }

    public class Adverb : Word
    {
        
    }

    public class Adjective : Word
    {
        public string Affirmative { get; set; }
        public string Negative { get; set; }
    }
}
