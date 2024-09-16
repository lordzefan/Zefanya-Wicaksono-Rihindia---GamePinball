using System.Collections;
using System.Collections.Generic;
using TMPro;
using TMPro.Examples;
using UnityEngine;

public class uiControl : MonoBehaviour
{
    public TMP_Text scoreText;

    public scoreManager scoreManager;

    private void Update()
    {
        scoreText.text = scoreManager.score.ToString();
    }
}
