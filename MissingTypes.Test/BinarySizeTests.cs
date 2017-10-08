using NUnit.Framework;

namespace uk.co.mainwave.MissingTypes.Test
{
    public static class BinarySizeTests
    {
        [TestCase]
        public static void TestStuff()
        {
            var bs = BinarySize.FromBytes((1024L * 1024L * 1024L) + 42L);
            Assert.AreEqual(42L, bs.Bytes);
            Assert.AreEqual(0L, bs.Kb);
            Assert.AreEqual(0L, bs.Mb);
            Assert.AreEqual(1L, bs.Gb);
            Assert.AreEqual(0L, bs.Tb);
            Assert.AreEqual(0L, bs.Pb);

            bs = BinarySize.FromKb(1.5D);
            Assert.AreEqual(512L, bs.Bytes);
            Assert.AreEqual(1L, bs.Kb);
            Assert.AreEqual(0L, bs.Mb);
            Assert.AreEqual(0L, bs.Gb);
            Assert.AreEqual(0L, bs.Tb);
            Assert.AreEqual(0L, bs.Pb);

            bs = BinarySize.FromKb(1025.5M);
            Assert.AreEqual(512L, bs.Bytes);
            Assert.AreEqual(1L, bs.Kb);
            Assert.AreEqual(1L, bs.Mb);
            Assert.AreEqual(0L, bs.Gb);
            Assert.AreEqual(0L, bs.Tb);
            Assert.AreEqual(0L, bs.Pb);

            bs = (BinarySize)20;
            Assert.AreEqual(20L, bs.Bytes);
            Assert.AreEqual(0L, bs.Kb);
            Assert.AreEqual(0L, bs.Mb);
            Assert.AreEqual(0L, bs.Gb);
            Assert.AreEqual(0L, bs.Tb);
            Assert.AreEqual(0L, bs.Pb);

            bs = BinarySize.FromBytes(1024 + 512 + 256);
            Assert.AreEqual(1.75M, bs.TotalKbAsDecimal);
            Assert.AreEqual(1.75D, bs.TotalKbAsDouble, 0.01D);
        }
    }
}