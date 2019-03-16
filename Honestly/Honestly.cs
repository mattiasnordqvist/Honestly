using System;

namespace Honestly
{
    public class Honestly
    {
        private bool _knows = false;
        private bool? _value = null;

        public static Honestly DontKnow => new Honestly { _knows = false, _value = null };
        public static Honestly True => new Honestly { _knows = true, _value = true };
        public static Honestly False => new Honestly { _knows = true, _value = false };
        public static Honestly Null => new Honestly { _knows = true, _value = null };

        public static implicit operator bool(Honestly honestly)
        {
            if (honestly._knows && honestly._value != null)
            {
                return honestly._value.Value;
            }
            throw new InvalidCastException("Honestly, don't know");
        }

        public static implicit operator bool? (Honestly honestly)
        {
            if (honestly._knows)
            {
                return honestly._value;
            }
            throw new InvalidCastException("Honestly, don't know");
        }

        public static implicit operator Honestly(bool value)
        {
            return value ? True : False;
        }

        public static implicit operator Honestly(bool? value)
        {
            return value.HasValue ? (value.Value ? True : False) : Null;
        }

    }
}
