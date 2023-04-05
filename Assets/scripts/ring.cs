using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ring : MonoBehaviour
{
    public Transform ball;
    private gamemanager gm;
    void Start()
    {
        gm = GameObject.FindObjectOfType<gamemanager>();
    }


    void Update()
    {
        if (transform.position.y + 12.5f >= ball.position.y)
        {
            //Destroy(gameObject);
            gm.gamescore(25);
        }
    }
}
