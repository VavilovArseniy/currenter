Console.WriteLine("Введите римское число");
string str = Console.ReadLine();
int a = 0;
for (int i = 0; i < str.Length; i++)
{
    char ch = str[i];
    if (ch == 'M')
        a += 1000;
    else if (ch == 'D')
        a += 500;
    else if (ch == 'C')
        a += 100;
    else if (ch == 'L')
        a += 50;
    else if (ch == 'X')
        a += 10;
    else if (ch == 'V')
        a += 5;
    else if (ch == 'I')
        a += 1;
}
Console.WriteLine("{0}", a);


