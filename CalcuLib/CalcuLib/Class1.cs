namespace CalcuLib;

public class Class1
{
    public double Add(int a, int b)
    {
        return a + b;
    }

    public double Subtract(int a, int b)
    {
        return a - b;
    }

    public double Multiply(int a, int b)
    {
        return a * b;
    }

    public double Divide(int a, int b)
    {
        if(a>0) 
            return a / b;
        else
            return 0;
    }
    
}