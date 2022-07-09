using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
    int stepsWalked;
    float feetPerStep;
    int feetPerMile;
    float stepsPerMinute;
    float calPerMinuteWalking;
    float minutesTotal;
    float caloriesTotal;
    float milesWalked;
    
    feetPerMile = 5280;
    
    // Typical adult
    feetPerStep = 2.5f;
    stepsPerMinute = 70.0f;
    calPerMinuteWalking = 3.5f;
    
    stepsWalked = 1600;
    milesWalked = stepsWalked * feetPerStep *(float)(1.0/feetPerMile);
    
    Console.WriteLine("Miles walked: " + milesWalked + "\n");
    
    minutesTotal = stepsWalked / stepsPerMinute;
    caloriesTotal = minutesTotal * calPerMinuteWalking;
    
    Console.WriteLine("Calories " + caloriesTotal + "\n");   
    }
  }
}