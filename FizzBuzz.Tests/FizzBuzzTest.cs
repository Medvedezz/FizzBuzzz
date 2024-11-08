using FizzBuzz;
using FizzBuzz.Project;


namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzTest
    {
        private FizzBuzzClass fizzBuzz = new();

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("FizzBuzz", fizzBuzz.play(15));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("Buzz", fizzBuzz.play(3));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("Fizz", fizzBuzz.play(5));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual("4", fizzBuzz.play(4));
        }
    }
}