using System;

namespace MyApplication
{
  class Program
  {
    static float StepsToMiles(int numSteps)
    {
    float milesTotal;
    float feetPerStep;
    int feetPerMile;
    
    feetPerMile = 5280;
    
    // Typical adult
    feetPerStep = 2.5f;
    
    milesTotal = numSteps * feetPerStep *(float)(1.0/feetPerMile);
    
    return milesTotal;
    }
    static float StepsToCalories(int numSteps)
    {
    float caloriesTotal;
    float stepsPerMinute;
    float calPerMinuteWalking;
    float minutesTotal;
    
    // Typical adult
    stepsPerMinute = 70.0f;
    calPerMinuteWalking = 3.5f;
    
    minutesTotal = numSteps / stepsPerMinute;
    caloriesTotal = minutesTotal * calPerMinuteWalking;
    
    return caloriesTotal;
    }
    static void Main()
    {
    int stepsWalked;
    
    stepsWalked = 1600;
    
    Console.WriteLine("Miles walked: " + StepsToMiles(stepsWalked) + "\n" + "Calories: " + StepsToCalories(stepsWalked) + "\n");
    }
  }
}