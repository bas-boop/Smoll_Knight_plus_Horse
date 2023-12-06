using System;

namespace Baz_geluk9.Extensions
{
    public sealed class StringValueAttribute : Attribute
    {
        public string Value { get; }

        public StringValueAttribute(string value) => Value = value;
    }
}