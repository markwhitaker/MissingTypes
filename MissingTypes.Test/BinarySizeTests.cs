using System;
using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;

namespace uk.co.mainwave.MissingTypes.Test
{
    [SuppressMessage("ReSharper", "RedundantCast")]
    [SuppressMessage("ReSharper", "UnusedVariable")]
    public class BinarySizeTests
    {
        #region Static constructor tests

        #region FromBytes(uint) tests

        [Test]
        public void TestFromBytesWithUintZero()
        {
            var b = BinarySize.FromBytes(0);
            Assert.AreEqual(0UL, b.ToBytes);
            Assert.AreEqual(0.0, b.ToKbAsDouble);
            Assert.AreEqual(0M, b.ToKbAsDecimal);
            Assert.AreEqual(0.0, b.ToMbAsDouble);
            Assert.AreEqual(0M, b.ToMbAsDecimal);
        }

        [Test]
        public void TestFromBytesWithUintOne()
        {
            var b = BinarySize.FromBytes(1);
            Assert.AreEqual(1UL, b.ToBytes);
            Assert.AreEqual(1.0 / 1024.0, b.ToKbAsDouble, 0.001);
            Assert.AreEqual(1M / 1024M, b.ToKbAsDecimal);
            Assert.AreEqual(1.0 / 1024.0 / 1024.0, b.ToMbAsDouble, 0.001);
            Assert.AreEqual(1M / 1024M / 1024M, b.ToMbAsDecimal);
        }

        [Test]
        public void TestFromBytesWithUintMax()
        {
            var b = BinarySize.FromBytes(uint.MaxValue);
            Assert.AreEqual(uint.MaxValue, b.ToBytes);
            Assert.AreEqual(uint.MaxValue / 1024.0, b.ToKbAsDouble, 0.001);
            Assert.AreEqual(uint.MaxValue / 1024M, b.ToKbAsDecimal);
            Assert.AreEqual(uint.MaxValue / 1024.0 / 1024.0, b.ToMbAsDouble, 0.001);
            Assert.AreEqual(uint.MaxValue / 1024M / 1024M, b.ToMbAsDecimal);
        }

        #endregion

        #region FromBytes(ulong) tests

        [Test]
        public void TestFromBytesWithUlongZero()
        {
            var b = BinarySize.FromBytes(0L);
            Assert.AreEqual(0UL, b.ToBytes);
            Assert.AreEqual(0.0, b.ToKbAsDouble);
            Assert.AreEqual(0M, b.ToKbAsDecimal);
            Assert.AreEqual(0.0, b.ToMbAsDouble);
            Assert.AreEqual(0M, b.ToMbAsDecimal);
        }

        [Test]
        public void TestFromBytesWithUlongOne()
        {
            var b = BinarySize.FromBytes(1L);
            Assert.AreEqual(1UL, b.ToBytes);
            Assert.AreEqual(1.0 / 1024.0, b.ToKbAsDouble, 0.001);
            Assert.AreEqual(1M / 1024M, b.ToKbAsDecimal);
            Assert.AreEqual(1.0 / 1024.0 / 1024.0, b.ToMbAsDouble, 0.001);
            Assert.AreEqual(1M / 1024M / 1024M, b.ToMbAsDecimal);
        }

        [Test]
        public void TestFromBytesWithUlongMax()
        {
            var b = BinarySize.FromBytes(ulong.MaxValue);
            Assert.AreEqual(ulong.MaxValue, b.ToBytes);
            Assert.AreEqual(ulong.MaxValue / 1024.0, b.ToKbAsDouble, 0.001);
            Assert.AreEqual(ulong.MaxValue / 1024M, b.ToKbAsDecimal);
            Assert.AreEqual(ulong.MaxValue / 1024.0 / 1024.0, b.ToMbAsDouble, 0.001);
            Assert.AreEqual(ulong.MaxValue / 1024M / 1024M, b.ToMbAsDecimal);
        }

        #endregion

        #region FromKb(uint) tests

        [Test]
        public void TestFromKbWithUintZero()
        {
            var b = BinarySize.FromKb(0);
            Assert.AreEqual(0UL, b.ToBytes);
            Assert.AreEqual(0.0, b.ToKbAsDouble);
            Assert.AreEqual(0M, b.ToKbAsDecimal);
            Assert.AreEqual(0.0, b.ToMbAsDouble);
            Assert.AreEqual(0M, b.ToMbAsDecimal);
        }

        [Test]
        public void TestFromKbWithUintOne()
        {
            var b = BinarySize.FromKb(1);
            Assert.AreEqual(1024UL, b.ToBytes);
            Assert.AreEqual(1.0, b.ToKbAsDouble);
            Assert.AreEqual(1M, b.ToKbAsDecimal);
            Assert.AreEqual(1.0 / 1024.0, b.ToMbAsDouble, 0.001);
            Assert.AreEqual(1M / 1024M, b.ToMbAsDecimal);
        }

        [Test]
        public void TestFromKbWithUintMax()
        {
            var b = BinarySize.FromKb(uint.MaxValue);
            Assert.AreEqual(uint.MaxValue * 1024UL, b.ToBytes);
            Assert.AreEqual(uint.MaxValue, b.ToKbAsDouble, 0.001);
            Assert.AreEqual(uint.MaxValue, b.ToKbAsDecimal);
            Assert.AreEqual(uint.MaxValue / 1024.0, b.ToMbAsDouble, 0.001);
            Assert.AreEqual(uint.MaxValue / 1024M, b.ToMbAsDecimal);
        }

        #endregion

        #region FromKb(decimal) tests

        [Test]
        public void TestFromKbWithDecimalZero()
        {
            var b = BinarySize.FromKb(0M);
            Assert.AreEqual(0UL, b.ToBytes);
            Assert.AreEqual(0.0, b.ToKbAsDouble);
            Assert.AreEqual(0M, b.ToKbAsDecimal);
            Assert.AreEqual(0.0, b.ToMbAsDouble);
            Assert.AreEqual(0M, b.ToMbAsDecimal);
        }

        [Test]
        public void TestFromKbWithDecimalOne()
        {
            var b = BinarySize.FromKb(1M);
            Assert.AreEqual(1024UL, b.ToBytes);
            Assert.AreEqual(1.0, b.ToKbAsDouble);
            Assert.AreEqual(1M, b.ToKbAsDecimal);
            Assert.AreEqual(1.0 / 1024.0, b.ToMbAsDouble, 0.001);
            Assert.AreEqual(1M / 1024M, b.ToMbAsDecimal);
        }

        [Test]
        public void TestFromKbWithDecimalMax()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var b = BinarySize.FromKb(decimal.MaxValue);
            });
        }

        #endregion

        #region FromKb(double) tests

        [Test]
        public void TestFromKbWithDoubleZero()
        {
            var b = BinarySize.FromKb(0.0);
            Assert.AreEqual(0UL, b.ToBytes);
            Assert.AreEqual(0.0, b.ToKbAsDouble);
            Assert.AreEqual(0M, b.ToKbAsDecimal);
            Assert.AreEqual(0.0, b.ToMbAsDouble);
            Assert.AreEqual(0M, b.ToMbAsDecimal);
        }

        [Test]
        public void TestFromKbWithDoubleOne()
        {
            var b = BinarySize.FromKb(1.0);
            Assert.AreEqual(1024UL, b.ToBytes);
            Assert.AreEqual(1.0, b.ToKbAsDouble);
            Assert.AreEqual(1M, b.ToKbAsDecimal);
            Assert.AreEqual(1.0 / 1024.0, b.ToMbAsDouble, 0.001);
            Assert.AreEqual(1M / 1024M, b.ToMbAsDecimal);
        }

        [Test]
        public void TestFromKbWithDoubleMax()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var b = BinarySize.FromKb(double.MaxValue);
            });
        }

        #endregion

        #region FromMb(uint) tests

        [Test]
        public void TestFromMbWithUintZero()
        {
            var b = BinarySize.FromMb(0);
            Assert.AreEqual(0UL, b.ToBytes);
            Assert.AreEqual(0.0, b.ToMbAsDouble);
            Assert.AreEqual(0M, b.ToMbAsDecimal);
            Assert.AreEqual(0.0, b.ToMbAsDouble);
            Assert.AreEqual(0M, b.ToMbAsDecimal);
        }

        [Test]
        public void TestFromMbWithUintOne()
        {
            var b = BinarySize.FromMb(1);
            Assert.AreEqual(1024UL * 1024UL, b.ToBytes);
            Assert.AreEqual(1024.0, b.ToKbAsDouble);
            Assert.AreEqual(1024M, b.ToKbAsDecimal);
            Assert.AreEqual(1.0, b.ToMbAsDouble);
            Assert.AreEqual(1M, b.ToMbAsDecimal);
        }

        [Test]
        public void TestFromMbWithUintMax()
        {
            var b = BinarySize.FromMb(uint.MaxValue);
            Assert.AreEqual(uint.MaxValue * 1024UL * 1024UL, b.ToBytes);
            Assert.AreEqual(uint.MaxValue * 1024.0, b.ToKbAsDouble, 0.001);
            Assert.AreEqual(uint.MaxValue * 1024M, b.ToKbAsDecimal);
            Assert.AreEqual(uint.MaxValue, b.ToMbAsDouble, 0.001);
            Assert.AreEqual(uint.MaxValue, b.ToMbAsDecimal);
        }

        #endregion

        #region FromMb(decimal) tests

        [Test]
        public void TestFromMbWithDecimalZero()
        {
            var b = BinarySize.FromMb(0M);
            Assert.AreEqual(0UL, b.ToBytes);
            Assert.AreEqual(0.0, b.ToKbAsDouble);
            Assert.AreEqual(0M, b.ToKbAsDecimal);
            Assert.AreEqual(0.0, b.ToMbAsDouble);
            Assert.AreEqual(0M, b.ToMbAsDecimal);
        }

        [Test]
        public void TestFromMbWithDecimalOne()
        {
            var b = BinarySize.FromMb(1M);
            Assert.AreEqual(1024UL * 1024UL, b.ToBytes);
            Assert.AreEqual(1024.0, b.ToKbAsDouble);
            Assert.AreEqual(1024M, b.ToKbAsDecimal);
            Assert.AreEqual(1.0, b.ToMbAsDouble, 0.001);
            Assert.AreEqual(1M, b.ToMbAsDecimal);
        }

        [Test]
        public void TestFromMbWithDecimalMax()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var b = BinarySize.FromMb(decimal.MaxValue);
            });
        }

        #endregion

        #region FromMb(double) tests

        [Test]
        public void TestFromMbWithDoubleZero()
        {
            var b = BinarySize.FromMb(0.0);
            Assert.AreEqual(0UL, b.ToBytes);
            Assert.AreEqual(0.0, b.ToKbAsDouble);
            Assert.AreEqual(0M, b.ToKbAsDecimal);
            Assert.AreEqual(0.0, b.ToMbAsDouble);
            Assert.AreEqual(0M, b.ToMbAsDecimal);
        }

        [Test]
        public void TestFromMbWithDoubleOne()
        {
            var b = BinarySize.FromMb(1.0);
            Assert.AreEqual(1024UL * 1024UL, b.ToBytes);
            Assert.AreEqual(1024.0, b.ToKbAsDouble);
            Assert.AreEqual(1024M, b.ToKbAsDecimal);
            Assert.AreEqual(1.0, b.ToMbAsDouble, 0.001);
            Assert.AreEqual(1M, b.ToMbAsDecimal);
        }

        [Test]
        public void TestFromMbWithDoubleMax()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var b = BinarySize.FromMb(double.MaxValue);
            });
        }

        #endregion

        #endregion
    }
}