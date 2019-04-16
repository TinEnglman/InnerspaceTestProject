using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

namespace Tests
{
    public class SceneLoaderTest
    {
        [Test]
        public void SceneLoaderTest_GetProgress_Early_Call()
        {
            float expectedResult = 0;

            SceneLoader sceneLoader = new SceneLoader();
            float result = sceneLoader.Progress;

            Assert.AreEqual(result, expectedResult);
        }
    }
}
