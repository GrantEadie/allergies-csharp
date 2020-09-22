using System;
using System.Collections.Generic;
using Allergies;


namespace Allergies 
{
  public class Program 
  {
    public static void Main()
    {
      Console.WriteLine(@"
      ENTER A NUMBER AND LEARN YOUR ALLERGIES: 
      ");

      Allergen newAllergenList = new Allergen();
      int inputAllergy = int.Parse(Console.ReadLine());
      Console.WriteLine(newAllergenList.myAllergens(inputAllergy));
    }
  }
}