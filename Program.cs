class Program
{

    static void Main(string[] args)
    {
        Console.Write("Input Size: ");
        int size = int.Parse(Console.ReadLine());
        Console.Write("Input Number: ");
        int num = int.Parse(Console.ReadLine());
        int[] road = new int[size];
        Input(ref road);
        Console.WriteLine("{0}",road[size]);
  }
        

static void Input(ref int[] road)
  {
    for (int i = 0; i < road.Length; i++)
    {
      road[i] = int.Parse(Console.ReadLine());
    }
  }
}