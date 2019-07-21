using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JapanesePractise.Core.DomainModels
{
    public class WordImportResult
    {
        public int NumRecords { get; set; }
        public int NumAttempted { get; set; }
        public int NumFaiures { get; set; }
        public int NumSuccesses { get; set; }
    }
}
