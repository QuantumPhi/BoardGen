using Accord.Neuro;
using Accord.Neuro.Learning;
using Accord.Neuro.Networks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoggleLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            DeepBeliefNetwork network = new DeepBeliefNetwork(2, 23, 1);
            new NguyenWidrow(network).Randomize();
            ParallelResilientBackpropagationLearning learning = new ParallelResilientBackpropagationLearning(network);

            string[] trainingData =
            {
                "elotsopestidisfs",

            };
        }
    }
}
