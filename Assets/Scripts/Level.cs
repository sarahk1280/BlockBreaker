using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int breakableBlocks;

    private SceneLoader sceneLoader;

    void Start()
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }

    public void RemoveBreakableBlock()
    {
        breakableBlocks--;
        if (breakableBlocks <= 0)
        {
            sceneLoader.NextLevel();
        }
    }
}
