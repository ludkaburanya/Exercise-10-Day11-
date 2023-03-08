using z2;

namespace z2
{
    class Program
    {
        static void Main()
        {
            A a = new A();
            Console.WriteLine($"C у класса A: {a.C}");
            B b = new B(3, 4, 2);
            Console.WriteLine($"C у класса B: {b.C}");
            Console.WriteLine($"C2 у класса B: {b.C2}");
        }
    }
}
