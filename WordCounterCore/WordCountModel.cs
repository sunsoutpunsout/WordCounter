using System.Collections.Generic;

namespace WordCounterCore
{
    /// <summary>
    /// Describes the word count model.
    /// </summary>
    public class WordCountModel
    {
        public WordCountModel()
        {
            this.UniqueList = new List<WordWithUniqueCountModel>();
        }

        /// <summary>
        /// Gets or sets the total count of words.
        /// </summary>
        public int Count { get; set; } = 0;

        /// <summary>
        /// Gets or sets the unique count of words.
        /// </summary>
        public int UniqueCount { get; set; } = 0;

        /// <summary>
        /// Gets the list of unique words with counts.
        /// </summary>
        public List<WordWithUniqueCountModel> UniqueList { get; }
    }

    /// <summary>
    /// Describes the word with individual count model.
    /// </summary>
    public class WordWithUniqueCountModel
    {
        /// <summary>
        /// Gets or sets the word.
        /// </summary>
        public string Word { get; set; }

        /// <summary>
        /// Gets or sets the word count.
        /// </summary>
        public int Count { get; set; }
    }
}
