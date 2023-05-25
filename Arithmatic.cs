// See https://aka.ms/new-console-template for more information
class Arithmetic
{
    static void Main(String[] args)
    {
        string[] names = { "John", "James" };
        int numOne = 0;
        int result;
        try
        {
            Console.WriteLine("This is the outer try block");
            try
            {
                result = 133 / numOne;
            }catch(ArithmeticException objMaths)
            {
                Console.WriteLine("Divide by 0 " + objMaths);
            }
            names[2] = "Smith";
        }catch(IndexOutOfRangeException objIndex)
        {
            Console.WriteLine("Wrong number of arguments supplied" + objIndex);
        }
    }
}