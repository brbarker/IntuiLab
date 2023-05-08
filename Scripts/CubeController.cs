using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    public Collider coll;
    public Rigidbody rb;
    public GameObject cube;

    private void Start() 
    {
        Pause(coll);
    }

    public void ResetPosition(Collider coll)
    {
        cube.transform.position=new Vector3(0,7.34f,-9.4f);
        cube.transform.rotation=new Quaternion(0,35,0,0);
        coll.attachedRigidbody.useGravity=false;
        rb.constraints=RigidbodyConstraints.FreezePosition;
        rb.constraints=RigidbodyConstraints.FreezeRotation;
        
    }
    public void Play(Collider coll)
    {
        rb.constraints=RigidbodyConstraints.None;
        coll.attachedRigidbody.useGravity=true;
    }

    public void Pause(Collider coll)
    {
        rb.constraints=RigidbodyConstraints.FreezeAll;
    }
}
