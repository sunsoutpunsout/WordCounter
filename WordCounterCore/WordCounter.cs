using System;
using System.Linq;

namespace WordCounterCore
{
    public class WordCounter
    {
        /// <summary>
        /// Gets relevant word count information.
        /// </summary>
        /// <param name="words">The given words.</param>
        /// <returns>The relevant word count information.</returns>
        public WordCountModel GetWordCount (string words)
        {
            var model = new WordCountModel();

            // return if empty
            if (string.IsNullOrEmpty(words))
                return model;
            
            // strip out extraneous whitespace and punctuations excluding hyphens (-)
            var strippedWords = new string(words.Trim().Where(x => !char.IsPunctuation(x) || x == '-').ToArray());

            // return if no valid words are found
            if (string.IsNullOrEmpty(strippedWords))
                return model;

            // split by whitespace
            var wordList = strippedWords.Split(null).Where(x => !string.IsNullOrEmpty(x));
            model.Count = wordList.Count();

            var distinctList = wordList.Distinct(StringComparer.OrdinalIgnoreCase);
            model.UniqueCount = distinctList.Count();

            // order the unique word list and get a total count for each word
            model.UniqueList.AddRange(
                distinctList
                    .OrderBy(x => x)
                    .Select(x => 
                        new WordWithUniqueCountModel
                        {
                            Word = x,
                            Count = wordList.Count(y => string.Equals(x, y, StringComparison.OrdinalIgnoreCase))
                        }));

            return model;
        }
    }
}
