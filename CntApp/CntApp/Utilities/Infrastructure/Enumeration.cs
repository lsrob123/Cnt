using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using SQLite;
using Xamarin.Forms.Internals;

namespace CntApp.Utilities.Infrastructure
{
    public abstract class Enumeration 
    {
        protected Enumeration() { }

        protected Enumeration(int value, string name)
        {
            SetData(value, name);
        }

        protected Enumeration(Enumeration other)
        {
            SetData(other.Value, other.Name);
        }

        public virtual int Value { get; set; }

        [MaxLength(128)]
        public virtual string Name { get; set; }

        public int CompareTo(object other)
        {
            return Value.CompareTo(((Enumeration)other).Value);
        }

        public void AssignDefaultValuesToComplexPropertiesIfNull() { }

        protected void SetData(int value, string name)
        {
            Value = value;
            Name = name;
        }

        protected void SetValueAndName(Enumeration other)
        {
            SetData(other.Value, other.Name);
        }

        public override string ToString()
        {
            return Name;
        }

        public static ICollection<T> GetAll<T>() where T : Enumeration
        {
            var type = typeof(T);
            var values = type
                .GetProperties()
                .Select(x => x.GetValue(null))
                .OfType<T>()
                .ToList();
            return values;
        }

        public bool EqualsAnyIn<T>(params T[] list) where T : Enumeration
        {
            var result = list.Any(x => x.Equals(this));
            return result;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Enumeration castedEnumeration))
                return false;

            var typeMatches = GetType() == obj.GetType();
            var valueMatches = Value.Equals(castedEnumeration.Value);

            return typeMatches && valueMatches;
        }

        public override int GetHashCode()
        {
            return GetValueHashCode();
        }

        private int GetValueHashCode()
        {
            return Value.GetHashCode();
        }

        public static T FromValue<T>(int value) where T : Enumeration
        {
            var matchingItem = Parse<T, int>(value, item => item.Value == value);
            return matchingItem;
        }

        public static T FromName<T>(string name, StringComparison stringComparison = StringComparison.OrdinalIgnoreCase)
            where T : Enumeration
        {
            var matchingItem = Parse<T, string>(name, item => item.Name.Equals(name, stringComparison));
            return matchingItem;
        }

        protected static T Parse<T, TK>(TK value, Func<T, bool> predicate) where T : Enumeration
        {
            var matchingItem = GetAll<T>().FirstOrDefault(predicate);
            return matchingItem;
        }

        public virtual HttpStatusCode ToHttpStatusCode()
        {
            var httpStatusCode = (HttpStatusCode)Value;
            return httpStatusCode;
        }
    }
}
