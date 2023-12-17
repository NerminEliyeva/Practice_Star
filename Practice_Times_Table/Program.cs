
TimesTable();
void TimesTable()
{
    int res = 0;
    string tre = new String('-', 15);
    for (int i = 2; i <= 10; i++)
    {
        for (int j = 1; j <= 10; j++)
        {
            res = i * j;
            Console.WriteLine($"{i} * {j} = {res}");
        }
            Console.WriteLine($"{tre}");
    }
}