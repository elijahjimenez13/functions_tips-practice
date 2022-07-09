using System;

namespace MyApplication
{
  class Program
  {
    static void PrintPizzaArea(float pizzaDiameter)
    {
    float pizzaRadius;
    float piVal;
    float pizzaArea;
    
    piVal = 3.14159265f;
    pizzaRadius = pizzaDiameter / 2.0f;
    pizzaArea = piVal * pizzaRadius * pizzaRadius;
    
    Console.WriteLine(pizzaDiameter + " in. pizza is " + pizzaArea + " sq. in.\n");
    }
    static void Main()
    {
	PrintPizzaArea(12);
    }
  }
}