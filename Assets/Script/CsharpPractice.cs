
using System.Collections.Generic;

public class CsharpPractice
{
  public int Add(int a, int b)
  {
    return a + b;
  }
  
  //英轉中
  private Dictionary<string , string> localizationTexts_EnglishToChinese = new Dictionary<string , string>()
  {
    {"Apple" ,"蘋果"}, {"Banana" , "香蕉"} ,
  };

  //中轉英
  private Dictionary<string , string> localizationTexts_ChineseToEnglish = new Dictionary<string , string>()
  {
    { "蘋果" , "Apple" } , { "香蕉" , "Banana" } ,
  };

  public enum Language
  {
    英轉中 = 0,
    中轉英 = 10,
  }
  public string GetLocalizationText(Language language ,string key)
  {
    if (language == Language.英轉中)
    {
      return localizationTexts_EnglishToChinese[key];
    }
    else if (language == Language.中轉英)
    {
      return localizationTexts_ChineseToEnglish[key];
    }
    //丟出錯誤
    return "";
  }
  
}
