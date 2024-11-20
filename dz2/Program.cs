double start = 1;
double  end = 29;
double step  = 0.2;
for (double x = start; x <= end; x += step)
{
    double y = Math.Log(x*x)- x + 4;
    Console.WriteLine($"x:{x:F2},U:{y:F2}");
}

