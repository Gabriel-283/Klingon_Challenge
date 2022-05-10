using KlingonLanguageReader.Resource;
using System;
using System.Collections.Generic;

namespace KlingonLanguageReader
{
    class Program
    {
        static void Main(string[] args)
        {
            KlingonReader klingonReader = new KlingonReader(klingonTextA.Text);
            Console.WriteLine($"E no Texto B, quantas preposições existem? R: {klingonReader.GetTotalPrepositions()}");
            Console.WriteLine($"Já no Texto B, quantos são os verbos? R: {klingonReader.GetTotalVerbs()}");
            Console.WriteLine($"E quantos verbos do Texto B estão em primeira pessoa? R: {klingonReader.GetTotalVerbsInFirstPerson()}");
            Console.WriteLine($"Como seria a lista de vocabulário do Texto B? R: {klingonReader.GetVocabularyOrganized()}");
            Console.WriteLine($"E no Texto B, quantos números bonitos distintos existem? R: {klingonReader.GetBeautifullNumeber()}");
            Console.ReadKey();
        }
    }
}
