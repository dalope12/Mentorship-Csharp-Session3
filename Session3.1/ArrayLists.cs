using System;
using System.Collections;

public class ArrayLists
{
	public void arrayMethod()
    {
        int[] number;
        number = new int[3];

        number[0] = 11111;
        number[1] = 2222;
        number[2] = 33;

        Console.WriteLine(number[0]);
        Console.WriteLine(number[1]);
        Console.WriteLine(number[2]);
    }

    public void arrayListMethod()
    {
        ArrayList number = new ArrayList();

        number.Add(11111111111);
        number.Add("DaNiEl");
        number.Add(true);
        number.Add(20.45);

        Console.WriteLine(number[0]);
        Console.WriteLine(number[1]);
        Console.WriteLine(number[2]);
        Console.WriteLine(number[3]);
        Console.WriteLine(number.Count);

        if (number.Contains("Daniel"))
        {
            Console.WriteLine("HI DANI");
        }
        else if (number.Contains("DaNiEl"))
        {
            Console.WriteLine("HI LEAN TECH");
        }

        foreach (var item in number)
        {
            Console.WriteLine(item);
        }

        for (int i = 0; i < number.Count; i++)
        {
            Console.WriteLine(number[i]);
        }
    }

}
