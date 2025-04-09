
using NUnit.Framework;

public class ScriptTests
{
    [Test(Description = "測試兩個數字相加")]
    [TestCase(2, 2, 4)]
    [TestCase(4, 4, 8)]
    public void Add_Two_Number(int a, int b, int expected)
    {
        //建立變數
        CsharpPractice timeConverter = new CsharpPractice();
        //呼叫方法
        int result = timeConverter.Add(a,b);
        //驗證結果
        Assert.AreEqual(expected, actual: result);
    }

    [Test(Description = "取得語言本地化文字")]
    [TestCase(CsharpPractice.Language.英轉中,  "Apple" ,"蘋果")]
    [TestCase(CsharpPractice.Language.英轉中,  "Banana" ,"香蕉")]
    [TestCase(CsharpPractice.Language.中轉英 , "蘋果" ,"Apple")]
    [TestCase(CsharpPractice.Language.中轉英 , "香蕉" ,"Banana")]
    public void GetLocalizationText(CsharpPractice.Language language, string key, string expectedText)
    {
        //建立變數
        var csharpPractice = new CsharpPractice();
        //呼叫方法
        var    text = csharpPractice.GetLocalizationText(language , key);
        //驗證結果
        Assert.AreEqual(expectedText , text);
    }
}
