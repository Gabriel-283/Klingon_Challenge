using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KlingonLanguageReader.Model
{
    public class Word
    {
        const int MAX_CHARACTER_HAS_ON_WORD_PREPOSITION = 3;
        const int MIN_CHARACTER_HAS_ON_VERB = 8;
        const int MIN_NUMBER_HAS_ON_DIFFERENT_BEATIFULNUMBERS = 440566;
        const int DIVISIBLE_NUMBER_TO_BE_BEATIFUL = 3;
        const int REST_OF_DIVISIBLE_NUMBER_TO_BE_BEATIFUL = 0;

        const char INVALID_CHARACTER = 'd';
        public string Text { get; private set; }

        public Word(string word)
        {
            Text = word;
        }

        public bool IsValid()
        {
            return HasMaxCharacter()
                    && TheLasCharacterIsBarType()
                    && IsValidWord();
        }

        public bool IsValidVerb()
        {
            return Text.Length >= MIN_CHARACTER_HAS_ON_VERB &&
                   KlingonLanguage.FooType.Contains(Text.Last());
        }

        public bool IsVerbFirstPerson()
        {
            if (!IsValidVerb()) return false;

            string firstLetter = Text.Substring(0, 1);
            return KlingonLanguage.BarType.Contains(Convert.ToChar(firstLetter));
        }
        public bool IsBeautifull()
        {
            double numericValue = GetNumericValue();
            return (numericValue >= MIN_NUMBER_HAS_ON_DIFFERENT_BEATIFULNUMBERS
                    && numericValue % DIVISIBLE_NUMBER_TO_BE_BEATIFUL
                    == REST_OF_DIVISIBLE_NUMBER_TO_BE_BEATIFUL);
        }
        private double GetNumericValue()
        {
            const int MULTIPLY_BASE = 20;
            double numericValue = 0;

            for (int x = 0; x < Text.Length; x++)
            {
                numericValue += KlingonLanguage.AlphabeticalOrder.IndexOf(Text[x]) * Math.Pow(MULTIPLY_BASE, x);
            }

            return numericValue;
        }

        private bool HasMaxCharacter()
        {
            return Text.Length == MAX_CHARACTER_HAS_ON_WORD_PREPOSITION;
        }

        private bool TheLasCharacterIsBarType()
        {
            return KlingonLanguage.BarType.Contains(Text.Last());
        }

        private bool IsValidWord()
        {
            return !Text.Contains(INVALID_CHARACTER);
        }
    }
}
