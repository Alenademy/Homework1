int a, b, c;
Console.WriteLine("Введите первое число : ");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число : ");
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число : ");
c = Convert.ToInt32(Console.ReadLine());
int[] num = { a, b, c };
Console.WriteLine(Math.Max(a, Math.Max(b, c)));
Console.ReadLine();
