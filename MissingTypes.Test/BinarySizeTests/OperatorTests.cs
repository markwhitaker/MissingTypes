using System;
using NUnit.Framework;

namespace uk.co.mainwave.MissingTypes.Test.BinarySizeTests
{
    public class OperatorTests
    {
        #region Conversion operator

        [Test]
        public void TestConversionOperatorZero()
        {
            BinarySize b = (BinarySize)0;

            Assert.AreEqual(0, b.ToBytes);
            Assert.AreEqual(0M, b.ToKbAsDecimal);
        }

        [Test]
        public void TestConversionOperator1Kb()
        {
            BinarySize b = (BinarySize)1024;

            Assert.AreEqual(1024, b.ToBytes);
        }

        [Test]
        public void TestConversionOperatorMazimum()
        {
            BinarySize b = (BinarySize)ulong.MaxValue;

            Assert.AreEqual(ulong.MaxValue, b.ToBytes);
        }

        #endregion

        #region +(ulong) operator

        [Test]
        public void TestPlusUlongOperator()
        {
            BinarySize b = BinarySize.Zero;
            Assert.AreEqual(0, b.ToBytes);

            b = b + 0;
            Assert.AreEqual(0, b.ToBytes);

            b = b + 10;
            Assert.AreEqual(10, b.ToBytes);
        }

        [Test]
        public void TestPlusUlongOperatorMaximum()
        {
            BinarySize b = BinarySize.FromBytes(ulong.MaxValue);
            Assert.AreEqual(ulong.MaxValue, b.ToBytes);

            b = b + 0;
            Assert.AreEqual(ulong.MaxValue, b.ToBytes);

            Assert.Throws<ArgumentOutOfRangeException>(() =>
                {
                    b = b + 1;
                }
            );
        }

        #endregion

        #region +(BinarySize) operator

        [Test]
        public void TestPlusBinarySizeOperator()
        {
            BinarySize b = BinarySize.Zero;
            Assert.AreEqual(0, b.ToBytes);

            b = b + BinarySize.Zero;
            Assert.AreEqual(0, b.ToBytes);

            b = b + BinarySize.FromBytes(10);
            Assert.AreEqual(10, b.ToBytes);
        }

        [Test]
        public void TestPlusBinarySizeOperatorMaximum()
        {
            BinarySize b = BinarySize.FromBytes(ulong.MaxValue);
            Assert.AreEqual(ulong.MaxValue, b.ToBytes);

            b = b + BinarySize.Zero;
            Assert.AreEqual(ulong.MaxValue, b.ToBytes);

            Assert.Throws<ArgumentOutOfRangeException>(() =>
                {
                    b = b + BinarySize.FromBytes(1);
                }
            );
        }

        #endregion

        #region -(ulong) operator

        [Test]
        public void TestMinusUlongOperatorZero()
        {
            BinarySize b = BinarySize.Zero;
            Assert.AreEqual(0, b.ToBytes);

            b = b - 0;
            Assert.AreEqual(0, b.ToBytes);

            b = b - 10;
            Assert.AreEqual(0, b.ToBytes);
        }

        [Test]
        public void TestMinusUlongOperatorMaximum()
        {
            BinarySize b = BinarySize.FromBytes(ulong.MaxValue);
            Assert.AreEqual(ulong.MaxValue, b.ToBytes);

            b = b - 0;
            Assert.AreEqual(ulong.MaxValue, b.ToBytes);

            b = b - ulong.MaxValue;
            Assert.AreEqual(0, b.ToBytes);
        }

        #endregion

        #region -(BinarySize) operator

        [Test]
        public void TestMinusBinarySizeOperatorZero()
        {
            BinarySize b = BinarySize.Zero;
            Assert.AreEqual(0, b.ToBytes);

            b = b - BinarySize.Zero;
            Assert.AreEqual(0, b.ToBytes);

            b = b - BinarySize.FromBytes(10);
            Assert.AreEqual(0, b.ToBytes);
        }

        [Test]
        public void TestMinusBinarySizeOperatorMaximum()
        {
            BinarySize b = BinarySize.FromBytes(ulong.MaxValue);
            Assert.AreEqual(ulong.MaxValue, b.ToBytes);

            b = b - BinarySize.Zero;
            Assert.AreEqual(ulong.MaxValue, b.ToBytes);

            b = b - BinarySize.FromBytes(ulong.MaxValue);
            Assert.AreEqual(0, b.ToBytes);
        }

        #endregion

        #region == operator

        [Test]
        public void TestEqualsOperator()
        {
            Assert.IsTrue(BinarySize.Zero == BinarySize.FromBytes(0));

            Assert.IsTrue(BinarySize.FromBytes(1) == BinarySize.FromKb(1M / 1024M));

            Assert.IsTrue(BinarySize.FromBytes(1024) == BinarySize.FromKb(1));
            Assert.IsTrue(BinarySize.FromBytes(1024) == BinarySize.FromKb(1.0));
            Assert.IsTrue(BinarySize.FromBytes(1024) == BinarySize.FromKb(1M));
        }

        #endregion

        #region != operator

        [Test]
        public void TestNotEqualsOperator()
        {
            Assert.IsTrue(BinarySize.Zero != BinarySize.FromBytes(1));

            Assert.IsTrue(BinarySize.FromBytes(1) != BinarySize.FromKb(1M));

            Assert.IsTrue(BinarySize.FromBytes(1023) != BinarySize.FromKb(1));
            Assert.IsTrue(BinarySize.FromBytes(1023) != BinarySize.FromKb(1.0));
            Assert.IsTrue(BinarySize.FromBytes(1023) != BinarySize.FromKb(1M));
        }

        #endregion

        #region > operator

        [Test]
        public void TestGreaterThanOperator()
        {
            Assert.IsTrue(BinarySize.FromBytes(1) > BinarySize.Zero);
            Assert.IsTrue(BinarySize.FromBytes(ulong.MaxValue) > BinarySize.Zero);
            Assert.IsFalse(BinarySize.Zero > BinarySize.FromBytes(1));
            Assert.IsTrue(BinarySize.FromKb(1) > BinarySize.FromKb(0));
        }

        #endregion

        #region < operator

        [Test]
        public void TestLessThanOperator()
        {
            Assert.IsFalse(BinarySize.FromBytes(1) < BinarySize.Zero);
            Assert.IsFalse(BinarySize.FromBytes(ulong.MaxValue) < BinarySize.Zero);
            Assert.IsTrue(BinarySize.Zero < BinarySize.FromBytes(1));
            Assert.IsFalse(BinarySize.FromKb(1) < BinarySize.FromKb(0));
        }

        #endregion

        #region >= operator

        [Test]
        public void TestGreaterThanOrEqualsOperator()
        {
            Assert.IsTrue(BinarySize.Zero >= BinarySize.Zero);
            Assert.IsFalse(BinarySize.Zero >= BinarySize.FromBytes(1));
            Assert.IsFalse(BinarySize.Zero >= BinarySize.FromBytes(ulong.MaxValue));

            Assert.IsTrue(BinarySize.FromBytes(1) >= BinarySize.Zero);
            Assert.IsTrue(BinarySize.FromBytes(1) >= BinarySize.FromBytes(1));
            Assert.IsFalse(BinarySize.FromBytes(1) >= BinarySize.FromBytes(ulong.MaxValue));

            Assert.IsTrue(BinarySize.FromBytes(ulong.MaxValue) >= BinarySize.Zero);
            Assert.IsTrue(BinarySize.FromBytes(ulong.MaxValue) >= BinarySize.FromBytes(1));
            Assert.IsTrue(BinarySize.FromBytes(ulong.MaxValue) >= BinarySize.FromBytes(ulong.MaxValue));
        }

        #endregion

        #region <= operator

        [Test]
        public void TestLessThanOrEqualsOperator()
        {
            Assert.IsTrue(BinarySize.Zero <= BinarySize.Zero);
            Assert.IsTrue(BinarySize.Zero <= BinarySize.FromBytes(1));
            Assert.IsTrue(BinarySize.Zero <= BinarySize.FromBytes(ulong.MaxValue));

            Assert.IsFalse(BinarySize.FromBytes(1) <= BinarySize.Zero);
            Assert.IsTrue(BinarySize.FromBytes(1) <= BinarySize.FromBytes(1));
            Assert.IsTrue(BinarySize.FromBytes(1) <= BinarySize.FromBytes(ulong.MaxValue));

            Assert.IsFalse(BinarySize.FromBytes(ulong.MaxValue) <= BinarySize.Zero);
            Assert.IsFalse(BinarySize.FromBytes(ulong.MaxValue) <= BinarySize.FromBytes(1));
            Assert.IsTrue(BinarySize.FromBytes(ulong.MaxValue) <= BinarySize.FromBytes(ulong.MaxValue));
        }

        #endregion

        #region ToString tests

        [Test]
        public void TestToString()
        {
            Assert.AreEqual("0 bytes", BinarySize.Zero.ToString());

            Assert.AreEqual("1 bytes", BinarySize.FromBytes(1).ToString());

            Assert.AreEqual("1,024 bytes", BinarySize.FromBytes(1024).ToString());
            Assert.AreEqual("1,024 bytes", BinarySize.FromKb(1).ToString());
            Assert.AreEqual("1,024 bytes", BinarySize.FromKb(1.0).ToString());
            Assert.AreEqual("1,024 bytes", BinarySize.FromKb(1M).ToString());

            Assert.AreEqual("1,048,576 bytes", BinarySize.FromBytes(1048576).ToString());
            Assert.AreEqual("1,048,576 bytes", BinarySize.FromMb(1).ToString());
            Assert.AreEqual("1,048,576 bytes", BinarySize.FromMb(1.0).ToString());
            Assert.AreEqual("1,048,576 bytes", BinarySize.FromMb(1M).ToString());
        }

        #endregion
    }
}