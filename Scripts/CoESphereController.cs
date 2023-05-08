using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoESphereController : MonoBehaviour
{
    public Collider ballColl;
    public Rigidbody ballRb;
    public GameObject ball;

    void Start() 
    {
        ballRb.constraints=RigidbodyConstraints.FreezeAll;
        Time.timeScale=0f;
    }
    public void ResetPosition()
    {
        ball.transform.position=new Vector3(0.728f,7.13f,45.4f);
        ballRb.velocity=new Vector3(0,0,0);
        Time.timeScale=0f;
    }

    public void Play()
    {
        ballRb.constraints=RigidbodyConstraints.None;
        Time.timeScale=1f;
    }

    public void Pause()
    {
        Time.timeScale=0f;
    }
}
