using System;
using System.Collections;
using System.ComponentModel;

namespace RSBot
{
    public class DictionaryPropertyDescriptor : PropertyDescriptor
    {
        private const char Spliter = ':';

        private readonly IDictionary dictionary;
        private readonly object key;

        internal DictionaryPropertyDescriptor(IDictionary d, object key)
            : base(key.ToString().Split(Spliter)[0], null)
        {
            dictionary = d;

            var split = key.ToString().Split(Spliter);
            this.key = split[0];
            Category = split[1];
        }

        public override Type PropertyType => dictionary[key].GetType();

        public override bool IsReadOnly => false;

        public override Type ComponentType => null;

        public override void SetValue(object component, object value)
        {
            dictionary[key] = value;
        }

        public override object GetValue(object component)
        {
            return dictionary[key];
        }

        public override bool CanResetValue(object component)
        {
            return false;
        }

        public override void ResetValue(object component)
        {
        }

        public override bool ShouldSerializeValue(object component)
        {
            return false;
        }

        public override string Category { get; }
    }
}