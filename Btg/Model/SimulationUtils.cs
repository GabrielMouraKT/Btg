﻿// SimulationUtils.cs
using System;

namespace Btg.Utils
{
    public class SimulationUtils
    {
        public static double[] GenerateBrownianMotion(double sigma, double mean, double initialPrice, int numDays)
        {
            Random rand = new Random();
            double[] prices = new double[numDays];
            prices[0] = initialPrice;

            for (int i = 1; i < numDays; i++)
            {
                double u1 = rand.NextDouble();
                double u2 = rand.NextDouble();
                double z = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Cos(2.0 * Math.PI * u2);

                double retornoDiario = mean + sigma * z;
                prices[i] = prices[i - 1] * Math.Exp(retornoDiario);
            }

            return prices;
        }
    }
}
