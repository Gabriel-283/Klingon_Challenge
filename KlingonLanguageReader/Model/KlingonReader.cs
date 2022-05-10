using KlingonLanguageReader.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KlingonLanguageReader
{
    public class KlingonReader
    {

        private readonly List<string> _separateWords = new List<string>();
        public KlingonReader(string text)
        {
            _separateWords = text.Split(" ").ToList();
        }

        public int GetTotalPrepositions()
        {
            int total = 0;
            foreach (var text in _separateWords)
            {
                Word word = new Word(text);
                total += word.IsValid() ? 1 : 0;
            }

            return total;
        }

        public int GetTotalVerbs()
        {
            int totalVerbs = 0;
            foreach (var text in _separateWords)
            {
                Word word = new Word(text);
                totalVerbs += word.IsValidVerb() ? 1 : 0;
            }

            return totalVerbs;
        }

        public int GetTotalVerbsInFirstPerson()
        {
            int totalVerbsInFirstPerson = 0;

            foreach (var text in _separateWords)
            {
                Word word = new Word(text);
                totalVerbsInFirstPerson += word.IsVerbFirstPerson() ? 1 : 0;
            }

            return totalVerbsInFirstPerson;
        }
        public string GetVocabularyOrganized()
        {
            List<string> words = _separateWords.Distinct().ToList();

            StringBuilder vocabularyOrganizedText = new StringBuilder();

            Dictionary<string, string> vocabulary = new Dictionary<string, string>();

            foreach (var word in words)
            {
                StringBuilder letterPositionInPortugueseOrder = new StringBuilder();
                foreach (var letter in word)
                {
                    letterPositionInPortugueseOrder.Append(PortugueseLanguage.AlphabeticalOrder
                                                           [Array.IndexOf(KlingonLanguage.AlphabeticalOrder.ToArray(), letter)]);
                }
                vocabulary.Add(word, letterPositionInPortugueseOrder.ToString());
            }

            var vocabularyOrdened = vocabulary.OrderBy(x => x.Value);
            foreach (var item in vocabularyOrdened)
            {
                vocabularyOrganizedText.Append($"{item.Key} ");
            }

            return vocabularyOrganizedText.ToString().Trim();
        }
        public int GetBeautifullNumeber()
        {
            int countBetyfullNumber = 0;
            foreach (var text in _separateWords)
            {
                Word word = new Word(text);
                countBetyfullNumber += word.IsBeautifull() ? 1 : 0;
            }
            return countBetyfullNumber;
        }
    }
}
