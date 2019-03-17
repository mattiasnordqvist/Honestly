using System;
using System.Collections.Generic;

namespace HonestNamespace
{
    public class Honest<T>
    {
        private bool _knows = false;
        private T _value = default(T);

        public static Honest<T> DontKnow() => new Honest<T>();
        public static Honest<T> Null() => null;

        public override bool Equals(object obj)
        {
            if (obj is Honest<T> honest)
            {
                if (!_knows || !honest._knows)
                {
                    return Honestly.DontKnow;
                }
                else
                {
                    return _value.Equals(honest._value);
                }
            }
            else if (obj is T t)
            {
                return _value.Equals(t);
            }
            return false;
        }

        public override int GetHashCode()
        {
            if (!_knows)
            {
                throw new InvalidOperationException("Honestly?");
            }
            var hashCode = -370571027;
            hashCode = hashCode * -1521134295 + EqualityComparer<T>.Default.GetHashCode(_value);
            return hashCode;
        }

        internal Honest()
        {
            _knows = false;
            _value = default(T);
        }
        public Honest(T value)
        {
            _knows = true;
            _value = value;
        }

        public static implicit operator T(Honest<T> honestly)
        {
            if (honestly._knows)
            {
                return honestly._value;
            }
            throw new InvalidOperationException("Honestly, don't know");
        }

        public static implicit operator Honest<T>(T value)
        {
            return new Honest<T>(value);
        }
    }
}