using JapanesePractise.Core.DomainModels;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JapanesePractise.Core.DomainManagers.Interfaces
{
    public interface IWordManager
    {
        Task<WordImportResult> ImportWordListJsonFile(IFormFile importFile);
        Task<WordImportResult> ImportWordList(IEnumerable<Word> wordList);
    }
}
