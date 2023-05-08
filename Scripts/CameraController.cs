using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera cam;
    public float speed;
    public float camRotateSpeed;
    public Vector3 camStartPos;
    public Quaternion camStartRotation;

    // Start is called before the first frame update
    void Start()
    {
        camStartPos=cam.transform.position;
        camStartRotation=cam.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");  // d key changes value to 1, a key changes value to -1

        float yMove = Input.GetAxisRaw("Vertical");  // w changes value to 1, s changes value to -1

        if(Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0.0f,-camRotateSpeed,0.0f,Space.World);
        }

        if(Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0.0f,camRotateSpeed,0.0f,Space.World);
        }

        float camVerticalRotate = Input.GetAxisRaw("Mouse ScrollWheel");

        transform.Translate(xMove*speed,0,yMove*speed);
        transform.Rotate(camVerticalRotate*10,0.0f,0.0f,Space.Self);

        float zPos = Mathf.Clamp(cam.transform.position.z,-300,180);
        float xPos =Mathf.Clamp(cam.transform.position.x,-250,250);

        if(cam.transform.position.z!=zPos)
        {
            cam.transform.position=camStartPos;
            cam.transform.rotation=camStartRotation;
            Debug.Log("OUT OF BOUNDS");
        }

        if(cam.transform.position.x!=xPos)
        {
            cam.transform.position=camStartPos;
            cam.transform.rotation=camStartRotation;
            Debug.Log("OUT OF BOUNDS");
        }


    }
}
