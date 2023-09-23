using DotNetFreeStyleProject.Controllers;
namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Maths m = new Maths();           
            Assert.AreEqual(3,m.Add(1, 2));
        }
    }
}