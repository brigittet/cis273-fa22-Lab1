namespace Polynomial;
class Program
{
    static void Main(string[] args)
    {
        Polynomial p1 = new Polynomial();

        p1.AddTerm(5, 4);
        p1.AddTerm(3, 2);
        p1.AddTerm(13, 6);

        p1.AddTerm(-2, 4);

        Console.WriteLine(p1);

        Polynomial polynomial = new Polynomial();
        Term term1 = new Term(0, 2);
        polynomial.AddTerm(term1.Coefficient, term1.Power);
        Term term2 = new Term(1, 3);
        polynomial.AddTerm(term2.Coefficient, term2.Power);

        Polynomial polynomial2 = new Polynomial();
        Term term3 = new Term(0, 2);
        polynomial2.AddTerm(term3.Coefficient, term3.Power);
        Term term4 = new Term(1, 3);
        polynomial2.AddTerm(term4.Coefficient, term4.Power);

        Polynomial polynomialSum = Polynomial.Subtract(polynomial, polynomial2);
        Console.WriteLine(polynomialSum.NumberOfTerms);
    }
}

