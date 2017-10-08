using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace uk.co.mainwave.MissingTypes
{
    public class VersionNumber :
        IComparable<VersionNumber>,
        IComparable<int>,
        IComparable<string>,
        IEquatable<VersionNumber>,
        IEquatable<int>,
        IEquatable<string>
    {
        private const int MaxParts = 4;
        private static readonly Regex ValidVersionString = new Regex(@"^\d+(\.\d+){0,3}$");

        private readonly int[] _parts = new int[MaxParts];

        #region Constructors

        public VersionNumber(params int[] numbers)
        {
            Set(numbers);
        }

        public VersionNumber(string value)
        {
            if (value == null)
            {
                throw new Exception();
            }

            var cleanValue = value.Trim();
            if (!ValidVersionString.IsMatch(cleanValue))
            {
                throw new Exception("Invalid string");
            }

            Set(cleanValue.Split('.').Select(int.Parse));
        }

        #endregion

        #region VersionNumber operators

        public static bool operator ==(VersionNumber v1, VersionNumber v2)
        {
            return !ReferenceEquals(null, v1) && v1.Equals(v2);
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

        #region int operators

        public static bool operator ==(VersionNumber v1, int v2)
        {
            return !ReferenceEquals(null, v1) && v1.Equals(v2);
        }

        public static bool operator !=(VersionNumber v1, int v2)
        {
            return v1 != new VersionNumber(v2);
        }

        public static bool operator >(VersionNumber v1, int v2)
        {
            return v1 > new VersionNumber(v2);
        }

        public static bool operator <(VersionNumber v1, int v2)
        {
            return v1 < new VersionNumber(v2);
        }

        public static bool operator >=(VersionNumber v1, int v2)
        {
            return v1 >= new VersionNumber(v2);
        }

        public static bool operator <=(VersionNumber v1, int v2)
        {
            return v1 <= new VersionNumber(v2);
        }

        #endregion

        #region string operators

        public static bool operator ==(VersionNumber v1, string v2)
        {
            try
            {
                return !ReferenceEquals(null, v1) && v1.Equals(v2);
            }
            catch
            {
                return false;
            }
        }

        public static bool operator !=(VersionNumber v1, string v2)
        {
            try
            {
                return v1 != new VersionNumber(v2);
            }
            catch
            {
                return true;
            }
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

        #region Public methods

        public string ToShortString()
        {
            return string.Join(".", _parts.Reverse().SkipWhile(p => p == 0).Reverse());
        }

        public string ToLongString()
        {
            return string.Join(".", _parts);
        }

        #endregion

        #region Overrides and interface methods

        public bool Equals(VersionNumber other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }
            return ReferenceEquals(this, other) || _parts.SequenceEqual(other._parts);
        }

        public bool Equals(int other)
        {
            return Equals(new VersionNumber(other));
        }

        public bool Equals(string other)
        {
            return Equals(new VersionNumber(other));
        }

        public override bool Equals(object obj)
        {
            if (obj is VersionNumber)
            {
                return this == (VersionNumber)obj;
            }
            if (obj is string)
            {
                return this == (string)obj;
            }
            if (obj is Int32)
            {
                return this == (int)obj;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return (_parts != null ? _parts.GetHashCode() : 0);
        }

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

        public int CompareTo(int other)
        {
            return CompareTo(new VersionNumber(other));
        }

        public int CompareTo(string other)
        {
            return CompareTo(new VersionNumber(other));
        }

        public override string ToString()
        {
            return ToLongString();
        }

        #endregion

        #region Private methods

        private void Set(IEnumerable<int> parts)
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