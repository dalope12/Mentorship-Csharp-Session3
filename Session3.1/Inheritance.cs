using System;

public class Inheritance
{
	protected int sessionNumber;
	protected string sessionName;
	public bool daniel;
	private double lopez;

	public void printInheritanceData()
    {
		Console.WriteLine($"This is {sessionName} {sessionNumber}");
    }
}
