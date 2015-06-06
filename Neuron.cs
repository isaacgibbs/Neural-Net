/*
    Isaac A. Gibbs
    6/6/2015
    Neural Net
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Net
{
    class Neuron
    {
        public float weight;
        public Neuron[] inputs;

        public Neuron(float w)
        {
            this.weight = w;
        }

        public void connectInput(Neuron[] i)
        {
            inputs = i;
        }

        public void readSums() //reads inputs and updates weight
        {
            for (int i = 0; i < inputs.Length; i++)
            {
                weight += inputs[i].weight;
            }
        }

        

        public void applySigmoid()
        {
            weight = (float)(1.0 / (1.0 + Math.Pow(Math.E, (-1 * weight))));
        }

    }
}
