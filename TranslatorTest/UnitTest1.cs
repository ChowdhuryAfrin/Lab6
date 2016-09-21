using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab6_PigLatinTranslator; 
namespace TranslatorTest
{
    [TestClass]
    public class TranslatorTest
    {
        [TestMethod]
        public void TestthatAppleTranslatorsToAppleway()
        {
            string toTranslate = "apple";
            Translator brad = new Translator();
            string translating = brad.Translate(toTranslate);
            Assert.AreEqual("appleway", translating); 

        }

        [TestMethod]
        public void TestthatLaptopTranslatorsToaptoplay()
        {
            string toTranslate = "laptop";
            Translator brad = new Translator();
            string translating = brad.Translate(toTranslate);
            Assert.AreEqual("aptoplay", translating);

        }

        [TestMethod]
        public void TestthatBreadTranslatorsToeadbray()
        {
            string toTranslate = "bread";
            Translator brad = new Translator();
            string translating = brad.Translate(toTranslate);
            Assert.AreEqual("eadbray", translating); 

        }


        [TestMethod]
        public void TestthatscrapTranslatorsToapscray()
        {
            string toTranslate = "scrap";
            Translator brad = new Translator();
            string translating = brad.Translate(toTranslate);
            Assert.AreEqual("apscray", translating);

        }
    }
}
