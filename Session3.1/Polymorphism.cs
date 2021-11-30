using System;

public class Polymorphism:Inheritance
{
    public void setData(int number, string name, double lastName=0)
    {
        sessionNumber = number;
        sessionName = name;
    }

    public void setData(int number, double lastName = 0)
    {
        sessionNumber = number;
    }

    public void setData(string name, double lastName = 0)
    {
        sessionName = name;
    }

    public void setData(double lastName = 0)
    {
        Console.WriteLine("WELL DONE");
    }
}
