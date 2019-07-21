using JapanesePractise.Core.DomainManagers.Interfaces;
using JapanesePractise.Core.DomainModels;
using JapanesePractise.Extensions;
using JapanesePractise.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JapanesePractise.Core.DomainManagers.Implementation
{
    public class WordManager : IWordManager
    {
        private readonly JapanesePractiseContext _dbContext;
        public WordManager(JapanesePractiseContext context)
        {
            _dbContext = context;
        }

        public async Task<WordImportResult> ImportWordListJsonFile(IFormFile importFile)
        {
            var json = JsonConvert.DeserializeObject<IEnumerable<Word>>(await importFile.ReadAsStringAsync());
            return await ImportWordList(json);
        }

        public async Task<WordImportResult> ImportWordList(IEnumerable<Word> wordList)
        {
            //TODO Clean this up with proper error messages per word failure
            var result = new WordImportResult()
            {
                NumAttempted = wordList.Count(),
                NumFaiures = 0,
                NumSuccesses = 0
            };

            foreach (var word in wordList)
            {
                try
                {
                    _dbContext.Add(word);
                    result.NumSuccesses++;
                }
                catch (DbUpdateException)
                {
                    result.NumFaiures++;
                }
                
            }

            await _dbContext.SaveChangesAsync();
            return result;
        }
    }
}
