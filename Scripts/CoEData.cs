using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoEData : MonoBehaviour
{
    public GameObject ball;
    public Rigidbody ballRb;
    private float ballMass;
    public TMP_Text ballMassText;
    private float ballHeight;
    private float grav;
    private Vector3 ballVel;
    private float U;
    public TMP_Text uText;
    public TMP_Text tFinalText;
    private Vector3 T;
    private Vector3 TFinal;
    public TMP_Text scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ballMass=ballRb.mass;
        ballMassText.text=ballMass.ToString();

        ballHeight=ball.transform.position.y-0.8873353f;
        grav=-9.8f;
        ballVel=ballRb.velocity;

        U=Mathf.Abs(ballMass*grav*ballHeight);
        uText.text=U.ToString();

        T=Vector3.Scale(ballVel,ballVel);
        TFinal=T*.5f*ballMass;
        tFinalText.text=TFinal.ToString();

        //scoreText.text=Mathf.Min(U).ToString();

        Debug.Log(ballVel);
    }
}
