using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControl : MonoBehaviour
{
    private void Start()
    {
        //PlayerPrefs.DeleteAll();
    }
    public void startGame()
    {
        int savedLevel = PlayerPrefs.GetInt("save");

        if (savedLevel == 0)
        {
            SceneManager.LoadScene(savedLevel+1);
        }
        else
        {
            SceneManager.LoadScene(savedLevel);
        }
        
    }
    public void quitGame()
    {
        Application.Quit();
    }
}
