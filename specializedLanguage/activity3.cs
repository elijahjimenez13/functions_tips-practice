using System;

namespace MyApplication
{
  class Program
  {
    static float ConvKilometersToMiles(float numKilometers)
    {
    float numMiles;
    float milesPerKm;
    
    milesPerKm = 0.621371f;
    numMiles = numKilometers * milesPerKm;
    
    return numMiles;
    }
    static void Main()
    {
    float distKm;
    float distMiles;
    
    distKm = 12;
    distMiles = ConvKilometersToMiles(distKm);
    
    Console.WriteLine("Miles driven: " + distMiles);
    }
  }
}