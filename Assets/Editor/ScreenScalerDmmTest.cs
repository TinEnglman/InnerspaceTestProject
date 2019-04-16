using NUnit.Framework;

public class ScreenScalerDmmTest
{
    [Test]
    public void ScreeneScalerDmmTest_GetScale()
    {
        float expectedResult = 2;

        IScreenScaler sceneScaler = new ScreenScalerDmm();
        float distance = 2;

        float result = sceneScaler.GetScale(distance);

        Assert.AreEqual(result, expectedResult);
    }
}
