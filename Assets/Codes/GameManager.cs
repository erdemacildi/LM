using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    GameObject SpinningCircle;
    GameObject MainCircle;
    public Animator Animator;
    public Text SpinningCircleLevel;
    public Text one;
    public Text two;
    public Text three;
    void Start()
    {
        SpinningCircle = GameObject.FindGameObjectWithTag("SpinningCircleTag");
        MainCircle = GameObject.FindGameObjectWithTag("MainCircleTag");
        SpinningCircleLevel.text = SceneManager.GetActiveScene().name;
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
