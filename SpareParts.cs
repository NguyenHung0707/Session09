// See https://aka.ms/new-console-template for more information
using System;
namespace Automotive
{
    public class SpareParts
    {
        String spareName;
            public SpareParts() {
            spareName = "Gear Box";
            }
        public void Display()
        {
            Console.WriteLine("SpareParts Name : " + spareName);
        }
    }
}