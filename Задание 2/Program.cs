System.Console.WriteLine("Введите число:");

var input = int.Parse(Console.ReadLine());

int Solution (int something)
{
   something = something%10;
    return something;
}

if(input<100)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else if(input<1000)
{
    System.Console.WriteLine(Solution(input));
}
else if (input>1000)
{
    while(input>999)
    {
        input = input / 10;
    }

    System.Console.WriteLine(Solution(input));

}
else
{
    System.Console.WriteLine("Какая-то ошибка");
}

