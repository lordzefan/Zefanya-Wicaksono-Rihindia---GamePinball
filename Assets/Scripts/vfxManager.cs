using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vfxManager : MonoBehaviour
{

    public GameObject vfxAudioSource;
    

    public void playVfx(Vector3 spawnPosition)
    {
        GameObject.Instantiate(vfxAudioSource, spawnPosition, Quaternion.identity);
    }
}
