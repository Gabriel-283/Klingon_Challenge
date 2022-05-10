using KlingonLanguageReader.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace KlingonLanguageReaderTest
{
    public class WordTest
    {
        Word word;

        [Fact]
        private void Should_IsValid()
        {
            word=new Word("vlz");

            bool isValidWord= word.IsValid();

            Assert.True(isValidWord);
        }

        [Fact]
        private void Should_IsValidVerb()
        {
            word = new Word("cwrsgrdk");

            bool isValidVerbs = word.IsValidVerb();

            Assert.True(isValidVerbs);
        }

        [Fact]
        private void Should_IsVerbFirstPerson()
        {
            word = new Word("cswrsgrk");

            bool isVerbInFirstPerson = word.IsVerbFirstPerson();

            Assert.True(isVerbInFirstPerson);
        }

        [Fact]
        private void Should_IsBeatifull()
        {
            word = new Word("ltdtqrd");

            bool isBeatifullWord = word.IsBeautifull();

            Assert.True(isBeatifullWord);
        }
    }
}
