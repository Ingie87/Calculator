public class MultiplicationDivision
{
    public static double Multiply(double a, double b)
    {
        return a * b;
    }

    public static double Division(double a, double b)
    {
        if(b== 0)
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }

        return a / b;
    }
}