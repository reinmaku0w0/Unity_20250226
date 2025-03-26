
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
}
