/*Дано число, найдите, является ли оно сильным или нет, и верните либо "STRONG!!!!" или "Not Strong !!"
 * Сильное число — это число у которого сумма факториала его цифр равна самому числу.
 * Например, 145 сильное, так как 1! + 4! + 5! = 1 + 24 + 120 = 145.
 */
Console.WriteLine(Kata.StrongNumber(10));
class Kata
{
    public static string StrongNumber(int number)
    {
        string _number;
        int result = 0;
        int digit = 0;
        _number = number.ToString();
        foreach (char item in _number)
        {
            digit = int.Parse(item.ToString());
            result += Factorial(digit);
            
            
        }

        return result == number ? "STRONG!!!!" : "Not Strong !!";
    }
    public static int Factorial( int n) 
    {
        if (n == 1 || n == 0) return 1;

        return n * Factorial(n - 1);
    }
    
}