using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : ISceneLoader
{
    private AsyncOperation _loadingOperation = null;

    public float Progress
    {
        get
        {
            if (_loadingOperation != null)
            { 
                return _loadingOperation.progress;
            }
            else
            {
                return 0;
            }
        }
    }
    
    public void LoadScene(int sceneBuildIndex)
    {
        _loadingOperation = SceneManager.LoadSceneAsync(sceneBuildIndex);

    }
}
