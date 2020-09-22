using Microsoft.VisualStudio.TestTools.UnitTesting;
using Allergies;

namespace Allergies.Tests
{
  [TestClass]
  public class AllergenTests
  {
    [TestMethod]
    public void ListOfAllergies_CreatesInstanceOfDictionary_Index()
    {
      Allergen newAllergenList = new Allergen();
      Assert.AreEqual("eggs", newAllergenList.myAllergens(1));
    }
  }
}