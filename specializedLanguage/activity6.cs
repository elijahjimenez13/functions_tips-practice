using System;

namespace MyApplication
{
  class Program
  {
	static void PrintPizzaVolume(float pizzaDiameter, float pizzaHeight)
    {
    float pizzaRadius;
    float piVal;
    float pizzaArea;
    float pizzaVolume;
    
    piVal = 3.14159265f;
    pizzaRadius = pizzaDiameter / 2.0f;
    pizzaArea = piVal * pizzaRadius * pizzaRadius;
    pizzaVolume = pizzaArea * pizzaHeight;
    
    Console.WriteLine(pizzaDiameter + " x " + pizzaHeight + " inch pizza is " + pizzaVolume + " inches cubed.\n");
    }
    static void Main()
    {
	PrintPizzaVolume(12.0f, 0.3f);
    PrintPizzaVolume(12.0f, 0.8f);
    PrintPizzaVolume(16.0f, 0.8f);
    }
  }
}