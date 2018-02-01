using System;
using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;

namespace uk.co.mainwave.MissingTypes.Test
{
    [SuppressMessage("ReSharper", "EqualExpressionComparison")]
    [SuppressMessage("ReSharper", "ObjectCreationAsStatement")]
    [SuppressMessage("ReSharper", "UnusedVariable")]
    public class VersionNumberTests
    {
        #region Constructor tests

        [Test]
        public void TestIntConstructor()
        {
            var v = new VersionNumber(0);
            Assert.AreEqual(0, v.Part1);
            Assert.AreEqual(0, v.Part2);
            Assert.AreEqual(0, v.Part3);
            Assert.AreEqual(0, v.Part4);
            Assert.AreEqual(new uint[] { 0, 0, 0, 0 }, v.AllParts);

            v = new VersionNumber(1);
            Assert.AreEqual(1, v.Part1);
            Assert.AreEqual(0, v.Part2);
            Assert.AreEqual(0, v.Part3);
            Assert.AreEqual(0, v.Part4);
            Assert.AreEqual(new uint[] { 1, 0, 0, 0 }, v.AllParts);

            v = new VersionNumber(uint.MaxValue);
            Assert.AreEqual(uint.MaxValue, v.Part1);
            Assert.AreEqual(0, v.Part2);
            Assert.AreEqual(0, v.Part3);
            Assert.AreEqual(0, v.Part4);
            Assert.AreEqual(new uint[] { uint.MaxValue, 0, 0, 0 }, v.AllParts);

            v = new VersionNumber(uint.MinValue);
            Assert.AreEqual(uint.MinValue, v.Part1);
            Assert.AreEqual(0, v.Part2);
            Assert.AreEqual(0, v.Part3);
            Assert.AreEqual(0, v.Part4);
            Assert.AreEqual(new uint[] { uint.MinValue, 0, 0, 0 }, v.AllParts);
        }

        [Test]
        public void TestIntIntConstructor()
        {
            var v = new VersionNumber(0, 0);
            Assert.AreEqual(0, v.Part1);
            Assert.AreEqual(0, v.Part2);
            Assert.AreEqual(0, v.Part3);
            Assert.AreEqual(0, v.Part4);
            Assert.AreEqual(new uint[] { 0, 0, 0, 0 }, v.AllParts);

            v = new VersionNumber(1, 2);
            Assert.AreEqual(1, v.Part1);
            Assert.AreEqual(2, v.Part2);
            Assert.AreEqual(0, v.Part3);
            Assert.AreEqual(0, v.Part4);
            Assert.AreEqual(new uint[] { 1, 2, 0, 0 }, v.AllParts);

            v = new VersionNumber(0, uint.MaxValue);
            Assert.AreEqual(0, v.Part1);
            Assert.AreEqual(uint.MaxValue, v.Part2);
            Assert.AreEqual(0, v.Part3);
            Assert.AreEqual(0, v.Part4);
            Assert.AreEqual(new uint[] { 0, uint.MaxValue, 0, 0 }, v.AllParts);

            v = new VersionNumber(1, uint.MinValue);
            Assert.AreEqual(1, v.Part1);
            Assert.AreEqual(uint.MinValue, v.Part2);
            Assert.AreEqual(0, v.Part3);
            Assert.AreEqual(0, v.Part4);
            Assert.AreEqual(new uint[] { 1, uint.MinValue, 0, 0 }, v.AllParts);
        }

        [Test]
        public void TestIntIntIntConstructor()
        {
            var v = new VersionNumber(0, 0, 0);
            Assert.AreEqual(0, v.Part1);
            Assert.AreEqual(0, v.Part2);
            Assert.AreEqual(0, v.Part3);
            Assert.AreEqual(0, v.Part4);
            Assert.AreEqual(new uint[] { 0, 0, 0, 0 }, v.AllParts);

            v = new VersionNumber(1, 2, 3);
            Assert.AreEqual(1, v.Part1);
            Assert.AreEqual(2, v.Part2);
            Assert.AreEqual(3, v.Part3);
            Assert.AreEqual(0, v.Part4);
            Assert.AreEqual(new uint[] { 1, 2, 3, 0 }, v.AllParts);

            v = new VersionNumber(0, 0, uint.MaxValue);
            Assert.AreEqual(0, v.Part1);
            Assert.AreEqual(0, v.Part2);
            Assert.AreEqual(uint.MaxValue, v.Part3);
            Assert.AreEqual(0, v.Part4);
            Assert.AreEqual(new uint[] { 0, 0, uint.MaxValue, 0 }, v.AllParts);

            v = new VersionNumber(1, 1, uint.MinValue);
            Assert.AreEqual(1, v.Part1);
            Assert.AreEqual(1, v.Part2);
            Assert.AreEqual(uint.MinValue, v.Part3);
            Assert.AreEqual(0, v.Part4);
            Assert.AreEqual(new uint[] { 1, 1, uint.MinValue, 0 }, v.AllParts);
        }

        [Test]
        public void TestIntIntIntIntConstructor()
        {
            var v = new VersionNumber(0, 0, 0, 0);
            Assert.AreEqual(0, v.Part1);
            Assert.AreEqual(0, v.Part2);
            Assert.AreEqual(0, v.Part3);
            Assert.AreEqual(0, v.Part4);
            Assert.AreEqual(new uint[] { 0, 0, 0, 0 }, v.AllParts);

            v = new VersionNumber(1, 2, 3, 4);
            Assert.AreEqual(1, v.Part1);
            Assert.AreEqual(2, v.Part2);
            Assert.AreEqual(3, v.Part3);
            Assert.AreEqual(4, v.Part4);
            Assert.AreEqual(new uint[] { 1, 2, 3, 4 }, v.AllParts);

            v = new VersionNumber(0, 0, 0, uint.MaxValue);
            Assert.AreEqual(0, v.Part1);
            Assert.AreEqual(0, v.Part2);
            Assert.AreEqual(0, v.Part3);
            Assert.AreEqual(uint.MaxValue, v.Part4);
            Assert.AreEqual(new uint[] { 0, 0, 0, uint.MaxValue }, v.AllParts);

            v = new VersionNumber(1, 1, 1, uint.MinValue);
            Assert.AreEqual(1, v.Part1);
            Assert.AreEqual(1, v.Part2);
            Assert.AreEqual(1, v.Part3);
            Assert.AreEqual(uint.MinValue, v.Part4);
            Assert.AreEqual(new uint[] { 1, 1, 1, uint.MinValue }, v.AllParts);
        }

        [Test]
        public void TestStringConstructor()
        {
            var v = new VersionNumber("0");
            Assert.AreEqual(0, v.Part1);
            Assert.AreEqual(0, v.Part2);
            Assert.AreEqual(0, v.Part3);
            Assert.AreEqual(0, v.Part4);
            Assert.AreEqual(new uint[] { 0, 0, 0, 0 }, v.AllParts);

            v = new VersionNumber("1");
            Assert.AreEqual(1, v.Part1);
            Assert.AreEqual(0, v.Part2);
            Assert.AreEqual(0, v.Part3);
            Assert.AreEqual(0, v.Part4);
            Assert.AreEqual(new uint[] { 1, 0, 0, 0 }, v.AllParts);

            v = new VersionNumber("0.1");
            Assert.AreEqual(0, v.Part1);
            Assert.AreEqual(1, v.Part2);
            Assert.AreEqual(0, v.Part3);
            Assert.AreEqual(0, v.Part4);
            Assert.AreEqual(new uint[] { 0, 1, 0, 0 }, v.AllParts);

            v = new VersionNumber("1.2.3.4");
            Assert.AreEqual(1, v.Part1);
            Assert.AreEqual(2, v.Part2);
            Assert.AreEqual(3, v.Part3);
            Assert.AreEqual(4, v.Part4);
            Assert.AreEqual(new uint[] { 1, 2, 3, 4 }, v.AllParts);

            var s = $"{uint.MaxValue}.{uint.MaxValue}.{uint.MaxValue}.{uint.MaxValue}";
            v = new VersionNumber(s);
            Assert.AreEqual(uint.MaxValue, v.Part1);
            Assert.AreEqual(uint.MaxValue, v.Part2);
            Assert.AreEqual(uint.MaxValue, v.Part3);
            Assert.AreEqual(uint.MaxValue, v.Part4);
            Assert.AreEqual(new [] { uint.MaxValue, uint.MaxValue, uint.MaxValue, uint.MaxValue }, v.AllParts);

            Assert.Throws<NullReferenceException>(() => { new VersionNumber((string)null); });
            Assert.Throws<FormatException>(() => { new VersionNumber("hello world"); });
            Assert.Throws<FormatException>(() => { new VersionNumber(string.Empty); });
            Assert.Throws<FormatException>(() => { new VersionNumber("1.2.3.4.5"); });
        }

        [Test]
        public void TestVersionConstructor()
        {
            var v = new VersionNumber(new Version(1, 2));
            Assert.AreEqual(1, v.Part1);
            Assert.AreEqual(2, v.Part2);
            Assert.AreEqual(0, v.Part3);
            Assert.AreEqual(0, v.Part4);
            Assert.AreEqual(new uint[] { 1, 2, 0, 0 }, v.AllParts);

            v = new VersionNumber(new Version(1, 2, 3));
            Assert.AreEqual(1, v.Part1);
            Assert.AreEqual(2, v.Part2);
            Assert.AreEqual(3, v.Part3);
            Assert.AreEqual(0, v.Part4);
            Assert.AreEqual(new uint[] { 1, 2, 3, 0 }, v.AllParts);

            v = new VersionNumber(new Version(1, 2, 3, 4));
            Assert.AreEqual(1, v.Part1);
            Assert.AreEqual(2, v.Part2);
            Assert.AreEqual(3, v.Part3);
            Assert.AreEqual(4, v.Part4);
            Assert.AreEqual(new uint[] { 1, 2, 3, 4 }, v.AllParts);

            v = new VersionNumber(new Version(int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue));
            Assert.AreEqual(int.MaxValue, v.Part1);
            Assert.AreEqual(int.MaxValue, v.Part2);
            Assert.AreEqual(int.MaxValue, v.Part3);
            Assert.AreEqual(int.MaxValue, v.Part4);
            Assert.AreEqual(new uint[] { int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue }, v.AllParts);

            Assert.Throws<NullReferenceException>(() => { new VersionNumber((Version)null); });
        }

        #endregion

        #region ToString tests

        [Test]
        public void TestToShortString()
        {
            Assert.AreEqual("1", new VersionNumber(1).ToShortString());
            Assert.AreEqual("0.1", new VersionNumber(0, 1).ToShortString());
            Assert.AreEqual("0.0.1", new VersionNumber(0, 0, 1).ToShortString());
            Assert.AreEqual("0.0.0.1", new VersionNumber(0, 0, 0, 1).ToShortString());
            Assert.AreEqual("1.0.0.1", new VersionNumber(1, 0, 0, 1).ToShortString());
            Assert.AreEqual("0.1.0.1", new VersionNumber(0, 1, 0, 1).ToShortString());
            Assert.AreEqual("0.0.1.1", new VersionNumber(0, 0, 1, 1).ToShortString());
            Assert.AreEqual(string.Empty, new VersionNumber(0).ToShortString());
        }

        [Test]
        public void TestToLongString()
        {
            Assert.AreEqual("1.0.0.0", new VersionNumber(1).ToLongString());
            Assert.AreEqual("0.1.0.0", new VersionNumber(0, 1).ToLongString());
            Assert.AreEqual("0.0.1.0", new VersionNumber(0, 0, 1).ToLongString());
            Assert.AreEqual("0.0.0.1", new VersionNumber(0, 0, 0, 1).ToLongString());
            Assert.AreEqual("1.0.0.1", new VersionNumber(1, 0, 0, 1).ToLongString());
            Assert.AreEqual("0.1.0.1", new VersionNumber(0, 1, 0, 1).ToLongString());
            Assert.AreEqual("0.0.1.1", new VersionNumber(0, 0, 1, 1).ToLongString());
            Assert.AreEqual("0.0.0.0", new VersionNumber(0).ToLongString());
        }

        [Test]
        public void TestToString()
        {
            Assert.AreEqual("1.0.0.0", new VersionNumber(1).ToString());
            Assert.AreEqual("0.1.0.0", new VersionNumber(0, 1).ToString());
            Assert.AreEqual("0.0.1.0", new VersionNumber(0, 0, 1).ToString());
            Assert.AreEqual("0.0.0.1", new VersionNumber(0, 0, 0, 1).ToString());
            Assert.AreEqual("1.0.0.1", new VersionNumber(1, 0, 0, 1).ToString());
            Assert.AreEqual("0.1.0.1", new VersionNumber(0, 1, 0, 1).ToString());
            Assert.AreEqual("0.0.1.1", new VersionNumber(0, 0, 1, 1).ToString());
            Assert.AreEqual("0.0.0.0", new VersionNumber(0).ToString());
        }

        #endregion

        #region Equal operator tests

        [Test]
        public void TestEqualOperatorVersionNumber()
        {
            Assert.IsTrue(new VersionNumber(1) == new VersionNumber(1));
            Assert.IsTrue(new VersionNumber(1) == new VersionNumber(1, 0));
            Assert.IsTrue(new VersionNumber(1) == new VersionNumber(1, 0, 0));
            Assert.IsTrue(new VersionNumber(1) == new VersionNumber(1, 0, 0, 0));

            Assert.IsTrue(new VersionNumber(1, 0) == new VersionNumber(1));
            Assert.IsTrue(new VersionNumber(1, 0) == new VersionNumber(1, 0));
            Assert.IsTrue(new VersionNumber(1, 0) == new VersionNumber(1, 0, 0));
            Assert.IsTrue(new VersionNumber(1, 0) == new VersionNumber(1, 0, 0, 0));

            Assert.IsTrue(new VersionNumber(1, 0, 0) == new VersionNumber(1));
            Assert.IsTrue(new VersionNumber(1, 0, 0) == new VersionNumber(1, 0));
            Assert.IsTrue(new VersionNumber(1, 0, 0) == new VersionNumber(1, 0, 0));
            Assert.IsTrue(new VersionNumber(1, 0, 0) == new VersionNumber(1, 0, 0, 0));

            Assert.IsTrue(new VersionNumber(1, 0, 0, 0) == new VersionNumber(1));
            Assert.IsTrue(new VersionNumber(1, 0, 0, 0) == new VersionNumber(1, 0));
            Assert.IsTrue(new VersionNumber(1, 0, 0, 0) == new VersionNumber(1, 0, 0));
            Assert.IsTrue(new VersionNumber(1, 0, 0, 0) == new VersionNumber(1, 0, 0, 0));

            var v1 = new VersionNumber(1);
            var v2 = v1;
            Assert.IsTrue(v1 == v2);
            Assert.IsFalse(new VersionNumber(1) == new VersionNumber(2));
            Assert.IsFalse(new VersionNumber(1) == (VersionNumber)null);
            // ReSharper disable once RedundantCast
            Assert.IsTrue((VersionNumber)null == (VersionNumber)null);
        }

        [Test]
        public void TestEqualOperatorVersion()
        {
            Assert.IsTrue(new VersionNumber(1) == new Version(1, 0));
            Assert.IsTrue(new VersionNumber(1) == new Version(1, 0, 0));
            Assert.IsTrue(new VersionNumber(1) == new Version(1, 0, 0, 0));

            Assert.IsTrue(new VersionNumber(1, 0) == new Version(1, 0));
            Assert.IsTrue(new VersionNumber(1, 0) == new Version(1, 0, 0));
            Assert.IsTrue(new VersionNumber(1, 0) == new Version(1, 0, 0, 0));

            Assert.IsTrue(new VersionNumber(1, 0, 0) == new Version(1, 0));
            Assert.IsTrue(new VersionNumber(1, 0, 0) == new Version(1, 0, 0));
            Assert.IsTrue(new VersionNumber(1, 0, 0) == new Version(1, 0, 0, 0));

            Assert.IsTrue(new VersionNumber(1, 0, 0, 0) == new Version(1, 0));
            Assert.IsTrue(new VersionNumber(1, 0, 0, 0) == new Version(1, 0, 0));
            Assert.IsTrue(new VersionNumber(1, 0, 0, 0) == new Version(1, 0, 0, 0));

            Assert.IsFalse(new VersionNumber(1) == new Version(2, 0));
            Assert.IsFalse(new VersionNumber(1) == (Version)null);
            Assert.IsFalse((VersionNumber)null == (Version)null);
        }

        [Test]
        public void TestEqualOperatorUint()
        {
            Assert.IsTrue(new VersionNumber(1) == 1);
            Assert.IsTrue(new VersionNumber(1, 0) == 1);
            Assert.IsTrue(new VersionNumber(1, 0, 0) == 1);
            Assert.IsTrue(new VersionNumber(1, 0, 0, 0) == 1);

            Assert.IsFalse(new VersionNumber(1, 0, 0, 0) == 2);
        }

        [Test]
        public void TestEqualOperatorString()
        {
            Assert.IsTrue(new VersionNumber(1) == "1");
            Assert.IsTrue(new VersionNumber(1) == "1.0");
            Assert.IsTrue(new VersionNumber(1) == "1.0.0");
            Assert.IsTrue(new VersionNumber(1) == "1.0.0.0");

            Assert.IsTrue(new VersionNumber(1, 0) == "1");
            Assert.IsTrue(new VersionNumber(1, 0) == "1.0");
            Assert.IsTrue(new VersionNumber(1, 0) == "1.0.0");
            Assert.IsTrue(new VersionNumber(1, 0) == "1.0.0.0");

            Assert.IsTrue(new VersionNumber(1, 0, 0) == "1");
            Assert.IsTrue(new VersionNumber(1, 0, 0) == "1.0");
            Assert.IsTrue(new VersionNumber(1, 0, 0) == "1.0.0");
            Assert.IsTrue(new VersionNumber(1, 0, 0) == "1.0.0.0");

            Assert.IsTrue(new VersionNumber(1, 0, 0, 0) == "1");
            Assert.IsTrue(new VersionNumber(1, 0, 0, 0) == "1.0");
            Assert.IsTrue(new VersionNumber(1, 0, 0, 0) == "1.0.0");
            Assert.IsTrue(new VersionNumber(1, 0, 0, 0) == "1.0.0.0");

            // ReSharper disable once UnusedVariable
            Assert.Throws<FormatException>(() => { var val = new VersionNumber("1.2.3.4") == string.Empty; });
            Assert.IsFalse(new VersionNumber(1) == "2");
            Assert.IsFalse(new VersionNumber("1.2.3.4") == (string)null);
            Assert.IsFalse((VersionNumber)null == (string)null);
        }

        #endregion

        #region Not-equal operator tests

        [Test]
        public void TestNotEqualOperatorVersionNumber()
        {
            Assert.IsFalse(new VersionNumber(1) != new VersionNumber(1));
            Assert.IsFalse(new VersionNumber(1) != new VersionNumber(1, 0));
            Assert.IsFalse(new VersionNumber(1) != new VersionNumber(1, 0, 0));
            Assert.IsFalse(new VersionNumber(1) != new VersionNumber(1, 0, 0, 0));

            Assert.IsFalse(new VersionNumber(1, 0) != new VersionNumber(1));
            Assert.IsFalse(new VersionNumber(1, 0) != new VersionNumber(1, 0));
            Assert.IsFalse(new VersionNumber(1, 0) != new VersionNumber(1, 0, 0));
            Assert.IsFalse(new VersionNumber(1, 0) != new VersionNumber(1, 0, 0, 0));

            Assert.IsFalse(new VersionNumber(1, 0, 0) != new VersionNumber(1));
            Assert.IsFalse(new VersionNumber(1, 0, 0) != new VersionNumber(1, 0));
            Assert.IsFalse(new VersionNumber(1, 0, 0) != new VersionNumber(1, 0, 0));
            Assert.IsFalse(new VersionNumber(1, 0, 0) != new VersionNumber(1, 0, 0, 0));

            Assert.IsFalse(new VersionNumber(1, 0, 0, 0) != new VersionNumber(1));
            Assert.IsFalse(new VersionNumber(1, 0, 0, 0) != new VersionNumber(1, 0));
            Assert.IsFalse(new VersionNumber(1, 0, 0, 0) != new VersionNumber(1, 0, 0));
            Assert.IsFalse(new VersionNumber(1, 0, 0, 0) != new VersionNumber(1, 0, 0, 0));

            Assert.IsTrue(new VersionNumber(1) != new VersionNumber(2));
        }

        [Test]
        public void TestNotEqualOperatorVersion()
        {
            Assert.IsFalse(new VersionNumber(1) != new Version(1, 0));
            Assert.IsFalse(new VersionNumber(1) != new Version(1, 0, 0));
            Assert.IsFalse(new VersionNumber(1) != new Version(1, 0, 0, 0));

            Assert.IsFalse(new VersionNumber(1, 0) != new Version(1, 0));
            Assert.IsFalse(new VersionNumber(1, 0) != new Version(1, 0, 0));
            Assert.IsFalse(new VersionNumber(1, 0) != new Version(1, 0, 0, 0));

            Assert.IsFalse(new VersionNumber(1, 0, 0) != new Version(1, 0));
            Assert.IsFalse(new VersionNumber(1, 0, 0) != new Version(1, 0, 0));
            Assert.IsFalse(new VersionNumber(1, 0, 0) != new Version(1, 0, 0, 0));

            Assert.IsFalse(new VersionNumber(1, 0, 0, 0) != new Version(1, 0));
            Assert.IsFalse(new VersionNumber(1, 0, 0, 0) != new Version(1, 0, 0));
            Assert.IsFalse(new VersionNumber(1, 0, 0, 0) != new Version(1, 0, 0, 0));

            Assert.IsTrue(new VersionNumber(1) != new Version(2, 0));
        }

        [Test]
        public void TestNotEqualOperatorUint()
        {
            Assert.IsFalse(new VersionNumber(1) != 1);
            Assert.IsFalse(new VersionNumber(1, 0) != 1);
            Assert.IsFalse(new VersionNumber(1, 0, 0) != 1);
            Assert.IsFalse(new VersionNumber(1, 0, 0, 0) != 1);

            Assert.IsTrue(new VersionNumber(1, 0, 0, 0) != 2);
        }

        [Test]
        public void TestNotEqualOperatorString()
        {
            Assert.IsFalse(new VersionNumber(1) != "1");
            Assert.IsFalse(new VersionNumber(1) != "1.0");
            Assert.IsFalse(new VersionNumber(1) != "1.0.0");
            Assert.IsFalse(new VersionNumber(1) != "1.0.0.0");

            Assert.IsFalse(new VersionNumber(1, 0) != "1");
            Assert.IsFalse(new VersionNumber(1, 0) != "1.0");
            Assert.IsFalse(new VersionNumber(1, 0) != "1.0.0");
            Assert.IsFalse(new VersionNumber(1, 0) != "1.0.0.0");

            Assert.IsFalse(new VersionNumber(1, 0, 0) != "1");
            Assert.IsFalse(new VersionNumber(1, 0, 0) != "1.0");
            Assert.IsFalse(new VersionNumber(1, 0, 0) != "1.0.0");
            Assert.IsFalse(new VersionNumber(1, 0, 0) != "1.0.0.0");

            Assert.IsFalse(new VersionNumber(1, 0, 0, 0) != "1");
            Assert.IsFalse(new VersionNumber(1, 0, 0, 0) != "1.0");
            Assert.IsFalse(new VersionNumber(1, 0, 0, 0) != "1.0.0");
            Assert.IsFalse(new VersionNumber(1, 0, 0, 0) != "1.0.0.0");

            Assert.IsTrue(new VersionNumber(1) != "2");
            Assert.Throws<FormatException>(() => { var val = new VersionNumber("1.2.3.4") != string.Empty; });
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            Assert.Throws<NullReferenceException>(() => { var val = new VersionNumber("1.2.3.4") != (string)null; });
        }

        #endregion

        #region Equals method tests

        [Test]
        public void TestEqualsMethodVersionNumber()
        {
            Assert.IsTrue(new VersionNumber(1).Equals(new VersionNumber(1)));
            Assert.IsTrue(new VersionNumber(1).Equals(new VersionNumber(1, 0)));
            Assert.IsTrue(new VersionNumber(1).Equals(new VersionNumber(1, 0, 0)));
            Assert.IsTrue(new VersionNumber(1).Equals(new VersionNumber(1, 0, 0, 0)));

            Assert.IsTrue(new VersionNumber(1, 0).Equals(new VersionNumber(1)));
            Assert.IsTrue(new VersionNumber(1, 0).Equals(new VersionNumber(1, 0)));
            Assert.IsTrue(new VersionNumber(1, 0).Equals(new VersionNumber(1, 0, 0)));
            Assert.IsTrue(new VersionNumber(1, 0).Equals(new VersionNumber(1, 0, 0, 0)));

            Assert.IsTrue(new VersionNumber(1, 0, 0).Equals(new VersionNumber(1)));
            Assert.IsTrue(new VersionNumber(1, 0, 0).Equals(new VersionNumber(1, 0)));
            Assert.IsTrue(new VersionNumber(1, 0, 0).Equals(new VersionNumber(1, 0, 0)));
            Assert.IsTrue(new VersionNumber(1, 0, 0).Equals(new VersionNumber(1, 0, 0, 0)));

            Assert.IsTrue(new VersionNumber(1, 0, 0, 0).Equals(new VersionNumber(1)));
            Assert.IsTrue(new VersionNumber(1, 0, 0, 0).Equals(new VersionNumber(1, 0)));
            Assert.IsTrue(new VersionNumber(1, 0, 0, 0).Equals(new VersionNumber(1, 0, 0)));
            Assert.IsTrue(new VersionNumber(1, 0, 0, 0).Equals(new VersionNumber(1, 0, 0, 0)));

            Assert.IsFalse(new VersionNumber(1).Equals(new VersionNumber(2)));
        }

        [Test]
        public void TestEqualsMethodVersion()
        {
            Assert.IsTrue(new VersionNumber(1).Equals(new Version(1, 0)));
            Assert.IsTrue(new VersionNumber(1).Equals(new Version(1, 0, 0)));
            Assert.IsTrue(new VersionNumber(1).Equals(new Version(1, 0, 0, 0)));

            Assert.IsTrue(new VersionNumber(1, 0).Equals(new Version(1, 0)));
            Assert.IsTrue(new VersionNumber(1, 0).Equals(new Version(1, 0, 0)));
            Assert.IsTrue(new VersionNumber(1, 0).Equals(new Version(1, 0, 0, 0)));

            Assert.IsTrue(new VersionNumber(1, 0, 0).Equals(new Version(1, 0)));
            Assert.IsTrue(new VersionNumber(1, 0, 0).Equals(new Version(1, 0, 0)));
            Assert.IsTrue(new VersionNumber(1, 0, 0).Equals(new Version(1, 0, 0, 0)));

            Assert.IsTrue(new VersionNumber(1, 0, 0, 0).Equals(new Version(1, 0)));
            Assert.IsTrue(new VersionNumber(1, 0, 0, 0).Equals(new Version(1, 0, 0)));
            Assert.IsTrue(new VersionNumber(1, 0, 0, 0).Equals(new Version(1, 0, 0, 0)));

            Assert.IsFalse(new VersionNumber(1).Equals(new Version(2, 0)));
        }

        [Test]
        public void TestEqualsMethodUint()
        {
            Assert.IsTrue(new VersionNumber(1).Equals(1));
            Assert.IsTrue(new VersionNumber(1, 0).Equals(1));
            Assert.IsTrue(new VersionNumber(1, 0, 0).Equals(1));
            Assert.IsTrue(new VersionNumber(1, 0, 0, 0).Equals(1));

            Assert.IsFalse(new VersionNumber(1).Equals(2));
        }

        [Test]
        public void TestEqualsMethodString()
        {
            Assert.IsTrue(new VersionNumber(1).Equals("1"));
            Assert.IsTrue(new VersionNumber(1).Equals("1.0"));
            Assert.IsTrue(new VersionNumber(1).Equals("1.0.0"));
            Assert.IsTrue(new VersionNumber(1).Equals("1.0.0.0"));

            Assert.IsTrue(new VersionNumber(1, 0).Equals("1"));
            Assert.IsTrue(new VersionNumber(1, 0).Equals("1.0"));
            Assert.IsTrue(new VersionNumber(1, 0).Equals("1.0.0"));
            Assert.IsTrue(new VersionNumber(1, 0).Equals("1.0.0.0"));

            Assert.IsTrue(new VersionNumber(1, 0, 0).Equals("1"));
            Assert.IsTrue(new VersionNumber(1, 0, 0).Equals("1.0"));
            Assert.IsTrue(new VersionNumber(1, 0, 0).Equals("1.0.0"));
            Assert.IsTrue(new VersionNumber(1, 0, 0).Equals("1.0.0.0"));

            Assert.IsTrue(new VersionNumber(1, 0, 0, 0).Equals("1"));
            Assert.IsTrue(new VersionNumber(1, 0, 0, 0).Equals("1.0"));
            Assert.IsTrue(new VersionNumber(1, 0, 0, 0).Equals("1.0.0"));
            Assert.IsTrue(new VersionNumber(1, 0, 0, 0).Equals("1.0.0.0"));

            Assert.IsFalse(new VersionNumber(1).Equals("2"));
            Assert.Throws<FormatException>(() => { var val = new VersionNumber("1.2.3.4").Equals(string.Empty); });
            Assert.Throws<NullReferenceException>(() => { var val = new VersionNumber("1.2.3.4").Equals((string)null); });
        }

        #endregion
        
        [Test]
        public void TestEverything()
        {
            Assert.IsTrue(new VersionNumber(1, 2, 3, 4) == new VersionNumber("1.2.3.4"));
            Assert.IsTrue(new VersionNumber(1, 2, 3, 4).Equals(new VersionNumber("1.2.3.4")));
            Assert.IsTrue(new VersionNumber(1, 2, 3, 4) == "1.2.3.4");
            Assert.IsTrue(new VersionNumber(1, 2, 3, 4).Equals("1.2.3.4"));
            Assert.IsTrue(new VersionNumber(1) == 1);
            Assert.IsTrue(new VersionNumber(1).Equals(1));

            Assert.IsTrue(new VersionNumber(1, 2, 3, 4) != new VersionNumber("1.2.3.5"));
            Assert.IsTrue(new VersionNumber(1, 2, 3, 4) != "1.2.3.5");
            Assert.IsTrue(new VersionNumber(1, 2, 3, 4) != 1);

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

            Assert.Throws<FormatException>(() => { var val = new VersionNumber("1.2.3.4") > string.Empty; });
            Assert.Throws<FormatException>(() => { var val = new VersionNumber("1.2.3.4") < string.Empty; });
            Assert.Throws<FormatException>(() => { var val = new VersionNumber("1.2.3.4") >= string.Empty; });
            Assert.Throws<FormatException>(() => { var val = new VersionNumber("1.2.3.4") <= string.Empty; });
            Assert.Throws<NullReferenceException>(() => { var val = new VersionNumber("1.2.3.4") > (string)null; });
            Assert.Throws<NullReferenceException>(() => { var val = new VersionNumber("1.2.3.4") < (string)null; });
            Assert.Throws<NullReferenceException>(() => { var val = new VersionNumber("1.2.3.4") >= (string)null; });
            Assert.Throws<NullReferenceException>(() => { var val = new VersionNumber("1.2.3.4") <= (string)null; });
        }

    }
}