
using Xunit;
using System;
using KlingonLanguageReader;
using System.Collections.Generic;
using KlingonLanguageReaderTest.ResourceTest;
using KlingonLanguageReader.Resource;

namespace KlingonLanguageReaderTest
{
    public class KlingonLanguageReaderTest
    {
        KlingonReader klingonReader = new KlingonReader(klingonTextA.Text);

        [Fact]
        private void Should_GetTotalPrepositions()
        {
            int totalPrepositions = klingonReader.GetTotalPrepositions();

            Assert.Equal(63, totalPrepositions);
        }

        [Fact]
        private void Should_GetTotalVerbs()
        {
            int totalVerbs = klingonReader.GetTotalVerbs();

            Assert.Equal(26, totalVerbs);
        }

        [Fact]
        private void Should_GetverbsInFirstPerson()
        {
            int totalVerbsInFirstPerson = klingonReader.GetTotalVerbsInFirstPerson();
            Assert.Equal(23, totalVerbsInFirstPerson);
        }

        [Fact]
        private void Should_GetVocabularyOrganized()
        {
            string vocabularyOrganized = klingonReader.GetVocabularyOrganized();

            Assert.Equal(OrganizedVocabularyKlingonTextA.Text, vocabularyOrganized);
        }

        [Fact]
        private void Should_GetBeatyfullNumeber()
        {
            int countBeatifullNumber = klingonReader.GetBeautifullNumeber();

            Assert.Equal(126, countBeatifullNumber);
        }


    }
}