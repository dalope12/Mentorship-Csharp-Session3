using System;

namespace Session3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Inheritance2 inheritance2 = new Inheritance2();
            inheritance2.setData(3, "SESSION");
            inheritance2.printInheritanceData();

            Polymorphism polymorphism = new Polymorphism();
            polymorphism.setData(10, "SESSION_NOVEMBER");
            polymorphism.printInheritanceData();
            polymorphism.setData(20);
            polymorphism.printInheritanceData();
            polymorphism.setData("DANIEL");
            polymorphism.printInheritanceData();
            polymorphism.setData();


            ArrayLists arrayLists = new ArrayLists();
            arrayLists.arrayMethod();
            arrayLists.arrayListMethod();


            Console.ReadKey();
        }
    }
}
