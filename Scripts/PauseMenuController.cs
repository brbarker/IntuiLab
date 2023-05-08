using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenuController : MonoBehaviour
{
    public Slider cameraMoveSpeed;
    public Slider cameraRotateSpeed;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("P Pressed");
        }
    }
    public void SetMoveSpeed(float cameraMoveSpeed)
    {

    }
}
