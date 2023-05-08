using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMaterialController : MonoBehaviour
{
    public float dFriction;
    public float sFriction;
    public Collider coll;
    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<Collider>();
        coll.material.dynamicFriction=dFriction;
        coll.material.staticFriction=sFriction;
    }

    public void ModifySettings()
    {
        dFriction=0;
        sFriction=0;
    }

}
