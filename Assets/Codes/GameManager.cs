using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    GameObject SpinningCircle;
    GameObject MainCircle;
    public Animator Animator;
    void Start()
    {
        SpinningCircle = GameObject.FindGameObjectWithTag("SpinningCircleTag");
        MainCircle = GameObject.FindGameObjectWithTag("MainCircleTag");
    }

    public void GameOver() 
    {
        StartCoroutine(GameO());
    }

    IEnumerator GameO()
    {
        SpinningCircle.GetComponent<Spinning>().enabled = false;
        MainCircle.GetComponent<MainCircle>().enabled = false;
        Animator.SetTrigger("GameOverTrigger");

        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("MainMenu");
    }
}
