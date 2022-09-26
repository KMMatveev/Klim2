using System.Security.Cryptography.X509Certificates;

int i;
double x, k, z;
x = double.Parse(Console.ReadLine());
k = 10;
i = 1;
z = 1;
while (i < 10)
{
    z *= x;
    k += z * (10 - i);
    i++;
}
Console.WriteLine(k);
i = 0;
z = 1;
k = 0;
while (i < 10)
{
    z *= x;
    k += Math.Cos(z);
    i++;
}
Console.WriteLine(k);
i= int.Parse(Console.ReadLine());
z = Math.Sin(x);
double s;
s = 0;
k=1;
while (k < i)
{
    s += z;
    z = Math.Sin(z);
    k++;
}
Console.WriteLine(s);



Console.ReadKey();