﻿using System;
namespace Polynomial
{
	public class Term
	{
		public int Power { get; set; }
		public double Coefficient { get; set; }

		public Term(int power, double coeffecient)
		{
			Power = power;
            Coefficient = coeffecient;
		}

		// TODO
		public override string ToString()
		{
			if (Coefficient == 0)
            {
				return "0";
            }
			if (Power == 0)
            {
				return $"{Coefficient}";
            }

            return $"{Coefficient}x^{Power}";
        }

	}
}

