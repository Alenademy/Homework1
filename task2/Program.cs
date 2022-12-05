int a, b;
 Console.WriteLine("Введите первое число : ");
 a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число : ");
 b = Convert.ToInt32(Console.ReadLine());
 if (a > b)
 {
        Console.WriteLine("max={0}", a);
 }
 else
 {
      Console.WriteLine("max={0}", b);
 }
      Console.ReadLine();