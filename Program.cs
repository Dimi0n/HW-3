//Задача №19
Console.WriteLine("Введите 5и значное число");
string Number = Console.ReadLine();

if (Number[0]==Number[4])
{
   if (Number[1]==Number[3])
   {
    
   }
    System.Console.WriteLine("Число является полиндромом");
}
else
{
    System.Console.WriteLine("Число НЕ является полиндромом");
}

//Задача №21

Console.WriteLine("\n Задача 21");
int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt16(Console.ReadLine());
}

double Decision(double x1, double x2, 
                double y1, double y2, 
                double z1, double z2){
  return Math.Sqrt(Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine($"Длина отрезка  {segmentLength}");

//Задача №23
System.Console.WriteLine("Введите число: ");
double Number = Convert.ToInt32(Console.ReadLine());


for (double i = 1; i <= Number; i++)
{
   
    System.Console.Write($"\t {Math.Pow(i, 3)}");
  
}

