using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JapanesePractise.Core.DomainManagers;
using JapanesePractise.Core.DomainManagers.Interfaces;
using JapanesePractise.Core.DomainModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JapanesePractise.Controllers
{
    //TODO: maybe change to convension routing?
    [Route("api/[controller]/[action]")]
    public class WordController : Controller
    {
        private readonly IWordManager _wordManager;

        public WordController(IWordManager wordManager)
        {
            _wordManager = wordManager;
        }

        [HttpPost]
        public async Task<IActionResult> ImportWordList([FromBody] IEnumerable<Word> wordList)
        {
            var import = await _wordManager.ImportWordList(wordList);
            
            return Json(import);
        }
    }

}
