using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera cam;                          // Defines a reference for the camera
    public float speed;                         // Defines a variable for the camera move speed
    public float camRotateSpeed;                // Defines a variable for the camera rotation speed
    public Vector3 camStartPos;                 // Defines a variable for the initial position of the camera
    public Quaternion camStartRotation;         // Defines a variable for the initial rotational values of the camera
    public float xMove;                         // Defines a variable for the movement along the x-axis
    public float yMove;                         // Defines a variable for the movement along the y-axis
    public float camVerticalRotate;             // Defines a variable for the up-and-down tilt of the camera
    public float zPos;                          // Defines a variable for the range of the z-position value
    public float xPos;                          // Defines a variable for the range of the x-position value

    void Start()                                        // Start is called before the first frame update
    {
        camStartPos=cam.transform.position;             // Assign the cameras starting position to the variable
        camStartRotation=cam.transform.rotation;        // Assign the cameras starting rotational values to the variable
    }

    
    void Update()                                           // Update is called once per frame
    {
        xMove = Input.GetAxisRaw("Horizontal");       // "D" key changes value to 1, "A" key changes value to -1

        yMove = Input.GetAxisRaw("Vertical");         // "W" key changes value to 1, "S" key changes value to -1

        if(Input.GetKey(KeyCode.Q))                                     // Starts an if-statement to rotate the camera to the left
        {                                                               // if the "Q" key is pressed
            transform.Rotate(0.0f,-camRotateSpeed,0.0f,Space.World);
        }

        if(Input.GetKey(KeyCode.E))                                     // Starts an if-statement to rotate the camera to the right
        {                                                               // if the "E" key is pressed
            transform.Rotate(0.0f,camRotateSpeed,0.0f,Space.World);
        }

        camVerticalRotate = Input.GetAxisRaw("Mouse ScrollWheel");      // Scrolling the mouse wheel will tilt the camera up or down

        transform.Translate(xMove*speed,0,yMove*speed);                 // Sets the camera movement speed using the variable
        transform.Rotate(camVerticalRotate*10,0.0f,0.0f,Space.Self);    // Sets the camera rotation angle for every step of the scrollwheel

        zPos = Mathf.Clamp(cam.transform.position.z,-300,180);          // Defines the range for the z-axis value
        xPos =Mathf.Clamp(cam.transform.position.x,-250,250);           // Defines the range for the x-axis value

        if(cam.transform.position.z!=zPos)                              // Checks if the camera has moved outside the range on the z-axis.
        {                                                               // If it has, reset the position to the initial, saved position.
            cam.transform.position=camStartPos;                         // and rotation.
            cam.transform.rotation=camStartRotation;
            Debug.Log("OUT OF BOUNDS");
        }

        if(cam.transform.position.x!=xPos)                              // Checks if the camera has moved outside the range on the x-axis.
        {                                                               // If it has, reset the position to the initial, saved position
            cam.transform.position=camStartPos;                         // and rotation.
            cam.transform.rotation=camStartRotation;
            Debug.Log("OUT OF BOUNDS");
        }


    }
}
