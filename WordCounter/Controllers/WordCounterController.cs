using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

using WordCounterSite.Models;

namespace WordCounterSite.Controllers
{
    public class WordCounterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Gets relevant word count information.
        /// </summary>
        /// <param name="model">The given model.</param>
        /// <returns>The populated model.</returns>
        [HttpPost]
        public IActionResult WordCount(WordCountViewModel model)
        {
            var counts = new WordCounterCore.WordCounter().GetWordCount(model.Words);
            model.Count = counts.Count;
            model.UniqueCount = counts.UniqueCount;
            model.UniqueList.AddRange(counts.UniqueList);

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
