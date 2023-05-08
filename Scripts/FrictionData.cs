using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FrictionData : MonoBehaviour
{
    public Collider block;
    private float blockFriction;
    public TMP_Text blockFrictionText;
    public PhysicMaterial blockMaterial;


    public Collider ramp;
    private float rampFriction;
    public TMP_Text rampFrictionText;
    public PhysicMaterial rampMaterial;
    // Start is called before the first frame update
    void Start()
    {
        blockFriction=blockMaterial.dynamicFriction;

        rampFriction=rampMaterial.dynamicFriction;

    }

    // Update is called once per frame
    void Update()
    {
        blockFriction=blockMaterial.dynamicFriction;
        blockFrictionText.text=blockFriction.ToString();

        rampFriction=rampMaterial.dynamicFriction;
        rampFrictionText.text=rampFriction.ToString();
    }
}
