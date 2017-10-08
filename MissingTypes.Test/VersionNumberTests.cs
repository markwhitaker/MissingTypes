using System;
using NUnit.Framework;

namespace uk.co.mainwave.MissingTypes.Test
{
    public class VersionNumberTests
    {
        [Test]
        public void TestEverything()
        {
            Assert.AreEqual(new VersionNumber(3).ToShortString(), "3");
            Assert.AreEqual(new VersionNumber(3).ToLongString(), "3.0.0.0");
            Assert.AreEqual(new VersionNumber(3).ToString(), "3.0.0.0");

            Assert.IsTrue(new VersionNumber(1, 2, 3, 4) == new VersionNumber("1.2.3.4"));
            Assert.IsTrue(new VersionNumber(1, 2, 3, 4).Equals(new VersionNumber("1.2.3.4")));
            Assert.IsTrue(new VersionNumber(1, 2, 3, 4) == "1.2.3.4");
            Assert.IsTrue(new VersionNumber(1, 2, 3, 4).Equals("1.2.3.4"));
            Assert.IsTrue(new VersionNumber(1) == 1);
            Assert.IsTrue(new VersionNumber(1).Equals(1));

            Assert.IsTrue(new VersionNumber(1, 2, 3, 4) != new VersionNumber("1.2.3.5"));
            Assert.IsTrue(new VersionNumber(1, 2, 3, 4) != "1.2.3.5");
            Assert.IsTrue(new VersionNumber(1, 2, 3, 4) != 1);
            Assert.IsTrue(new VersionNumber(1, 2, 3, 4) != (VersionNumber)null);
            Assert.IsTrue(new VersionNumber(1, 2, 3, 4) != (string)null);

            Assert.IsTrue(new VersionNumber(1, 2, 3, 4) > new VersionNumber("1.2.3.3"));
            Assert.IsTrue(new VersionNumber(1, 2, 3, 4) > "1.2.3.3");
            Assert.IsTrue(new VersionNumber(1, 2, 3, 4) > "1.2.3");
            Assert.IsTrue(new VersionNumber(1, 2, 3, 4) > "1.2");
            Assert.IsTrue(new VersionNumber(1, 2, 3, 4) > "1");
            Assert.IsTrue(new VersionNumber(1, 2, 3, 4) > 1);

            Assert.IsTrue(new VersionNumber(1, 2, 3, 4) < new VersionNumber("1.2.3.5"));
            Assert.IsTrue(new VersionNumber(1, 2, 3, 4) < "1.2.3.5");
            Assert.IsTrue(new VersionNumber(1, 2, 3, 4) < "1.2.4");
            Assert.IsTrue(new VersionNumber(1, 2, 3, 4) < "1.3");
            Assert.IsTrue(new VersionNumber(1, 2, 3, 4) < "2");
            Assert.IsTrue(new VersionNumber(1, 2, 3, 4) < 2);

            Assert.Throws<Exception>(() => { new VersionNumber(); });
            Assert.Throws<Exception>(() => { new VersionNumber((string)null); });
            Assert.Throws<Exception>(() => { new VersionNumber((int[])null); });
            Assert.Throws<Exception>(() => { new VersionNumber("hello world"); });
            Assert.Throws<Exception>(() => { new VersionNumber(string.Empty); });
            Assert.Throws<Exception>(() => { new VersionNumber("1.2.3.4.5"); });
            Assert.Throws<Exception>(() => { var val = new VersionNumber("1.2.3.4") > string.Empty; });
            Assert.Throws<Exception>(() => { var val = new VersionNumber("1.2.3.4") < string.Empty; });
            Assert.Throws<Exception>(() => { var val = new VersionNumber("1.2.3.4") >= string.Empty; });
            Assert.Throws<Exception>(() => { var val = new VersionNumber("1.2.3.4") <= string.Empty; });
            Assert.Throws<Exception>(() => { var val = new VersionNumber("1.2.3.4") > (string)null; });
            Assert.Throws<Exception>(() => { var val = new VersionNumber("1.2.3.4") < (string)null; });
            Assert.Throws<Exception>(() => { var val = new VersionNumber("1.2.3.4") >= (string)null; });
            Assert.Throws<Exception>(() => { var val = new VersionNumber("1.2.3.4") <= (string)null; });
        }

    }
}