using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private int currentSceneIndex;
    private string currentSceneName;
    // Start is called before the first frame update
    void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        currentSceneName  = SceneManager.GetActiveScene().name;
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void ReplayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void WinGame()
    {
        SceneManager.LoadScene(3);
    }

}
