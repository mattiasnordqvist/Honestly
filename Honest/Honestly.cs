namespace HonestNamespace
{
    public class Honestly
    {
        public static Honest<bool> DontKnow => new Honest<bool>();
        public static Honest<bool> True => new Honest<bool>(true);
        public static Honest<bool> False => new Honest<bool>(false);
        public static Honest<bool> Null => null;
    }
}