
var calcul = new Calculator();
Console.Write("The first number is: ");
calcul.A = Convert.ToInt32(Console.ReadLine());
Console.Write("The first number is: ");
calcul.n = Convert.ToString(Console.ReadLine());
Console.Write("The operation is: ");
calcul.B = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(calcul.Loop);


public class Calculator
{
    public int A;
    public int B;
    public string n;
    public void Loop()
    {
        if(n == "+")
        {
            Console.WriteLine(A + B);
        } 
        else if (n == "-")
        {
            Console.WriteLine(A - B);
        }
        else if(n == "*")
        {
            Console.WriteLine(A * B);
        }
        else if(n == "/")
        {
            Console.WriteLine(A / B);
        }
    }
}