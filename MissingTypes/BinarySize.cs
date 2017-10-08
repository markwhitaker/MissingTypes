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

        private const long KbMultiplier = 1024L;
        private const long MbMultiplier = KbMultiplier << 10;
        private const long GbMultiplier = KbMultiplier << 20;
        private const long TbMultiplier = KbMultiplier << 30;
        private const long PbMultiplier = KbMultiplier << 40;

        private const long ByteMask = 0x3FFL;

        #endregion

        #region Fields

        private readonly long _bytes;

        #endregion

        #region Constructors

        private BinarySize(long bytes)
        {
            _bytes = bytes;
        }

        #endregion

        #region Static constructors

        #region Bytes

        public static BinarySize FromBytes(int bytes)
        {
            return new BinarySize(bytes);
        }

        public static BinarySize FromBytes(long bytes)
        {
            return new BinarySize(bytes);
        }

        #endregion

        #region Kilobytes

        public static BinarySize FromKb(int kb)
        {
            return FromBytes(kb * KbMultiplier);
        }

        public static BinarySize FromKb(long kb)
        {
            return FromBytes(kb * KbMultiplier);
        }

        public static BinarySize FromKb(decimal kb)
        {
            return FromBytes((long)(kb * KbMultiplier));
        }

        public static BinarySize FromKb(double kb)
        {
            return FromBytes((long)(kb * KbMultiplier));
        }

        #endregion

        #region Megabytes

        public static BinarySize FromMb(int mb)
        {
            return FromBytes(mb * MbMultiplier);
        }

        public static BinarySize FromMb(long mb)
        {
            return FromBytes(mb * MbMultiplier);
        }

        public static BinarySize FromMb(decimal mb)
        {
            return FromBytes((long)(mb * MbMultiplier));
        }

        public static BinarySize FromMb(double mb)
        {
            return FromBytes((long)(mb * MbMultiplier));
        }

        #endregion

        #region Gigabytes

        public static BinarySize FromGb(int gb)
        {
            return FromBytes(gb * GbMultiplier);
        }

        public static BinarySize FromGb(long gb)
        {
            return FromBytes(gb * GbMultiplier);
        }

        public static BinarySize FromGb(decimal gb)
        {
            return FromBytes((long)(gb * GbMultiplier));
        }

        public static BinarySize FromGb(double gb)
        {
            return FromBytes((long)(gb * GbMultiplier));
        }

        #endregion

        #region Terabytes

        public static BinarySize FromTb(int tb)
        {
            return FromBytes(tb * TbMultiplier);
        }

        public static BinarySize FromTb(long tb)
        {
            return FromBytes(tb * TbMultiplier);
        }

        public static BinarySize FromTb(decimal tb)
        {
            return FromBytes((long)(tb * TbMultiplier));
        }

        public static BinarySize FromTb(double tb)
        {
            return FromBytes((long)(tb * TbMultiplier));
        }

        #endregion

        #region Petabytes

        public static BinarySize FromPb(int pb)
        {
            return FromBytes(pb * PbMultiplier);
        }

        public static BinarySize FromPb(long pb)
        {
            return FromBytes(pb * PbMultiplier);
        }

        public static BinarySize FromPb(decimal pb)
        {
            return FromBytes((long)(pb * PbMultiplier));
        }

        public static BinarySize FromPb(double pb)
        {
            return FromBytes((long)(pb * PbMultiplier));
        }

        #endregion

        #endregion

        #region Properties

        #region Bytes

        public long TotalBytes => _bytes;

        public long Bytes => (_bytes & ByteMask);

        #endregion

        #region Kilobytes

        public long Kb => (_bytes >> 10) & ByteMask;

        public double TotalKbAsDouble => _bytes / (double)KbMultiplier;

        public decimal TotalKbAsDecimal => _bytes / (decimal)KbMultiplier;

        #endregion

        #region Megabytes

        public long Mb => (_bytes >> 20) & ByteMask;

        public double TotalMbAsDouble => _bytes / (double)MbMultiplier;

        public decimal TotalMbAsDecimal => _bytes / (decimal)MbMultiplier;

        #endregion

        public long Gb => (_bytes >> 30) & ByteMask;

        public long Tb => (_bytes >> 40) & ByteMask;

        public long Pb => (_bytes >> 50) & ByteMask;

        #endregion

        #region Operators

        public static explicit operator BinarySize(int value)
        {
            return new BinarySize(value);
        }

        public static explicit operator BinarySize(long value)
        {
            return new BinarySize(value);
        }

        public static BinarySize operator +(BinarySize a, int value)
        {
            return new BinarySize(a._bytes + value);
        }

        public static BinarySize operator +(BinarySize a, long value)
        {
            return new BinarySize(a._bytes + value);
        }

        public static BinarySize operator -(BinarySize a, int value)
        {
            return new BinarySize(Math.Max(0, a._bytes - value));
        }

        public static BinarySize operator -(BinarySize a, long value)
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
    }
}