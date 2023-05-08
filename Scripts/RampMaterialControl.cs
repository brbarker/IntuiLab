using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RampMaterialControl : MonoBehaviour
{

    public Slider frictionSlider;
    public PhysicMaterial material;
    public GameObject physicsObject;
    // Start is called before the first frame update
    void Start()
    {
        // Get the PhysicMaterial component attached to this object
        material = GetComponent<Collider>().material;
    }

    // Update is called once per frame
    void Update()
    {
        // Change the friction of the physics material based on the value of the slider
        material.dynamicFriction = frictionSlider.value;
    }
}
