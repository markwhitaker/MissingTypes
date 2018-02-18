using System;
using System.Diagnostics.CodeAnalysis;
using NUnit.Framework;

namespace uk.co.mainwave.MissingTypes.Test
{
    [SuppressMessage("ReSharper", "RedundantCast")]
    [SuppressMessage("ReSharper", "UnusedVariable")]
    public class BinarySizeTests
    {
        #region Constants

        private const ulong ThousandUlong = 1024UL;
        private const decimal ThousandDecimal = 1024M;
        private const double ThousandDouble = 1024.0;

        #endregion

        #region Static constructor tests

        #region FromBytes(ulong) tests

        [Test]
        public void TestFromBytesWithUlongZero()
        {
            var b = BinarySize.FromBytes(0);
            // Bytes
            Assert.AreEqual(0UL, b.ToBytes);
            // Kb
            Assert.AreEqual(0.0, b.ToKbAsDouble);
            Assert.AreEqual(0M, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(0.0, b.ToMbAsDouble);
            Assert.AreEqual(0M, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(0.0, b.ToGbAsDouble);
            Assert.AreEqual(0M, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(0.0, b.ToTbAsDouble);
            Assert.AreEqual(0M, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(0.0, b.ToPbAsDouble);
            Assert.AreEqual(0M, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromBytesWithUlongOne()
        {
            var b = BinarySize.FromBytes(1L);
            // Bytes
            Assert.AreEqual(1UL, b.ToBytes);
            // Kb
            Assert.AreEqual(1.0 / ThousandDouble, b.ToKbAsDouble, 0.001);
            Assert.AreEqual(1M / ThousandDecimal, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(1.0 / ThousandDouble / ThousandDouble, b.ToMbAsDouble, 0.001);
            Assert.AreEqual(1M / ThousandDecimal / ThousandDecimal, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(1.0 / ThousandDouble / ThousandDouble / ThousandDouble, b.ToGbAsDouble, 0.001);
            Assert.AreEqual(1M / ThousandDecimal / ThousandDecimal / ThousandDecimal, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(1.0 / ThousandDouble / ThousandDouble / ThousandDouble / ThousandDouble, b.ToTbAsDouble, 0.001);
            Assert.AreEqual(1M / ThousandDecimal / ThousandDecimal / ThousandDecimal / ThousandDecimal, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(1.0 / ThousandDouble / ThousandDouble / ThousandDouble / ThousandDouble / ThousandDouble, b.ToPbAsDouble, 0.001);
            Assert.AreEqual(1M / ThousandDecimal / ThousandDecimal / ThousandDecimal / ThousandDecimal / ThousandDecimal, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromBytesWithUlongMax()
        {
            var b = BinarySize.FromBytes(ulong.MaxValue);
            // Bytes
            Assert.AreEqual(ulong.MaxValue, b.ToBytes);
            // Kb
            Assert.AreEqual(ulong.MaxValue / ThousandDouble, b.ToKbAsDouble, 0.001);
            Assert.AreEqual(ulong.MaxValue / ThousandDecimal, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(ulong.MaxValue / ThousandDouble / ThousandDouble, b.ToMbAsDouble, 0.001);
            Assert.AreEqual(ulong.MaxValue / ThousandDecimal / ThousandDecimal, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(ulong.MaxValue / ThousandDouble / ThousandDouble / ThousandDouble, b.ToGbAsDouble, 0.001);
            Assert.AreEqual((double)(ulong.MaxValue / ThousandDecimal / ThousandDecimal / ThousandDecimal), (double)(b.ToGbAsDecimal), 0.001);
            // Tb
            Assert.AreEqual(ulong.MaxValue / ThousandDouble / ThousandDouble / ThousandDouble / ThousandDouble, b.ToTbAsDouble, 0.001);
            Assert.AreEqual((double)(ulong.MaxValue / ThousandDecimal / ThousandDecimal / ThousandDecimal / ThousandDecimal), (double)(b.ToTbAsDecimal), 0.001);
            // Pb
            Assert.AreEqual(ulong.MaxValue / ThousandDouble / ThousandDouble / ThousandDouble / ThousandDouble / ThousandDouble, b.ToPbAsDouble, 0.001);
            Assert.AreEqual((double)(ulong.MaxValue / ThousandDecimal / ThousandDecimal / ThousandDecimal / ThousandDecimal / ThousandDecimal), (double)(b.ToPbAsDecimal), 0.001);
        }

        #endregion

        #region FromKb(ulong) tests

        [Test]
        public void TestFromKbWithUlongZero()
        {
            var b = BinarySize.FromKb(0);
            // Bytes
            Assert.AreEqual(0UL, b.ToBytes);
            // Kb
            Assert.AreEqual(0.0, b.ToKbAsDouble);
            Assert.AreEqual(0M, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(0.0, b.ToMbAsDouble);
            Assert.AreEqual(0M, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(0.0, b.ToGbAsDouble);
            Assert.AreEqual(0M, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(0.0, b.ToTbAsDouble);
            Assert.AreEqual(0M, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(0.0, b.ToPbAsDouble);
            Assert.AreEqual(0M, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromKbWithUlongOne()
        {
            var b = BinarySize.FromKb(1);
            // Bytes
            Assert.AreEqual(ThousandUlong, b.ToBytes);
            // Kb
            Assert.AreEqual(1.0, b.ToKbAsDouble);
            Assert.AreEqual(1M, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(1.0 / ThousandDouble, b.ToMbAsDouble, 0.001);
            Assert.AreEqual(1M / ThousandDecimal, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(1.0 / ThousandDouble / ThousandDouble, b.ToGbAsDouble, 0.001);
            Assert.AreEqual(1M / ThousandDecimal / ThousandDecimal, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(1.0 / ThousandDouble / ThousandDouble / ThousandDouble, b.ToTbAsDouble, 0.001);
            Assert.AreEqual(1M / ThousandDecimal / ThousandDecimal / ThousandDecimal, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(1.0 / ThousandDouble / ThousandDouble / ThousandDouble / ThousandDouble, b.ToPbAsDouble, 0.001);
            Assert.AreEqual(1M / ThousandDecimal / ThousandDecimal / ThousandDecimal / ThousandDecimal, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromKbWithUlongMaximum()
        {
            var kb = ulong.MaxValue >> 10;
            var b = BinarySize.FromKb(kb);
            // Bytes
            Assert.AreEqual(kb * ThousandUlong, b.ToBytes);
            // Kb
            Assert.AreEqual(kb, b.ToKbAsDouble, 0.001);
            Assert.AreEqual(kb, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(kb / ThousandDouble, b.ToMbAsDouble, 0.001);
            Assert.AreEqual(kb / ThousandDecimal, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(kb / ThousandDouble / ThousandDouble, b.ToGbAsDouble, 0.001);
            Assert.AreEqual(kb / ThousandDecimal / ThousandDecimal, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(kb / ThousandDouble / ThousandDouble / ThousandDouble, b.ToTbAsDouble, 0.001);
            Assert.AreEqual(kb / ThousandDecimal / ThousandDecimal / ThousandDecimal, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(kb / ThousandDouble / ThousandDouble / ThousandDouble / ThousandDouble, b.ToPbAsDouble, 0.001);
            Assert.AreEqual((double)(kb / ThousandDecimal / ThousandDecimal / ThousandDecimal / ThousandDecimal), (double)(b.ToPbAsDecimal), 0.001);
        }

        [Test]
        public void TestFromKbWithUlongOverMaximum()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var b = BinarySize.FromKb((ulong.MaxValue >> 10) + 1UL);
            });

        }

        #endregion

        #region FromKb(decimal) tests

        [Test]
        public void TestFromKbWithDecimalZero()
        {
            var b = BinarySize.FromKb(0M);
            // Bytes
            Assert.AreEqual(0UL, b.ToBytes);
            // Kb
            Assert.AreEqual(0.0, b.ToKbAsDouble);
            Assert.AreEqual(0M, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(0.0, b.ToMbAsDouble);
            Assert.AreEqual(0M, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(0.0, b.ToGbAsDouble);
            Assert.AreEqual(0M, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(0.0, b.ToTbAsDouble);
            Assert.AreEqual(0M, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(0.0, b.ToPbAsDouble);
            Assert.AreEqual(0M, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromKbWithDecimalOne()
        {
            var b = BinarySize.FromKb(1M);
            // Bytes
            Assert.AreEqual(ThousandUlong, b.ToBytes);
            // Kb
            Assert.AreEqual(1.0, b.ToKbAsDouble);
            Assert.AreEqual(1M, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(1.0 / ThousandDouble, b.ToMbAsDouble, 0.001);
            Assert.AreEqual(1M / ThousandDecimal, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(1.0 / ThousandDouble / ThousandDouble, b.ToGbAsDouble, 0.001);
            Assert.AreEqual(1M / ThousandDecimal / ThousandDecimal, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(1.0 / ThousandDouble / ThousandDouble / ThousandDouble, b.ToTbAsDouble, 0.001);
            Assert.AreEqual(1M / ThousandDecimal / ThousandDecimal / ThousandDecimal, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(1.0 / ThousandDouble / ThousandDouble / ThousandDouble / ThousandDouble, b.ToPbAsDouble, 0.001);
            Assert.AreEqual(1M / ThousandDecimal / ThousandDecimal / ThousandDecimal / ThousandDecimal, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromKbWithDecimalMaximum()
        {
            var kb = ulong.MaxValue >> 10;
            var b = BinarySize.FromKb((decimal)kb);
            // Bytes
            Assert.AreEqual(kb * ThousandUlong, b.ToBytes);
            // Kb
            Assert.AreEqual(kb, b.ToKbAsDouble, 0.001);
            Assert.AreEqual(kb, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(kb / ThousandDouble, b.ToMbAsDouble, 0.001);
            Assert.AreEqual(kb / ThousandDecimal, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(kb / ThousandDouble / ThousandDouble, b.ToGbAsDouble, 0.001);
            Assert.AreEqual(kb / ThousandDecimal / ThousandDecimal, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(kb / ThousandDouble / ThousandDouble / ThousandDouble, b.ToTbAsDouble, 0.001);
            Assert.AreEqual(kb / ThousandDecimal / ThousandDecimal / ThousandDecimal, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(kb / ThousandDouble / ThousandDouble / ThousandDouble / ThousandDouble, b.ToPbAsDouble, 0.001);
            Assert.AreEqual((double)(kb / ThousandDecimal / ThousandDecimal / ThousandDecimal / ThousandDecimal), (double)(b.ToPbAsDecimal), 0.001);
        }

        [Test]
        public void TestFromKbWithDecimalOverMaximum()
        {
            var kb = ulong.MaxValue >> 10;

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var b = BinarySize.FromKb((decimal)kb + 0.000001M);
            });
        }

        #endregion

        #region FromKb(double) tests

        [Test]
        public void TestFromKbWithDoubleZero()
        {
            var b = BinarySize.FromKb(0.0);
            // Bytes
            Assert.AreEqual(0UL, b.ToBytes);
            // Kb
            Assert.AreEqual(0.0, b.ToKbAsDouble);
            Assert.AreEqual(0M, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(0.0, b.ToMbAsDouble);
            Assert.AreEqual(0M, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(0.0, b.ToGbAsDouble);
            Assert.AreEqual(0M, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(0.0, b.ToTbAsDouble);
            Assert.AreEqual(0M, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(0.0, b.ToPbAsDouble);
            Assert.AreEqual(0M, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromKbWithDoubleOne()
        {
            var b = BinarySize.FromKb(1.0);
            // Bytes
            Assert.AreEqual(ThousandUlong, b.ToBytes);
            // Kb
            Assert.AreEqual(1.0, b.ToKbAsDouble);
            Assert.AreEqual(1M, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(1.0 / ThousandDouble, b.ToMbAsDouble, 0.001);
            Assert.AreEqual(1M / ThousandDecimal, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(1.0 / ThousandDouble / ThousandDouble, b.ToGbAsDouble, 0.001);
            Assert.AreEqual(1M / ThousandDecimal / ThousandDecimal, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(1.0 / ThousandDouble / ThousandDouble / ThousandDouble, b.ToTbAsDouble, 0.001);
            Assert.AreEqual(1M / ThousandDecimal / ThousandDecimal / ThousandDecimal, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(1.0 / ThousandDouble / ThousandDouble / ThousandDouble / ThousandDouble, b.ToPbAsDouble, 0.001);
            Assert.AreEqual(1M / ThousandDecimal / ThousandDecimal / ThousandDecimal / ThousandDecimal, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromKbWithDoubleMaximum()
        {
            // Note: Using "(double)(ulong.MaxValue >> 10)" here causes a rounding error when converted back to a ulong: it ends up 1 over the maximum allowable value
            var kb = (ulong.MaxValue >> 10) - 1;
            var b = BinarySize.FromKb((double)kb);
            // Bytes
            Assert.AreEqual(kb * ThousandUlong, b.ToBytes);
            // Kb
            Assert.AreEqual(kb, b.ToKbAsDouble, 0.001);
            Assert.AreEqual(kb, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(kb / ThousandDouble, b.ToMbAsDouble, 0.001);
            Assert.AreEqual(kb / ThousandDecimal, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(kb / ThousandDouble / ThousandDouble, b.ToGbAsDouble, 0.001);
            Assert.AreEqual(kb / ThousandDecimal / ThousandDecimal, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(kb / ThousandDouble / ThousandDouble / ThousandDouble, b.ToTbAsDouble, 0.001);
            Assert.AreEqual((double)(kb / ThousandDecimal / ThousandDecimal / ThousandDecimal), (double)(b.ToTbAsDecimal), 0.001);
            // Pb
            Assert.AreEqual(kb / ThousandDouble / ThousandDouble / ThousandDouble / ThousandDouble, b.ToPbAsDouble, 0.001);
            Assert.AreEqual((double)(kb / ThousandDecimal / ThousandDecimal / ThousandDecimal / ThousandDecimal), (double)(b.ToPbAsDecimal), 0.001);
        }

        [Test]
        public void TestFromKbWithDoubleOverMaximum()
        {
            var kb = (ulong.MaxValue >> 10);

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var b = BinarySize.FromKb((double)kb + 0.001);
            });
        }

        #endregion

        #region FromMb(ulong) tests

        [Test]
        public void TestFromMbWithUlongZero()
        {
            var b = BinarySize.FromMb(0);
            // Bytes
            Assert.AreEqual(0UL, b.ToBytes);
            // Kb
            Assert.AreEqual(0.0, b.ToKbAsDouble);
            Assert.AreEqual(0M, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(0.0, b.ToMbAsDouble);
            Assert.AreEqual(0M, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(0.0, b.ToGbAsDouble);
            Assert.AreEqual(0M, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(0.0, b.ToTbAsDouble);
            Assert.AreEqual(0M, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(0.0, b.ToPbAsDouble);
            Assert.AreEqual(0M, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromMbWithUlongOne()
        {
            var b = BinarySize.FromMb(1);
            // Bytes
            Assert.AreEqual(ThousandUlong * ThousandUlong, b.ToBytes);
            // Kb
            Assert.AreEqual(ThousandDouble, b.ToKbAsDouble);
            Assert.AreEqual(ThousandDecimal, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(1.0, b.ToMbAsDouble);
            Assert.AreEqual(1M, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(1.0 / ThousandDouble, b.ToGbAsDouble, 0.001);
            Assert.AreEqual(1M / ThousandDecimal, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(1.0 / ThousandDouble / ThousandDouble, b.ToTbAsDouble, 0.001);
            Assert.AreEqual(1M / ThousandDecimal / ThousandDecimal, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(1.0 / ThousandDouble / ThousandDouble / ThousandDouble, b.ToPbAsDouble, 0.001);
            Assert.AreEqual(1M / ThousandDecimal / ThousandDecimal / ThousandDecimal, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromMbWithUlongMaximum()
        {
            var mb = ulong.MaxValue >> 20;
            var b = BinarySize.FromMb(mb);
            // Bytes
            Assert.AreEqual(mb * ThousandUlong * ThousandUlong, b.ToBytes);
            // Kb
            Assert.AreEqual(mb * ThousandDouble, b.ToKbAsDouble, 0.001);
            Assert.AreEqual(mb * ThousandDecimal, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(mb, b.ToMbAsDouble, 0.001);
            Assert.AreEqual(mb, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(mb / ThousandDouble, b.ToGbAsDouble, 0.001);
            Assert.AreEqual(mb / ThousandDecimal, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(mb / ThousandDouble / ThousandDouble, b.ToTbAsDouble, 0.001);
            Assert.AreEqual(mb / ThousandDecimal / ThousandDecimal, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(mb / ThousandDouble / ThousandDouble / ThousandDouble, b.ToPbAsDouble, 0.001);
            Assert.AreEqual(mb / ThousandDecimal / ThousandDecimal / ThousandDecimal, b.ToPbAsDecimal);
        }


        [Test]
        public void TestFromMbWithUlongOverMaximum()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var b = BinarySize.FromMb((ulong.MaxValue >> 20) + 1UL);
            });

        }

        #endregion

        #region FromMb(decimal) tests

        [Test]
        public void TestFromMbWithDecimalZero()
        {
            var b = BinarySize.FromMb(0M);
            // Bytes
            Assert.AreEqual(0UL, b.ToBytes);
            // Kb
            Assert.AreEqual(0.0, b.ToKbAsDouble);
            Assert.AreEqual(0M, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(0.0, b.ToMbAsDouble);
            Assert.AreEqual(0M, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(0.0, b.ToGbAsDouble);
            Assert.AreEqual(0M, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(0.0, b.ToTbAsDouble);
            Assert.AreEqual(0M, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(0.0, b.ToPbAsDouble);
            Assert.AreEqual(0M, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromMbWithDecimalOne()
        {
            var b = BinarySize.FromMb(1M);
            // Bytes
            Assert.AreEqual(ThousandUlong * ThousandUlong, b.ToBytes);
            // Kb
            Assert.AreEqual(ThousandDouble, b.ToKbAsDouble);
            Assert.AreEqual(ThousandDecimal, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(1.0, b.ToMbAsDouble, 0.001);
            Assert.AreEqual(1M, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(1.0 / ThousandDouble, b.ToGbAsDouble);
            Assert.AreEqual(1M / ThousandDecimal, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(1.0 / ThousandDouble / ThousandDouble, b.ToTbAsDouble);
            Assert.AreEqual(1M / ThousandDecimal / ThousandDecimal, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(1.0 / ThousandDouble / ThousandDouble / ThousandDouble, b.ToPbAsDouble);
            Assert.AreEqual(1M / ThousandDecimal / ThousandDecimal / ThousandDecimal, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromMbWithDecimalMaximum()
        {
            var mb = ulong.MaxValue >> 20;
            var b = BinarySize.FromMb((decimal)mb);
            // Bytes
            Assert.AreEqual(mb * ThousandUlong * ThousandUlong, b.ToBytes);
            // Kb
            Assert.AreEqual(mb * ThousandDouble, b.ToKbAsDouble);
            Assert.AreEqual(mb * ThousandDecimal, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(mb, b.ToMbAsDouble, 0.001);
            Assert.AreEqual(mb, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(mb / ThousandDouble, b.ToGbAsDouble);
            Assert.AreEqual(mb / ThousandDecimal, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(mb / ThousandDouble / ThousandDouble, b.ToTbAsDouble);
            Assert.AreEqual(mb / ThousandDecimal / ThousandDecimal, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(mb / ThousandDouble / ThousandDouble / ThousandDouble, b.ToPbAsDouble);
            Assert.AreEqual(mb / ThousandDecimal / ThousandDecimal / ThousandDecimal, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromMbWithDecimalOverMaximum()
        {
            var mb = ulong.MaxValue >> 20;

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var b = BinarySize.FromMb((decimal)mb + 0.000001M);
            });
        }

        #endregion

        #region FromMb(double) tests

        [Test]
        public void TestFromMbWithDoubleZero()
        {
            var b = BinarySize.FromMb(0.0);
            // Bytes
            Assert.AreEqual(0UL, b.ToBytes);
            // Kb
            Assert.AreEqual(0.0, b.ToKbAsDouble);
            Assert.AreEqual(0M, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(0.0, b.ToMbAsDouble);
            Assert.AreEqual(0M, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(0.0, b.ToGbAsDouble);
            Assert.AreEqual(0M, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(0.0, b.ToTbAsDouble);
            Assert.AreEqual(0M, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(0.0, b.ToPbAsDouble);
            Assert.AreEqual(0M, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromMbWithDoubleOne()
        {
            var b = BinarySize.FromMb(1.0);
            // Bytes
            Assert.AreEqual(ThousandUlong * ThousandUlong, b.ToBytes);
            // Kb
            Assert.AreEqual(ThousandDouble, b.ToKbAsDouble);
            Assert.AreEqual(ThousandDecimal, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(1.0, b.ToMbAsDouble, 0.001);
            Assert.AreEqual(1M, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(1.0 / ThousandDouble, b.ToGbAsDouble);
            Assert.AreEqual(1M / ThousandDecimal, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(1.0 / ThousandDouble / ThousandDouble, b.ToTbAsDouble);
            Assert.AreEqual(1M / ThousandDecimal / ThousandDecimal, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(1.0 / ThousandDouble / ThousandDouble / ThousandDouble, b.ToPbAsDouble);
            Assert.AreEqual(1M / ThousandDecimal / ThousandDecimal / ThousandDecimal, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromMbWithDoubleMaximum()
        {
            // Note: Using "(double)(ulong.MaxValue >> 20)" here causes a rounding error when converted back to a ulong: it ends up 1 over the maximum allowable value
            var mb = (ulong.MaxValue >> 20) - 1;
            var b = BinarySize.FromMb((double)mb);
            // Bytes
            Assert.AreEqual(mb * ThousandUlong * ThousandUlong, b.ToBytes);
            // Kb
            Assert.AreEqual(mb * ThousandDouble, b.ToKbAsDouble);
            Assert.AreEqual(mb * ThousandDecimal, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(mb, b.ToMbAsDouble, 0.001);
            Assert.AreEqual(mb, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(mb / ThousandDouble, b.ToGbAsDouble);
            Assert.AreEqual(mb / ThousandDecimal, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(mb / ThousandDouble / ThousandDouble, b.ToTbAsDouble);
            Assert.AreEqual(mb / ThousandDecimal / ThousandDecimal, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(mb / ThousandDouble / ThousandDouble / ThousandDouble, b.ToPbAsDouble);
            Assert.AreEqual(mb / ThousandDecimal / ThousandDecimal / ThousandDecimal, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromMbWithDoubleOverMaximum()
        {
            var mb = (ulong.MaxValue >> 20);

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var b = BinarySize.FromMb((double)mb + 0.001);
            });
        }

        #endregion

        #region FromGb(ulong) tests

        [Test]
        public void TestFromGbWithUlongZero()
        {
            var b = BinarySize.FromGb(0);
            // Bytes
            Assert.AreEqual(0UL, b.ToBytes);
            // Kb
            Assert.AreEqual(0.0, b.ToKbAsDouble);
            Assert.AreEqual(0M, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(0.0, b.ToMbAsDouble);
            Assert.AreEqual(0M, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(0.0, b.ToGbAsDouble);
            Assert.AreEqual(0M, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(0.0, b.ToTbAsDouble);
            Assert.AreEqual(0M, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(0.0, b.ToPbAsDouble);
            Assert.AreEqual(0M, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromGbWithUlongOne()
        {
            var b = BinarySize.FromGb(1);
            // Bytes
            Assert.AreEqual(ThousandUlong * ThousandUlong * ThousandUlong, b.ToBytes);
            // Kb
            Assert.AreEqual(ThousandDouble * ThousandDouble, b.ToKbAsDouble, 0.001);
            Assert.AreEqual(ThousandDecimal * ThousandDecimal, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(ThousandDouble, b.ToMbAsDouble);
            Assert.AreEqual(ThousandDecimal, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(1.0, b.ToGbAsDouble);
            Assert.AreEqual(1M, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(1.0 / ThousandDouble, b.ToTbAsDouble, 0.001);
            Assert.AreEqual(1M / ThousandDecimal, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(1.0 / ThousandDouble / ThousandDouble, b.ToPbAsDouble, 0.001);
            Assert.AreEqual(1M / ThousandDecimal / ThousandDecimal, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromGbWithUlongMaximum()
        {
            var gb = ulong.MaxValue >> 30;
            var b = BinarySize.FromGb(gb);
            // Bytes
            Assert.AreEqual(gb * ThousandUlong * ThousandUlong * ThousandUlong, b.ToBytes);
            // Kb
            Assert.AreEqual(gb * ThousandDouble * ThousandDouble, b.ToKbAsDouble, 0.001);
            Assert.AreEqual(gb * ThousandDecimal * ThousandDecimal, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(gb * ThousandDouble, b.ToMbAsDouble, 0.001);
            Assert.AreEqual(gb * ThousandDecimal, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(gb, b.ToGbAsDouble);
            Assert.AreEqual(gb, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(gb/ ThousandDouble, b.ToTbAsDouble, 0.001);
            Assert.AreEqual(gb / ThousandDecimal, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(gb / ThousandDouble / ThousandDouble, b.ToPbAsDouble, 0.001);
            Assert.AreEqual(gb / ThousandDecimal / ThousandDecimal, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromGbWithUlongOverMaximum()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var b = BinarySize.FromGb((ulong.MaxValue >> 30) + 1UL);
            });

        }

        #endregion

        #region FromGb(decimal) tests

        [Test]
        public void TestFromGbWithDecimalZero()
        {
            var b = BinarySize.FromGb(0M);
            // Bytes
            Assert.AreEqual(0UL, b.ToBytes);
            // Kb
            Assert.AreEqual(0.0, b.ToKbAsDouble);
            Assert.AreEqual(0M, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(0.0, b.ToMbAsDouble);
            Assert.AreEqual(0M, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(0.0, b.ToGbAsDouble);
            Assert.AreEqual(0M, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(0.0, b.ToTbAsDouble);
            Assert.AreEqual(0M, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(0.0, b.ToPbAsDouble);
            Assert.AreEqual(0M, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromGbWithDecimalOne()
        {
            var b = BinarySize.FromGb(1M);
            // Bytes
            Assert.AreEqual(ThousandUlong * ThousandUlong * ThousandUlong, b.ToBytes);
            // Kb
            Assert.AreEqual(ThousandDouble * ThousandDouble, b.ToKbAsDouble, 0.001);
            Assert.AreEqual(ThousandDecimal * ThousandDecimal, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(ThousandDouble, b.ToMbAsDouble);
            Assert.AreEqual(ThousandDecimal, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(1.0, b.ToGbAsDouble);
            Assert.AreEqual(1M, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(1.0 / ThousandDouble, b.ToTbAsDouble, 0.001);
            Assert.AreEqual(1M / ThousandDecimal, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(1.0 / ThousandDouble / ThousandDouble, b.ToPbAsDouble, 0.001);
            Assert.AreEqual(1M / ThousandDecimal / ThousandDecimal, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromGbWithDecimalMaximum()
        {
            var gb = ulong.MaxValue >> 30;
            var b = BinarySize.FromGb((decimal)gb);
            // Bytes
            Assert.AreEqual(gb * ThousandUlong * ThousandUlong * ThousandUlong, b.ToBytes);
            // Kb
            Assert.AreEqual(gb * ThousandDouble * ThousandDouble, b.ToKbAsDouble, 0.001);
            Assert.AreEqual(gb * ThousandDecimal * ThousandDecimal, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(gb * ThousandDouble, b.ToMbAsDouble);
            Assert.AreEqual(gb * ThousandDecimal, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(gb, b.ToGbAsDouble);
            Assert.AreEqual(gb, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(gb / ThousandDouble, b.ToTbAsDouble, 0.001);
            Assert.AreEqual(gb / ThousandDecimal, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(gb / ThousandDouble / ThousandDouble, b.ToPbAsDouble, 0.001);
            Assert.AreEqual(gb / ThousandDecimal / ThousandDecimal, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromGbWithDecimalOverMaximum()
        {
            var gb = ulong.MaxValue >> 30;

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var b = BinarySize.FromGb((decimal)gb + 0.000001M);
            });
        }

        #endregion

        #region FromGb(double) tests

        [Test]
        public void TestFromGbWithDoubleZero()
        {
            var b = BinarySize.FromGb(0.0);
            // Bytes
            Assert.AreEqual(0UL, b.ToBytes);
            // Kb
            Assert.AreEqual(0.0, b.ToKbAsDouble);
            Assert.AreEqual(0M, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(0.0, b.ToMbAsDouble);
            Assert.AreEqual(0M, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(0.0, b.ToGbAsDouble);
            Assert.AreEqual(0M, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(0.0, b.ToTbAsDouble);
            Assert.AreEqual(0M, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(0.0, b.ToPbAsDouble);
            Assert.AreEqual(0M, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromGbWithDoubleOne()
        {
            var b = BinarySize.FromGb(1.0);
            // Bytes
            Assert.AreEqual(ThousandUlong * ThousandUlong * ThousandUlong, b.ToBytes);
            // Kb
            Assert.AreEqual(ThousandDouble * ThousandDouble, b.ToKbAsDouble, 0.001);
            Assert.AreEqual(ThousandDecimal * ThousandDecimal, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(ThousandDouble, b.ToMbAsDouble);
            Assert.AreEqual(ThousandDecimal, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(1.0, b.ToGbAsDouble);
            Assert.AreEqual(1M, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(1.0 / ThousandDouble, b.ToTbAsDouble, 0.001);
            Assert.AreEqual(1M / ThousandDecimal, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(1.0 / ThousandDouble / ThousandDouble, b.ToPbAsDouble, 0.001);
            Assert.AreEqual(1M / ThousandDecimal / ThousandDecimal, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromGbWithDoubleMaximum()
        {
            // Note: Using "(double)(ulong.MaxValue >> 30)" here causes a rounding error when converted back to a ulong: it ends up 1 over the maximum allowable value
            var gb = (ulong.MaxValue >> 30) - 1;
            var b = BinarySize.FromGb((double)gb);
            // Bytes
            Assert.AreEqual(gb * ThousandUlong * ThousandUlong * ThousandUlong, b.ToBytes);
            // Kb
            Assert.AreEqual(gb * ThousandDouble * ThousandDouble, b.ToKbAsDouble, 0.001);
            Assert.AreEqual(gb * ThousandDecimal * ThousandDecimal, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(gb * ThousandDouble, b.ToMbAsDouble);
            Assert.AreEqual(gb * ThousandDecimal, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(gb, b.ToGbAsDouble);
            Assert.AreEqual(gb, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(gb / ThousandDouble, b.ToTbAsDouble, 0.001);
            Assert.AreEqual(gb / ThousandDecimal, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(gb / ThousandDouble / ThousandDouble, b.ToPbAsDouble, 0.001);
            Assert.AreEqual(gb / ThousandDecimal / ThousandDecimal, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromGbWithDoubleOverMaximum()
        {
            var gb = (ulong.MaxValue >> 30);

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var b = BinarySize.FromGb((double)gb + 0.001);
            });
        }

        #endregion

        #region FromTb(ulong) tests

        [Test]
        public void TestFromTbWithUlongZero()
        {
            var b = BinarySize.FromTb(0);
            // Bytes
            Assert.AreEqual(0UL, b.ToBytes);
            // Kb
            Assert.AreEqual(0.0, b.ToKbAsDouble);
            Assert.AreEqual(0M, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(0.0, b.ToMbAsDouble);
            Assert.AreEqual(0M, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(0.0, b.ToGbAsDouble);
            Assert.AreEqual(0M, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(0.0, b.ToTbAsDouble);
            Assert.AreEqual(0M, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(0.0, b.ToPbAsDouble);
            Assert.AreEqual(0M, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromTbWithUlongOne()
        {
            var b = BinarySize.FromTb(1);
            // Bytes
            Assert.AreEqual(ThousandUlong * ThousandUlong * ThousandUlong * ThousandUlong, b.ToBytes);
            // Kb
            Assert.AreEqual(ThousandDouble * ThousandDouble * ThousandDouble, b.ToKbAsDouble, 0.001);
            Assert.AreEqual(ThousandDecimal * ThousandDecimal * ThousandDecimal, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(ThousandDouble * ThousandDouble, b.ToMbAsDouble);
            Assert.AreEqual(ThousandDecimal * ThousandDecimal, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(ThousandDouble, b.ToGbAsDouble);
            Assert.AreEqual(ThousandDecimal, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(1.0, b.ToTbAsDouble, 0.001);
            Assert.AreEqual(1M, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(1.0 / ThousandDouble, b.ToPbAsDouble, 0.001);
            Assert.AreEqual(1M / ThousandDecimal, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromTbWithUlongMaximum()
        {
            var tb = ulong.MaxValue >> 40;
            var b = BinarySize.FromTb(tb);
            // Bytes
            Assert.AreEqual(tb * ThousandUlong * ThousandUlong * ThousandUlong * ThousandUlong, b.ToBytes);
            // Kb
            Assert.AreEqual(tb * ThousandDouble * ThousandDouble * ThousandDouble, b.ToKbAsDouble, 0.001);
            Assert.AreEqual(tb * ThousandDecimal * ThousandDecimal * ThousandDecimal, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(tb * ThousandDouble * ThousandDouble, b.ToMbAsDouble);
            Assert.AreEqual(tb * ThousandDecimal * ThousandDecimal, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(tb * ThousandDouble, b.ToGbAsDouble);
            Assert.AreEqual(tb * ThousandDecimal, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(tb, b.ToTbAsDouble, 0.001);
            Assert.AreEqual(tb, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(tb / ThousandDouble, b.ToPbAsDouble, 0.001);
            Assert.AreEqual(tb / ThousandDecimal, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromTbWithUlongOverMaximum()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var b = BinarySize.FromTb((ulong.MaxValue >> 40) + 1UL);
            });

        }

        #endregion
        
        #region FromTb(decimal) tests

        [Test]
        public void TestFromTbWithDecimalZero()
        {
            var b = BinarySize.FromTb(0M);
            // Bytes
            Assert.AreEqual(0UL, b.ToBytes);
            // Kb
            Assert.AreEqual(0.0, b.ToKbAsDouble);
            Assert.AreEqual(0M, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(0.0, b.ToMbAsDouble);
            Assert.AreEqual(0M, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(0.0, b.ToGbAsDouble);
            Assert.AreEqual(0M, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(0.0, b.ToTbAsDouble);
            Assert.AreEqual(0M, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(0.0, b.ToPbAsDouble);
            Assert.AreEqual(0M, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromTbWithDecimalOne()
        {
            var b = BinarySize.FromTb(1M);
            // Bytes
            Assert.AreEqual(ThousandUlong * ThousandUlong * ThousandUlong * ThousandUlong, b.ToBytes);
            // Kb
            Assert.AreEqual(ThousandDouble * ThousandDouble * ThousandDouble, b.ToKbAsDouble, 0.001);
            Assert.AreEqual(ThousandDecimal * ThousandDecimal * ThousandDecimal, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(ThousandDouble * ThousandDouble, b.ToMbAsDouble);
            Assert.AreEqual(ThousandDecimal * ThousandDecimal, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(ThousandDouble, b.ToGbAsDouble);
            Assert.AreEqual(ThousandDecimal, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(1.0, b.ToTbAsDouble, 0.001);
            Assert.AreEqual(1M, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(1.0 / ThousandDouble, b.ToPbAsDouble, 0.001);
            Assert.AreEqual(1M / ThousandDecimal, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromTbWithDecimalMaximum()
        {
            {
                var tb = ulong.MaxValue >> 40;
                var b = BinarySize.FromTb((decimal) tb);
                // Bytes
                Assert.AreEqual(tb * ThousandUlong * ThousandUlong * ThousandUlong * ThousandUlong, b.ToBytes);
                // Kb
                Assert.AreEqual(tb * ThousandDouble * ThousandDouble * ThousandDouble, b.ToKbAsDouble, 0.001);
                Assert.AreEqual(tb * ThousandDecimal * ThousandDecimal * ThousandDecimal, b.ToKbAsDecimal);
                // Mb
                Assert.AreEqual(tb * ThousandDouble * ThousandDouble, b.ToMbAsDouble);
                Assert.AreEqual(tb * ThousandDecimal * ThousandDecimal, b.ToMbAsDecimal);
                // Gb
                Assert.AreEqual(tb * ThousandDouble, b.ToGbAsDouble);
                Assert.AreEqual(tb * ThousandDecimal, b.ToGbAsDecimal);
                // Tb
                Assert.AreEqual(tb, b.ToTbAsDouble, 0.001);
                Assert.AreEqual(tb, b.ToTbAsDecimal);
                // Pb
                Assert.AreEqual(tb / ThousandDouble, b.ToPbAsDouble, 0.001);
                Assert.AreEqual(tb / ThousandDecimal, b.ToPbAsDecimal);
            }
        }

        [Test]
        public void TestFromTbWithDecimalOverMaximum()
        {
            var tb = ulong.MaxValue >> 40;

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var b = BinarySize.FromTb((decimal)tb + 0.000001M);
            });
        }

        #endregion

        #region FromTb(double) tests

        [Test]
        public void TestFromTbWithDoubleZero()
        {
            var b = BinarySize.FromTb(0.0);
            // Bytes
            Assert.AreEqual(0UL, b.ToBytes);
            // Kb
            Assert.AreEqual(0.0, b.ToKbAsDouble);
            Assert.AreEqual(0M, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(0.0, b.ToMbAsDouble);
            Assert.AreEqual(0M, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(0.0, b.ToGbAsDouble);
            Assert.AreEqual(0M, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(0.0, b.ToTbAsDouble);
            Assert.AreEqual(0M, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(0.0, b.ToPbAsDouble);
            Assert.AreEqual(0M, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromTbWithDoubleOne()
        {
            var b = BinarySize.FromTb(1.0);
            // Bytes
            Assert.AreEqual(ThousandUlong * ThousandUlong * ThousandUlong * ThousandUlong, b.ToBytes);
            // Kb
            Assert.AreEqual(ThousandDouble * ThousandDouble * ThousandDouble, b.ToKbAsDouble, 0.001);
            Assert.AreEqual(ThousandDecimal * ThousandDecimal * ThousandDecimal, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(ThousandDouble * ThousandDouble, b.ToMbAsDouble);
            Assert.AreEqual(ThousandDecimal * ThousandDecimal, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(ThousandDouble, b.ToGbAsDouble);
            Assert.AreEqual(ThousandDecimal, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(1.0, b.ToTbAsDouble, 0.001);
            Assert.AreEqual(1M, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(1.0 / ThousandDouble, b.ToPbAsDouble, 0.001);
            Assert.AreEqual(1M / ThousandDecimal, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromTbWithDoubleMaximum()
        {
            // Note: Using "(double)(ulong.MaxValue >> 40)" here causes a rounding error when converted back to a ulong: it ends up 1 over the maximum allowable value
            var tb = (ulong.MaxValue >> 40) - 1;
            var b = BinarySize.FromTb((double)tb);
            // Bytes
            Assert.AreEqual(tb * ThousandUlong * ThousandUlong * ThousandUlong * ThousandUlong, b.ToBytes);
            // Kb
            Assert.AreEqual(tb * ThousandDouble * ThousandDouble * ThousandDouble, b.ToKbAsDouble, 0.001);
            Assert.AreEqual(tb * ThousandDecimal * ThousandDecimal * ThousandDecimal, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(tb * ThousandDouble * ThousandDouble, b.ToMbAsDouble);
            Assert.AreEqual(tb * ThousandDecimal * ThousandDecimal, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(tb * ThousandDouble, b.ToGbAsDouble);
            Assert.AreEqual(tb * ThousandDecimal, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(tb, b.ToTbAsDouble, 0.001);
            Assert.AreEqual(tb, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(tb / ThousandDouble, b.ToPbAsDouble, 0.001);
            Assert.AreEqual(tb / ThousandDecimal, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromTbWithDoubleOverMaximum()
        {
            var tb = (ulong.MaxValue >> 40);

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var b = BinarySize.FromTb((double)tb + 0.001);
            });
        }

        #endregion

        #region FromPb(ulong) tests

        [Test]
        public void TestFromPbWithUlongZero()
        {
            var b = BinarySize.FromPb(0);
            // Bytes
            Assert.AreEqual(0UL, b.ToBytes);
            // Kb
            Assert.AreEqual(0.0, b.ToKbAsDouble);
            Assert.AreEqual(0M, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(0.0, b.ToMbAsDouble);
            Assert.AreEqual(0M, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(0.0, b.ToGbAsDouble);
            Assert.AreEqual(0M, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(0.0, b.ToTbAsDouble);
            Assert.AreEqual(0M, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(0.0, b.ToPbAsDouble);
            Assert.AreEqual(0M, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromPbWithUlongOne()
        {
            var b = BinarySize.FromPb(1);
            // Bytes
            Assert.AreEqual(ThousandUlong * ThousandUlong * ThousandUlong * ThousandUlong * ThousandUlong, b.ToBytes);
            // Kb
            Assert.AreEqual(ThousandDouble * ThousandDouble * ThousandDouble * ThousandDouble, b.ToKbAsDouble, 0.001);
            Assert.AreEqual(ThousandDecimal * ThousandDecimal * ThousandDecimal * ThousandDecimal, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(ThousandDouble * ThousandDouble * ThousandDouble, b.ToMbAsDouble);
            Assert.AreEqual(ThousandDecimal * ThousandDecimal * ThousandDecimal, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(ThousandDouble * ThousandDouble, b.ToGbAsDouble);
            Assert.AreEqual(ThousandDecimal * ThousandDecimal, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(ThousandDouble, b.ToTbAsDouble, 0.001);
            Assert.AreEqual(ThousandDecimal, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(1.0, b.ToPbAsDouble, 0.001);
            Assert.AreEqual(1M, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromPbWithUlongMaximum()
        {
            var pb = ulong.MaxValue >> 50;
            var b = BinarySize.FromPb(pb);
            // Bytes
            Assert.AreEqual(pb * ThousandUlong * ThousandUlong * ThousandUlong * ThousandUlong * ThousandUlong, b.ToBytes);
            // Kb
            Assert.AreEqual(pb * ThousandDouble * ThousandDouble * ThousandDouble * ThousandDouble, b.ToKbAsDouble, 0.001);
            Assert.AreEqual(pb * ThousandDecimal * ThousandDecimal * ThousandDecimal * ThousandDecimal, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(pb * ThousandDouble * ThousandDouble * ThousandDouble, b.ToMbAsDouble);
            Assert.AreEqual(pb * ThousandDecimal * ThousandDecimal * ThousandDecimal, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(pb * ThousandDouble * ThousandDouble, b.ToGbAsDouble);
            Assert.AreEqual(pb * ThousandDecimal * ThousandDecimal, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(pb * ThousandDouble, b.ToTbAsDouble, 0.001);
            Assert.AreEqual(pb * ThousandDecimal, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(pb, b.ToPbAsDouble, 0.001);
            Assert.AreEqual(pb, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromPbWithUlongOverMaximum()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var b = BinarySize.FromPb((ulong.MaxValue >> 50) + 1UL);
            });

        }

        #endregion

        #region FromTb(decimal) tests

        [Test]
        public void TestFromPbWithDecimalZero()
        {
            var b = BinarySize.FromPb(0M);
            // Bytes
            Assert.AreEqual(0UL, b.ToBytes);
            // Kb
            Assert.AreEqual(0.0, b.ToKbAsDouble);
            Assert.AreEqual(0M, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(0.0, b.ToMbAsDouble);
            Assert.AreEqual(0M, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(0.0, b.ToGbAsDouble);
            Assert.AreEqual(0M, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(0.0, b.ToTbAsDouble);
            Assert.AreEqual(0M, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(0.0, b.ToPbAsDouble);
            Assert.AreEqual(0M, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromPbWithDecimalOne()
        {
            var b = BinarySize.FromPb(1M);
            // Bytes
            Assert.AreEqual(ThousandUlong * ThousandUlong * ThousandUlong * ThousandUlong * ThousandUlong, b.ToBytes);
            // Kb
            Assert.AreEqual(ThousandDouble * ThousandDouble * ThousandDouble * ThousandDouble, b.ToKbAsDouble, 0.001);
            Assert.AreEqual(ThousandDecimal * ThousandDecimal * ThousandDecimal * ThousandDecimal, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(ThousandDouble * ThousandDouble * ThousandDouble, b.ToMbAsDouble);
            Assert.AreEqual(ThousandDecimal * ThousandDecimal * ThousandDecimal, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(ThousandDouble * ThousandDouble, b.ToGbAsDouble);
            Assert.AreEqual(ThousandDecimal * ThousandDecimal, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(ThousandDouble, b.ToTbAsDouble, 0.001);
            Assert.AreEqual(ThousandDecimal, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(1.0, b.ToPbAsDouble, 0.001);
            Assert.AreEqual(1M, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromPbWithDecimalMaximum()
        {
            {
                var pb = ulong.MaxValue >> 50;
                var b = BinarySize.FromPb((decimal) pb);
                // Bytes
                Assert.AreEqual(pb * ThousandUlong * ThousandUlong * ThousandUlong * ThousandUlong * ThousandUlong, b.ToBytes);
                // Kb
                Assert.AreEqual(pb * ThousandDouble * ThousandDouble * ThousandDouble * ThousandDouble, b.ToKbAsDouble, 0.001);
                Assert.AreEqual(pb * ThousandDecimal * ThousandDecimal * ThousandDecimal * ThousandDecimal, b.ToKbAsDecimal);
                // Mb
                Assert.AreEqual(pb * ThousandDouble * ThousandDouble * ThousandDouble, b.ToMbAsDouble);
                Assert.AreEqual(pb * ThousandDecimal * ThousandDecimal * ThousandDecimal, b.ToMbAsDecimal);
                // Gb
                Assert.AreEqual(pb * ThousandDouble * ThousandDouble, b.ToGbAsDouble);
                Assert.AreEqual(pb * ThousandDecimal * ThousandDecimal, b.ToGbAsDecimal);
                // Tb
                Assert.AreEqual(pb * ThousandDouble, b.ToTbAsDouble, 0.001);
                Assert.AreEqual(pb * ThousandDecimal, b.ToTbAsDecimal);
                // Pb
                Assert.AreEqual(pb, b.ToPbAsDouble, 0.001);
                Assert.AreEqual(pb, b.ToPbAsDecimal);
            }
        }

        [Test]
        public void TestFromPbWithDecimalOverMaximum()
        {
            var pb = ulong.MaxValue >> 50;

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var b = BinarySize.FromPb((decimal)pb + 0.000001M);
            });
        }

        #endregion

        #region FromTb(double) tests

        [Test]
        public void TestFromPbWithDoubleZero()
        {
            var b = BinarySize.FromPb(0.0);
            // Bytes
            Assert.AreEqual(0UL, b.ToBytes);
            // Kb
            Assert.AreEqual(0.0, b.ToKbAsDouble);
            Assert.AreEqual(0M, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(0.0, b.ToMbAsDouble);
            Assert.AreEqual(0M, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(0.0, b.ToGbAsDouble);
            Assert.AreEqual(0M, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(0.0, b.ToTbAsDouble);
            Assert.AreEqual(0M, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(0.0, b.ToPbAsDouble);
            Assert.AreEqual(0M, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromPbWithDoubleOne()
        {
            var b = BinarySize.FromPb(1.0);
            // Bytes
            Assert.AreEqual(ThousandUlong * ThousandUlong * ThousandUlong * ThousandUlong * ThousandUlong, b.ToBytes);
            // Kb
            Assert.AreEqual(ThousandDouble * ThousandDouble * ThousandDouble * ThousandDouble, b.ToKbAsDouble, 0.001);
            Assert.AreEqual(ThousandDecimal * ThousandDecimal * ThousandDecimal * ThousandDecimal, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(ThousandDouble * ThousandDouble * ThousandDouble, b.ToMbAsDouble);
            Assert.AreEqual(ThousandDecimal * ThousandDecimal * ThousandDecimal, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(ThousandDouble * ThousandDouble, b.ToGbAsDouble);
            Assert.AreEqual(ThousandDecimal * ThousandDecimal, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(ThousandDouble, b.ToTbAsDouble, 0.001);
            Assert.AreEqual(ThousandDecimal, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(1.0, b.ToPbAsDouble, 0.001);
            Assert.AreEqual(1M, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromPbWithDoubleMaximum()
        {
            // Note: Using "(double)(ulong.MaxValue >> 50)" here causes a rounding error when converted back to a ulong: it ends up 1 over the maximum allowable value
            var pb = (ulong.MaxValue >> 50) - 1;
            var b = BinarySize.FromPb((double)pb);
            // Bytes
            Assert.AreEqual(pb * ThousandUlong * ThousandUlong * ThousandUlong * ThousandUlong * ThousandUlong, b.ToBytes);
            // Kb
            Assert.AreEqual(pb * ThousandDouble * ThousandDouble * ThousandDouble * ThousandDouble, b.ToKbAsDouble, 0.001);
            Assert.AreEqual(pb * ThousandDecimal * ThousandDecimal * ThousandDecimal * ThousandUlong, b.ToKbAsDecimal);
            // Mb
            Assert.AreEqual(pb * ThousandDouble * ThousandDouble * ThousandDouble, b.ToMbAsDouble);
            Assert.AreEqual(pb * ThousandDecimal * ThousandDecimal * ThousandUlong, b.ToMbAsDecimal);
            // Gb
            Assert.AreEqual(pb * ThousandDouble * ThousandDouble, b.ToGbAsDouble);
            Assert.AreEqual(pb * ThousandDecimal * ThousandUlong, b.ToGbAsDecimal);
            // Tb
            Assert.AreEqual(pb * ThousandDouble, b.ToTbAsDouble, 0.001);
            Assert.AreEqual(pb * ThousandUlong, b.ToTbAsDecimal);
            // Pb
            Assert.AreEqual(pb, b.ToPbAsDouble, 0.001);
            Assert.AreEqual(pb, b.ToPbAsDecimal);
        }

        [Test]
        public void TestFromPbWithDoubleOverMaximum()
        {
            var tb = (ulong.MaxValue >> 50);

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var b = BinarySize.FromPb((double)tb + 0.001);
            });
        }

        #endregion

        #endregion
    }
}