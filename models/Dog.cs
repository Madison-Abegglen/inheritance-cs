using System;

namespace inheritance.Models
{
  public class Dog
  {
    public bool Tail { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }


    public virtual void Speak()
    {
      Console.WriteLine("Bark");
    }

    public void Eat(string food)
    {

      if (food != "dogfood")
      {
        Console.WriteLine("BARF");
      }
    }

    public Dog(bool tail, string name, int age)
    {
      Tail = tail;
      Name = name;
      Age = age;
    }
  }
}