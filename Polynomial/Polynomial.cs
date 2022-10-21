using System;
namespace Polynomial
{
	public class Polynomial
	{
		private LinkedList<Term> terms;

		public int NumberOfTerms => terms.Count;

		public int Degree => NumberOfTerms == 0 ? 0: terms.First.Value.Power;

		public Polynomial()
		{
			terms = new LinkedList<Term>();
		}

        // TODO
        public void AddTerm(double coeff, int power)
		{
            if (coeff == 0.0)
            {
                power = 0;
            }
            var currentNode = terms.First;
            while( currentNode != null )
            {
                // check for matching power
                if( power == currentNode.Value.Power)
                {
                    currentNode.Value.Coefficient += coeff;
                    return;
                }

                // check for lesser power
                if ( power > currentNode.Value.Power)
                {
                    var newTerm = new Term(power, coeff);

                    terms.AddBefore(currentNode, newTerm);
                    return;
                }


                currentNode = currentNode.Next;
            }
            // Add new term to end of list
            terms.AddLast(new Term(power, coeff));

		}

		// TODO
        public override string ToString()
        {
            string result = "";

            int i = 1;

            int length = 0;

            foreach (var term in terms)
            {
                length += 1;
            }

            if (length == 0)
            {
                return "0";
            }
            else
            {
                foreach (var term in terms)
                {
                    if (term.Coefficient != 0.0)
                    {
                        if (i == length)
                        {
                            result += term.ToString();
                        }
                        else
                        {
                            result += term.ToString() + "+";
                            i++;
                        }

                    }

                    else
                    {
                        return "0";
                    }
                }
            }

            return result;
        }

		public static Polynomial Add(Polynomial p1, Polynomial p2)
		{
			Polynomial sum = new Polynomial();

            // add all the terms from p1 to sum
            foreach( var term in p1.terms)
            {
                sum.AddTerm(term.Coefficient, term.Power);
            }

            // add all the terms from p2 to sum
            foreach (var term in p2.terms)
            {
                sum.AddTerm(term.Coefficient, term.Power);
            }

            return sum;
		}

        public static Polynomial Subtract(Polynomial p1, Polynomial p2)
        {
            Polynomial difference = new Polynomial();

            foreach (var term in p1.terms)
            {
                difference.AddTerm(term.Coefficient, term.Power);
            }

            Polynomial negative_p2 = Negate(p2);

            foreach (var term in negative_p2.terms)
            {
                difference.AddTerm(term.Coefficient, term.Power);
            }

            return difference;
        }

        public static Polynomial Negate(Polynomial p)
        {
            Polynomial inverse = new Polynomial();

            foreach(var term in p.terms)
            {
                inverse.AddTerm(term.Coefficient * -1, term.Power);
            }

            return inverse;
        }

        public static Polynomial Multiply(Polynomial p1, Polynomial p2)
        {
            Polynomial product = new Polynomial();
            // Do the work...

            foreach (var term1 in p1.terms)
            {
                foreach (var term2 in p2.terms)
                {
                    double coeff = term1.Coefficient * term2.Coefficient;
                    int pow = term1.Power + term2.Power;
                    product.AddTerm(coeff, pow);
                }
            }

            return product;
        }


    }
}

