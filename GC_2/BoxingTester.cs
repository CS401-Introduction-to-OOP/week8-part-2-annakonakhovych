namespace GC_2;

public static class BoxingTester
{
    public static void Test()
    {
        int a = 10;
        object b = a; // boxing: Перетворення value type → reference type
        int c = (int)b; //unboxing: Перетворення reference type → value type
        Console.WriteLine($"Original {a}");
        Console.WriteLine($"Boxed {b}");
        Console.WriteLine($"Unboxed {c}");
        
    }
}