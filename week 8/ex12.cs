using System;

public class Program
{
    public static void Main(string[] args)
    {
       int i=2;

       while(i<=100)
       {
        i=i+1;
        if(i%2!=0)
        {
        Console.WriteLine(i);
        }

        if(i==21 || i==59)
        {
           continue;
        }

        else if(i==83)
        {
           break;
        }
       }
    }
}