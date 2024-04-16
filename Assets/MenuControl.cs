using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene("Level-1");
    }
    public void quitGame()
    {
        Application.Quit();
    }
}
