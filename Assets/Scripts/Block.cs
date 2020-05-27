using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip breakSound;


    void Start()
    {
        ScoreManager.Instance.addBlock();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SoundManager.Instance.ClickSoundPlay();
        ScoreManager.Instance.loseBlock();
        Destroy(gameObject);
        ScoreManager.Instance.addScore();
    }
}
