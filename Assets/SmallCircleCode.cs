using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SmallCircleCode : MonoBehaviour
{
    Rigidbody2D physic;
    public float speed;
    bool checkMovement = false;
    GameObject GameManager;
    void Start()
    {
        physic = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if(!checkMovement)
        {
            physic.MovePosition(physic.position + Vector2.up * speed * Time.deltaTime);
            GameManager = GameObject.FindGameObjectWithTag("GameManagerTag");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "SpinningCircleTag")
        {
            transform.SetParent(collision.transform);
            checkMovement = true;
        }

        if (collision.tag == "SmallCircleTag")
        {
            GameManager.GetComponent<GameManager>().GameOver();
        }
    }
}
