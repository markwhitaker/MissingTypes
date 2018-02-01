using System;

namespace uk.co.mainwave.MissingTypes
{
    /// <summary>
    /// A better way to represent binary sizes in bytes and multiples of bytes
    /// </summary>
    /// <inheritdoc cref="IEquatable{T}"/>
    /// <inheritdoc cref="IComparable{T}"/>
    public sealed class BinarySize : IEquatable<BinarySize>, IComparable<BinarySize>
    {
        #region Constants

        private const ulong KbMultiplier = 1024L;
        private const ulong MbMultiplier = KbMultiplier << 10;
        private const ulong GbMultiplier = KbMultiplier << 20;
        private const ulong TbMultiplier = KbMultiplier << 30;
        private const ulong PbMultiplier = KbMultiplier << 40;

        private const ulong ByteMask = 0x3FFL;

        #endregion

        #region Fields

        private readonly ulong _bytes;

        #endregion

        #region Constructors

        private BinarySize(ulong bytes)
        {
            _bytes = bytes;
        }

        #endregion

        #region Static constructors

        #region Bytes

        /// <summary>
        /// Construct with a number of bytes
        /// </summary>
        /// <param name="bytes">Total number of bytes to represent</param>
        /// <returns>New <see cref="BinarySize"/> object</returns>
        public static BinarySize FromBytes(uint bytes)
        {
            return new BinarySize(bytes);
        }

        /// <summary>
        /// Construct with a number of bytes
        /// </summary>
        /// <param name="bytes">Total number of bytes to represent</param>
        /// <returns>New <see cref="BinarySize"/> object</returns>
        public static BinarySize FromBytes(ulong bytes)
        {
            return new BinarySize(bytes);
        }

        #endregion

        #region Kilobytes

        /// <summary>
        /// Construct with a number of kilobytes
        /// </summary>
        /// <param name="kb">Total number of kilobytes to represent</param>
        /// <returns>New <see cref="BinarySize"/> object</returns>
        public static BinarySize FromKb(uint kb)
        {
            return FromBytes(kb * KbMultiplier);
        }

        /// <summary>
        /// Construct with a number of kilobytes
        /// </summary>
        /// <param name="kb">Total or fractional number of kilobytes to represent</param>
        /// <exception cref="ArgumentOutOfRangeException">kb value is negative or too large</exception>
        /// <returns>New <see cref="BinarySize"/> object</returns>
        public static BinarySize FromKb(decimal kb)
        {
            CheckRange(kb, KbMultiplier);
            return FromBytes((ulong)(kb * KbMultiplier));
        }

        /// <summary>
        /// Construct with a number of kilobytes
        /// </summary>
        /// <param name="kb">Total or fractional number of kilobytes to represent</param>
        /// <exception cref="ArgumentOutOfRangeException">kb value is negative or too large</exception>
        /// <returns>New <see cref="BinarySize"/> object</returns>
        public static BinarySize FromKb(double kb)
        {
            CheckRange(kb, KbMultiplier);
            return FromBytes((ulong)(kb * KbMultiplier));
        }

        #endregion

        #region Megabytes

        /// <summary>
        /// Construct with a number of megabytes
        /// </summary>
        /// <param name="kb">Total number of megabytes to represent</param>
        /// <returns>New <see cref="BinarySize"/> object</returns>
        public static BinarySize FromMb(uint mb)
        {
            return FromBytes(mb * MbMultiplier);
        }

        /// <summary>
        /// Construct with a number of megabytes
        /// </summary>
        /// <param name="kb">Total or fractional number of megabytes to represent</param>
        /// <exception cref="ArgumentOutOfRangeException">mb value is negative or too large</exception>
        /// <returns>New <see cref="BinarySize"/> object</returns>
        public static BinarySize FromMb(decimal mb)
        {
            CheckRange(mb, MbMultiplier);
            return FromBytes((ulong)(mb * MbMultiplier));
        }

        /// <summary>
        /// Construct with a number of megabytes
        /// </summary>
        /// <param name="kb">Total or fractional number of megabytes to represent</param>
        /// <exception cref="ArgumentOutOfRangeException">mb value is negative or too large</exception>
        /// <returns>New <see cref="BinarySize"/> object</returns>
        public static BinarySize FromMb(double mb)
        {
            CheckRange(mb, MbMultiplier);
            return FromBytes((ulong)(mb * MbMultiplier));
        }

        #endregion

        #region Gigabytes

        public static BinarySize FromGb(uint gb)
        {
            return FromBytes(gb * GbMultiplier);
        }

        public static BinarySize FromGb(decimal gb)
        {
            CheckRange(gb, GbMultiplier);
            return FromBytes((ulong)(gb * GbMultiplier));
        }

        public static BinarySize FromGb(double gb)
        {
            CheckRange(gb, GbMultiplier);
            return FromBytes((ulong)(gb * GbMultiplier));
        }

        #endregion

        #region Terabytes

        public static BinarySize FromTb(uint tb)
        {
            return FromBytes(tb * TbMultiplier);
        }

        public static BinarySize FromTb(decimal tb)
        {
            CheckRange(tb, TbMultiplier);
            return FromBytes((ulong)(tb * TbMultiplier));
        }

        public static BinarySize FromTb(double tb)
        {
            CheckRange(tb, TbMultiplier);
            return FromBytes((ulong)(tb * TbMultiplier));
        }

        #endregion

        #region Petabytes

        public static BinarySize FromPb(uint pb)
        {
            return FromBytes(pb * PbMultiplier);
        }

        public static BinarySize FromPb(decimal pb)
        {
            CheckRange(pb, PbMultiplier);
            return FromBytes((ulong)(pb * PbMultiplier));
        }

        public static BinarySize FromPb(double pb)
        {
            CheckRange(pb, PbMultiplier);
            return FromBytes((ulong)(pb * PbMultiplier));
        }

        #endregion

        #endregion

        #region Properties

        #region Bytes

        public ulong ToBytes => _bytes;

        #endregion

        #region Kilobytes

        public double ToKbAsDouble => _bytes / (double)KbMultiplier;

        public decimal ToKbAsDecimal => _bytes / (decimal)KbMultiplier;

        #endregion

        #region Megabytes

        public double ToMbAsDouble => _bytes / (double)MbMultiplier;

        public decimal ToMbAsDecimal => _bytes / (decimal)MbMultiplier;

        #endregion

        #region Gigabytes

        public double ToGbAsDouble => _bytes / (double)GbMultiplier;

        public decimal ToGbAsDecimal => _bytes / (decimal)GbMultiplier;

        #endregion

        #region Terabytes

        public double ToTbAsDouble => _bytes / (double)TbMultiplier;

        public decimal ToTbAsDecimal => _bytes / (decimal)TbMultiplier;

        #endregion

        #region Petabytes

        public double ToPbAsDouble => _bytes / (double)PbMultiplier;

        public decimal ToPbAsDecimal => _bytes / (decimal)PbMultiplier;

        #endregion

        #endregion

        #region Operators

        public static explicit operator BinarySize(uint value)
        {
            return new BinarySize(value);
        }

        public static explicit operator BinarySize(ulong value)
        {
            return new BinarySize(value);
        }

        public static BinarySize operator +(BinarySize a, uint value)
        {
            return new BinarySize(a._bytes + value);
        }

        public static BinarySize operator +(BinarySize a, ulong value)
        {
            return new BinarySize(a._bytes + value);
        }

        public static BinarySize operator -(BinarySize a, uint value)
        {
            return new BinarySize(Math.Max(0, a._bytes - value));
        }

        public static BinarySize operator -(BinarySize a, ulong value)
        {
            return new BinarySize(Math.Max(0, a._bytes - value));
        }

        public static bool operator ==(BinarySize me, BinarySize you)
        {
            return me != null && me.Equals(you);
        }

        public static bool operator !=(BinarySize me, BinarySize you)
        {
            return !(me == you);
        }

        public static bool operator >(BinarySize me, BinarySize you)
        {
            return me.CompareTo(you) > 0;
        }

        public static bool operator <(BinarySize me, BinarySize you)
        {
            return me.CompareTo(you) < 0;
        }

        public static bool operator >=(BinarySize me, BinarySize you)
        {
            return me.CompareTo(you) >= 0;
        }

        public static bool operator <=(BinarySize me, BinarySize you)
        {
            return me.CompareTo(you) <= 0;
        }

        #endregion

        public bool Equals(BinarySize other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;
            return _bytes == other._bytes;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj is BinarySize && Equals((BinarySize) obj);
        }

        public override int GetHashCode()
        {
            return _bytes.GetHashCode();
        }

        public int CompareTo(BinarySize other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            return _bytes.CompareTo(other._bytes);
        }

        #region Private methods

        private static void CheckRange(decimal value, ulong multiplier)
        {
            if (value < 0M)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (value > decimal.MaxValue / multiplier)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        private static void CheckRange(double value, ulong multiplier)
        {
            if (value < 0.0)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (value > double.MaxValue / multiplier)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        #endregion
    }
}