using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class triggerGamerOver : MonoBehaviour
{
    public Collider bola;
    public GameObject canvaGameObject;

    private void OnTriggerEnter(Collider other)
    {
        if (other == bola)
        {
            canvaGameObject.SetActive(true);
        }
    }
}
