using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    private AudioSource myAudioSource;
    [SerializeField] List<AudioClip> AudioList;

    // Start is called before the first frame update
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
        myAudioSource = GetComponent<AudioSource>();
    }

    public void ClickSoundPlay()
    {
        int index = Random.Range(0, AudioList.Count);
        myAudioSource.clip = AudioList[index];
        myAudioSource.Play();
    }

}
