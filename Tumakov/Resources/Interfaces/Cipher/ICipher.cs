namespace Tumakov
{
    public interface ICipher
    {
        public string Encode(string input);
        public string Decode(string input);
    }
}
