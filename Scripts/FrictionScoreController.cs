using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrictionScoreController : MonoBehaviour
{
    public Rigidbody block;
    private Vector3 currentPos;
    private Vector3 startPos;
    private Vector3 endPos;
    public Collider coll;



    // Start is called before the first frame update
    void Start()
    {
        startPos=new Vector3(0.0f,7.34f,-9.4f);
        endPos=new Vector3(0.0f,.634f,-.098f);
    }

    // Update is called once per frame
    void Update()
    {
        currentPos=block.transform.position;

        if(currentPos.y<endPos.y)
        {
            ResetPosition(coll);
        }
    }

        public void ResetPosition(Collider coll)
    {
        block.transform.position=new Vector3(0,7.34f,-9.4f);
        block.transform.rotation=new Quaternion(0,0,0,0);
        coll.attachedRigidbody.useGravity=false;
        block.constraints=RigidbodyConstraints.FreezePosition;
        block.constraints=RigidbodyConstraints.FreezeRotation;
    }
}