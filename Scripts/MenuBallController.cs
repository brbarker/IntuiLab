using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBallController : MonoBehaviour
{
    public Rigidbody consBall;
    public Rigidbody massBall;
    public Rigidbody frictBlock;
    public Rigidbody coEBall;
    private float massStart;
    private float consStart;
    private float frictStart;
    public float amp;
    public float freq;
    private Vector3 tempPos;

    // Start is called before the first frame update
    void Start()
    {
        massStart=massBall.transform.position.y;
        consStart=consBall.transform.position.y;
        frictStart=frictBlock.transform.position.y;

    }

    void Update()
    {
        tempPos.y+=Mathf.Sin(Time.fixedTime*Mathf.PI*freq)*amp;
        massStart=tempPos.y;
    }
    
}
