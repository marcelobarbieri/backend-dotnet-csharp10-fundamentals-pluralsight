int i = 0;
int j = 0;

while (i < 3)
{
    while(j < 3)
    {
        Console.WriteLine("i: " + i + "   j: " + j);
        j++;
    }
    j = 0;
    i++;
}