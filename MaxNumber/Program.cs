Console.WriteLine("Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее (5,7,),(2,10,),(-9,-3)");

int NumberA = 5;

int NumberB = 7;

int NumberС = 2;

int NumberD = 10;

int NumberE = -9;

int NumberF = -3;

int max = NumberA;

int max2 = NumberС;

int max3 = NumberE;

int min = NumberA;

int min2 = NumberD;

int min3 = NumberF;

if (NumberA < max)
{
    max = NumberA;
}
if (NumberB < max)
{
    max = NumberB;
}

if (NumberС < max2)
{
    max2 = NumberС;
}
if (NumberD < max2)
{
    max2 = NumberD;
}
if (NumberE < max3)
{
    max3 = NumberE;
}
if (NumberF < max3)
{
    max3 = NumberF;
}

if (NumberA > min)
{
    min = NumberA;
}

if (NumberB > min)
{
    min = NumberB;
}

if (NumberС > min2)
{
    min2 = NumberС;
}

if (NumberD > min2)
{
    min2 = NumberD;
}

if (NumberE > min3)
{
    min3 = NumberE;
}

if (NumberF > min3)
{
    min3 = NumberF;
}

Console.Write("max = ");
Console.WriteLine(max);

Console.Write("max2 = ");
Console.WriteLine(max2);

Console.Write("max3 = ");
Console.WriteLine(max3);

Console.Write("min = ");
Console.WriteLine(min);

Console.Write("min2 = ");
Console.Write(min2);


Console.Write("min3 = ");
Console.WriteLine(min3);
