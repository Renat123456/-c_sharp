int a = int.Parse(Console.ReadLine()!);
int count = 1;
if (a == 0 )
{
 Console.WriteLine("1");
}
else {
while (count <= Math.Abs(a) )
        {
            Console.WriteLine(Math.Pow(count, 2));
             count++;
        }
}
