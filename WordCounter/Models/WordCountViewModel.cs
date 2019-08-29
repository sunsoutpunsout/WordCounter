using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using WordCounterCore;

namespace WordCounterSite.Models
{
    public class WordCountViewModel
    {
        public WordCountViewModel()
        {
            this.UniqueList = new List<WordWithUniqueCountModel>();
        }

        /// <summary>
        /// Gets or sets the total count of words.
        /// </summary>
        [Display(Name = "Total Words")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the unique count of words.
        /// </summary>
        [Display(Name = "Total Unique Words")]
        public int UniqueCount { get; set; }

        /// <summary>
        /// Gets the list of unique words with counts.
        /// </summary>
        public List<WordWithUniqueCountModel> UniqueList { get; }

        /// <summary>
        /// Gets or sets the initial words.
        /// </summary>
        public string Words { get; set; }
    }
}
