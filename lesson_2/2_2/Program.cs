void rem(int a, int b)
{
    if (a % b == 0)
        Console.WriteLine("Числа кратны");
    else 
    {  
         Console.WriteLine("Числа не кратны "+a % b);
    }
        
}
int NumA = int.Parse(Console.ReadLine()!);
int NumB = int.Parse(Console.ReadLine()!);
rem(NumA, NumB);
