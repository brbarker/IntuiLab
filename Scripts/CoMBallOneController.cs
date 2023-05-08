using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoMBallOneController : MonoBehaviour
{
    public Rigidbody ballOne;
    public Vector3 ballVelocity;
    // Start is called before the first frame update
    void Start()
    {
        ballOne.velocity=ballVelocity;
    }

    void Update() 
    {
    
    }
}
