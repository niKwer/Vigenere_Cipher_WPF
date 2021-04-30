using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Cipher_Nyss
{
    public class VigenereCalc
    {
        public static string Encrypt(string str, string oldStringKey, ref string messageString)
        {
            string returnString = string.Empty, stringKey=string.Empty;
            string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            int alpStr,alpKey,k=0;
            bool isKeyRu = true;
            foreach (var item in oldStringKey.ToLower())
            {
                if(!alphabet.Contains(item)) { isKeyRu = false; }
                else { stringKey += item; }
            }
            if(!isKeyRu && string.IsNullOrEmpty(stringKey) || oldStringKey == "")
            {
                messageString = "The key is incorrectly defined, it doesn't contain the letters of the Russian alphabet. Please change the key.";
                return "";
            }
            else if(!isKeyRu && !string.IsNullOrEmpty(stringKey))
            {
                messageString = "The key contains non-Russian characters. They weren't taken into account during the calculation.";
            }

            for (int i = 0; i < str.Length; i++)
            {
                bool isRuLetter = false;

                if (k >= stringKey.Length) { k = 0; };
                for (alpStr = 0; alpStr < alphabet.Length; alpStr++)
                {
                    if (char.ToLower(str[i]) == alphabet[alpStr])
                    {
                        isRuLetter = true;
                        break;
                    }
                }
                if (isRuLetter)
                {
                    for (alpKey = 0; alpKey < alphabet.Length; alpKey++)
                    {
                        if (stringKey[k] == alphabet[alpKey])
                        {
                            break;
                        }
                    }
                    k++;

                    if (alpStr + alpKey > 32) { returnString += alphabet[alpStr + alpKey - 33]; }
                    else { returnString += alphabet[alpStr + alpKey]; }
                }
                else { returnString += str[i]; }
            }
            return returnString;
        }
        public static string Decrypt(string str, string oldStringKey, ref string messageString)
        {
            string returnString = string.Empty, stringKey = string.Empty;
            string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            int alpStr, alpKey, k = 0;
            bool isKeyRu = true;

            foreach (var item in oldStringKey.ToLower())
            {
                if (!alphabet.Contains(item)) { isKeyRu = false; }
                else { stringKey += item; }
            }
            if ((!isKeyRu && string.IsNullOrEmpty(stringKey)) || oldStringKey == "")
            {
                messageString = "The key is incorrectly defined, it doesn't contain the letters of the Russian alphabet. Please change the key.";
                return "";
            }
            else if (!isKeyRu && !string.IsNullOrEmpty(stringKey))
            {
                messageString = "The key contains non-Russian characters. They weren't taken into account during the calculation.";
            }

            for (int i = 0; i < str.Length; i++)
            {
                bool isRuLetter = false;
                if (k >= stringKey.Length) { k = 0; };
                for (alpStr = 0; alpStr < alphabet.Length; alpStr++)
                {
                    if (str[i] == alphabet[alpStr])
                    {
                        isRuLetter = true;
                        break;
                    }
                }
                if (isRuLetter)
                {
                    for (alpKey = 0; alpKey < alphabet.Length; alpKey++)
                    {
                        if (stringKey[k] == alphabet[alpKey])
                        {
                            break;
                        }
                    }
                    k++;

                    if (alpStr - alpKey < 0) { returnString += alphabet[alpStr - alpKey + 33]; }
                    else { returnString += alphabet[alpStr - alpKey]; }
                }
                else { returnString += str[i]; }
            }
            return returnString;
        }
    }
}
