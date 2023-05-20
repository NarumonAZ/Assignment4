class Program
{
  static int Calculate(int a, int b)
  {
    if (a > b)
    {
      return a;
    }
    return b;
  }

    static void Main(string[] args)
    {
        int size = int.Parse(Console.ReadLine());
        int[] road = new int[size];

        
        Console.WriteLine("{0}",road[size]);
  }
        
}
