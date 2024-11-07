Console.WriteLine("Enter the two numbers");
decimal a = Convert.ToInt32(Console.ReadLine());
decimal b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Operator");
Console.WriteLine("'+' for addition");
Console.WriteLine("'-' for subraction");
Console.WriteLine("'*' for multiplication");
Console.WriteLine("'/' for division");
Console.WriteLine("'%' for remainder");
Console.WriteLine("'^' for power function (first number will be raised to secind number)");
char c = Convert.ToChar(Console.ReadLine());
decimal result = 0;
switch (c)
{
    case'+':
        result = a + b;
        break;
    case'-':
        result = a - b;
        break;
    case '*':
        result = a * b;
        break;
    case '/':
        if(b==0)
        {
            Console.WriteLine("NOT POSSIBLE TO DIVIDE BY 0");
        }
        else
        {
            result = a/b;
        }
        break;
    case'%':
        result = a % b;
        break;
    case '^':
        if(b==0)
        {
            result = 1;
        }
        else if(b>1)
        {
            result = 1;
            while(b>0)
            {
                result = result*a;
                b--;
            }
        }
    break;       
}
Console.WriteLine($"Calculated answer is {result}");
