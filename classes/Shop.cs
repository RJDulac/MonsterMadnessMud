using System;
public class Shop
{
    public void Shopping(bool isShoping)
    {


        while (isShoping == true)
        {
            Console.WriteLine("Welcome to my store!");
            Console.ReadLine();
            isShoping = false;

        }
    }
}