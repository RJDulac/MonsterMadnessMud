using System;
public class Shop
{

    // public bool IsShoping { get; set; }
    // public Shop(bool isShoping)
    // {
    //     IsShoping = isShoping;
    // }
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