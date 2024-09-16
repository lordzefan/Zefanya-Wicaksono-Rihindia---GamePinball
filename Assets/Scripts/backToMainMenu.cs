using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class backToMainMenu : MonoBehaviour
{
    public Button menuButton;


    private void Start()
    {
        menuButton.onClick.AddListener(MainMenu);
        
    }

    private void MainMenu()
    {
        SceneManager.LoadScene("main_menu");
    }
}
