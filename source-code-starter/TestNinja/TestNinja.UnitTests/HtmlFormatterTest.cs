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
    class HtmlFormatterTest
    {
        [Test]
        public void FormatAsBold_WhenCalled_ReturnsStringWithStrongEncluser()
        {
            var htmlFormatter = new HtmlFormatter();

            var result = htmlFormatter.FormatAsBold("Hello World");

            Assert.That(result, Does.StartWith("<strong>"));
            Assert.That(result, Does.EndWith("</strong>"));
        }
    }
}
