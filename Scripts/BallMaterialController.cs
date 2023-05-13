using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMaterialController : MonoBehaviour
{
    // Declare the variables to be used in the script. 
    public float dFriction;     // Dynamic Friction float
    public float sFriction;     // Static Friction float
    public Collider coll;       // Defines the collider on the ball so we can access its attributes
    
    void Start()
    {
        coll = GetComponent<Collider>();                // Finds the collider component of the ball and assigns it to the variable
        coll.material.dynamicFriction=dFriction;        // Accesses the dynamic friction value of the collider and assigns it to the variable
        coll.material.staticFriction=sFriction;         // Accesses the static friction value of the collider and assigns it to the variable
    }

    public void ModifySettings()
    {
        dFriction=1;        // Sets the dynamic friction value to 1
        sFriction=1;        // Sets the static friction value to 1
    }

}
