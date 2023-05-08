using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMaterialController : MonoBehaviour
{
    public float dFriction;
    public float sFriction;
    public Collider coll;

    private Rigidbody rb;

    public PhysicMaterial cubeMaterial;


    // Start is called before the first frame update
    void Start()
    {
        coll = GetComponent<Collider>();
        rb = GetComponent<Rigidbody>();


        //PhysicMaterial ballMaterial = new PhysicMaterial();

        cubeMaterial.dynamicFriction=dFriction;
        cubeMaterial.staticFriction=sFriction;

        coll.material=cubeMaterial;

    }
    public void ModifySettings()
    {
        cubeMaterial.dynamicFriction=dFriction;
        cubeMaterial.staticFriction=sFriction;
    }
}
