using System;

for (int i = 1; i < 100; i++)
{
    string str = $"";

    if (i % 3 == 0) str += "Fizz";

    if (i % 5 == 0) str += "Buzz";
    
    if (str == "") Console.WriteLine(i);
    else Console.WriteLine(str);
}