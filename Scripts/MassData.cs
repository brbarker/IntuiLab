using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MassData : MonoBehaviour
{
    public Rigidbody ball;
    private float ballMass;
    public TMP_Text ballMassText;
    
    public Rigidbody block;
    private float blockMass;
    public TMP_Text blockMassText;
    
    // Start is called before the first frame update
    void Start()
    {
        ballMass=ball.mass;
        ballMass=1;
        blockMass=block.mass;
        blockMass=1;
    }

    // Update is called once per frame
    void Update()
    {
        ballMass=ball.mass;
        blockMass=block.mass;
        ballMassText.text=ballMass.ToString();
        blockMassText.text=blockMass.ToString();
    }
}
