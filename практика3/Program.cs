using System;

Console.Write("введите x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("введите y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("введите a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("введите b: ");
int b = Convert.ToInt32(Console.ReadLine());

Point kap = new Point(x, y);

double DistanceToOrigin = kap.DistanceToOrigin(x, y);
string move = kap.Move(a, b);

Console.WriteLine(DistanceToOrigin);
Console.WriteLine(move);

string action = "";

while (action != "exit")
{
    Console.WriteLine("\nкоманда действий (++ или --, или 'exit' для выхода):");
    action = Console.ReadLine();

    if (action != "exit")
    {
        string answer = kap.action(action);
        Console.WriteLine(answer);
        kap.Print();  
    }
}

class Point
{
    int x, y;

    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public double DistanceToOrigin(int x, int y)
    {
        return Math.Sqrt(x * 2 + y * 2);
    }

    public string Move(int a, int b)
    {
        x = x + a;
        y = y + b;
        return $"складывание x:{x} y:{y}";
    }

    public string action(string action)
    {
        if (action == "++")
        {
            x += 1;
            y += 1;
            return "число х и у увеличены на +1 ";
        }
        else if (action == "--")
        {
            x -= 1;
            y -= 1;
            return "число х и у уменьшены на -1 ";
        }
        else
            return "Not correct answer ";
    }

    public void Print()
    {
        Console.WriteLine(DistanceToOrigin);
        Console.WriteLine($"Текущие значения -> x: {x}, y: {y}");
    }
}