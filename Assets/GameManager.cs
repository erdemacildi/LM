using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameObject SpinningCircle;
    GameObject MainCircle;
    void Start()
    {
        SpinningCircle = GameObject.FindGameObjectWithTag("SpinningCircleTag");
        MainCircle = GameObject.FindGameObjectWithTag("MainCircleTag");
    }

    public void GameOver()
    {
        SpinningCircle.GetComponent<Spinning>().enabled = false;
        MainCircle.GetComponent<MainCircle>().enabled = false;
    }
}
