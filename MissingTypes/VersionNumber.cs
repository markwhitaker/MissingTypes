using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace uk.co.mainwave.MissingTypes
{
    /// <summary>
    /// Represents a version number with up to 4 parts.
    /// </summary>
    public class VersionNumber :
        IComparable<VersionNumber>,
        IComparable<Version>,
        IComparable<uint>,
        IComparable<string>,
        IEquatable<VersionNumber>,
        IEquatable<Version>,
        IEquatable<uint>,
        IEquatable<string>
    {
        private const int MaxParts = 4;
        private static readonly Regex ValidVersionString = new Regex(@"^\d+(\.\d+){0,3}$");

        private readonly uint[] _parts = new uint[MaxParts];

        #region Constructors

        /// <summary>
        /// Construct with the first part. All other parts are initialized to 0.
        /// </summary>
        /// <param name="part1">The first part of the version number.</param>
        public VersionNumber(uint part1)
        {
            Set(part1);
        }

        /// <summary>
        /// Construct with the first two parts. All other parts are initialized to 0.
        /// </summary>
        /// <param name="part1">The first part of the version number.</param>
        /// <param name="part2">The second part of the version number.</param>
        public VersionNumber(uint part1, uint part2)
        {
            Set(part1, part2);
        }

        /// <summary>
        /// Construct with the first three parts. All other parts are initialized to 0.
        /// </summary>
        /// <param name="part1">The first part of the version number.</param>
        /// <param name="part2">The second part of the version number.</param>
        /// <param name="part3">The third part of the version number.</param>
        public VersionNumber(uint part1, uint part2, uint part3)
        {
            Set(part1, part2, part3);
        }

        /// <summary>
        /// Construct with all four parts.
        /// </summary>
        /// <param name="part1">The first part of the version number.</param>
        /// <param name="part2">The second part of the version number.</param>
        /// <param name="part3">The third part of the version number.</param>
        /// <param name="part4">The fourth part of the version number.</param>
        public VersionNumber(uint part1, uint part2, uint part3, uint part4)
        {
            Set(part1, part2, part3, part4);
        }

        /// <summary>
        /// Construct from a string containing a version number.
        /// </summary>
        /// <param name="versionString">String representation of a version number.</param>
        /// <exception cref="NullReferenceException">versionString is null</exception>
        /// <exception cref="FormatException">The string does not contain a valid version number</exception>
        public VersionNumber(string versionString)
        {
            if (versionString == null)
            {
                throw new NullReferenceException();
            }

            var cleanValue = versionString.Trim();
            if (!ValidVersionString.IsMatch(cleanValue))
            {
                throw new FormatException();
            }

            Set(cleanValue.Split('.').Select(uint.Parse).ToArray());
        }

        /// <summary>
        /// Construct from a <see cref="Version"/> object. Any negative parts in the <see cref="Version"/> object will be replaced with 0.
        /// </summary>
        /// <param name="version">String representation of a version number.</param>
        /// <exception cref="NullReferenceException">version is null</exception>
        public VersionNumber(Version version)
        {
            if (version == null)
            {
                throw new NullReferenceException();
            }

            Set((uint)Math.Max(0, version.Major),
                (uint)Math.Max(0, version.Minor),
                (uint)Math.Max(0, version.Build),
                (uint)Math.Max(0, version.Revision));
        }

        #endregion

        #region Public properties

        /// <summary>
        /// The first part of the version number
        /// </summary>
        public uint Part1 => _parts[0];

        /// <summary>
        /// The second part of the version number
        /// </summary>
        public uint Part2 => _parts[1];

        /// <summary>
        /// The third part of the version number
        /// </summary>
        public uint Part3 => _parts[2];

        /// <summary>
        /// The fourth part of the version number
        /// </summary>
        public uint Part4 => _parts[3];

        /// <summary>
        /// All parts of the version number
        /// </summary>
        public uint[] AllParts => _parts;

        #endregion

        #region Public methods

        /// <summary>
        /// Get a string representation, with all trailing zero parts omitted.
        /// </summary>
        /// <example>4.0.1.0 will return "4.0.1"</example>
        /// <example>0.1.0.0 will return "0.1"</example>
        /// <returns>A short string representation of this version number</returns>
        public string ToShortString()
        {
            return string.Join(".", _parts
                .Reverse()
                .SkipWhile(p => p == 0)
                .Reverse());
        }

        /// <summary>
        /// Get a string representation, with all parts included even if zero.
        /// </summary>
        /// <example>4.1.0.0 will return "4.1.0.0"</example>
        /// <returns>A short string representation of this version number</returns>
        public string ToLongString()
        {
            return string.Join(".", _parts);
        }

        #endregion

        #region VersionNumber operators

        public static bool operator ==(VersionNumber v1, VersionNumber v2)
        {
            if (ReferenceEquals(v1, null))
            {
                return ReferenceEquals(v2, null);
            }
            return ReferenceEquals(v1, v2) || v1.Equals(v2);
        }

        public static bool operator !=(VersionNumber v1, VersionNumber v2)
        {
            return !(v1 == v2);
        }

        public static bool operator >(VersionNumber v1, VersionNumber v2)
        {
            for (var i = 0; i < MaxParts; i++)
            {
                if (v1._parts[i] > v2._parts[i])
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator <(VersionNumber v1, VersionNumber v2)
        {
            for (var i = 0; i < MaxParts; i++)
            {
                if (v1._parts[i] < v2._parts[i])
                {
                    return true;
                }
            }

            return false;
        }

        public static bool operator >=(VersionNumber v1, VersionNumber v2)
        {
            return !(v1 < v2);
        }

        public static bool operator <=(VersionNumber v1, VersionNumber v2)
        {
            return !(v1 > v2);
        }

        #endregion

        #region Version operators

        public static bool operator ==(VersionNumber v1, Version v2)
        {
            if (ReferenceEquals(v2, null))
            {
                return false;
            }
            return !ReferenceEquals(null, v1) && v1.Equals(v2);
        }

        public static bool operator !=(VersionNumber v1, Version v2)
        {
            return v1 != new VersionNumber(v2);
        }

        public static bool operator >(VersionNumber v1, Version v2)
        {
            return v1 > new VersionNumber(v2);
        }

        public static bool operator <(VersionNumber v1, Version v2)
        {
            return v1 < new VersionNumber(v2);
        }

        public static bool operator >=(VersionNumber v1, Version v2)
        {
            return v1 >= new VersionNumber(v2);
        }

        public static bool operator <=(VersionNumber v1, Version v2)
        {
            return v1 <= new VersionNumber(v2);
        }

        #endregion

        #region uint operators

        public static bool operator ==(VersionNumber v1, uint v2)
        {
            return !ReferenceEquals(null, v1) && v1.Equals(v2);
        }

        public static bool operator !=(VersionNumber v1, uint v2)
        {
            return v1 != new VersionNumber(v2);
        }

        public static bool operator >(VersionNumber v1, uint v2)
        {
            return v1 > new VersionNumber(v2);
        }

        public static bool operator <(VersionNumber v1, uint v2)
        {
            return v1 < new VersionNumber(v2);
        }

        public static bool operator >=(VersionNumber v1, uint v2)
        {
            return v1 >= new VersionNumber(v2);
        }

        public static bool operator <=(VersionNumber v1, uint v2)
        {
            return v1 <= new VersionNumber(v2);
        }

        #endregion

        #region string operators

        public static bool operator ==(VersionNumber v1, string v2)
        {
            return !ReferenceEquals(null, v1) && !ReferenceEquals(v2, null) && v1.Equals(v2);
        }

        public static bool operator !=(VersionNumber v1, string v2)
        {
            return v1 != new VersionNumber(v2);
        }

        public static bool operator >(VersionNumber v1, string v2)
        {
            return v1 > new VersionNumber(v2);
        }

        public static bool operator <(VersionNumber v1, string v2)
        {
            return v1 < new VersionNumber(v2);
        }

        public static bool operator >=(VersionNumber v1, string v2)
        {
            return v1 >= new VersionNumber(v2);
        }

        public static bool operator <=(VersionNumber v1, string v2)
        {
            return v1 <= new VersionNumber(v2);
        }

        #endregion

        #region IEquatable<> interface methods

        public bool Equals(VersionNumber other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            return ReferenceEquals(this, other) || _parts.SequenceEqual(other._parts);
        }

        public bool Equals(Version other)
        {
            return Equals(new VersionNumber(other));
        }

        public bool Equals(uint other)
        {
            return Equals(new VersionNumber(other));
        }

        public bool Equals(string other)
        {
            return Equals(new VersionNumber(other));
        }

        #endregion

        #region IComparable<> interface methods

        public int CompareTo(VersionNumber other)
        {
            if (this > other)
            {
                return 1;
            }
            if (this < other)
            {
                return -1;
            }
            return 0;
        }

        public int CompareTo(Version other)
        {
            return CompareTo(new VersionNumber(other));
        }

        public int CompareTo(uint other)
        {
            return CompareTo(new VersionNumber(other));
        }

        public int CompareTo(string other)
        {
            return CompareTo(new VersionNumber(other));
        }

        #endregion

        #region System.Object overrides

        public override bool Equals(object obj)
        {
            if (obj is VersionNumber)
            {
                return this == (VersionNumber)obj;
            }
            if (obj is Version)
            {
                return this == (Version)obj;
            }
            if (obj is string)
            {
                return this == (string)obj;
            }
            if (obj is UInt32)
            {
                return this == (uint)obj;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (_parts != null ? _parts.GetHashCode() : 0);
        }
        public override string ToString()
        {
            return ToLongString();
        }

        #endregion

        #region Private methods

        private void Set(params uint[] parts)
        {
            if (parts == null)
            {
                throw new Exception();
            }

            var array = parts.ToArray();
            if (array.Length == 0 || array.Length > MaxParts)
            {
                throw new Exception();
            }

            Array.Copy(array, _parts, array.Length);
        }

        #endregion
    }
}