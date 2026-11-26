using System.Text;

namespace Tumakov
{
    public class ACipher : ICipher
    {
        private string _engAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZAabcdefghijklmnopqrstuvwxyza";
        private string _rusAlphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯАабвгдеёжзийклмнопрстуфхцчшщъыьэюяа";
        public string Encode(string input)
        {
            string encoded = "";
            foreach (char c in input)
            {
                string alphabet = "";
                if (_engAlphabet.Contains(c))
                {
                    alphabet = _engAlphabet;
                }
                else
                { 
                    alphabet = _rusAlphabet;
                }

                int index = alphabet.IndexOf(c);
                if (index != -1)
                {
                    encoded += alphabet[index + 1];
                }
                else
                {
                    encoded += c;
                }
            }
            return encoded;
        }

        public string Decode(string input)
        {
            string decoded = "";
            foreach (char c in input)
            {
                string alphabet = "";
                if (_engAlphabet.Contains(c))
                {
                    alphabet = _engAlphabet;
                }
                else
                {
                    alphabet = _rusAlphabet;
                }

                int index = alphabet.LastIndexOf(c);
                if (index != -1)
                {
                    decoded += alphabet[index - 1];
                }
                else
                {
                    decoded += c;
                }
            }
            return decoded;
        }
    }
}
