using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WPF_Cipher_Nyss.Tests
{
    [TestClass]
    public class CryptographerTests
    {
        [TestMethod]
        public void EncryptText_RuText()
        {
            // arrange
            string testString = "поздравляю";
            string keyString = "скорпион";
            string messageString = "";
            string selectedLanguage = "Russian";
            string expected = "бщцфаирщри";
            
            // act 
            string actual = VigenereCalc.Encrypt(testString, keyString, selectedLanguage, ref messageString);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual("", messageString);
        }
        [TestMethod]
        public void EncryptText_EngText()
        {
            // arrange
            string testString = "hello world";
            string keyString = "home";
            string messageString = "";
            string selectedLanguage = "English";
            string expected = "osxpv kavsr";

            // act 
            string actual = VigenereCalc.Encrypt(testString, keyString, selectedLanguage, ref messageString);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual("", messageString);
        }

        [TestMethod]
        public void EncryptText_RuTextWithSymbols()
        {
            // arrange
            string testString = "юё?*ъ312с: !№хй";
            string keyString = "скорпион";  
            string messageString = "";
            string selectedLanguage = "Russian";
            string expected = "пр?*и312в: !№ет";

            // act 
            string actual = VigenereCalc.Encrypt(testString, keyString,selectedLanguage, ref messageString);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual("", messageString);
        }

        [TestMethod]
        public void EncryptText_EngTextWithSymbols()
        {
            // arrange
            string testString = "snd134yv hxjy2(*$13k";
            string keyString = "print";
            string messageString = "";
            string selectedLanguage = "English";
            string expected = "hel134lo worl2(*$13d";

            // act 
            string actual = VigenereCalc.Encrypt(testString, keyString, selectedLanguage, ref messageString);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual("", messageString);
        }

        [TestMethod]
        public void EncryptText_textWithOtherAlphabet()
        {
            // arrange
            string testString = "юёyuъсFхdQй";
            string keyString = "скорпион";
            string messageString = "";
            string selectedLanguage = "Russian";
            string expected = "прyuивFеdQт";

            // act 
            string actual = VigenereCalc.Encrypt(testString, keyString, selectedLanguage, ref messageString);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual("", messageString);
        }
        [TestMethod]
        public void DecryptText_RuText()
        {
            // arrange
            string testString = "бщцфаирщри, бл ячъбиуъ щбюэсяёш гфуаа!!!";
            string keyString = "скорпион";
            string messageString = "";
            string selectedLanguage = "Russian";
            string expected = "поздравляю, ты получил исходный текст!!!";

            // act 
            string actual = VigenereCalc.Decrypt(testString, keyString, selectedLanguage, ref messageString);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual("", messageString);
        }

        [TestMethod]
        public void DecryptText_EngText()
        {
            // arrange
            string testString = "wvtyh";
            string keyString = "print";
            string messageString = "";
            string selectedLanguage = "English";
            string expected = "hello";

            // act 
            string actual = VigenereCalc.Decrypt(testString, keyString, selectedLanguage, ref messageString);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual("", messageString);
        }

        [TestMethod]
        public void DecryptText_RuWithSymbols()
        {
            // arrange
            string testString = "жп132ъ^%$ьюь рьв.*@#цт";
            string keyString = "скорпион";
            string messageString = "";
            string selectedLanguage = "Russian";
            string expected = "хе132л^%$лоу вор.*@#лд";

            // act 
            string actual = VigenereCalc.Decrypt(testString, keyString, selectedLanguage, ref messageString);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual("", messageString);
        }

        [TestMethod]
        public void DecryptText_EngWithSymbols()
        {
            // arrange
            string testString = "w123v(*ty1h";
            string keyString = "print";
            string messageString = "";
            string selectedLanguage = "English";
            string expected = "h123e(*ll1o";

            // act 
            string actual = VigenereCalc.Decrypt(testString, keyString, selectedLanguage, ref messageString);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual("", messageString);
        }

        [TestMethod]
        public void key_RuEncryptText_Message()
        {
            // arrange
            string testString = "юёъсхй, WORLD!!!=)";
            string keyString = "ско72рпион43";
            string messageString = "";
            string selectedLanguage = "Russian";
            string expected = "привет, WORLD!!!=)";

            // act 
            string actual = VigenereCalc.Encrypt(testString, keyString, selectedLanguage, ref messageString);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual("The key contains non-Russian characters. They weren't taken into account during the calculation.", messageString);
        }
        public void key_EngEncryptText_Message()
        {
            // arrange
            string testString = "s123n(*dy1v";
            string keyString = "p*r23i1nt";
            string messageString = "";
            string selectedLanguage = "English";
            string expected = "h123e(*ll1o";

            // act 
            string actual = VigenereCalc.Encrypt(testString, keyString, selectedLanguage, ref messageString);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual("The key contains non-English characters. They weren't taken into account during the calculation.", messageString);
        }
        [TestMethod]
        public void keyFailed_RuEncryptText_Message()
        {
            // arrange
            string testString = "юёъсхй, WORLD!!!=)";
            string keyString = "fail7243";
            string messageString = "";
            string selectedLanguage = "Russian";
            string expected = "";

            // act 
            string actual = VigenereCalc.Encrypt(testString, keyString, selectedLanguage, ref messageString);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual("The key is incorrectly defined, it doesn't contain the letters of the Russian alphabet. Please change the key.", messageString);
        }

        [TestMethod]
        public void keyEmpty_RuEncryptText_Message()
        {
            // arrange
            string testString = "юёъсхй, WORLD!!!=)";
            string keyString = "";
            string messageString = "";
            string selectedLanguage = "Russian";
            string expected = "";

            // act 
            string actual = VigenereCalc.Encrypt(testString, keyString, selectedLanguage, ref messageString);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual("The key is incorrectly defined, it doesn't contain the letters of the Russian alphabet. Please change the key.", messageString);
        }

        [TestMethod]
        public void key_RuDecryptText_Message()
        {
            // arrange
            string testString = "бщцфаирщри";
            string keyString = "ско72рпион43";
            string messageString = "";
            string selectedLanguage = "Russian";
            string expected = "поздравляю";

            // act 
            string actual = VigenereCalc.Decrypt(testString, keyString, selectedLanguage, ref messageString);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual("The key contains non-Russian characters. They weren't taken into account during the calculation.", messageString);
        }

        [TestMethod]
        public void keyFailed_RuDecryptText_Message()
        {
            // arrange
            string testString = "бщцфаирщри";
            string keyString = "fail7243";
            string messageString = "";
            string selectedLanguage = "Russian";
            string expected = "";

            // act 
            string actual = VigenereCalc.Decrypt(testString, keyString, selectedLanguage, ref messageString);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual("The key is incorrectly defined, it doesn't contain the letters of the Russian alphabet. Please change the key.", messageString);
        }

        [TestMethod]
        public void keyEmpty_RuDecryptText_Message()
        {
            // arrange
            string testString = "бщцфаирщри";
            string keyString = "";
            string messageString = "";
            string selectedLanguage = "Russian";
            string expected = "";

            // act 
            string actual = VigenereCalc.Encrypt(testString, keyString, selectedLanguage, ref messageString);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual("The key is incorrectly defined, it doesn't contain the letters of the Russian alphabet. Please change the key.", messageString);
        }
        public void keyEmpty_EngDecryptText_Message()
        {
            // arrange
            string testString = "helloworld";
            string keyString = "";
            string messageString = "";
            string selectedLanguage = "English";
            string expected = "";

            // act 
            string actual = VigenereCalc.Encrypt(testString, keyString, selectedLanguage, ref messageString);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual("The key is incorrectly defined, it doesn't contain the letters of the English alphabet. Please change the key.", messageString);
        }
    }
}
