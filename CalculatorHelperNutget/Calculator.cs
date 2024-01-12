namespace CalculatorHelperNutget
{
    public class Calculator
    {
        public static decimal mutiply(decimal x, decimal y)
        {
            return x * y;
        }
        public static decimal? Divide(decimal x, decimal y)
        {
            try
            {
                return x / y;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Division of {0} by  zero.",x);
                return null;
            }

            
        }
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
        public static decimal subtract(decimal x, decimal y)
        {
            return x -y;
        }
    }
}
