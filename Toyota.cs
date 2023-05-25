namespace Automotive
{
    class Toyota
    {
        static void Main(string[] args)
        {
            Category category = new Category();
            SpareParts part = new SpareParts();
            category.Display();
            part.Display();
        }
    }
}