using System;

class Person
{
    public string Name { get; }
    public string Surname { get; }
    public int Age { get; }
    public double Weight { get; }
    public double Height { get; }

    public Person(string name, string surname, int age, double weight, double height)
    {
        Name = name;
        Surname = surname;
        Age = age;
        Weight = weight;
        Height = height;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Surname: {Surname}, Age: {Age}, Weight: {Weight}, Height: {Height}";
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the person's name:");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the person's surname:");
        string surname = Console.ReadLine();

        Console.WriteLine("Enter the person's age:");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the person's weight:");
        double weight = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the person's height:");
        double height = double.Parse(Console.ReadLine());

        Person person = new Person(name, surname, age, weight, height);
        Console.WriteLine(person.ToString());
    }
}