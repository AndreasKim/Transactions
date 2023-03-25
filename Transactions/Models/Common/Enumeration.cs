using System.Reflection;

namespace Transactions.Models.Common
{
    public abstract class Enumeration : IComparable
    {
        public string Name { get; private set; }

        public int Value { get; private set; }

        protected Enumeration(int value, string name) => (Value, Name) = (value, name);

        public override string ToString() => Name;

        public static IEnumerable<T> GetAll<T>() where T : Enumeration =>
            typeof(T).GetFields(BindingFlags.Public |
                                BindingFlags.Static |
                                BindingFlags.DeclaredOnly)
                     .Select(f => f.GetValue(null))
                     .Cast<T>();

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj is not Enumeration otherValue)
            {
                return false;
            }

            var typeMatches = GetType().Equals(obj.GetType());
            var valueMatches = Value.Equals(otherValue.Value);

            return typeMatches && valueMatches;
        }

        public int CompareTo(object? other) 
        {
            if (other is null) 
                return 1;

            return Value.CompareTo(((Enumeration)other).Value);
        }

        public override int GetHashCode() => Value.GetHashCode();

    }
}
