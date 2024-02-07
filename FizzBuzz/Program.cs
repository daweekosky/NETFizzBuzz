string text;
for (int i = 1; i <= 100; i++)
{
    text = "";
    if (i % 3 == 0)
    {
        text += "Fizz";
    }
    if (i % 5 == 0)
    {
        text += "Buzz";
    }
    if (i % 3 != 0 && i % 5 != 0)
    {
        text += i;
    }
    Console.WriteLine(text);
}