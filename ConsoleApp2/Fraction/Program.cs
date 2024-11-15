namespace Fraction
{
    public class Fraction
    {
        public Fraction(int numerator, int denumerator)
        {
            _numerator = numerator;
            _denumerator = denumerator;

            if (_numerator == 0)
            {
                throw new ArgumentException("Numerator shouldn't be equal to 0");

            }
            if (_denumerator == 0)
            {
                throw new ArgumentException("Denumerator shouldn't be equal to 0");
            }


        }

        public int _numerator;
        public int _denumerator;

        public override string ToString()
        {
            return $"{_numerator}/{_denumerator}";
        }

        public static Fraction operator +(Fraction v1, Fraction v2)
        {

            int mutualDenumerator = v1._denumerator * v2._denumerator;
            int sumNumerators = v1._denumerator * v2._numerator + v2._denumerator * v1._numerator;
            return new Fraction(mutualDenumerator, sumNumerators);
        }
        public static bool operator == (Fraction v1, Fraction v2)
        {
            return  v1._numerator*v2._denumerator == v2._numerator*v1._denumerator;
        }

        public static bool operator != (Fraction v1, Fraction v2) 
        {
            return !(v1 == v2);
        }

    }
}