using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class MathTests
    {
        private Fundamentals.Math _math;

        [SetUp]
        public void SetUp() 
        {
            _math = new Fundamentals.Math();
        }

        [Test]
        [Ignore("Becouse I wanted to")]
        public void Add_WhenCalled_ReturnSumOfArguments() 
        {

            var result = _math.Add(1,2);

            Assert.That(result, Is.EqualTo(3));

        }
        [Test]
        [TestCase(2,1,2)]
        [TestCase(1, 2, 2)]
        [TestCase(2, 2, 2)]
        public void Max_WhenCalled_ReturnsGreaterValue(int a, int b, int expectedReturn)
        {
            var result = _math.Max(a,b);
            Assert.That(result, Is.EqualTo(expectedReturn));
        }
    }
}
