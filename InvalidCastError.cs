﻿// See https://aka.ms/new-console-template for more information
using System;
class InvalidCastError
{
    static void Main(string[] args)
    {
        try
        {
            float numOne = 3.14F;
            object obj = numOne;
            int result = (int)obj;
            Console.WriteLine("Value of numOne = {0}", result);
        }catch (InvalidCastException objEx)
        {
            Console.WriteLine("Message: {0}", objEx.Message);
            Console.WriteLine("Error: {0}", objEx);
        }catch(Exception objEx)
        {
            Console.WriteLine("Error: {0}", objEx);
        }
    }
}