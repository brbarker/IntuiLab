using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoMSphereController : MonoBehaviour
{
    public Collider ballOneColl;
    public Rigidbody ballOneRb;
    public GameObject ballOne;
    public Vector3 ballOneVelocity;
    public Collider ballTwoColl;
    public Rigidbody ballTwoRb;
    public GameObject ballTwo;
    public Collider ballThreeColl;
    public Rigidbody ballThreeRb;
    public GameObject ballThree;
    public Slider ballOneVelSlider;

    void Start()
    {
        ballOneVelSlider.onValueChanged.AddListener(delegate{ValueChangeCheck();});
        Time.timeScale=0f;
    }

    public void ValueChangeCheck()
    {
        ballOneVelocity.z=ballOneVelSlider.value;
        ballOneVelocity.z=ballOneVelSlider.value;
        ballOneRb.velocity=new Vector3(0.0f,0.0f,ballOneVelocity.z);
    }
    public void ResetPosition()
    {
        ballOne.transform.position=new Vector3(-0.02f,0.51f,-5.7f);
        ballOneColl.attachedRigidbody.useGravity=false;
        ballOneRb.constraints=RigidbodyConstraints.FreezeAll;

        ballTwo.transform.position=new Vector3(-0.5f,0.51f,11.43f);
        ballTwoColl.attachedRigidbody.useGravity=false;
        ballTwoRb.constraints=RigidbodyConstraints.FreezeAll;

        ballThree.transform.position=new Vector3(0.5f,0.51f,11.43f);
        ballThreeColl.attachedRigidbody.useGravity=false;
        ballThreeRb.constraints=RigidbodyConstraints.FreezeAll;
    }
    public void Play()
    {
        Time.timeScale=1f;
        ballOneRb.constraints=RigidbodyConstraints.None;
        ballOneColl.attachedRigidbody.useGravity=true;

        ballTwoRb.constraints=RigidbodyConstraints.None;
        ballThreeRb.constraints=RigidbodyConstraints.None;
    }

    public void Pause()
    {
        Time.timeScale=0f;
    }

    public void ChangeVelocity()
    {
        ballOneRb.velocity=ballOneVelocity;
    }
}
