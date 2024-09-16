using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mainMenu : MonoBehaviour
{
    public Button playButton;
    public Button exitButton;
    public Button creditButton;

    private void Start()
    {
        playButton.onClick.AddListener(PlayGame);
        exitButton.onClick.AddListener(ExitGame);
        creditButton.onClick.AddListener(Credit);
    }

    private void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    private void Credit()
    {
        SceneManager.LoadScene("credit");
    }

    private void ExitGame()
    {
        Application.Quit();
    }
}
