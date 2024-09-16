using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{

    public AudioSource bgmAudioSource;
    public GameObject sfxAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        playBgm();  
    }

    private void playBgm()
    {
        bgmAudioSource.Play();
    }

    public void playSfx(Vector3 spawnPosition)
    {
        GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
    }
}
