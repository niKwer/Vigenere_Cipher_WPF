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
            string expected = "бщцфаирщри";
            
            // act 
            string actual = VigenereCalc.Encrypt(testString, keyString, ref messageString);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual("", messageString);
        }
        [TestMethod]
        public void EncryptText_RuText2()
        {
            // arrange
            string testString = "тестовое сообщение";
            string keyString = "скорпион";
            string messageString = "";
            string expected = "дпагюкэт гщэсиньцц";

            // act 
            string actual = VigenereCalc.Encrypt(testString, keyString, ref messageString);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual("", messageString);
        }

        [TestMethod]
        public void EncryptText_textWithSymbols()
        {
            // arrange
            string testString = "юё?*ъ312с: !№хй";
            string keyString = "скорпион";  
            string messageString = "";
            string expected = "пр?*и312в: !№ет";

            // act 
            string actual = VigenereCalc.Encrypt(testString, keyString, ref messageString);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual("", messageString);
        }

        [TestMethod]
        public void EncryptText_textWithNumbers()
        {
            // arrange
            string testString = "бъг4вящ3654а865ч а432дар123й";
            string keyString = "скорпион";
            string messageString = "";
            string expected = "тес4тов3654о865е с432ооб123щ";

            // act 
            string actual = VigenereCalc.Encrypt(testString, keyString, ref messageString);

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
            string expected = "прyuивFеdQт";

            // act 
            string actual = VigenereCalc.Encrypt(testString, keyString, ref messageString);

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
            string expected = "поздравляю, ты получил исходный текст!!!";

            // act 
            string actual = VigenereCalc.Decrypt(testString, keyString, ref messageString);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual("", messageString);
        }

        [TestMethod]
        public void DecryptText_RuText2()
        {
            // arrange
            string testString = "жпъьюь рьвцт";
            string keyString = "скорпион";
            string messageString = "";
            string expected = "хеллоу ворлд";

            // act 
            string actual = VigenereCalc.Decrypt(testString, keyString, ref messageString);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual("", messageString);
        }

        [TestMethod]
        public void DecryptText_WithSymbols()
        {
            // arrange
            string testString = "жп132ъ^%$ьюь рьв.*@#цт";
            string keyString = "скорпион";
            string messageString = "";
            string expected = "хе132л^%$лоу вор.*@#лд";

            // act 
            string actual = VigenereCalc.Decrypt(testString, keyString, ref messageString);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual("", messageString);
        }

        [TestMethod]
        public void DecryptText_WithNumbersAndOtherAlphabet()
        {
            // arrange
            string testString = "бычтфы, WORLD!!!=)";
            string keyString = "скорпион";
            string messageString = "";
            string expected = "привет, WORLD!!!=)";

            // act 
            string actual = VigenereCalc.Decrypt(testString, keyString, ref messageString);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual("", messageString);
        }

        [TestMethod]
        public void key_EncryptText_Message()
        {
            // arrange
            string testString = "юёъсхй, WORLD!!!=)";
            string keyString = "ско72рпион43";
            string messageString = "";
            string expected = "привет, WORLD!!!=)";

            // act 
            string actual = VigenereCalc.Encrypt(testString, keyString, ref messageString);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual("The key contains non-Russian characters. They weren't taken into account during the calculation.", messageString);
        }

        [TestMethod]
        public void keyFailed_EncryptText_Message()
        {
            // arrange
            string testString = "юёъсхй, WORLD!!!=)";
            string keyString = "fail7243";
            string messageString = "";
            string expected = "";

            // act 
            string actual = VigenereCalc.Encrypt(testString, keyString, ref messageString);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual("The key is incorrectly defined, it doesn't contain the letters of the Russian alphabet. Please change the key.", messageString);
        }

        [TestMethod]
        public void keyEmpty_EncryptText_Message()
        {
            // arrange
            string testString = "юёъсхй, WORLD!!!=)";
            string keyString = "";
            string messageString = "";
            string expected = "";

            // act 
            string actual = VigenereCalc.Encrypt(testString, keyString, ref messageString);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual("The key is incorrectly defined, it doesn't contain the letters of the Russian alphabet. Please change the key.", messageString);
        }

        [TestMethod]
        public void key_DecryptText_Message()
        {
            // arrange
            string testString = "бщцфаирщри";
            string keyString = "ско72рпион43";
            string messageString = "";
            string expected = "поздравляю";

            // act 
            string actual = VigenereCalc.Decrypt(testString, keyString, ref messageString);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual("The key contains non-Russian characters. They weren't taken into account during the calculation.", messageString);
        }

        [TestMethod]
        public void keyFailed_DecryptText_Message()
        {
            // arrange
            string testString = "бщцфаирщри";
            string keyString = "fail7243";
            string messageString = "";
            string expected = "";

            // act 
            string actual = VigenereCalc.Decrypt(testString, keyString, ref messageString);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual("The key is incorrectly defined, it doesn't contain the letters of the Russian alphabet. Please change the key.", messageString);
        }

        [TestMethod]
        public void keyEmpty_DecryptText_Message()
        {
            // arrange
            string testString = "бщцфаирщри";
            string keyString = "";
            string messageString = "";
            string expected = "";

            // act 
            string actual = VigenereCalc.Encrypt(testString, keyString, ref messageString);

            // assert
            Assert.AreEqual(expected, actual);
            Assert.AreEqual("The key is incorrectly defined, it doesn't contain the letters of the Russian alphabet. Please change the key.", messageString);
        }
    }
}
