using System;
using System.Collections.Generic;
using System.Linq;

namespace Allergies
{
  public class Allergen
  {

    public string myAllergens(int inputNum)
    {

      Dictionary<int, string> dictOfAllergens = new Dictionary<int, string>(){{1, "eggs"}, {2, "peanuts"}, {4, "shellfish"}, {8, "strawberries"}, {16, "tomatoes"}, {32, "chocolate"}, {64, "pollen"}, {128, "cats"}};

      List<string> allergyList = new List<string> {};
      
      for (int i = dictOfAllergens.Count - 1; i >= 0; i--)
      {
        if (dictOfAllergens.ElementAt(i).Key <= inputNum) 
        {
          allergyList.Add(dictOfAllergens.ElementAt(i).Value);
          inputNum = inputNum - dictOfAllergens.ElementAt(i).Key; 
        }
      }
      string output = string.Join(", ", allergyList);
      return output;
    }
  }
}