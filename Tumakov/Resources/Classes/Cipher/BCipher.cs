using System.Text;

namespace Tumakov
{
    public class BCipher : ICipher
    {
        private string _engUpAlphabet = " ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private string _engLowAlphabet = " abcdefghijklmnopqrstuvwxyz";
        private string _rusUpAlphabet = " АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        private string _rusLowAlphabet = " абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

        public string Encode(string input)
        {
            string encoded = "";
            foreach (char c in input)
            {
                string lowAlphabet = "";
                string upAlphabet = "";
                
                if (_engLowAlphabet.Contains(c))
                {
                    lowAlphabet = _engLowAlphabet;
                }
                else
                {
                    lowAlphabet = _rusLowAlphabet;
                }

                if (_engUpAlphabet.Contains(c))
                {
                    upAlphabet = _engUpAlphabet;
                }
                else
                {
                    upAlphabet = _rusUpAlphabet;
                }

                if ((!lowAlphabet.Contains(c) && !upAlphabet.Contains(c)) || c == ' ')
                {
                    encoded += c;
                    continue;
                }

                if (lowAlphabet.Contains(c))
                {
                    encoded += lowAlphabet[lowAlphabet.Length - lowAlphabet.IndexOf(c)];
                }
                else if (upAlphabet.Contains(c))
                {
                    encoded += upAlphabet[upAlphabet.Length - upAlphabet.IndexOf(c)];
                }
                
            }
            return encoded;
        }

        public string Decode(string input)
        {
            string decoded = "";
            foreach (char c in input)
            {
                string lowAlphabet = "";
                string upAlphabet = "";
                if (_engLowAlphabet.Contains(c))
                {
                    lowAlphabet = _engLowAlphabet;
                }
                else
                {
                    lowAlphabet = _rusLowAlphabet;
                }

                if (_engUpAlphabet.Contains(c))
                {
                    upAlphabet = _engUpAlphabet;
                }
                else
                {
                    upAlphabet = _rusUpAlphabet;
                }

                if ((!lowAlphabet.Contains(c) && !upAlphabet.Contains(c)) || c == ' ')
                {
                    decoded += c;
                    continue;
                }

                if (lowAlphabet.Contains(c))
                {
                    decoded += lowAlphabet[lowAlphabet.Length - lowAlphabet.IndexOf(c)];
                }
                else if (upAlphabet.Contains(c))
                {
                    decoded += upAlphabet[upAlphabet.Length - upAlphabet.IndexOf(c)];
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
