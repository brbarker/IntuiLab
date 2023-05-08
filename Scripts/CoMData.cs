using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CoMData : MonoBehaviour
{
    public Rigidbody ball1;
    private float ball1Velocity;
    public TMP_Text ball1VelocityText;
    private float ball1Mass;
    public TMP_Text ball1MassText;

    public Rigidbody ball2;
    private float ball2Velocity;
    public TMP_Text ball2VelocityText;
    private float ball2Mass;
    public TMP_Text ball2MassText;

    public Rigidbody ball3;
    private float ball3Velocity;
    public TMP_Text ball3VelocityText;
    private float ball3Mass;
    public TMP_Text ball3MassText;
    
    public Slider ballOneVelSlider;
    public Vector3 ballOneVelocity;
    private float ball1Selection;
    public TMP_Text ball1SelectionText;
    
    // Start is called before the first frame update
    void Start()
    {
        ballOneVelSlider.onValueChanged.AddListener(delegate{ValueChangeCheck();});
    }

    public void ValueChangeCheck()
    {
        ballOneVelocity.z=ballOneVelSlider.value;
    }

    // Update is called once per frame
    void Update()
    {
        ball1Selection=ballOneVelSlider.value;
        ball1SelectionText.text=ball1Selection.ToString();

        ball1Velocity=Mathf.Abs(ball1.velocity.z);
        ball1VelocityText.text=ball1Velocity.ToString();

        ball2Velocity=Mathf.Abs(ball2.velocity.z);
        ball2VelocityText.text=ball2Velocity.ToString();

        ball3Velocity=Mathf.Abs(ball3.velocity.z);
        ball3VelocityText.text=ball3Velocity.ToString();

        ball1Mass=ball1.mass;
        ball1MassText.text=ball1Mass.ToString();

        ball2Mass=ball2.mass;
        ball2MassText.text=ball2Mass.ToString();

        ball3Mass=ball3.mass;
        ball3MassText.text=ball3Mass.ToString();

        

    }
}
