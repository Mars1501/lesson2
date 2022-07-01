// Задача 13



void number(int x)
{
    int div = 1;
    while(x / div >= 10)
    {
        div *= 10;
    
}
if(div < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    int digit = (x / (div / 100)) % 10;
    Console.WriteLine("Третье число {0}", digit);
}
}


number(645);
number(78);
number(32679);

