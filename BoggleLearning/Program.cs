using Accord.Neuro;
using Accord.Neuro.Learning;
using Accord.Neuro.Networks;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BoggleLearning
{
    class Program
    {
        readonly static int EPOCHS = 150;

        static void Main(string[] args)
        {
            DeepBeliefNetwork network = new DeepBeliefNetwork(2, 23, 1);
            new NguyenWidrow(network).Randomize();
            ParallelResilientBackpropagationLearning learning = new ParallelResilientBackpropagationLearning(network);

            string[] trainingData =
            {
                "elotsopestidisfs",
            };

            var input = GetCharTypes(trainingData).ToArray();
            var output = new double[][]
            {
                new double[] {1}
            };

            for (int i = 0; i < EPOCHS; i++)
                Console.WriteLine(learning.RunEpoch(input, output));

            Debugger.Break();
        }

        static IEnumerable<double[]> GetCharTypes(string[] data)
        {
            int vowels = 0,
                consonants = 0;

            foreach (string item in data)
            {
                vowels = Regex.Matches(item.ToLower(), @"[aeiou]").Count;
                consonants = item.Length - vowels;
                yield return new double[] { vowels, consonants };
            }
        }
    }
}
