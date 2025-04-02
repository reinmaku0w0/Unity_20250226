
using System.Collections.Generic;

public class CsharpPractice
{
  public int Add(int a, int b)
  {
    return a + b;
  }

  private Dictionary<string , string> localizationTexts = new Dictionary<string , string>() { };
  public string localizationTexts(string key)
  {
    var value = localizationTexts[key];
    return value;
  }

}
