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
    public int howManySmallCircles;
    bool control = true;
    void Start()
    {
        PlayerPrefs.SetInt("save", int.Parse(SceneManager.GetActiveScene().name));

        SpinningCircle = GameObject.FindGameObjectWithTag("SpinningCircleTag");
        MainCircle = GameObject.FindGameObjectWithTag("MainCircleTag");
        SpinningCircleLevel.text = SceneManager.GetActiveScene().name;

        if (howManySmallCircles < 2)
        {
            one.text = howManySmallCircles + "";
        }else if (howManySmallCircles < 3)
        {
            one.text = howManySmallCircles + "";
            two.text = (howManySmallCircles-1) + "";
        }else
        {
            one.text = howManySmallCircles + "";
            two.text = (howManySmallCircles - 1) + "";
            three.text = (howManySmallCircles-2) + "";
        }
    }

    public void circleLeft()
    {
        howManySmallCircles--;
        if (howManySmallCircles < 2)
        {
            one.text = howManySmallCircles + "";
            two.text = "";
            three.text = "";
        }
        else if (howManySmallCircles < 3)
        {
            one.text = howManySmallCircles + "";
            two.text = (howManySmallCircles - 1) + "";
            three.text = "";
        }
        else
        {
            one.text = howManySmallCircles + "";
            two.text = (howManySmallCircles - 1) + "";
            three.text = (howManySmallCircles - 2) + "";
        }
        if (howManySmallCircles == 0)
        {
            nextLevel();
        }
    }

    public void nextLevel()
    {
        StartCoroutine(LevelChange());
    }

    IEnumerator LevelChange()
    {
        SpinningCircle.GetComponent<Spinning>().enabled = false;
        MainCircle.GetComponent<MainCircle>().enabled = false;

        yield return new WaitForSeconds(0.5f);
        if (control)
        {
            Animator.SetTrigger("NextLevelTrigger");
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene(int.Parse(SceneManager.GetActiveScene().name) + 1);
        }
    }

    public void GameOver() 
    {
        StartCoroutine(GameO());
    }

    IEnumerator GameO()
    {
        SpinningCircle.GetComponent<Spinning>().enabled = false;
        MainCircle.GetComponent<MainCircle>().enabled = false;
        control = false;
        Animator.SetTrigger("GameOverTrigger");

        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("MainMenu");
    }

}
