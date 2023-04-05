using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform ball;
    private Vector3 offset;

    public float smoothspeed;
    void Start()
    {
        offset = transform.position - ball.position;
    }

    void Update()
    {
        Vector3 newpos = Vector3.Lerp(transform.position, offset + ball.position, smoothspeed);
        transform.position = newpos;
    }
}
