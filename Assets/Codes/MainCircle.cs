using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCircle : MonoBehaviour
{
    public GameObject smallCircle;
    GameObject GameManage;

    void Start()
    {
        GameManage = GameObject.FindGameObjectWithTag("GameManagerTag");
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GenerateSmallCircle();
        }
    }

    void GenerateSmallCircle()
    {
        Instantiate(smallCircle,transform.position,transform.rotation);
        GameManage.GetComponent<GameManager>().circleLeft();
    }
}
