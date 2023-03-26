System.Console.WriteLine("Введите день недели:");

bool YesWeekend (int something)
{
    if (something >5)
    {
       return true;
        
    }
    else
    {
       return false;
       
    }
}

bool ItIsWeek (int something)
{
    if (something > 7)
    {
        return false;
    }
    else
    {
        return true;
    }
}

int input = int.Parse(Console.ReadLine());
System.Console.WriteLine("----------------------------------");
if (ItIsWeek(input))
{
    if(YesWeekend(input))
    {
        System.Console.WriteLine("Выходной!!!!!!");
    }
    else
    {
        System.Console.WriteLine("Рабочий день");
    }
}
else
{
    System.Console.WriteLine("Ввели некорректное число");
}
