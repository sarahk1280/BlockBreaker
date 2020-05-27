using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public int blockCount = 0;
    public int score = 0;
    [SerializeField] SceneLoader sceneLoader;
    [SerializeField] Text ScoreText;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        } else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        ScoreText.text = "Score: " + score.ToString();
    }

    public void addBlock()
    {
        blockCount++;
    }

    public void loseBlock()
    {
        blockCount--;
        checkGameOver();
    }

    public void checkGameOver()
    {
        if (blockCount <= 0)
        {
            sceneLoader.WinGame();
        }
    }

    public void addScore()
    {
        score++;
        ScoreText.text = "Score: " + score.ToString();
        Debug.Log(score);
    }

}
