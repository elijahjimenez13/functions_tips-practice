using System;

namespace MyApplication
{
  class Program
  {
    static float CircleArea(float circleDiameter)
    {
    float circleRadius;
    float piVal;
    float circleArea;
    
    piVal = 3.14159265f;
    circleRadius = circleDiameter / 2.0f;
    circleArea = piVal * circleRadius * circleRadius;
    
    return circleArea;
    }
    static void Main()
    {
    float pizzaDiameter1;
    float pizzaDiameter2;
    float totalPizzaArea;
    float circleRadius1;
    float circleRadius2;
    float circleArea1;
    float circleArea2;
    float piVal;
    
    piVal = 3.14159265f;
    pizzaDiameter1 = 12.0f;
    circleRadius1 = pizzaDiameter1 / 2.0f;
    circleArea1 = piVal * circleRadius1 * circleRadius1;
    
    pizzaDiameter2 = 14.0f;
    circleRadius2 = pizzaDiameter2 / 2.0f;
    circleArea2 = piVal * circleRadius2 * circleRadius2;
    
    totalPizzaArea = circleArea1 * circleArea2;
    Console.WriteLine("A 12 and 14 inch pizza has " + totalPizzaArea + " inches squared combined.");
    }
  }
}