using UnityEngine;
using UnityEngine.SceneManagement;

public interface ISceneLoader
{
    void LoadScene(int sceneIndex);
    float Progress { get; }
}
