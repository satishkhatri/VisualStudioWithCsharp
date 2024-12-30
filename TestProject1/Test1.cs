namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void CalculateTestMethod1()
        {
            const float expectedresult = 4;
            const float xValue = 2;
            const float yValue = 2;
            float answer = ClassLibrary1.Calculator.add(xValue, yValue);
            Assert.AreEqual(expectedresult, answer);
        }
        [TestMethod]
        public void CalculateSubstraction() {
        
        const float expectedresult = 0;
            const float xValue = 2;
            const float yValue = 2;
            float answer= ClassLibrary1.Calculator.sub(xValue,yValue);
            Assert.AreEqual(expectedresult, answer);
        }
    }
}
