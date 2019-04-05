using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : ISceneLoader
{
    public void LoadScene(int sceneBuildIndex)
    {
        SceneManager.LoadSceneAsync(sceneBuildIndex);
    }
}
