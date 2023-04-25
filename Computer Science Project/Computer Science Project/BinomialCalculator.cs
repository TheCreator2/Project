using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer_Science_Project
{
    class BinomialCalculator
    {




        //returns a list with all culomative probability values. Parameters need to be the data values from text boxes.
        public List<decimal> culmativeProbabilities(double nullHyp, int numTrials, int numOfSucesses)
        {
            decimal nullHypDecimal = (decimal)nullHyp;
            List<int> values = new List<int>();
            List<decimal> probabilities = new List<decimal>();
            //find probability of every outcome and add them to probabiliies in the list
            decimal probOfFailure = 1 - nullHypDecimal;


            for (int j = 0; j <= numTrials; j++)
            {
                decimal x = 0;
                decimal val;
                //probability of thing happening j times.
                if (j == 0)
                {
                    foreach (decimal p in probabilities)
                    {
                        x = x + p;
                    }
                    val = (numTrials * probOfFailure) + x;
                }
                else
                {
                    foreach (decimal p in probabilities)
                    {
                        x = x + p;
                    }
                    val = ((j * nullHypDecimal) * ((numTrials - j) * probOfFailure)) + x;
                }
                probabilities.Add(val);
                //all probabilities are now culmative and should sum to 1.
            }
            return probabilities;
        }

        public List<double> lowerCriticalReigons(List<int> probabilities, int sigLevel, double nullHyp)
        {
            List<double> lowerCriticalReigons = new List<double>();

            // iterates thorugh the list of culmative probabilities, if the list doesnt add up to half the sig level, the value is added to the list
            double counter = 0;
            foreach (double probability in probabilities)
            {
                
                if ((probability + counter) <= (sigLevel / 2))
                {
                    lowerCriticalReigons.Add(probability);
                }
                foreach (double value in lowerCriticalReigons)
                {
                    counter = counter + value;
                }
            }
            return lowerCriticalReigons;
        }
        public List<double> upperCriticalReigons(List<int> probabilities, int sigLevel, double nullHyp)
        {
            List<double> upperCriticalReigons = new List<double>();

            // iterates thorugh the list of culmative probabilities, if the list doesnt add up to half the sig level, the value is added to the list

            foreach (double probability in probabilities)
            {

                if ((probability) >= (1 - (sigLevel / 100)))
                {
                    upperCriticalReigons.Add(probability);
                }

            }
            return upperCriticalReigons;
        }
    }  
}
