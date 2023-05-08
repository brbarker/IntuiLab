using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReset : MonoBehaviour
{
    public Collider ballColl;
    public Rigidbody ballRb;
    public GameObject ball;
    public GameObject block;
    public Rigidbody blockRb;
    private Vector3 blockStartPos;
    private Quaternion blockStartRot;
    // Start is called before the first frame update
    void Start()
    {
        blockStartPos=blockRb.transform.position;
        blockStartRot=blockRb.transform.rotation;
    }

    // Update is called once per frame
    public void ResetPosition()
    {
        ball.transform.position=new Vector3(3.163f,5.297f,0.5f);
        block.transform.position=blockStartPos;
        block.transform.rotation=blockStartRot;
        ballColl.attachedRigidbody.useGravity=false;
        ballRb.constraints = RigidbodyConstraints.FreezePosition;
        blockRb.constraints=RigidbodyConstraints.FreezeAll;
        
    }
    public void Play()
    {
        ballRb.constraints=RigidbodyConstraints.None;
        ballColl.attachedRigidbody.useGravity=true;
        blockRb.constraints=RigidbodyConstraints.None;
    }
}
