using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CylinderController : MonoBehaviour
{
    public GameObject cylinder;
    public Rigidbody cylinderRb;
    public Slider cylinderVelocitySlider;
    public Vector3 cylinderVelocity;
    // Start is called before the first frame update
    void Start()
    {
        cylinderVelocitySlider.onValueChanged.AddListener(delegate{ValueChangeCheck();});

    }  

    public void ValueChangeCheck()
    {
        cylinderVelocity.x=cylinderVelocitySlider.value;
    }  
    // Update is called once per frame
    void Update()
    {
        
    }
}
