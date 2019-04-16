using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class publicclassTextLoaderTest
    {
        [Test]
        public void TextLoaderTest_CreateJSON()
        {
            string rawJSON = "{ \r\n\t\"keymap\": \r\n\t[\r\n\t\t{\r\n\t\t\t\"key\": \"TEST_KEY\",\r\n\t\t\t\"localizedValue\": \"TestValue\"\r\n\t\t}\r\n\t]\r\n}";
            string expectedTestKey = "TEST_KEY";
            string expectedValue = "TestValue";

            LocalizationDataArray locData = LocalizationDataArray.CreateFromJSON(rawJSON);

            string resultTextKey = locData.keymap[0].key;
            string resultValue = locData.keymap[0].localizedValue;

            Assert.AreEqual(expectedTestKey, resultTextKey);
            Assert.AreEqual(expectedValue, resultValue);
        }

        [Test]
        public void TextLoaderTest_LoadText()
        {
         
            string path = "G:\\Work\\InnerspaceLoadingScreen\\Assets\\Texts\\AutomatedTest.json";
            string testKey = "TEST_KEY";
            string expectedResult = "TestValue";

            TextLoader textLoader = new TextLoader();
            var loadedData = textLoader.LoadText(path);

            string result = loadedData[testKey];

            Assert.AreEqual(result, expectedResult);
        }
    }
}
