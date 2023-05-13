using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallReset : MonoBehaviour
{
    // Declare the variables to be used in the script.
    public Collider ballColl;           // Defines the collider on the ball so we can access its attributes
    public Rigidbody ballRb;            // Defines the rigidbody on the ball so we can access its attributes
    public GameObject ball;             // Defines a GameObject so we can manipulate its properties
    public GameObject block;            // Defines a GameObject so we can manipulate its properties
    public Rigidbody blockRb;           // Defines the rigidbody on the block so we can access its attributes
    private Vector3 blockStartPos;      // Defines a variable for the initial position of the block
    private Quaternion blockStartRot;   // Defines a variable for the initial rotational values of the block

    
    void Start()                                        // Start is called before the first frame update
    {
        blockStartPos=blockRb.transform.position;       // Assigns the starting position of the block to the variable
        blockStartRot=blockRb.transform.rotation;       // Assigns the starting rotational values of the block to the variable
    }

    
    public void ResetPosition()                                         // Define a new, public function to be run when we press "Reset"
    {
        ball.transform.position=new Vector3(3.163f,5.297f,0.5f);        // Set the position of the ball to the saved initial position
        block.transform.position=blockStartPos;                         // Set the position of the block to the saved initial position
        block.transform.rotation=blockStartRot;                         // Set the rotation of the block to the saved initial rotation
        ballColl.attachedRigidbody.useGravity=false;                    // Turn off the gravity for the ball so it doesn't move
        ballRb.constraints = RigidbodyConstraints.FreezePosition;       // Freeze the position of the ball so it doesn't move
        blockRb.constraints=RigidbodyConstraints.FreezeAll;             // Freeze all variables for the block so it doesn't move
        
    }
    public void Play()                                          // Define a new, public function to be run when we press "Play"
    {
        ballRb.constraints=RigidbodyConstraints.None;           // Unfreeze any frozen variables on the ball
        ballColl.attachedRigidbody.useGravity=true;             // Turn gravity back on so the ball falls
        blockRb.constraints=RigidbodyConstraints.None;          // Unfreeze any frozen variable on the block
    }
}
