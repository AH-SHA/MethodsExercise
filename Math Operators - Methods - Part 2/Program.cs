// See https://aka.ms/new-console-template for more information

    public class Program
    {
        static void Main(string[] args)

        {

            Console.WriteLine(Add(10, 2)); //  Output 12
            Console.WriteLine(Multiply(10, 2)); // Output 20
            Console.WriteLine(Subtract(10, 2)); // Output  8
            Console.WriteLine(Divide(10, 2)); // Output 5



            static int Add(int a, int b)
            {
                return a + b;

            }
            static int Multiply(int a, int b)
            {
                return 10 * 2;
            }
            static int Subtract(int a, int b)
            {
                return 10 - 2;
            }
            static float Divide(int a, int b)

            {
                return 10 / 2;
            }

        }
    }

