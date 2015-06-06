/*
    Isaac A. Gibbs
    3/25/2014
    Neural Net
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neural_Net
{
    public class Neural_Net
    {
        public int inputs, outputs, neurons;
        public double rate, delta;
        public double[] medin, medout, input, output, sigma, target, error, sigmoid;
        public double[,] synone, syntwo;
        int restoreInterval;
        int saveInterval;
        int counter;

        Random rand = new Random();

        public Neural_Net (int inputs, int outputs, int neurons, double rate){
            this.inputs = inputs + 1;
            this.outputs = outputs;
            this.neurons = neurons;
            this.rate = rate;
            restoreInterval = 30;
            saveInterval = 50;
            counter = 0;
            medin = new double[neurons];
            input = new double[inputs+1];
            output = new double[outputs];
            medout = new double[neurons];
            synone = new double[this.inputs+1, neurons];
            syntwo = new double[neurons, outputs];
            sigma = new double[neurons];
            sigmoid = new double[neurons];
            error = new double[outputs];
            target = new double[outputs];


            for (int i = 0; i < inputs; i++)
            {
                for (int j = 0; j < neurons; j++)
                {
                    synone [i, j] = (rand.NextDouble() * Form1.globals.noise*2) - Form1.globals.noise;
                }
            }
            for (int i = 0; i < neurons; i++)
            {
                for (int j = 0; j < outputs; j++)
                {
                    syntwo [i, j] = (rand.NextDouble() * 2) - 1;
                }
            }
        }

        public double[] evaluate(double[] input1)
        {
            for (int i = 0; i < inputs -1; i++)
            {
                this.input[i] = input1[i];
            }
            this.input [inputs - 1] = 1;
            for(int i = 0; i < neurons; i++) 
            {
                medin[i] = 0; //initializes each neuron input to 0
                for (int j = 0; j < inputs; j++)
                {
                    medin[i] = medin[i] + synone[j, i] * input[j]; //adds the value of each input times each synaptic weight to each medin
                }
                medout[i] = Math.Tanh(medin[i]); //applies normalizing function (between -1 and 1) for each medin and places in medout
            }

            for (int i = 0; i < outputs; i++){
                output[i] = 0;
                for (int j = 0; j < neurons; j++){
                    output[i] = output[i] + syntwo[j, i] * medout[j]; //sets each output to a sum of each medout times syntwo synaptic weights
                }
            }
            
            return output;
        }

        public void train(double[] input1, double[] target)
        {
            double[] output = evaluate(input1); //sets output to evaluate of input1
            
            for (int i = 0; i < outputs; i++)
            {
                error[i] = target[i] - output[i]; //difference between targets and outputs (-error for overestimate, +error for under)
                for (int j = 0; j < neurons; j++)
                {
                    syntwo[j, i] = syntwo[j, i] + (rate * medout[j] * error[i]); //adjusts syntwo up or down depending on error
                }
            }
            for (int i = 0; i < neurons; i++)
            {
                sigma[i] = 0; //summation for each neuron = 0
                for (int j = 0; j < outputs; j++) //sum each of the output synapses (syntwo) multiplied by that output's error
                {
                    sigma[i] = sigma[i] + (error[j] * syntwo[i, j]);
                }
                sigmoid[i] = 1 - (medout[i] * medout[i]); //sigmoid for each neuron = inverse medout^2
            }
            for (int i = 0; i < inputs; i++)
            {
                for (int j = 0; j < neurons; j++)
                {
                    delta = rate * sigmoid[j] * sigma[j] * this.input[i]; //for each medin synapse calculate that medin's delta
                    synone[i, j] = synone[i, j] + delta; //add that delta to the current synone
                }
            }
        }      
    }
}
