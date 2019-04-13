using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class LocalizationManagerTest
    {
        private const string ErrorMessagePrefix = "Text Key: '";
        private const string ErrorMessageSufix = "' does not exist!";
        private const string TextKey = "TEST_KEY";
        private const string TextValue = "TestValue";


        [Test]
        public void LocalizationManagerTest_CleanUp()
        {
            CleanUp();

            Dictionary<string, string> dummyLoc = new Dictionary<string, string>();
            dummyLoc.Add(TextKey, TextValue);
            LocalizationManager.Instance.AddLocalizations(dummyLoc);
            LocalizationManager.Instance.ClearData();

            string expectedResult = ErrorMessagePrefix + TextKey + ErrorMessageSufix;
            string result = LocalizationManager.Instance.GetText(TextKey);

            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void LocalizationManagerTest_GetText_Empty()
        {
            CleanUp();

            string expectedResult = ErrorMessagePrefix + TextKey + ErrorMessageSufix;
            string result = LocalizationManager.Instance.GetText(TextKey);

            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void LocalizationManagerTest_GetText()
        {
            CleanUp();

            Dictionary<string, string> dummyLoc = new Dictionary<string, string>();
            dummyLoc.Add(TextKey, TextValue);
            LocalizationManager.Instance.AddLocalizations(dummyLoc);

            string expectedResult = TextValue;
            string result = LocalizationManager.Instance.GetText(TextKey);

            Assert.AreEqual(result, expectedResult);
        }

        private void CleanUp() // Unity can do this automatically, if only it was merciful
        {
            LocalizationManager.Instance.ClearData();
        }
    }
}
