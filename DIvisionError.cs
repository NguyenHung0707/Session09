// See https://aka.ms/new-console-template for more information
class DivisionError
{
    static void Main(string[] args)
    {
        int numOne = 133;
        int numTwo = 0;
        int result;
        try
        {
            result = numOne / numTwo;

        }catch(Exception objDivde)
        {
            Console.WriteLine("Exception caught: " + objDivde);
        }
       
    }
}