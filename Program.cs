class Program {
        static void Swap(ref float a, ref float b) {
        float tmp = a;
        a = b;
        b = tmp;
    }
    static void SwapIfHigher(ref float a, ref float b) {
        if (a < b) {
            Swap(ref a, ref b);
        }
    }

static void Main(string[] args) {
       int size = int.Parse(Console.ReadLine());
       float[] num = new float[size];
       for (int i = 0; i < size; i++) {
        num[i] = float.Parse(Console.ReadLine());
       }
       // sort
       for(int i = size - 1; i > 0; i--) {
           for(int j = 0; j < i; j++) {
            SwapIfHigher(ref num[j], ref num[j+1]);
           }
       }
       for (int i = 0; i < size; i++) {
          Console.Write("{0} ", num[i]);
       }
    }
}
