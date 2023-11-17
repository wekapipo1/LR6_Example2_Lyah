using System;
public class MathClass
{
    public void MultiplyNumbers(int n, double m)
    {
        double x = n * m;
        Console.WriteLine("{0}*{1}={2}", n,m,x);
    }
    public void AddNumbers(int n, double m)
    {
        double x = n + m;
        Console.WriteLine("{0}+{1}={2}", n, m, x);
    }
    public double MNumbers(int n, double m)
    {
        double x=m * n;
        return x;
    }
    public double ANumbers(int n, double m)
    {
        double x=m + n;
        return x;
    }
}
class Program
{
    public delegate void MyDel(int i, double j);
    public delegate double MyDel2(int i, double j);
    static void Main(string[] args)
    {       
        MathClass m = new MathClass();
        MyDel d1 = new MyDel(m.MultiplyNumbers);
        MyDel d2 = new MyDel(m.AddNumbers);
        MyDel2 d3 = new MyDel2(m.MNumbers);
        MyDel2 d4 = new MyDel2(m.ANumbers);
        for (int i = 1; i < 10; i++)
        {
            d1(i, 1.5);
            d2(2, i);
            Console.WriteLine("_______________________");
            Console.WriteLine("{0}", d3(i,1.5));
            Console.WriteLine("{0}", d4(2,i));
            Console.WriteLine("_______________________");
        }        
        Console.ReadKey();
    }
}