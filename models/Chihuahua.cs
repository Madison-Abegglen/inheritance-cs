using System;

namespace inheritance.Models
{
  public class Chihuahua : Dog
  {
    public bool Brave { get; set; }
    public override void Speak()
    {
      Console.WriteLine("Yip");
    }
    public Chihuahua(bool tail, string name, int age, bool brave) : base(tail, name, age)
    {
      Brave = false;
    }
  }
}