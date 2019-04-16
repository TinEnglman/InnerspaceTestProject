using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class LoadingManagerTest
    {
        [Test]
        public void LoadingManagerTest_Init()
        {
            const int numHints = 1;

            LoadingManager.Instance.Init(numHints);

            int result = LoadingManager.Instance.CurrentHintIndex;
            int expectedResult = numHints;

            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void LoadingManagerTest_HintKey()
        {
            const int hintIndex = 1;
            const int numHints = 5;

            LoadingManager.Instance.Init(numHints);
            LoadingManager.Instance.CurrentHintIndex = hintIndex;

            string result = LoadingManager.Instance.HintKey;
            string expectedResult = "HINT_" + hintIndex;

            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void LoadingManagerTest_HintKey_Out_Of_Bounds()
        {
            const int hintIndex = 7;
            const int numHints = 5;

            LoadingManager.Instance.Init(numHints);
            LoadingManager.Instance.CurrentHintIndex = hintIndex;

            string result = LoadingManager.Instance.HintKey;
            string expectedResult = "HINT_" + (hintIndex - numHints);

            Assert.AreEqual(result, expectedResult);
        }


    }
}
